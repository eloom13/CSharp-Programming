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
            Indeks = new DataGridViewTextBoxColumn();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            btnNoviStudent = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Indeks, Ime, Prezime, Aktivan, DatumRodjenja });
            dgvStudenti.Location = new Point(12, 75);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 29;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(843, 296);
            dgvStudenti.TabIndex = 0;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            // 
            // Indeks
            // 
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Indeks";
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
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Width = 125;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rodjenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            DatumRodjenja.Resizable = DataGridViewTriState.True;
            DatumRodjenja.SortMode = DataGridViewColumnSortMode.NotSortable;
            DatumRodjenja.Width = 125;
            // 
            // btnNoviStudent
            // 
            btnNoviStudent.Location = new Point(742, 22);
            btnNoviStudent.Name = "btnNoviStudent";
            btnNoviStudent.Size = new Size(113, 32);
            btnNoviStudent.TabIndex = 1;
            btnNoviStudent.Text = "Novi student";
            btnNoviStudent.UseVisualStyleBackColor = true;
            btnNoviStudent.Click += btnNoviStudent_Click;
            // 
            // frmStudentiPretraga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 387);
            Controls.Add(btnNoviStudent);
            Controls.Add(dgvStudenti);
            Name = "frmStudentiPretraga";
            Text = "Pretraga Studenata";
            Load += frmStudentiPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private Button btnNoviStudent;
    }
}