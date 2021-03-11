namespace ÖğrenciBilgiSistemi
{
    partial class OgrenciisleriAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciisleriAnaSayfa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ogrenciEkleButton = new System.Windows.Forms.Button();
            this.ogretimUyesiButton = new System.Windows.Forms.Button();
            this.harcButton = new System.Windows.Forms.Button();
            this.kayitYenilemeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.kayitYenilemeButton);
            this.groupBox1.Controls.Add(this.harcButton);
            this.groupBox1.Controls.Add(this.ogrenciEkleButton);
            this.groupBox1.Controls.Add(this.ogretimUyesiButton);
            this.groupBox1.Location = new System.Drawing.Point(71, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 328);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // ogrenciEkleButton
            // 
            this.ogrenciEkleButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ogrenciEkleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ogrenciEkleButton.BackgroundImage")));
            this.ogrenciEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciEkleButton.ForeColor = System.Drawing.Color.White;
            this.ogrenciEkleButton.Location = new System.Drawing.Point(98, 49);
            this.ogrenciEkleButton.Name = "ogrenciEkleButton";
            this.ogrenciEkleButton.Size = new System.Drawing.Size(158, 65);
            this.ogrenciEkleButton.TabIndex = 2;
            this.ogrenciEkleButton.Text = "Öğrenci Ekle";
            this.ogrenciEkleButton.UseVisualStyleBackColor = false;
            this.ogrenciEkleButton.Click += new System.EventHandler(this.ogrenciEkleButton_Click);
            // 
            // ogretimUyesiButton
            // 
            this.ogretimUyesiButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ogretimUyesiButton.BackgroundImage = global::ÖğrenciBilgiSistemi.Properties.Resources.solid_color_5;
            this.ogretimUyesiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogretimUyesiButton.ForeColor = System.Drawing.Color.White;
            this.ogretimUyesiButton.Location = new System.Drawing.Point(373, 49);
            this.ogretimUyesiButton.Name = "ogretimUyesiButton";
            this.ogretimUyesiButton.Size = new System.Drawing.Size(158, 65);
            this.ogretimUyesiButton.TabIndex = 3;
            this.ogretimUyesiButton.Text = "Öğretim Üyesi Ekle";
            this.ogretimUyesiButton.UseVisualStyleBackColor = false;
            this.ogretimUyesiButton.Click += new System.EventHandler(this.ogretimUyesiButton_Click);
            // 
            // harcButton
            // 
            this.harcButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.harcButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("harcButton.BackgroundImage")));
            this.harcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harcButton.ForeColor = System.Drawing.Color.White;
            this.harcButton.Location = new System.Drawing.Point(373, 185);
            this.harcButton.Name = "harcButton";
            this.harcButton.Size = new System.Drawing.Size(158, 65);
            this.harcButton.TabIndex = 4;
            this.harcButton.Text = "Harç İşlemleri";
            this.harcButton.UseVisualStyleBackColor = false;
            this.harcButton.Click += new System.EventHandler(this.harcButton_Click_1);
            // 
            // kayitYenilemeButton
            // 
            this.kayitYenilemeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kayitYenilemeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kayitYenilemeButton.BackgroundImage")));
            this.kayitYenilemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitYenilemeButton.ForeColor = System.Drawing.Color.White;
            this.kayitYenilemeButton.Location = new System.Drawing.Point(98, 185);
            this.kayitYenilemeButton.Name = "kayitYenilemeButton";
            this.kayitYenilemeButton.Size = new System.Drawing.Size(158, 65);
            this.kayitYenilemeButton.TabIndex = 6;
            this.kayitYenilemeButton.Text = "Kayıt Yenileme İşlemleri";
            this.kayitYenilemeButton.UseVisualStyleBackColor = false;
            this.kayitYenilemeButton.Click += new System.EventHandler(this.kayitYenilemeButton_Click_1);
            // 
            // OgrenciisleriAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "OgrenciisleriAnaSayfa";
            this.Text = "OgrenciisleriAnaSayfa";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ogrenciEkleButton;
        private System.Windows.Forms.Button ogretimUyesiButton;
        private System.Windows.Forms.Button kayitYenilemeButton;
        private System.Windows.Forms.Button harcButton;
    }
}