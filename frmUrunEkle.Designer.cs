namespace UrunSatis
{
    partial class frmUrunEkle
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
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtUrunMarka = new System.Windows.Forms.TextBox();
            this.txtUrunAciklama = new System.Windows.Forms.TextBox();
            this.cmbUrunKategori = new System.Windows.Forms.ComboBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.nmrUrunMiktar = new System.Windows.Forms.NumericUpDown();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmrUrunFiyat = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtUrunAd.Location = new System.Drawing.Point(128, 72);
            this.txtUrunAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAd.MaxLength = 50;
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(208, 25);
            this.txtUrunAd.TabIndex = 0;
            // 
            // txtUrunMarka
            // 
            this.txtUrunMarka.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtUrunMarka.Location = new System.Drawing.Point(128, 104);
            this.txtUrunMarka.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunMarka.MaxLength = 50;
            this.txtUrunMarka.Name = "txtUrunMarka";
            this.txtUrunMarka.Size = new System.Drawing.Size(208, 25);
            this.txtUrunMarka.TabIndex = 1;
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtUrunAciklama.Location = new System.Drawing.Point(127, 240);
            this.txtUrunAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAciklama.MaxLength = 100;
            this.txtUrunAciklama.Multiline = true;
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(209, 67);
            this.txtUrunAciklama.TabIndex = 3;
            // 
            // cmbUrunKategori
            // 
            this.cmbUrunKategori.Font = new System.Drawing.Font("Montserrat", 11F);
            this.cmbUrunKategori.FormattingEnabled = true;
            this.cmbUrunKategori.Location = new System.Drawing.Point(127, 203);
            this.cmbUrunKategori.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUrunKategori.MaxLength = 50;
            this.cmbUrunKategori.Name = "cmbUrunKategori";
            this.cmbUrunKategori.Size = new System.Drawing.Size(209, 29);
            this.cmbUrunKategori.TabIndex = 4;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("Montserrat", 24F);
            this.btnUrunEkle.Location = new System.Drawing.Point(12, 325);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(341, 115);
            this.btnUrunEkle.TabIndex = 5;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // nmrUrunMiktar
            // 
            this.nmrUrunMiktar.Font = new System.Drawing.Font("Montserrat", 11F);
            this.nmrUrunMiktar.Location = new System.Drawing.Point(127, 170);
            this.nmrUrunMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.nmrUrunMiktar.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmrUrunMiktar.Name = "nmrUrunMiktar";
            this.nmrUrunMiktar.Size = new System.Drawing.Size(209, 25);
            this.nmrUrunMiktar.TabIndex = 6;
            // 
            // txtUrunId
            // 
            this.txtUrunId.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtUrunId.Location = new System.Drawing.Point(128, 40);
            this.txtUrunId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.ReadOnly = true;
            this.txtUrunId.Size = new System.Drawing.Size(208, 25);
            this.txtUrunId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ürün ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(48, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ürün Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(25, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ürün Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(33, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ürün Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(8, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ürün Kategori";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(2, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ürün Açıklama\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Location = new System.Drawing.Point(35, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ürün Fiyat";
            // 
            // nmrUrunFiyat
            // 
            this.nmrUrunFiyat.Font = new System.Drawing.Font("Montserrat", 11F);
            this.nmrUrunFiyat.Location = new System.Drawing.Point(127, 137);
            this.nmrUrunFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.nmrUrunFiyat.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmrUrunFiyat.Name = "nmrUrunFiyat";
            this.nmrUrunFiyat.Size = new System.Drawing.Size(209, 25);
            this.nmrUrunFiyat.TabIndex = 14;
            // 
            // frmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(366, 472);
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
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.cmbUrunKategori);
            this.Controls.Add(this.txtUrunAciklama);
            this.Controls.Add(this.txtUrunMarka);
            this.Controls.Add(this.txtUrunAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUrunEkle";
            this.ShowIcon = false;
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.frmUrunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtUrunMarka;
        private System.Windows.Forms.TextBox txtUrunAciklama;
        private System.Windows.Forms.ComboBox cmbUrunKategori;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.NumericUpDown nmrUrunMiktar;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmrUrunFiyat;
    }
}