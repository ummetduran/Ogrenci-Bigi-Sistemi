namespace ÖğrenciBilgiSistemi
{
    partial class AkademikAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AkademikAnaSayfa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notGirButton = new System.Windows.Forms.Button();
            this.isimLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.notGirButton);
            this.groupBox1.Location = new System.Drawing.Point(264, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 328);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // notGirButton
            // 
            this.notGirButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.notGirButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notGirButton.BackgroundImage")));
            this.notGirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notGirButton.ForeColor = System.Drawing.Color.White;
            this.notGirButton.Location = new System.Drawing.Point(161, 131);
            this.notGirButton.Name = "notGirButton";
            this.notGirButton.Size = new System.Drawing.Size(158, 65);
            this.notGirButton.TabIndex = 2;
            this.notGirButton.Text = "Not Gir";
            this.notGirButton.UseVisualStyleBackColor = false;
            this.notGirButton.Click += new System.EventHandler(this.notGirButton_Click);
            // 
            // isimLabel
            // 
            this.isimLabel.AutoSize = true;
            this.isimLabel.BackColor = System.Drawing.Color.Transparent;
            this.isimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimLabel.ForeColor = System.Drawing.Color.White;
            this.isimLabel.Location = new System.Drawing.Point(26, 224);
            this.isimLabel.Name = "isimLabel";
            this.isimLabel.Size = new System.Drawing.Size(78, 20);
            this.isimLabel.TabIndex = 14;
            this.isimLabel.Text = "adsoyad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ÖğrenciBilgiSistemi.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(30, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // AkademikAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ÖğrenciBilgiSistemi.Properties.Resources.solid_color_5;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isimLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AkademikAnaSayfa";
            this.Text = "AkademikAnaSayfa";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button notGirButton;
        private System.Windows.Forms.Label isimLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}