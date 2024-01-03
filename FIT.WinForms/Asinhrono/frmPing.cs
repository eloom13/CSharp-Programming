﻿using FIT.Data;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.Asinhrono
{
    public partial class frmPing : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();
        public frmPing()
        {
            InitializeComponent();
        }

        public string Sadrzaj {  get; set; } // zbog cross thread
        public int Brojac {  get; set; }

        private async void btnPing_Click(object sender, EventArgs e)
        {
            /*
            Thread google = new Thread(PingGoogle);
            Thread olx = new Thread(PingOlx);
            */

            //Thread google = new Thread(() => 
            //    Ping(new dtoPing()
            //    {
            //        BrojPonavljanja = 10,
            //        Lokacija = "www.google.ba",
            //        Pauza = 200
            //    }));

            //Thread olx = new Thread(PingOlx);

            //Thread studenti = new Thread(DodajStudente);

            //var task =  Task.Run(() => { DodajStudente(); });

            // task.GetAwaiter().OnCompleted(() => Ping(new dtoPing() { BrojPonavljanja = 10, Lokacija = "www.google.ba", Pauza = 200 }));


            var poruka = await PingGoogleNew();
            MessageBox.Show(poruka);
            await Task.Run(() => { DodajStudente(); });

            //await Task.Run(() =>
            //{
            //    Ping(new dtoPing() { BrojPonavljanja = 10, Lokacija = "www.google.ba", Pauza = 200 });
            //});


            //Task.Run(() =>
            //{
            //    Ping(new dtoPing() { BrojPonavljanja = 10, Lokacija = "www.google.ba", Pauza = 200 });
            //});

            // google.Start();
            // olx.Start();

            //studenti.Start();

            /*
            PingGoogle();
            PingOlx();
            */

            /*
            google.Join();
            olx.Join();
            */

            PrikaziSadrzaj();
        }

        private async Task<string> PingGoogleNew()
        {
            await Task.Run(() =>
            {
                Ping(new dtoPing() { BrojPonavljanja = 10, Lokacija = "www.google.ba", Pauza = 200 });
            });
            return "PING Google-a je ZAVRSEN!!!";
        }

        private void DodajStudente()
        {
            try
            {
                var slika = baza.Studenti.Find(2).Slika;

                for (int i = 0; i < 20; i++)
                {
                    var noviStudent = new Student()
                    {
                        Aktivan = true,
                        DatumRodjenja = DateTime.Now,
                        Email = $"ime{i + 1}.prezime{i + 1}@edu.fit.ba",
                        Ime = $"Ime{i + 1}",
                        Prezime = $"Prezime{i + 1}",
                        Indeks = Generator.GetNaredniBrojIndeksa(),
                        Lozinka = Generator.GetLozinka(),
                        SemestarId = 1,
                        Slika = slika
                    };

                    baza.Studenti.Add(noviStudent);
                    Sadrzaj += $"Student -> {noviStudent}{Environment.NewLine}";
                    BeginInvoke(PrikaziSadrzaj);
                    Thread.Sleep(200);
                }
                baza.SaveChanges();
            }
            catch (Exception ex)
            {

                Sadrzaj += ex;
            }
        }

        private void Ping(object obj)
        {
            try
            {
                var ping = new Ping();
                var dtoPing = obj as dtoPing;

                for (int i = 0; i < dtoPing.BrojPonavljanja; i++)
                {
                    var reply = ping.Send(dtoPing.Lokacija);
                    Sadrzaj += StringFromPingReply(reply);
                    BeginInvoke(PrikaziSadrzaj);
                    Thread.Sleep(dtoPing.Pauza);
                }
            }
            catch (Exception ex)
            {

                Sadrzaj += ex;
            }
        }

        private void PrikaziSadrzaj()
        {
            txtIspis.Text = Sadrzaj;
            PomjeriNaKraj();
        }

        private void PomjeriNaKraj()
        {
            txtIspis.SelectionStart = txtIspis.Text.Length;
            txtIspis.ScrollToCaret();
        }

        private void PingOlx()
        {
            try
            {
                var ping = new Ping();
                for (int i = 0; i < 10; i++) 
                {
                    var reply = ping.Send("olx.ba");
                    Sadrzaj += StringFromPingReply(reply);
                    BeginInvoke(PrikaziSadrzaj);
                    Thread.Sleep(200);
                }
            }
            catch (Exception ex)
            {

                Sadrzaj += ex;
            }
        }

        private string StringFromPingReply(PingReply reply)
        {
            return $"{++Brojac}. -> {reply.Address}\t{reply.RoundtripTime}\t{reply.Status}{Environment.NewLine}";
        }

        private void PingGoogle()
        {
            try
            {
                var ping = new Ping();
                for (int i = 0; i < 10; i++)
                {
                    var reply = ping.Send("www.google.ba");
                    Sadrzaj += StringFromPingReply(reply);
                    BeginInvoke(PrikaziSadrzaj);
                    Thread.Sleep(200);
                }
            }
            catch (Exception ex)
            {

                Sadrzaj += ex;
            }
        }
    }

    public class dtoPing
    {
        public string Lokacija { get; set; }
        public int BrojPonavljanja { get; set; }
        public int Pauza {  get; set; }
    }
}
