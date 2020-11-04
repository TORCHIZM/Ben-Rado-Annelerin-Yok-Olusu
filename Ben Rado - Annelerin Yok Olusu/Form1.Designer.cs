namespace Ben_Rado___Annelerin_Yok_Olusu
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
            this.AnaKarakter = new System.Windows.Forms.PictureBox();
            this.PuanSayaci = new System.Windows.Forms.Label();
            this.CanSayaci = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AnaKarakter)).BeginInit();
            this.SuspendLayout();
            // 
            // AnaKarakter
            // 
            this.AnaKarakter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnaKarakter.Image = ((System.Drawing.Image)(resources.GetObject("AnaKarakter.Image")));
            this.AnaKarakter.Location = new System.Drawing.Point(13, 203);
            this.AnaKarakter.Name = "AnaKarakter";
            this.AnaKarakter.Size = new System.Drawing.Size(112, 113);
            this.AnaKarakter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnaKarakter.TabIndex = 0;
            this.AnaKarakter.TabStop = false;
            // 
            // PuanSayaci
            // 
            this.PuanSayaci.AutoSize = true;
            this.PuanSayaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PuanSayaci.Location = new System.Drawing.Point(89, 9);
            this.PuanSayaci.Name = "PuanSayaci";
            this.PuanSayaci.Size = new System.Drawing.Size(86, 25);
            this.PuanSayaci.TabIndex = 2;
            this.PuanSayaci.Text = "Puan: 0";
            // 
            // CanSayaci
            // 
            this.CanSayaci.AutoSize = true;
            this.CanSayaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CanSayaci.Location = new System.Drawing.Point(8, 9);
            this.CanSayaci.Name = "CanSayaci";
            this.CanSayaci.Size = new System.Drawing.Size(75, 25);
            this.CanSayaci.TabIndex = 3;
            this.CanSayaci.Text = "Can: 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 545);
            this.Controls.Add(this.CanSayaci);
            this.Controls.Add(this.PuanSayaci);
            this.Controls.Add(this.AnaKarakter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ben Rado: Annelerin Yok Oluşu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.AnaKarakter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AnaKarakter;
        private System.Windows.Forms.Label PuanSayaci;
        private System.Windows.Forms.Label CanSayaci;
    }
}

