namespace UrunSatis
{
    partial class frmSiparis
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
            this.lstFatura = new System.Windows.Forms.ListBox();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.dtMusteri = new System.Windows.Forms.DataGridView();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtUrun = new System.Windows.Forms.DataGridView();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.txtUrunArama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmrUrunFiyat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.nmrUrunMiktar = new System.Windows.Forms.NumericUpDown();
            this.cmbUrunKategori = new System.Windows.Forms.ComboBox();
            this.txtUrunAciklama = new System.Windows.Forms.TextBox();
            this.txtUrunMarka = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMusteri)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFatura
            // 
            this.lstFatura.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.lstFatura.FormattingEnabled = true;
            this.lstFatura.ItemHeight = 21;
            this.lstFatura.Location = new System.Drawing.Point(973, 12);
            this.lstFatura.MultiColumn = true;
            this.lstFatura.Name = "lstFatura";
            this.lstFatura.Size = new System.Drawing.Size(351, 529);
            this.lstFatura.TabIndex = 50;
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Font = new System.Drawing.Font("Montserrat", 24F);
            this.btnSiparisVer.Location = new System.Drawing.Point(973, 621);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(358, 116);
            this.btnSiparisVer.TabIndex = 51;
            this.btnSiparisVer.Text = "Siparişi Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.dtMusteri);
            this.groupBox1.Controls.Add(this.txtArama);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 336);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Seçme";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.Location = new System.Drawing.Point(575, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 75;
            this.label8.Text = "Müşteri Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label9.Location = new System.Drawing.Point(575, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 21);
            this.label9.TabIndex = 74;
            this.label9.Text = "Müşteri Adres";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label10.Location = new System.Drawing.Point(564, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 21);
            this.label10.TabIndex = 73;
            this.label10.Text = "Müşteri Telefon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label11.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label11.Location = new System.Drawing.Point(597, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 21);
            this.label11.TabIndex = 72;
            this.label11.Text = "Müşteri Ad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label12.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label12.Location = new System.Drawing.Point(601, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 21);
            this.label12.TabIndex = 71;
            this.label12.Text = "Müşteri ID";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtId.Location = new System.Drawing.Point(689, 107);
            this.txtId.MaxLength = 30;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(243, 26);
            this.txtId.TabIndex = 70;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtEmail.Location = new System.Drawing.Point(689, 273);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(243, 26);
            this.txtEmail.TabIndex = 69;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtAdres.Location = new System.Drawing.Point(689, 201);
            this.txtAdres.MaxLength = 100;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ReadOnly = true;
            this.txtAdres.Size = new System.Drawing.Size(243, 66);
            this.txtAdres.TabIndex = 68;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtTelefon.Location = new System.Drawing.Point(689, 169);
            this.txtTelefon.MaxLength = 11;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.ReadOnly = true;
            this.txtTelefon.Size = new System.Drawing.Size(243, 26);
            this.txtTelefon.TabIndex = 67;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtAd.Location = new System.Drawing.Point(689, 139);
            this.txtAd.MaxLength = 30;
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(243, 26);
            this.txtAd.TabIndex = 66;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Montserrat", 11F);
            this.btnAra.ForeColor = System.Drawing.Color.Black;
            this.btnAra.Location = new System.Drawing.Point(256, 41);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(145, 29);
            this.btnAra.TabIndex = 65;
            this.btnAra.Text = "ID\'ye göre Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dtMusteri
            // 
            this.dtMusteri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtMusteri.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMusteri.Location = new System.Drawing.Point(24, 76);
            this.dtMusteri.Name = "dtMusteri";
            this.dtMusteri.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtMusteri.Size = new System.Drawing.Size(540, 242);
            this.dtMusteri.TabIndex = 64;
            this.dtMusteri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMusteri_CellDoubleClick);
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtArama.Location = new System.Drawing.Point(24, 43);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(226, 27);
            this.txtArama.TabIndex = 63;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtUrun);
            this.groupBox2.Controls.Add(this.btnUrunAra);
            this.groupBox2.Controls.Add(this.txtUrunArama);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nmrUrunFiyat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtUrunId);
            this.groupBox2.Controls.Add(this.nmrUrunMiktar);
            this.groupBox2.Controls.Add(this.cmbUrunKategori);
            this.groupBox2.Controls.Add(this.txtUrunAciklama);
            this.groupBox2.Controls.Add(this.txtUrunMarka);
            this.groupBox2.Controls.Add(this.txtUrunAd);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(18, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(938, 415);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Seçme";
            // 
            // dtUrun
            // 
            this.dtUrun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtUrun.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUrun.Location = new System.Drawing.Point(24, 90);
            this.dtUrun.Name = "dtUrun";
            this.dtUrun.Size = new System.Drawing.Size(540, 262);
            this.dtUrun.TabIndex = 82;
            this.dtUrun.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtUrun_CellDoubleClick);
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.Font = new System.Drawing.Font("Montserrat", 11F);
            this.btnUrunAra.ForeColor = System.Drawing.Color.Black;
            this.btnUrunAra.Location = new System.Drawing.Point(256, 55);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(145, 29);
            this.btnUrunAra.TabIndex = 81;
            this.btnUrunAra.Text = "ID\'ye göre Ara";
            this.btnUrunAra.UseVisualStyleBackColor = true;
            this.btnUrunAra.Click += new System.EventHandler(this.btnUrunAra_Click);
            // 
            // txtUrunArama
            // 
            this.txtUrunArama.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtUrunArama.Location = new System.Drawing.Point(24, 57);
            this.txtUrunArama.Name = "txtUrunArama";
            this.txtUrunArama.Size = new System.Drawing.Size(226, 27);
            this.txtUrunArama.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Location = new System.Drawing.Point(596, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 78;
            this.label7.Text = "Ürün Fiyat";
            // 
            // nmrUrunFiyat
            // 
            this.nmrUrunFiyat.Font = new System.Drawing.Font("Montserrat", 11F);
            this.nmrUrunFiyat.Location = new System.Drawing.Point(688, 187);
            this.nmrUrunFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.nmrUrunFiyat.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmrUrunFiyat.Name = "nmrUrunFiyat";
            this.nmrUrunFiyat.ReadOnly = true;
            this.nmrUrunFiyat.Size = new System.Drawing.Size(209, 25);
            this.nmrUrunFiyat.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(605, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 42);
            this.label6.TabIndex = 76;
            this.label6.Text = "Ürün\r\nAçıklama\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(569, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 75;
            this.label5.Text = "Ürün Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(594, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 74;
            this.label4.Text = "Ürün Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(586, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 73;
            this.label3.Text = "Ürün Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(609, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 72;
            this.label2.Text = "Ürün Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(616, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "Ürün ID";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtUrunId.Location = new System.Drawing.Point(689, 90);
            this.txtUrunId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.ReadOnly = true;
            this.txtUrunId.Size = new System.Drawing.Size(208, 25);
            this.txtUrunId.TabIndex = 70;
            this.txtUrunId.TextChanged += new System.EventHandler(this.txtUrunId_TextChanged);
            // 
            // nmrUrunMiktar
            // 
            this.nmrUrunMiktar.Font = new System.Drawing.Font("Montserrat", 11F);
            this.nmrUrunMiktar.Location = new System.Drawing.Point(688, 220);
            this.nmrUrunMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.nmrUrunMiktar.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmrUrunMiktar.Name = "nmrUrunMiktar";
            this.nmrUrunMiktar.ReadOnly = true;
            this.nmrUrunMiktar.Size = new System.Drawing.Size(209, 25);
            this.nmrUrunMiktar.TabIndex = 69;
            // 
            // cmbUrunKategori
            // 
            this.cmbUrunKategori.Font = new System.Drawing.Font("Montserrat", 11F);
            this.cmbUrunKategori.FormattingEnabled = true;
            this.cmbUrunKategori.Location = new System.Drawing.Point(688, 253);
            this.cmbUrunKategori.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUrunKategori.MaxLength = 50;
            this.cmbUrunKategori.Name = "cmbUrunKategori";
            this.cmbUrunKategori.Size = new System.Drawing.Size(209, 29);
            this.cmbUrunKategori.TabIndex = 68;
            this.cmbUrunKategori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbUrunKategori_KeyPress_1);
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtUrunAciklama.Location = new System.Drawing.Point(688, 290);
            this.txtUrunAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAciklama.MaxLength = 100;
            this.txtUrunAciklama.Multiline = true;
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.ReadOnly = true;
            this.txtUrunAciklama.Size = new System.Drawing.Size(209, 67);
            this.txtUrunAciklama.TabIndex = 67;
            // 
            // txtUrunMarka
            // 
            this.txtUrunMarka.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtUrunMarka.Location = new System.Drawing.Point(689, 154);
            this.txtUrunMarka.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunMarka.MaxLength = 50;
            this.txtUrunMarka.Name = "txtUrunMarka";
            this.txtUrunMarka.ReadOnly = true;
            this.txtUrunMarka.Size = new System.Drawing.Size(208, 25);
            this.txtUrunMarka.TabIndex = 66;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtUrunAd.Location = new System.Drawing.Point(689, 122);
            this.txtUrunAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAd.MaxLength = 50;
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.ReadOnly = true;
            this.txtUrunAd.Size = new System.Drawing.Size(208, 25);
            this.txtUrunAd.TabIndex = 65;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTutar.Location = new System.Drawing.Point(966, 581);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(35, 37);
            this.lblTutar.TabIndex = 67;
            this.lblTutar.Text = "0";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteri.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblMusteri.Location = new System.Drawing.Point(966, 544);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(118, 37);
            this.lblMusteri.TabIndex = 68;
            this.lblMusteri.Text = "Müşteri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(18, 354);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(938, 25);
            this.btnTemizle.TabIndex = 69;
            this.btnTemizle.Text = "Herşeyi Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1343, 749);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.lstFatura);
            this.Name = "frmSiparis";
            this.ShowIcon = false;
            this.Text = "Sipariş Verme";
            this.Load += new System.EventHandler(this.frmSiparis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMusteri)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstFatura;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dtMusteri;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtUrun;
        private System.Windows.Forms.Button btnUrunAra;
        private System.Windows.Forms.TextBox txtUrunArama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmrUrunFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.NumericUpDown nmrUrunMiktar;
        private System.Windows.Forms.ComboBox cmbUrunKategori;
        private System.Windows.Forms.TextBox txtUrunAciklama;
        private System.Windows.Forms.TextBox txtUrunMarka;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Button btnTemizle;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}