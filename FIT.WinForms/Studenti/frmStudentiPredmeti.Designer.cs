namespace FIT.WinForms.Studenti
{
    partial class frmStudentiPredmeti
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
            components = new System.ComponentModel.Container();
            dgvPolozeniPredmeti = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            DatumPolaganja = new DataGridViewTextBoxColumn();
            cmbPredmeti = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbOcjene = new ComboBox();
            dtpDatumPolaganja = new DateTimePicker();
            btnDodaj = new Button();
            err = new ErrorProvider(components);
            lblImePrezime = new Label();
            pbSlikaStudenta = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPolozeniPredmeti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSlikaStudenta).BeginInit();
            SuspendLayout();
            // 
            // dgvPolozeniPredmeti
            // 
            dgvPolozeniPredmeti.AllowUserToAddRows = false;
            dgvPolozeniPredmeti.AllowUserToDeleteRows = false;
            dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPolozeniPredmeti.Columns.AddRange(new DataGridViewColumn[] { Predmet, Ocjena, DatumPolaganja });
            dgvPolozeniPredmeti.Location = new Point(12, 311);
            dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            dgvPolozeniPredmeti.ReadOnly = true;
            dgvPolozeniPredmeti.RowHeadersWidth = 51;
            dgvPolozeniPredmeti.RowTemplate.Height = 29;
            dgvPolozeniPredmeti.Size = new Size(900, 306);
            dgvPolozeniPredmeti.TabIndex = 0;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            Ocjena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.MinimumWidth = 6;
            Ocjena.Name = "Ocjena";
            Ocjena.ReadOnly = true;
            // 
            // DatumPolaganja
            // 
            DatumPolaganja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPolaganja.DataPropertyName = "DatumPolaganja";
            DatumPolaganja.HeaderText = "Datum polaganja";
            DatumPolaganja.MinimumWidth = 6;
            DatumPolaganja.Name = "DatumPolaganja";
            DatumPolaganja.ReadOnly = true;
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(12, 265);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(196, 28);
            cmbPredmeti.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 232);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "Predmet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 232);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 4;
            label2.Text = "Ocjena:";
            // 
            // cmbOcjene
            // 
            cmbOcjene.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOcjene.FormattingEnabled = true;
            cmbOcjene.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjene.Location = new Point(235, 265);
            cmbOcjene.Name = "cmbOcjene";
            cmbOcjene.Size = new Size(115, 28);
            cmbOcjene.TabIndex = 3;
            // 
            // dtpDatumPolaganja
            // 
            dtpDatumPolaganja.Location = new Point(370, 265);
            dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            dtpDatumPolaganja.Size = new Size(355, 27);
            dtpDatumPolaganja.TabIndex = 5;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(741, 263);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(171, 29);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Segoe UI", 22F);
            lblImePrezime.Location = new Point(235, 86);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(0, 50);
            lblImePrezime.TabIndex = 7;
            // 
            // pbSlikaStudenta
            // 
            pbSlikaStudenta.Location = new Point(12, 12);
            pbSlikaStudenta.Name = "pbSlikaStudenta";
            pbSlikaStudenta.Size = new Size(196, 197);
            pbSlikaStudenta.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlikaStudenta.TabIndex = 8;
            pbSlikaStudenta.TabStop = false;
            // 
            // frmStudentiPredmeti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 625);
            Controls.Add(pbSlikaStudenta);
            Controls.Add(lblImePrezime);
            Controls.Add(btnDodaj);
            Controls.Add(dtpDatumPolaganja);
            Controls.Add(label2);
            Controls.Add(cmbOcjene);
            Controls.Add(label1);
            Controls.Add(cmbPredmeti);
            Controls.Add(dgvPolozeniPredmeti);
            Name = "frmStudentiPredmeti";
            Text = "Pregled uspjeha studenta";
            Load += frmStudentiPredmeti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPolozeniPredmeti).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSlikaStudenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPolozeniPredmeti;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn DatumPolaganja;
        private ComboBox cmbPredmeti;
        private Label label1;
        private Label label2;
        private ComboBox cmbOcjene;
        private DateTimePicker dtpDatumPolaganja;
        private Button btnDodaj;
        private ErrorProvider err;
        private Label lblImePrezime;
        private PictureBox pbSlikaStudenta;
    }
}