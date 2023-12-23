using FIT.Data;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.Studenti
{
    public partial class frmStudentiPredmeti : Form
    {
        private Student? student;
        public frmStudentiPredmeti(Student student)
        {
            InitializeComponent();
            this.student = student;
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        private void frmStudentiPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
            UcitajPolozenePredmete();
            UcitajLicnePodatke();
        }

        private void UcitajLicnePodatke()
        {
            pbSlikaStudenta.Image = student.Slika;
            lblImePrezime.Text = $"{student.Indeks}, {student.Ime} {student.Prezime}";
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.UcitajPodatke(InMemoryDb.Predmeti);
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = student.PolozeniPredmeti;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(ValidanUnos())
            {
                var predmet = cmbPredmeti.SelectedItem as Predmet;


                //var postoji = student.PolozeniPredmeti.Where(polozeni => polozeni.PredmetId == predmet.Id).Count() > 0;

                foreach (var p in student.PolozeniPredmeti)
                {
                    if (p.PredmetId == predmet.Id)
                        MessageBox.Show($"{Resursi.Get(Kljucevi.DuplicatedValue)}",
                            Resursi.Get(Kljucevi.Info),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    return;
                }

                var polozeniPredmet = new PolozeniPredmet()
                {
                    Id = student.PolozeniPredmeti.Count + 1,
                    DatumPolaganja = dtpDatumPolaganja.Value,
                    Ocjena = int.Parse(cmbOcjene.Text),
                    Predmet = predmet,
                    PredmetId = predmet.Id
                };

                student.PolozeniPredmeti.Add(polozeniPredmet);
                UcitajPolozenePredmete();
            }
        }

        private bool ValidanUnos()
        {
            return
                Validator.ProvjeriUnos(cmbPredmeti, err, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(cmbOcjene, err, Kljucevi.ReqiredValue);
        }
    }
}
