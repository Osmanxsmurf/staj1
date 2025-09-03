namespace UrunSatis
{
    partial class frmMusteriDuzenleme
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
            this.dtMusteri = new System.Windows.Forms.DataGridView();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // dtMusteri
            // 
            this.dtMusteri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtMusteri.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMusteri.Location = new System.Drawing.Point(38, 102);
            this.dtMusteri.Name = "dtMusteri";
            this.dtMusteri.Size = new System.Drawing.Size(921, 642);
            this.dtMusteri.TabIndex = 19;
            this.dtMusteri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Montserrat", 24F);
            this.btnTemizle.Location = new System.Drawing.Point(992, 624);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(351, 119);
            this.btnTemizle.TabIndex = 42;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Montserrat", 24F);
            this.btnSil.Location = new System.Drawing.Point(992, 500);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(351, 119);
            this.btnSil.TabIndex = 41;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Montserrat", 24F);
            this.btnGuncelle.Location = new System.Drawing.Point(990, 375);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(353, 119);
            this.btnGuncelle.TabIndex = 40;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(986, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "Müşteri Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(986, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Müşteri Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(975, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Müşteri Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(1008, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Müşteri Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(1012, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Müşteri ID";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtId.Location = new System.Drawing.Point(1100, 116);
            this.txtId.MaxLength = 30;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(243, 26);
            this.txtId.TabIndex = 47;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtEmail.Location = new System.Drawing.Point(1100, 282);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 26);
            this.txtEmail.TabIndex = 46;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtAdres.Location = new System.Drawing.Point(1100, 210);
            this.txtAdres.MaxLength = 100;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(243, 66);
            this.txtAdres.TabIndex = 45;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtTelefon.Location = new System.Drawing.Point(1100, 178);
            this.txtTelefon.MaxLength = 11;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(243, 26);
            this.txtTelefon.TabIndex = 44;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.txtAd.Location = new System.Drawing.Point(1100, 148);
            this.txtAd.MaxLength = 30;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(243, 26);
            this.txtAd.TabIndex = 43;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Montserrat", 11F);
            this.btnAra.Location = new System.Drawing.Point(270, 44);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(145, 27);
            this.btnAra.TabIndex = 54;
            this.btnAra.Text = "ID\'ye göre Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtArama.Location = new System.Drawing.Point(38, 44);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(226, 27);
            this.txtArama.TabIndex = 53;
            // 
            // frmMusteriDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1367, 791);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dtMusteri);
            this.Name = "frmMusteriDuzenleme";
            this.ShowIcon = false;
            this.Text = "Müşteri Düzenleme";
            this.Load += new System.EventHandler(this.frmMusteriDuzenleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtMusteri;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtArama;
    }
}