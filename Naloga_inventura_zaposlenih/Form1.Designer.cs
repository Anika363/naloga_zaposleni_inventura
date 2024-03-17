namespace Naloga_inventura_zaposlenih
{
    partial class Login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Ime_lable = new System.Windows.Forms.Label();
            this.Geslo_lable = new System.Windows.Forms.Label();
            this.Vpis_btn = new System.Windows.Forms.Button();
            this.ustvari_upr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(388, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(388, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 22);
            this.textBox2.TabIndex = 1;
            // 
            // Ime_lable
            // 
            this.Ime_lable.AutoSize = true;
            this.Ime_lable.Location = new System.Drawing.Point(304, 167);
            this.Ime_lable.Name = "Ime_lable";
            this.Ime_lable.Size = new System.Drawing.Size(32, 16);
            this.Ime_lable.TabIndex = 2;
            this.Ime_lable.Text = "Ime:";
            // 
            // Geslo_lable
            // 
            this.Geslo_lable.AutoSize = true;
            this.Geslo_lable.Location = new System.Drawing.Point(292, 231);
            this.Geslo_lable.Name = "Geslo_lable";
            this.Geslo_lable.Size = new System.Drawing.Size(46, 16);
            this.Geslo_lable.TabIndex = 3;
            this.Geslo_lable.Text = "Geslo:";
            // 
            // Vpis_btn
            // 
            this.Vpis_btn.Location = new System.Drawing.Point(676, 417);
            this.Vpis_btn.Name = "Vpis_btn";
            this.Vpis_btn.Size = new System.Drawing.Size(78, 40);
            this.Vpis_btn.TabIndex = 4;
            this.Vpis_btn.Text = "Vpisi";
            this.Vpis_btn.UseVisualStyleBackColor = true;
            // 
            // ustvari_upr
            // 
            this.ustvari_upr.Location = new System.Drawing.Point(191, 417);
            this.ustvari_upr.Name = "ustvari_upr";
            this.ustvari_upr.Size = new System.Drawing.Size(94, 40);
            this.ustvari_upr.TabIndex = 5;
            this.ustvari_upr.Text = "Ustvari uporabnika";
            this.ustvari_upr.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 622);
            this.Controls.Add(this.ustvari_upr);
            this.Controls.Add(this.Vpis_btn);
            this.Controls.Add(this.Geslo_lable);
            this.Controls.Add(this.Ime_lable);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Ime_lable;
        private System.Windows.Forms.Label Geslo_lable;
        private System.Windows.Forms.Button Vpis_btn;
        private System.Windows.Forms.Button ustvari_upr;
    }
}

