namespace UrunSatis
{
    partial class frmMenu
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
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunDuzenle = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriDuzenle = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Location = new System.Drawing.Point(66, 126);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(228, 197);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunDuzenle
            // 
            this.btnUrunDuzenle.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunDuzenle.Location = new System.Drawing.Point(300, 126);
            this.btnUrunDuzenle.Name = "btnUrunDuzenle";
            this.btnUrunDuzenle.Size = new System.Drawing.Size(228, 197);
            this.btnUrunDuzenle.TabIndex = 1;
            this.btnUrunDuzenle.Text = "Ürün Düzenle / Ara";
            this.btnUrunDuzenle.UseVisualStyleBackColor = true;
            this.btnUrunDuzenle.Click += new System.EventHandler(this.btnUrunDuzenle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.Location = new System.Drawing.Point(534, 126);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(228, 197);
            this.btnMusteriEkle.TabIndex = 2;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnMusteriDuzenle
            // 
            this.btnMusteriDuzenle.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriDuzenle.Location = new System.Drawing.Point(768, 126);
            this.btnMusteriDuzenle.Name = "btnMusteriDuzenle";
            this.btnMusteriDuzenle.Size = new System.Drawing.Size(228, 197);
            this.btnMusteriDuzenle.TabIndex = 3;
            this.btnMusteriDuzenle.Text = "Müşteri Düzenle / Ara";
            this.btnMusteriDuzenle.UseVisualStyleBackColor = true;
            this.btnMusteriDuzenle.Click += new System.EventHandler(this.btnMusteriDuzenle_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparis.Location = new System.Drawing.Point(1002, 126);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(228, 197);
            this.btnSiparis.TabIndex = 4;
            this.btnSiparis.Text = "Sipariş Oluştur";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1316, 488);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnMusteriDuzenle);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.btnUrunDuzenle);
            this.Controls.Add(this.btnUrunEkle);
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.Text = "Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunDuzenle;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriDuzenle;
        private System.Windows.Forms.Button btnSiparis;
    }
}