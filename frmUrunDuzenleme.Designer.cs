namespace UrunSatis
{
    partial class frmUrunDuzenleme
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
            this.txtArama = new System.Windows.Forms.TextBox();
            this.dtUrun = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtArama.Location = new System.Drawing.Point(36, 38);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(226, 27);
            this.txtArama.TabIndex = 0;
            // 
            // dtUrun
            // 
            this.dtUrun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtUrun.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUrun.Location = new System.Drawing.Point(36, 95);
            this.dtUrun.Name = "dtUrun";
            this.dtUrun.Size = new System.Drawing.Size(934, 642);
            this.dtUrun.TabIndex = 1;
            this.dtUrun.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Montserrat", 24F);
            this.btnGuncelle.Location = new System.Drawing.Point(1000, 369);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(299, 119);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Montserrat", 24F);
            this.btnSil.Location = new System.Drawing.Point(1002, 494);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(297, 119);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Montserrat", 24F);
            this.btnTemizle.Location = new System.Drawing.Point(1002, 618);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(297, 119);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Montserrat", 11F);
            this.btnAra.Location = new System.Drawing.Point(268, 36);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(145, 29);
            this.btnAra.TabIndex = 17;
            this.btnAra.Text = "ID\'ye göre Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Location = new System.Drawing.Point(998, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ürün Fiyat";
            // 
            // nmrUrunFiyat
            // 
            this.nmrUrunFiyat.Font = new System.Drawing.Font("Montserrat", 11F);
            this.nmrUrunFiyat.Location = new System.Drawing.Point(1090, 192);
            this.nmrUrunFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.nmrUrunFiyat.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmrUrunFiyat.Name = "nmrUrunFiyat";
            this.nmrUrunFiyat.Size = new System.Drawing.Size(209, 25);
            this.nmrUrunFiyat.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(1007, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 42);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ürün\r\nAçıklama\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(971, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ürün Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(996, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ürün Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(988, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ürün Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(1011, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ürün Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(1018, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ürün ID";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtUrunId.Location = new System.Drawing.Point(1091, 95);
            this.txtUrunId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.ReadOnly = true;
            this.txtUrunId.Size = new System.Drawing.Size(208, 25);
            this.txtUrunId.TabIndex = 23;
            this.txtUrunId.TextChanged += new System.EventHandler(this.txtUrunId_TextChanged);
            // 
            // nmrUrunMiktar
            // 
            this.nmrUrunMiktar.Font = new System.Drawing.Font("Montserrat", 11F);
            this.nmrUrunMiktar.Location = new System.Drawing.Point(1090, 225);
            this.nmrUrunMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.nmrUrunMiktar.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmrUrunMiktar.Name = "nmrUrunMiktar";
            this.nmrUrunMiktar.Size = new System.Drawing.Size(209, 25);
            this.nmrUrunMiktar.TabIndex = 22;
            // 
            // cmbUrunKategori
            // 
            this.cmbUrunKategori.Font = new System.Drawing.Font("Montserrat", 11F);
            this.cmbUrunKategori.FormattingEnabled = true;
            this.cmbUrunKategori.Location = new System.Drawing.Point(1090, 258);
            this.cmbUrunKategori.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUrunKategori.MaxLength = 50;
            this.cmbUrunKategori.Name = "cmbUrunKategori";
            this.cmbUrunKategori.Size = new System.Drawing.Size(209, 29);
            this.cmbUrunKategori.TabIndex = 21;
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtUrunAciklama.Location = new System.Drawing.Point(1090, 295);
            this.txtUrunAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAciklama.MaxLength = 100;
            this.txtUrunAciklama.Multiline = true;
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(209, 67);
            this.txtUrunAciklama.TabIndex = 20;
            // 
            // txtUrunMarka
            // 
            this.txtUrunMarka.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtUrunMarka.Location = new System.Drawing.Point(1091, 159);
            this.txtUrunMarka.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunMarka.MaxLength = 50;
            this.txtUrunMarka.Name = "txtUrunMarka";
            this.txtUrunMarka.Size = new System.Drawing.Size(208, 25);
            this.txtUrunMarka.TabIndex = 19;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtUrunAd.Location = new System.Drawing.Point(1091, 127);
            this.txtUrunAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAd.MaxLength = 50;
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(208, 25);
            this.txtUrunAd.TabIndex = 18;
            // 
            // frmUrunDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1350, 779);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nmrUrunFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunId);
            this.Controls.Add(this.nmrUrunMiktar);
            this.Controls.Add(this.cmbUrunKategori);
            this.Controls.Add(this.txtUrunAciklama);
            this.Controls.Add(this.txtUrunMarka);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dtUrun);
            this.Controls.Add(this.txtArama);
            this.Name = "frmUrunDuzenleme";
            this.ShowIcon = false;
            this.Text = "Ürün Düzenleme";
            this.Load += new System.EventHandler(this.frmUrunDuzenleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridView dtUrun;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
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
    }
}