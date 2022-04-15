namespace Web_Tasarim_KAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lbl_İnfo1 = new System.Windows.Forms.Label();
            this.linkLabel_Uye_Ol = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Giris_Yap = new System.Windows.Forms.LinkLabel();
            this.Btn_0_Km = new System.Windows.Forms.Button();
            this.Btn_2_El = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_İnfo1
            // 
            this.Lbl_İnfo1.AutoSize = true;
            this.Lbl_İnfo1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_İnfo1.ForeColor = System.Drawing.Color.Crimson;
            this.Lbl_İnfo1.Location = new System.Drawing.Point(404, 176);
            this.Lbl_İnfo1.Name = "Lbl_İnfo1";
            this.Lbl_İnfo1.Size = new System.Drawing.Size(541, 54);
            this.Lbl_İnfo1.TabIndex = 0;
            this.Lbl_İnfo1.Text = "BAKAN OTO GALERİ";
            // 
            // linkLabel_Uye_Ol
            // 
            this.linkLabel_Uye_Ol.AutoSize = true;
            this.linkLabel_Uye_Ol.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Uye_Ol.Location = new System.Drawing.Point(803, 281);
            this.linkLabel_Uye_Ol.Name = "linkLabel_Uye_Ol";
            this.linkLabel_Uye_Ol.Size = new System.Drawing.Size(130, 37);
            this.linkLabel_Uye_Ol.TabIndex = 1;
            this.linkLabel_Uye_Ol.TabStop = true;
            this.linkLabel_Uye_Ol.Text = "ÜYE OL";
            // 
            // linkLabel_Giris_Yap
            // 
            this.linkLabel_Giris_Yap.AutoSize = true;
            this.linkLabel_Giris_Yap.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Giris_Yap.Location = new System.Drawing.Point(977, 281);
            this.linkLabel_Giris_Yap.Name = "linkLabel_Giris_Yap";
            this.linkLabel_Giris_Yap.Size = new System.Drawing.Size(172, 37);
            this.linkLabel_Giris_Yap.TabIndex = 2;
            this.linkLabel_Giris_Yap.TabStop = true;
            this.linkLabel_Giris_Yap.Text = "GİRİŞ YAP";
            // 
            // Btn_0_Km
            // 
            this.Btn_0_Km.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_0_Km.ForeColor = System.Drawing.Color.Blue;
            this.Btn_0_Km.Location = new System.Drawing.Point(367, 472);
            this.Btn_0_Km.Name = "Btn_0_Km";
            this.Btn_0_Km.Size = new System.Drawing.Size(294, 149);
            this.Btn_0_Km.TabIndex = 3;
            this.Btn_0_Km.Text = "0 KM ARAÇLAR";
            this.Btn_0_Km.UseVisualStyleBackColor = false;
            this.Btn_0_Km.Click += new System.EventHandler(this.Btn_0_Km_Click);
            // 
            // Btn_2_El
            // 
            this.Btn_2_El.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_2_El.Location = new System.Drawing.Point(798, 472);
            this.Btn_2_El.Name = "Btn_2_El";
            this.Btn_2_El.Size = new System.Drawing.Size(294, 149);
            this.Btn_2_El.TabIndex = 3;
            this.Btn_2_El.Text = "2.EL ARAÇLAR";
            this.Btn_2_El.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 613);
            this.Controls.Add(this.Btn_2_El);
            this.Controls.Add(this.Btn_0_Km);
            this.Controls.Add(this.linkLabel_Giris_Yap);
            this.Controls.Add(this.linkLabel_Uye_Ol);
            this.Controls.Add(this.Lbl_İnfo1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GALERİ SİTESİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_İnfo1;
        private System.Windows.Forms.LinkLabel linkLabel_Uye_Ol;
        private System.Windows.Forms.LinkLabel linkLabel_Giris_Yap;
        private System.Windows.Forms.Button Btn_0_Km;
        private System.Windows.Forms.Button Btn_2_El;
    }
}

