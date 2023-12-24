using FIT.Data;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmStudentNovi : Form
    {
        private Student _student { get; set; }
        DLWMSDbContext baza = new DLWMSDbContext();

        public frmStudentNovi(Student student = null)
        {
            InitializeComponent();
            _student = student ?? new Student();
        }

        private void btnOdabirSlike_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void frmStudentNovi_Load(object sender, EventArgs e)
        {
            UcitajSemestre();

            if(_student.Id != 0)
                UcitajPodatkeOStudentu();
            else
            {
                GenerisiBrojIndeksa();
                GenerisiLozinku();
            }
        }

        private void UcitajPodatkeOStudentu()
        {
            cbAktivan.Checked = _student.Aktivan;
            dtpDatumRodjenja.Value = _student.DatumRodjenja;
            txtEmail.Text = _student.Email;
            txtIme.Text = _student.Ime;
            txtBrojIndeksa.Text = _student.Indeks;
            txtLozinka.Text = _student.Lozinka;
            txtPrezime.Text = _student.Prezime;
            cmbSemestri.SelectedValue = _student.Semestar;
            pbSlika.Image = _student.Slika.ToImage();
        }

        private void GenerisiLozinku()
        {
            txtLozinka.Text = Generator.GetLozinka();
        }

        private void GenerisiPodatke()
        {
            GenerisiEmail();
        }

        private void GenerisiBrojIndeksa()
        {
            txtBrojIndeksa.Text = Generator.GetNaredniBrojIndeksa();
        }

        private void GenerisiEmail()
        {

            txtEmail.Text = Generator.GetEmail(txtIme.Text, txtPrezime.Text);
        }

        private void UcitajSemestre()
        {
            cmbSemestri.DataSource = InMemoryDb.Semestri;
            cmbSemestri.DisplayMember = "Oznaka";
            cmbSemestri.ValueMember = "Id";
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }

        private void btnResetLozinka_Click(object sender, EventArgs e)
        {
            GenerisiLozinku();
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {

            if(ValidanUnos())
            {
                _student.Aktivan = cbAktivan.Checked;
                _student.DatumRodjenja = dtpDatumRodjenja.Value;
                _student.Email = txtEmail.Text;
                _student.Ime = txtIme.Text;
                _student.Indeks = txtBrojIndeksa.Text;
                _student.Lozinka = txtLozinka.Text;
                _student.Prezime = txtPrezime.Text;
                _student.Semestar = (int)cmbSemestri.SelectedValue;
                _student.Slika = pbSlika.Image.ToByteArray();

                if (_student.Id == 0)
                {
                    //_student.Id = InMemoryDb.Studenti.Count + 1;
                    //InMemoryDb.Studenti.Add(_student);
                    baza.Studenti.Add(_student);
                }else
                    baza.Entry(_student).State = EntityState.Modified;

                baza.SaveChanges();

                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(pbSlika, errorProvider1, Kljucevi.ReqiredValue) &&
                   Validator.ProvjeriUnos(txtIme, errorProvider1, Kljucevi.ReqiredValue) &&
                   Validator.ProvjeriUnos(txtPrezime, errorProvider1, Kljucevi.ReqiredValue) &&
                   Validator.ProvjeriUnos(txtEmail, errorProvider1, Kljucevi.ReqiredValue) &&
                   Validator.ProvjeriUnos(txtLozinka, errorProvider1, Kljucevi.ReqiredValue) &&
                   Validator.ProvjeriUnos(cmbSemestri, errorProvider1, Kljucevi.ReqiredValue) &&
                   Validator.ProvjeriUnos(txtBrojIndeksa, errorProvider1, Kljucevi.ReqiredValue) &&
                   Validator.ProvjeriUnos(txtLozinka, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}
