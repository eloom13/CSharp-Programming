namespace FIT.WinForms.Studenti
{
    partial class frmStudentNovi
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
            groupBox2 = new GroupBox();
            btnResetLozinka = new Button();
            cbAktivan = new CheckBox();
            label7 = new Label();
            txtLozinka = new TextBox();
            label2 = new Label();
            cmbSemestri = new ComboBox();
            txtBrojIndeksa = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            dtpDatumRodjenja = new DateTimePicker();
            label6 = new Label();
            txtPrezime = new TextBox();
            txtIme = new TextBox();
            label4 = new Label();
            label5 = new Label();
            pbSlika = new PictureBox();
            btnSpasi = new Button();
            btnOdabirSlike = new Button();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnResetLozinka);
            groupBox2.Controls.Add(cbAktivan);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtLozinka);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cmbSemestri);
            groupBox2.Controls.Add(txtBrojIndeksa);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(dtpDatumRodjenja);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtPrezime);
            groupBox2.Controls.Add(txtIme);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(268, 21);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(960, 244);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Podaci";
            // 
            // btnResetLozinka
            // 
            btnResetLozinka.BackgroundImage = Properties.Resources._5619264;
            btnResetLozinka.BackgroundImageLayout = ImageLayout.Stretch;
            btnResetLozinka.Location = new Point(650, 166);
            btnResetLozinka.Name = "btnResetLozinka";
            btnResetLozinka.Size = new Size(66, 65);
            btnResetLozinka.TabIndex = 17;
            btnResetLozinka.UseVisualStyleBackColor = true;
            btnResetLozinka.Click += btnResetLozinka_Click;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Checked = true;
            cbAktivan.CheckState = CheckState.Checked;
            cbAktivan.Location = new Point(650, 128);
            cbAktivan.Margin = new Padding(3, 4, 3, 4);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(80, 24);
            cbAktivan.TabIndex = 7;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 101);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 16;
            label7.Text = "Semestar:";
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(336, 187);
            txtLozinka.Margin = new Padding(3, 4, 3, 4);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(294, 27);
            txtLozinka.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 164);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 7;
            label2.Text = "Lozinka:";
            // 
            // cmbSemestri
            // 
            cmbSemestri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestri.FormattingEnabled = true;
            cmbSemestri.Location = new Point(336, 124);
            cmbSemestri.Name = "cmbSemestri";
            cmbSemestri.Size = new Size(294, 28);
            cmbSemestri.TabIndex = 4;
            // 
            // txtBrojIndeksa
            // 
            txtBrojIndeksa.Location = new Point(21, 187);
            txtBrojIndeksa.Margin = new Padding(3, 4, 3, 4);
            txtBrojIndeksa.Name = "txtBrojIndeksa";
            txtBrojIndeksa.Size = new Size(294, 27);
            txtBrojIndeksa.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 164);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 5;
            label1.Text = "Broj indeksa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(650, 40);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 15;
            label3.Text = "Datum rodjenja:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(21, 124);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(294, 27);
            txtEmail.TabIndex = 3;
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(650, 63);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(294, 27);
            dtpDatumRodjenja.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 101);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 9;
            label6.Text = "Email:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(336, 63);
            txtPrezime.Margin = new Padding(3, 4, 3, 4);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(294, 27);
            txtPrezime.TabIndex = 1;
            txtPrezime.TextChanged += txtPrezime_TextChanged;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(21, 63);
            txtIme.Margin = new Padding(3, 4, 3, 4);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(294, 27);
            txtIme.TabIndex = 0;
            txtIme.TextChanged += txtIme_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 40);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 0;
            label4.Text = "Ime:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 40);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 7;
            label5.Text = "Prezime:";
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(12, 30);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(240, 235);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 13;
            pbSlika.TabStop = false;
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(1134, 281);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(94, 29);
            btnSpasi.TabIndex = 2;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // btnOdabirSlike
            // 
            btnOdabirSlike.Location = new Point(12, 281);
            btnOdabirSlike.Name = "btnOdabirSlike";
            btnOdabirSlike.Size = new Size(240, 29);
            btnOdabirSlike.TabIndex = 0;
            btnOdabirSlike.Text = "Odaberi Sliku";
            btnOdabirSlike.UseVisualStyleBackColor = true;
            btnOdabirSlike.Click += btnOdabirSlike_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmStudentNovi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 322);
            Controls.Add(btnOdabirSlike);
            Controls.Add(btnSpasi);
            Controls.Add(pbSlika);
            Controls.Add(groupBox2);
            Name = "frmStudentNovi";
            Text = "Podaci o Studentu";
            Load += frmStudentNovi_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtPrezime;
        private TextBox txtIme;
        private Label label4;
        private Label label5;
        private CheckBox cbAktivan;
        private TextBox txtLozinka;
        private TextBox txtBrojIndeksa;
        private Label label1;
        private Label label2;
        private PictureBox pbSlika;
        private DateTimePicker dtpDatumRodjenja;
        private ComboBox cmbSemestri;
        private Label label7;
        private Label label3;
        private Button btnSpasi;
        private Button btnOdabirSlike;
        private OpenFileDialog openFileDialog1;
        private Button btnResetLozinka;
        private ErrorProvider errorProvider1;
    }
}