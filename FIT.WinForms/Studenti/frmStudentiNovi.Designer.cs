namespace FIT.WinForms.Studenti
{
    partial class frmStudentiNovi
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
            btnSpasi = new Button();
            groupBox2 = new GroupBox();
            btnNovaLozinka = new Button();
            cbAktivan = new CheckBox();
            label7 = new Label();
            cmbSemestri = new ComboBox();
            txtLozinka = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtIndeks = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            dtpDatumRodjenja = new DateTimePicker();
            label6 = new Label();
            txtPrezime = new TextBox();
            txtIme = new TextBox();
            label4 = new Label();
            label5 = new Label();
            pbSlika = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnOdabirSlike = new Button();
            errorProvider1 = new ErrorProvider(components);
            dgvUloge = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            cmbUloge = new ComboBox();
            btnDodajUlogu = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUloge).BeginInit();
            SuspendLayout();
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(519, 364);
            btnSpasi.Margin = new Padding(3, 4, 3, 4);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(86, 31);
            btnSpasi.TabIndex = 2;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnNovaLozinka);
            groupBox2.Controls.Add(cbAktivan);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmbSemestri);
            groupBox2.Controls.Add(txtLozinka);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtIndeks);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(dtpDatumRodjenja);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtPrezime);
            groupBox2.Controls.Add(txtIme);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(234, 28);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(370, 328);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnNovaLozinka
            // 
            btnNovaLozinka.BackgroundImage = Properties.Resources._5619264;
            btnNovaLozinka.BackgroundImageLayout = ImageLayout.Stretch;
            btnNovaLozinka.Location = new Point(320, 236);
            btnNovaLozinka.Margin = new Padding(3, 4, 3, 4);
            btnNovaLozinka.Name = "btnNovaLozinka";
            btnNovaLozinka.Size = new Size(30, 31);
            btnNovaLozinka.TabIndex = 15;
            btnNovaLozinka.UseVisualStyleBackColor = true;
            btnNovaLozinka.Click += btnNovaLozinka_Click;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Checked = true;
            cbAktivan.CheckState = CheckState.Checked;
            cbAktivan.Location = new Point(16, 275);
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
            label7.Location = new Point(184, 145);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 17;
            label7.Text = "Semestar:";
            // 
            // cmbSemestri
            // 
            cmbSemestri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestri.FormattingEnabled = true;
            cmbSemestri.Location = new Point(185, 169);
            cmbSemestri.Margin = new Padding(3, 4, 3, 4);
            cmbSemestri.Name = "cmbSemestri";
            cmbSemestri.Size = new Size(163, 28);
            cmbSemestri.TabIndex = 4;
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(175, 236);
            txtLozinka.Margin = new Padding(3, 4, 3, 4);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.PasswordChar = '*';
            txtLozinka.Size = new Size(138, 27);
            txtLozinka.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 212);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 7;
            label2.Text = "Lozinka:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 85);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 16;
            label3.Text = "Datum rođenja:";
            // 
            // txtIndeks
            // 
            txtIndeks.Enabled = false;
            txtIndeks.Location = new Point(16, 236);
            txtIndeks.Margin = new Padding(3, 4, 3, 4);
            txtIndeks.Name = "txtIndeks";
            txtIndeks.Size = new Size(150, 27);
            txtIndeks.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 212);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 5;
            label1.Text = "Broj indeksa:";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(15, 169);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 27);
            txtEmail.TabIndex = 3;
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(15, 109);
            dtpDatumRodjenja.Margin = new Padding(3, 4, 3, 4);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(333, 27);
            dtpDatumRodjenja.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 145);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 9;
            label6.Text = "Email:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(186, 51);
            txtPrezime.Margin = new Padding(3, 4, 3, 4);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(163, 27);
            txtPrezime.TabIndex = 1;
            txtPrezime.TextChanged += txtPrezime_TextChanged;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(16, 51);
            txtIme.Margin = new Padding(3, 4, 3, 4);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(163, 27);
            txtIme.TabIndex = 0;
            txtIme.TextChanged += txtIme_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 27);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 5;
            label4.Text = "Ime:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(186, 27);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 7;
            label5.Text = "Prezime:";
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(14, 41);
            pbSlika.Margin = new Padding(3, 4, 3, 4);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(204, 275);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 14;
            pbSlika.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOdabirSlike
            // 
            btnOdabirSlike.Location = new Point(14, 325);
            btnOdabirSlike.Margin = new Padding(3, 4, 3, 4);
            btnOdabirSlike.Name = "btnOdabirSlike";
            btnOdabirSlike.Size = new Size(205, 31);
            btnOdabirSlike.TabIndex = 0;
            btnOdabirSlike.Text = "Odaberi sliku";
            btnOdabirSlike.UseVisualStyleBackColor = true;
            btnOdabirSlike.Click += btnOdabirSlike_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dgvUloge
            // 
            dgvUloge.AllowUserToAddRows = false;
            dgvUloge.AllowUserToDeleteRows = false;
            dgvUloge.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUloge.Columns.AddRange(new DataGridViewColumn[] { Naziv });
            dgvUloge.Location = new Point(638, 103);
            dgvUloge.Name = "dgvUloge";
            dgvUloge.ReadOnly = true;
            dgvUloge.RowHeadersWidth = 51;
            dgvUloge.RowTemplate.Height = 29;
            dgvUloge.Size = new Size(432, 292);
            dgvUloge.TabIndex = 15;
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
            // cmbUloge
            // 
            cmbUloge.FormattingEnabled = true;
            cmbUloge.Location = new Point(638, 52);
            cmbUloge.Name = "cmbUloge";
            cmbUloge.Size = new Size(288, 28);
            cmbUloge.TabIndex = 16;
            // 
            // btnDodajUlogu
            // 
            btnDodajUlogu.Location = new Point(958, 51);
            btnDodajUlogu.Name = "btnDodajUlogu";
            btnDodajUlogu.Size = new Size(112, 29);
            btnDodajUlogu.TabIndex = 17;
            btnDodajUlogu.Text = "Dodaj ulogu";
            btnDodajUlogu.UseVisualStyleBackColor = true;
            btnDodajUlogu.Click += btnDodajUlogu_Click;
            // 
            // frmStudentiNovi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 407);
            Controls.Add(btnDodajUlogu);
            Controls.Add(cmbUloge);
            Controls.Add(dgvUloge);
            Controls.Add(btnOdabirSlike);
            Controls.Add(pbSlika);
            Controls.Add(btnSpasi);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmStudentiNovi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o studentu";
            Load += frmStudentiNovi_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUloge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSpasi;
        private GroupBox groupBox2;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtPrezime;
        private TextBox txtIme;
        private Label label4;
        private Label label5;
        private CheckBox cbAktivan;
        private TextBox txtLozinka;
        private TextBox txtIndeks;
        private Label label1;
        private Label label2;
        private PictureBox pbSlika;
        private DateTimePicker dtpDatumRodjenja;
        private ComboBox cmbSemestri;
        private Label label3;
        private Label label7;
        private OpenFileDialog openFileDialog1;
        private Button btnOdabirSlike;
        private Button btnNovaLozinka;
        private ErrorProvider errorProvider1;
        private Button btnDodajUlogu;
        private ComboBox cmbUloge;
        private DataGridView dgvUloge;
        private DataGridViewTextBoxColumn Naziv;
    }
}