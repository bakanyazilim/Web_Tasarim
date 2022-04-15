namespace Web_Tasarim_KAP
{
    partial class Frm_Fiat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Fiat));
            this.pictureBox_DOBLO = new System.Windows.Forms.PictureBox();
            this.Lbl_Ust_Bilgi = new System.Windows.Forms.Label();
            this.Btn_Hemen_Al = new System.Windows.Forms.Button();
            this.Btn_Detaylar = new System.Windows.Forms.Button();
            this.pictureBox_EGEA = new System.Windows.Forms.PictureBox();
            this.Btn_Hemen_Al2 = new System.Windows.Forms.Button();
            this.Btn_Detaylar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DOBLO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EGEA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_DOBLO
            // 
            this.pictureBox_DOBLO.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_DOBLO.Image")));
            this.pictureBox_DOBLO.Location = new System.Drawing.Point(12, 93);
            this.pictureBox_DOBLO.Name = "pictureBox_DOBLO";
            this.pictureBox_DOBLO.Size = new System.Drawing.Size(238, 119);
            this.pictureBox_DOBLO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_DOBLO.TabIndex = 0;
            this.pictureBox_DOBLO.TabStop = false;
            // 
            // Lbl_Ust_Bilgi
            // 
            this.Lbl_Ust_Bilgi.AutoSize = true;
            this.Lbl_Ust_Bilgi.Location = new System.Drawing.Point(99, 23);
            this.Lbl_Ust_Bilgi.Name = "Lbl_Ust_Bilgi";
            this.Lbl_Ust_Bilgi.Size = new System.Drawing.Size(128, 16);
            this.Lbl_Ust_Bilgi.TabIndex = 1;
            this.Lbl_Ust_Bilgi.Text = "FİAT ARAÇ LİSTESİ";
            // 
            // Btn_Hemen_Al
            // 
            this.Btn_Hemen_Al.Location = new System.Drawing.Point(12, 234);
            this.Btn_Hemen_Al.Name = "Btn_Hemen_Al";
            this.Btn_Hemen_Al.Size = new System.Drawing.Size(111, 67);
            this.Btn_Hemen_Al.TabIndex = 2;
            this.Btn_Hemen_Al.Text = "HEMEN AL";
            this.Btn_Hemen_Al.UseVisualStyleBackColor = true;
            this.Btn_Hemen_Al.Click += new System.EventHandler(this.Btn_Hemen_Al_Click);
            // 
            // Btn_Detaylar
            // 
            this.Btn_Detaylar.Location = new System.Drawing.Point(139, 234);
            this.Btn_Detaylar.Name = "Btn_Detaylar";
            this.Btn_Detaylar.Size = new System.Drawing.Size(111, 67);
            this.Btn_Detaylar.TabIndex = 3;
            this.Btn_Detaylar.Text = "DETAYLAR";
            this.Btn_Detaylar.UseVisualStyleBackColor = true;
            this.Btn_Detaylar.Click += new System.EventHandler(this.Btn_Detaylar_Click);
            // 
            // pictureBox_EGEA
            // 
            this.pictureBox_EGEA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_EGEA.Image")));
            this.pictureBox_EGEA.Location = new System.Drawing.Point(310, 93);
            this.pictureBox_EGEA.Name = "pictureBox_EGEA";
            this.pictureBox_EGEA.Size = new System.Drawing.Size(238, 119);
            this.pictureBox_EGEA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_EGEA.TabIndex = 0;
            this.pictureBox_EGEA.TabStop = false;
            // 
            // Btn_Hemen_Al2
            // 
            this.Btn_Hemen_Al2.Location = new System.Drawing.Point(310, 234);
            this.Btn_Hemen_Al2.Name = "Btn_Hemen_Al2";
            this.Btn_Hemen_Al2.Size = new System.Drawing.Size(111, 67);
            this.Btn_Hemen_Al2.TabIndex = 2;
            this.Btn_Hemen_Al2.Text = "HEMEN AL";
            this.Btn_Hemen_Al2.UseVisualStyleBackColor = true;
            this.Btn_Hemen_Al2.Click += new System.EventHandler(this.Btn_Hemen_Al2_Click);
            // 
            // Btn_Detaylar2
            // 
            this.Btn_Detaylar2.Location = new System.Drawing.Point(437, 234);
            this.Btn_Detaylar2.Name = "Btn_Detaylar2";
            this.Btn_Detaylar2.Size = new System.Drawing.Size(111, 67);
            this.Btn_Detaylar2.TabIndex = 3;
            this.Btn_Detaylar2.Text = "DETAYLAR";
            this.Btn_Detaylar2.UseVisualStyleBackColor = true;
            this.Btn_Detaylar2.Click += new System.EventHandler(this.Btn_Detaylar2_Click);
            // 
            // Frm_Fiat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Detaylar2);
            this.Controls.Add(this.Btn_Detaylar);
            this.Controls.Add(this.Btn_Hemen_Al2);
            this.Controls.Add(this.Btn_Hemen_Al);
            this.Controls.Add(this.Lbl_Ust_Bilgi);
            this.Controls.Add(this.pictureBox_EGEA);
            this.Controls.Add(this.pictureBox_DOBLO);
            this.Name = "Frm_Fiat";
            this.Text = "Frm_Fiat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DOBLO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EGEA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_DOBLO;
        private System.Windows.Forms.Label Lbl_Ust_Bilgi;
        private System.Windows.Forms.Button Btn_Hemen_Al;
        private System.Windows.Forms.Button Btn_Detaylar;
        private System.Windows.Forms.PictureBox pictureBox_EGEA;
        private System.Windows.Forms.Button Btn_Hemen_Al2;
        private System.Windows.Forms.Button Btn_Detaylar2;
    }
}