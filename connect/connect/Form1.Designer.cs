namespace connect
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
            this.SqlEkle_btn = new System.Windows.Forms.Button();
            this.Sqlupdate_btn = new System.Windows.Forms.Button();
            this.SqlDelete_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SqlEkle_btn
            // 
            this.SqlEkle_btn.Location = new System.Drawing.Point(57, 35);
            this.SqlEkle_btn.Name = "SqlEkle_btn";
            this.SqlEkle_btn.Size = new System.Drawing.Size(196, 162);
            this.SqlEkle_btn.TabIndex = 0;
            this.SqlEkle_btn.Text = "Sql veri ekleme ";
            this.SqlEkle_btn.UseVisualStyleBackColor = true;
            this.SqlEkle_btn.Click += new System.EventHandler(this.SqlEkle_btn_Click);
            // 
            // Sqlupdate_btn
            // 
            this.Sqlupdate_btn.Location = new System.Drawing.Point(57, 248);
            this.Sqlupdate_btn.Name = "Sqlupdate_btn";
            this.Sqlupdate_btn.Size = new System.Drawing.Size(196, 162);
            this.Sqlupdate_btn.TabIndex = 1;
            this.Sqlupdate_btn.Text = "Sql veri güncelleme";
            this.Sqlupdate_btn.UseVisualStyleBackColor = true;
            this.Sqlupdate_btn.Click += new System.EventHandler(this.Sqlupdate_btn_Click);
            // 
            // SqlDelete_btn
            // 
            this.SqlDelete_btn.Location = new System.Drawing.Point(57, 464);
            this.SqlDelete_btn.Name = "SqlDelete_btn";
            this.SqlDelete_btn.Size = new System.Drawing.Size(196, 162);
            this.SqlDelete_btn.TabIndex = 2;
            this.SqlDelete_btn.Text = "Sql veri silme ";
            this.SqlDelete_btn.UseVisualStyleBackColor = true;
            this.SqlDelete_btn.Click += new System.EventHandler(this.SqlDelete_btn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 162);
            this.button3.TabIndex = 3;
            this.button3.Text = "frebase veri ekleme ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 744);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SqlDelete_btn);
            this.Controls.Add(this.Sqlupdate_btn);
            this.Controls.Add(this.SqlEkle_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SqlEkle_btn;
        private System.Windows.Forms.Button Sqlupdate_btn;
        private System.Windows.Forms.Button SqlDelete_btn;
        private System.Windows.Forms.Button button3;
    }
}

