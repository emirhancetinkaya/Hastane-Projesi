namespace udemy13._1_hastane_projesi
{
    partial class FrmGirişler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirişler));
            this.btnhastagirişi = new System.Windows.Forms.Button();
            this.btndoktorgirişi = new System.Windows.Forms.Button();
            this.btnsekretergirişi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhastagirişi
            // 
            this.btnhastagirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhastagirişi.BackgroundImage")));
            this.btnhastagirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhastagirişi.Location = new System.Drawing.Point(71, 171);
            this.btnhastagirişi.Name = "btnhastagirişi";
            this.btnhastagirişi.Size = new System.Drawing.Size(181, 135);
            this.btnhastagirişi.TabIndex = 0;
            this.btnhastagirişi.UseVisualStyleBackColor = true;
            this.btnhastagirişi.Click += new System.EventHandler(this.btnhastagirişi_Click);
            // 
            // btndoktorgirişi
            // 
            this.btndoktorgirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndoktorgirişi.BackgroundImage")));
            this.btndoktorgirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoktorgirişi.Location = new System.Drawing.Point(331, 171);
            this.btndoktorgirişi.Name = "btndoktorgirişi";
            this.btndoktorgirişi.Size = new System.Drawing.Size(184, 135);
            this.btndoktorgirişi.TabIndex = 1;
            this.btndoktorgirişi.UseVisualStyleBackColor = true;
            this.btndoktorgirişi.Click += new System.EventHandler(this.btndoktorgirişi_Click);
            // 
            // btnsekretergirişi
            // 
            this.btnsekretergirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsekretergirişi.BackgroundImage")));
            this.btnsekretergirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsekretergirişi.Location = new System.Drawing.Point(575, 171);
            this.btnsekretergirişi.Name = "btnsekretergirişi";
            this.btnsekretergirişi.Size = new System.Drawing.Size(196, 135);
            this.btnsekretergirişi.TabIndex = 2;
            this.btnsekretergirişi.UseVisualStyleBackColor = true;
            this.btnsekretergirişi.Click += new System.EventHandler(this.btnsekretergirişi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 71);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hilal Hospital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(396, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGirişler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(825, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsekretergirişi);
            this.Controls.Add(this.btndoktorgirişi);
            this.Controls.Add(this.btnhastagirişi);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmGirişler";
            this.Text = "Hilal Hospital Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhastagirişi;
        private System.Windows.Forms.Button btndoktorgirişi;
        private System.Windows.Forms.Button btnsekretergirişi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

