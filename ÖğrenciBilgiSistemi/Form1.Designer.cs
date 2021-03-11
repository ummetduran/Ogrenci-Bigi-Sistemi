namespace ÖğrenciBilgiSistemi
{
    partial class loginForm
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
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.mailComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.parolaLabel = new System.Windows.Forms.Label();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.kullanıcıAdıLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.loginGroupBox.Controls.Add(this.mailComboBox);
            this.loginGroupBox.Controls.Add(this.label1);
            this.loginGroupBox.Controls.Add(this.loginButton);
            this.loginGroupBox.Controls.Add(this.parolaLabel);
            this.loginGroupBox.Controls.Add(this.parolaTextBox);
            this.loginGroupBox.Controls.Add(this.kullaniciAdiTextBox);
            this.loginGroupBox.Controls.Add(this.kullanıcıAdıLabel);
            this.loginGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginGroupBox.ForeColor = System.Drawing.Color.White;
            this.loginGroupBox.Location = new System.Drawing.Point(12, 58);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(641, 245);
            this.loginGroupBox.TabIndex = 0;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Giriş Sayfası";
            // 
            // mailComboBox
            // 
            this.mailComboBox.FormattingEnabled = true;
            this.mailComboBox.Items.AddRange(new object[] {
            "ogrenci.edu.tr",
            "akademik.edu.tr",
            "personel.edu.tr"});
            this.mailComboBox.Location = new System.Drawing.Point(424, 39);
            this.mailComboBox.Name = "mailComboBox";
            this.mailComboBox.Size = new System.Drawing.Size(197, 28);
            this.mailComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "@";
            // 
            // loginButton
            // 
            this.loginButton.BackgroundImage = global::ÖğrenciBilgiSistemi.Properties.Resources.solid_color_5;
            this.loginButton.Location = new System.Drawing.Point(236, 148);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(129, 41);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Giriş";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // parolaLabel
            // 
            this.parolaLabel.AutoSize = true;
            this.parolaLabel.Location = new System.Drawing.Point(120, 99);
            this.parolaLabel.Name = "parolaLabel";
            this.parolaLabel.Size = new System.Drawing.Size(63, 20);
            this.parolaLabel.TabIndex = 3;
            this.parolaLabel.Text = "Parola";
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.Location = new System.Drawing.Point(208, 92);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.Size = new System.Drawing.Size(177, 27);
            this.parolaTextBox.TabIndex = 2;
            this.parolaTextBox.UseSystemPasswordChar = true;
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(208, 40);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(177, 27);
            this.kullaniciAdiTextBox.TabIndex = 1;
            // 
            // kullanıcıAdıLabel
            // 
            this.kullanıcıAdıLabel.AutoSize = true;
            this.kullanıcıAdıLabel.Location = new System.Drawing.Point(16, 43);
            this.kullanıcıAdıLabel.Name = "kullanıcıAdıLabel";
            this.kullanıcıAdıLabel.Size = new System.Drawing.Size(167, 20);
            this.kullanıcıAdıLabel.TabIndex = 0;
            this.kullanıcıAdıLabel.Text = "Kullanıcı Adı/Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ÖğrenciBilgiSistemi.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(659, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // loginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ÖğrenciBilgiSistemi.Properties.Resources.solid_color_5;
            this.ClientSize = new System.Drawing.Size(934, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Bilgi Sistemi";
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Label kullanıcıAdıLabel;
        private System.Windows.Forms.Label parolaLabel;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ComboBox mailComboBox;
        private System.Windows.Forms.Label label1;
    }
}

