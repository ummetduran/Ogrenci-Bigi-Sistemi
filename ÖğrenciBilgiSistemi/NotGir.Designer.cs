namespace ÖğrenciBilgiSistemi
{
    partial class NotGir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotGir));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ogrNoTextBox = new System.Windows.Forms.TextBox();
            this.vizeTextBox = new System.Windows.Forms.TextBox();
            this.finalTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.temizleButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(166, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vize Notu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(110, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Final Notu";
            // 
            // ogrNoTextBox
            // 
            this.ogrNoTextBox.Location = new System.Drawing.Point(268, 72);
            this.ogrNoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ogrNoTextBox.Name = "ogrNoTextBox";
            this.ogrNoTextBox.Size = new System.Drawing.Size(313, 24);
            this.ogrNoTextBox.TabIndex = 5;
            this.ogrNoTextBox.TextChanged += new System.EventHandler(this.ogrNoTextBox_TextChanged);
            this.ogrNoTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ogrNoTextBox_MouseDown);
            // 
            // vizeTextBox
            // 
            this.vizeTextBox.Location = new System.Drawing.Point(268, 200);
            this.vizeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.vizeTextBox.Name = "vizeTextBox";
            this.vizeTextBox.Size = new System.Drawing.Size(313, 24);
            this.vizeTextBox.TabIndex = 6;
            // 
            // finalTextBox
            // 
            this.finalTextBox.Location = new System.Drawing.Point(268, 263);
            this.finalTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.finalTextBox.Name = "finalTextBox";
            this.finalTextBox.Size = new System.Drawing.Size(313, 24);
            this.finalTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.kaydetButton);
            this.groupBox1.Controls.Add(this.temizleButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.finalTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.vizeTextBox);
            this.groupBox1.Controls.Add(this.ogrNoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(182, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(654, 448);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 134);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(318, 26);
            this.comboBox1.TabIndex = 12;
            // 
            // kaydetButton
            // 
            this.kaydetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kaydetButton.BackgroundImage")));
            this.kaydetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetButton.ForeColor = System.Drawing.Color.White;
            this.kaydetButton.Location = new System.Drawing.Point(455, 327);
            this.kaydetButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(126, 35);
            this.kaydetButton.TabIndex = 11;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // temizleButton
            // 
            this.temizleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("temizleButton.BackgroundImage")));
            this.temizleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleButton.ForeColor = System.Drawing.Color.White;
            this.temizleButton.Location = new System.Drawing.Point(268, 327);
            this.temizleButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(126, 35);
            this.temizleButton.TabIndex = 10;
            this.temizleButton.Text = "Temizle";
            this.temizleButton.UseVisualStyleBackColor = true;
            // 
            // NotGir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1042, 555);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NotGir";
            this.Text = "NotGir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ogrNoTextBox;
        private System.Windows.Forms.TextBox vizeTextBox;
        private System.Windows.Forms.TextBox finalTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.Button temizleButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}