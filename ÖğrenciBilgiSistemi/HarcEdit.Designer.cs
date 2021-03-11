namespace ÖğrenciBilgiSistemi
{
    partial class HarcEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.donemTextBox = new System.Windows.Forms.TextBox();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            this.odemeTextBox = new System.Windows.Forms.TextBox();
            this.kayitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harç Dönemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(138, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(122, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ödeme";
            // 
            // donemTextBox
            // 
            this.donemTextBox.Location = new System.Drawing.Point(233, 74);
            this.donemTextBox.Name = "donemTextBox";
            this.donemTextBox.Size = new System.Drawing.Size(203, 22);
            this.donemTextBox.TabIndex = 3;
            // 
            // fiyatTextBox
            // 
            this.fiyatTextBox.Location = new System.Drawing.Point(233, 129);
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.Size = new System.Drawing.Size(203, 22);
            this.fiyatTextBox.TabIndex = 4;
            // 
            // odemeTextBox
            // 
            this.odemeTextBox.Location = new System.Drawing.Point(233, 187);
            this.odemeTextBox.Name = "odemeTextBox";
            this.odemeTextBox.Size = new System.Drawing.Size(203, 22);
            this.odemeTextBox.TabIndex = 5;
            // 
            // kayitButton
            // 
            this.kayitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitButton.Location = new System.Drawing.Point(269, 253);
            this.kayitButton.Name = "kayitButton";
            this.kayitButton.Size = new System.Drawing.Size(108, 43);
            this.kayitButton.TabIndex = 6;
            this.kayitButton.Text = "Kaydet";
            this.kayitButton.UseVisualStyleBackColor = true;
            this.kayitButton.Click += new System.EventHandler(this.kayitButton_Click);
            // 
            // HarcEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(652, 389);
            this.Controls.Add(this.kayitButton);
            this.Controls.Add(this.odemeTextBox);
            this.Controls.Add(this.fiyatTextBox);
            this.Controls.Add(this.donemTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HarcEdit";
            this.Text = "HarcEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox donemTextBox;
        private System.Windows.Forms.TextBox fiyatTextBox;
        private System.Windows.Forms.TextBox odemeTextBox;
        private System.Windows.Forms.Button kayitButton;
    }
}