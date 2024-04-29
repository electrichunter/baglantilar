namespace Connecting_lib
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtTelefonTuru = new System.Windows.Forms.TextBox();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.txtDogumTarihi = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(79, 70);
            this.txtIsim.Multiline = true;
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(510, 26);
            this.txtIsim.TabIndex = 0;
            this.txtIsim.Text = "İsim Giriniz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 121);
            this.button1.TabIndex = 1;
            this.button1.Text = "veri ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(79, 112);
            this.txtSoyisim.Multiline = true;
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(510, 26);
            this.txtSoyisim.TabIndex = 2;
            this.txtSoyisim.Text = "Soyismi Giriniz";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(79, 154);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(510, 26);
            this.txtTelefon.TabIndex = 3;
            this.txtTelefon.Text = "Telefon No giriniz";
            // 
            // txtTelefonTuru
            // 
            this.txtTelefonTuru.Location = new System.Drawing.Point(79, 203);
            this.txtTelefonTuru.Multiline = true;
            this.txtTelefonTuru.Name = "txtTelefonTuru";
            this.txtTelefonTuru.Size = new System.Drawing.Size(510, 26);
            this.txtTelefonTuru.TabIndex = 4;
            this.txtTelefonTuru.Text = "Telefon Türür (cep,ev vs)";
            // 
            // txtDepartman
            // 
            this.txtDepartman.Location = new System.Drawing.Point(79, 249);
            this.txtDepartman.Multiline = true;
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(510, 26);
            this.txtDepartman.TabIndex = 5;
            this.txtDepartman.Text = "Departman";
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(79, 297);
            this.txtSehir.Multiline = true;
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(510, 26);
            this.txtSehir.TabIndex = 6;
            this.txtSehir.Text = "Şehir";
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.Location = new System.Drawing.Point(79, 342);
            this.txtDogumTarihi.Multiline = true;
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(510, 26);
            this.txtDogumTarihi.TabIndex = 7;
            this.txtDogumTarihi.Text = "Dogum Tarihi (1999)";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(79, 393);
            this.txtMaas.Multiline = true;
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(510, 26);
            this.txtMaas.TabIndex = 8;
            this.txtMaas.Text = "Maaş (8000)";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(79, 454);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(510, 26);
            this.txtMail.TabIndex = 9;
            this.txtMail.Text = "Mail (omer@xyzbankası.com)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 795);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.txtDogumTarihi);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.txtDepartman);
            this.Controls.Add(this.txtTelefonTuru);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIsim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtTelefonTuru;
        private System.Windows.Forms.TextBox txtDepartman;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.TextBox txtDogumTarihi;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.TextBox txtMail;
    }
}

