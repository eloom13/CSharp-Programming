using FIT.Data;
using FIT.Infrastructure;
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
    public partial class frmStudentiPretraga : Form
    {
        public frmStudentiPretraga()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudentiPretraga_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente()
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = InMemoryDb.Studenti;
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            frmStudentNovi frmStudentNovi = new frmStudentNovi();
            if (frmStudentNovi.ShowDialog() == DialogResult.OK)
                UcitajStudente();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudent = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            frmStudentNovi frmEditovanjeStudenta = new frmStudentNovi(odabraniStudent);
            frmEditovanjeStudenta.ShowDialog();
        }
    }
}
