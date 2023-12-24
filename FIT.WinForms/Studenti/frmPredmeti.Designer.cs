namespace FIT.WinForms.Studenti
{
    partial class frmPredmeti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPredmeti = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Semestar = new DataGridViewTextBoxColumn();
            txtNazivPredmeta = new TextBox();
            cmbSemestar = new ComboBox();
            btnDodaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPredmeti).BeginInit();
            SuspendLayout();
            // 
            // dgvPredmeti
            // 
            dgvPredmeti.AllowUserToAddRows = false;
            dgvPredmeti.AllowUserToDeleteRows = false;
            dgvPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPredmeti.Columns.AddRange(new DataGridViewColumn[] { Naziv, Semestar });
            dgvPredmeti.Location = new Point(12, 120);
            dgvPredmeti.Name = "dgvPredmeti";
            dgvPredmeti.ReadOnly = true;
            dgvPredmeti.RowHeadersWidth = 51;
            dgvPredmeti.RowTemplate.Height = 29;
            dgvPredmeti.Size = new Size(537, 256);
            dgvPredmeti.TabIndex = 0;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Semestar
            // 
            Semestar.DataPropertyName = "Semestar";
            Semestar.HeaderText = "Semestar";
            Semestar.MinimumWidth = 6;
            Semestar.Name = "Semestar";
            Semestar.ReadOnly = true;
            Semestar.Width = 125;
            // 
            // txtNazivPredmeta
            // 
            txtNazivPredmeta.Location = new Point(12, 55);
            txtNazivPredmeta.Name = "txtNazivPredmeta";
            txtNazivPredmeta.Size = new Size(219, 27);
            txtNazivPredmeta.TabIndex = 1;
            // 
            // cmbSemestar
            // 
            cmbSemestar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestar.FormattingEnabled = true;
            cmbSemestar.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            cmbSemestar.Location = new Point(251, 55);
            cmbSemestar.Name = "cmbSemestar";
            cmbSemestar.Size = new Size(139, 28);
            cmbSemestar.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(423, 55);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(126, 29);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // frmPredmeti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 388);
            Controls.Add(btnDodaj);
            Controls.Add(cmbSemestar);
            Controls.Add(txtNazivPredmeta);
            Controls.Add(dgvPredmeti);
            Name = "frmPredmeti";
            Text = "Predmeti";
            Load += frmPredmeti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPredmeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPredmeti;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Semestar;
        private TextBox txtNazivPredmeta;
        private ComboBox cmbSemestar;
        private Button btnDodaj;
    }
}