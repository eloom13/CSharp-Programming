namespace FIT.WinForms.Studenti
{
    partial class frmStudentiPretraga
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
            dgvStudenti = new DataGridView();
            btnNoviStudent = new Button();
            txtFilter = new TextBox();
            Indeks = new DataGridViewTextBoxColumn();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Semestar = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Polozeni = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.AllowUserToOrderColumns = true;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Indeks, Ime, Prezime, DatumRodjenja, Semestar, Aktivan, Polozeni });
            dgvStudenti.Location = new Point(14, 67);
            dgvStudenti.Margin = new Padding(3, 4, 3, 4);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 25;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(865, 325);
            dgvStudenti.TabIndex = 0;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            // 
            // btnNoviStudent
            // 
            btnNoviStudent.Location = new Point(775, 28);
            btnNoviStudent.Margin = new Padding(3, 4, 3, 4);
            btnNoviStudent.Name = "btnNoviStudent";
            btnNoviStudent.Size = new Size(104, 31);
            btnNoviStudent.TabIndex = 1;
            btnNoviStudent.Text = "Novi student";
            btnNoviStudent.UseVisualStyleBackColor = true;
            btnNoviStudent.Click += btnNoviStudent_Click;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(14, 29);
            txtFilter.Margin = new Padding(3, 4, 3, 4);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(754, 27);
            txtFilter.TabIndex = 2;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // Indeks
            // 
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Indeksa";
            Indeks.MinimumWidth = 6;
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            Indeks.Width = 125;
            // 
            // Ime
            // 
            Ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ime.DataPropertyName = "Ime";
            Ime.HeaderText = "Ime";
            Ime.MinimumWidth = 6;
            Ime.Name = "Ime";
            Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            Prezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prezime.DataPropertyName = "Prezime";
            Prezime.HeaderText = "Prezime";
            Prezime.MinimumWidth = 6;
            Prezime.Name = "Prezime";
            Prezime.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rođenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
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
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Width = 125;
            // 
            // Polozeni
            // 
            Polozeni.HeaderText = "";
            Polozeni.MinimumWidth = 6;
            Polozeni.Name = "Polozeni";
            Polozeni.ReadOnly = true;
            Polozeni.Text = "Predmeti";
            Polozeni.UseColumnTextForButtonValue = true;
            Polozeni.Width = 125;
            // 
            // frmStudentiPretraga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 415);
            Controls.Add(txtFilter);
            Controls.Add(btnNoviStudent);
            Controls.Add(dgvStudenti);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmStudentiPretraga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga studenata";
            Load += frmStudentiPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudenti;
        private Button btnNoviStudent;
        private TextBox txtFilter;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewTextBoxColumn Semestar;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Polozeni;
    }
}