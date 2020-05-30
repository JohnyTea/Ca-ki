namespace Całki
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.wspolczynniki_TB = new System.Windows.Forms.TextBox();
            this.metodaProstokatow_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lewyKraniec_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prawyKraniec_TB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wartoscN_TB = new System.Windows.Forms.TextBox();
            this.metodaTrapezow_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.wyniki_TB = new System.Windows.Forms.RichTextBox();
            this.DetodaSimpsona_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wspolczynniki_TB
            // 
            this.wspolczynniki_TB.Location = new System.Drawing.Point(12, 29);
            this.wspolczynniki_TB.Name = "wspolczynniki_TB";
            this.wspolczynniki_TB.Size = new System.Drawing.Size(403, 20);
            this.wspolczynniki_TB.TabIndex = 0;
            // 
            // metodaProstokatow_Button
            // 
            this.metodaProstokatow_Button.Location = new System.Drawing.Point(47, 103);
            this.metodaProstokatow_Button.Name = "metodaProstokatow_Button";
            this.metodaProstokatow_Button.Size = new System.Drawing.Size(75, 23);
            this.metodaProstokatow_Button.TabIndex = 1;
            this.metodaProstokatow_Button.Text = "Prostokaty";
            this.metodaProstokatow_Button.UseVisualStyleBackColor = true;
            this.metodaProstokatow_Button.Click += new System.EventHandler(this.MetodaProstokatow_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ax^n + ax^(n-1)  + ... +ax^2 + ax + a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "a";
            // 
            // lewyKraniec_TB
            // 
            this.lewyKraniec_TB.Location = new System.Drawing.Point(12, 67);
            this.lewyKraniec_TB.Name = "lewyKraniec_TB";
            this.lewyKraniec_TB.Size = new System.Drawing.Size(26, 20);
            this.lewyKraniec_TB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "b";
            // 
            // prawyKraniec_TB
            // 
            this.prawyKraniec_TB.Location = new System.Drawing.Point(44, 67);
            this.prawyKraniec_TB.Name = "prawyKraniec_TB";
            this.prawyKraniec_TB.Size = new System.Drawing.Size(26, 20);
            this.prawyKraniec_TB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "n";
            // 
            // wartoscN_TB
            // 
            this.wartoscN_TB.Location = new System.Drawing.Point(15, 105);
            this.wartoscN_TB.Name = "wartoscN_TB";
            this.wartoscN_TB.Size = new System.Drawing.Size(26, 20);
            this.wartoscN_TB.TabIndex = 7;
            // 
            // metodaTrapezow_Button
            // 
            this.metodaTrapezow_Button.Location = new System.Drawing.Point(128, 105);
            this.metodaTrapezow_Button.Name = "metodaTrapezow_Button";
            this.metodaTrapezow_Button.Size = new System.Drawing.Size(75, 23);
            this.metodaTrapezow_Button.TabIndex = 9;
            this.metodaTrapezow_Button.Text = "Trapezy";
            this.metodaTrapezow_Button.UseVisualStyleBackColor = true;
            this.metodaTrapezow_Button.Click += new System.EventHandler(this.MetodaTrapezow_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wynik";
            // 
            // wyniki_TB
            // 
            this.wyniki_TB.Location = new System.Drawing.Point(20, 145);
            this.wyniki_TB.Name = "wyniki_TB";
            this.wyniki_TB.Size = new System.Drawing.Size(395, 96);
            this.wyniki_TB.TabIndex = 12;
            this.wyniki_TB.Text = "";
            // 
            // DetodaSimpsona_Button
            // 
            this.DetodaSimpsona_Button.Location = new System.Drawing.Point(209, 105);
            this.DetodaSimpsona_Button.Name = "DetodaSimpsona_Button";
            this.DetodaSimpsona_Button.Size = new System.Drawing.Size(75, 23);
            this.DetodaSimpsona_Button.TabIndex = 13;
            this.DetodaSimpsona_Button.Text = "Simpson";
            this.DetodaSimpsona_Button.UseVisualStyleBackColor = true;
            this.DetodaSimpsona_Button.Click += new System.EventHandler(this.DetodaSimpsona_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 260);
            this.Controls.Add(this.DetodaSimpsona_Button);
            this.Controls.Add(this.wyniki_TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.metodaTrapezow_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wartoscN_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prawyKraniec_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lewyKraniec_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metodaProstokatow_Button);
            this.Controls.Add(this.wspolczynniki_TB);
            this.Name = "Form1";
            this.Text = "Całkowianie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wspolczynniki_TB;
        private System.Windows.Forms.Button metodaProstokatow_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lewyKraniec_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prawyKraniec_TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox wartoscN_TB;
        private System.Windows.Forms.Button metodaTrapezow_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox wyniki_TB;
        private System.Windows.Forms.Button DetodaSimpsona_Button;
    }
}

