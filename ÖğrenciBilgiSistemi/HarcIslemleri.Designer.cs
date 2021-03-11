namespace ÖğrenciBilgiSistemi
{
    partial class HarcIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HarcIslemleri));
            this.araButton = new System.Windows.Forms.Button();
            this.ogrNoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // araButton
            // 
            this.araButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("araButton.BackgroundImage")));
            this.araButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.araButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araButton.ForeColor = System.Drawing.Color.White;
            this.araButton.Location = new System.Drawing.Point(469, 28);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(47, 32);
            this.araButton.TabIndex = 11;
            this.araButton.UseVisualStyleBackColor = true;
            this.araButton.Click += new System.EventHandler(this.araButton_Click);
            // 
            // ogrNoTextBox
            // 
            this.ogrNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrNoTextBox.Location = new System.Drawing.Point(230, 33);
            this.ogrNoTextBox.Name = "ogrNoTextBox";
            this.ogrNoTextBox.Size = new System.Drawing.Size(223, 27);
            this.ogrNoTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Öğrenci No";
            // 
            // HarcIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ÖğrenciBilgiSistemi.Properties.Resources.solid_color_5;
            this.ClientSize = new System.Drawing.Size(1108, 577);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.ogrNoTextBox);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Name = "HarcIslemleri";
            this.Text = "HarcIslemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.TextBox ogrNoTextBox;
        private System.Windows.Forms.Label label1;
    }
}