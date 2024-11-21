namespace DatabaseElectionProject
{
    partial class FrmEntry
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
            this.BtnOyGirisiYap = new System.Windows.Forms.Button();
            this.BtnGrafikler = new System.Windows.Forms.Button();
            this.BtnCikisYap = new System.Windows.Forms.Button();
            this.TxtE = new System.Windows.Forms.TextBox();
            this.TxtD = new System.Windows.Forms.TextBox();
            this.TxtC = new System.Windows.Forms.TextBox();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIlceAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOyGirisiYap
            // 
            this.BtnOyGirisiYap.Location = new System.Drawing.Point(123, 377);
            this.BtnOyGirisiYap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnOyGirisiYap.Name = "BtnOyGirisiYap";
            this.BtnOyGirisiYap.Size = new System.Drawing.Size(230, 43);
            this.BtnOyGirisiYap.TabIndex = 0;
            this.BtnOyGirisiYap.Text = "OY GİRİŞİ YAP";
            this.BtnOyGirisiYap.UseVisualStyleBackColor = true;
            this.BtnOyGirisiYap.Click += new System.EventHandler(this.BtnOyGirisiYap_Click);
            // 
            // BtnGrafikler
            // 
            this.BtnGrafikler.Location = new System.Drawing.Point(123, 426);
            this.BtnGrafikler.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnGrafikler.Name = "BtnGrafikler";
            this.BtnGrafikler.Size = new System.Drawing.Size(113, 42);
            this.BtnGrafikler.TabIndex = 1;
            this.BtnGrafikler.Text = "GRAFİKLER";
            this.BtnGrafikler.UseVisualStyleBackColor = true;
            this.BtnGrafikler.Click += new System.EventHandler(this.BtnGrafikler_Click);
            // 
            // BtnCikisYap
            // 
            this.BtnCikisYap.Location = new System.Drawing.Point(240, 425);
            this.BtnCikisYap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCikisYap.Name = "BtnCikisYap";
            this.BtnCikisYap.Size = new System.Drawing.Size(113, 42);
            this.BtnCikisYap.TabIndex = 2;
            this.BtnCikisYap.Text = "ÇIKIŞ YAP";
            this.BtnCikisYap.UseVisualStyleBackColor = true;
            this.BtnCikisYap.Click += new System.EventHandler(this.BtnCikisYap_Click);
            // 
            // TxtE
            // 
            this.TxtE.Location = new System.Drawing.Point(123, 325);
            this.TxtE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtE.Name = "TxtE";
            this.TxtE.Size = new System.Drawing.Size(231, 34);
            this.TxtE.TabIndex = 3;
            // 
            // TxtD
            // 
            this.TxtD.Location = new System.Drawing.Point(123, 276);
            this.TxtD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtD.Name = "TxtD";
            this.TxtD.Size = new System.Drawing.Size(231, 34);
            this.TxtD.TabIndex = 4;
            // 
            // TxtC
            // 
            this.TxtC.Location = new System.Drawing.Point(123, 229);
            this.TxtC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(231, 34);
            this.TxtC.TabIndex = 5;
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(123, 181);
            this.TxtB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(231, 34);
            this.TxtB.TabIndex = 6;
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(123, 134);
            this.TxtA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(231, 34);
            this.TxtA.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "A Partisi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "B Partisi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "C Partisi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "D Partisi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 327);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "E Partisi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "İLÇE ADI:";
            // 
            // TxtIlceAd
            // 
            this.TxtIlceAd.Location = new System.Drawing.Point(123, 46);
            this.TxtIlceAd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtIlceAd.Name = "TxtIlceAd";
            this.TxtIlceAd.Size = new System.Drawing.Size(231, 34);
            this.TxtIlceAd.TabIndex = 14;
            // 
            // FrmEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(392, 494);
            this.Controls.Add(this.TxtIlceAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtA);
            this.Controls.Add(this.TxtB);
            this.Controls.Add(this.TxtC);
            this.Controls.Add(this.TxtD);
            this.Controls.Add(this.TxtE);
            this.Controls.Add(this.BtnCikisYap);
            this.Controls.Add(this.BtnGrafikler);
            this.Controls.Add(this.BtnOyGirisiYap);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEntry";
            this.Text = "Veritabanlı Seçim Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOyGirisiYap;
        private System.Windows.Forms.Button BtnGrafikler;
        private System.Windows.Forms.Button BtnCikisYap;
        private System.Windows.Forms.TextBox TxtE;
        private System.Windows.Forms.TextBox TxtD;
        private System.Windows.Forms.TextBox TxtC;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtIlceAd;
    }
}

