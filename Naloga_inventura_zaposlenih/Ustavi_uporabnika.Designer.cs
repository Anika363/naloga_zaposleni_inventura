namespace Naloga_inventura_zaposlenih
{
    partial class Ustavi_uporabnika
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
            this.ime_upr = new System.Windows.Forms.Label();
            this.priimek_upr = new System.Windows.Forms.Label();
            this.email_upr = new System.Windows.Forms.Label();
            this.geslo_upr = new System.Windows.Forms.Label();
            this.sola_upr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ime_uporabnika = new System.Windows.Forms.TextBox();
            this.priimek_uporabnika = new System.Windows.Forms.TextBox();
            this.email_uporabnika = new System.Windows.Forms.TextBox();
            this.geslo_uporabnika = new System.Windows.Forms.TextBox();
            this.sola_uporabnika = new System.Windows.Forms.TextBox();
            this.kraj_upr = new System.Windows.Forms.Label();
            this.kraj_uporabnika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ozadje_barva = new System.Windows.Forms.Label();
            this.font_upr = new System.Windows.Forms.Label();
            this.comboBox_barva = new System.Windows.Forms.ComboBox();
            this.comboBox_pisava = new System.Windows.Forms.ComboBox();
            this.Ustvali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ime_upr
            // 
            this.ime_upr.AutoSize = true;
            this.ime_upr.Location = new System.Drawing.Point(68, 106);
            this.ime_upr.Name = "ime_upr";
            this.ime_upr.Size = new System.Drawing.Size(40, 16);
            this.ime_upr.TabIndex = 0;
            this.ime_upr.Text = "* Ime:";
            this.ime_upr.Click += new System.EventHandler(this.label1_Click);
            // 
            // priimek_upr
            // 
            this.priimek_upr.AutoSize = true;
            this.priimek_upr.Location = new System.Drawing.Point(71, 150);
            this.priimek_upr.Name = "priimek_upr";
            this.priimek_upr.Size = new System.Drawing.Size(63, 16);
            this.priimek_upr.TabIndex = 1;
            this.priimek_upr.Text = "* Priimek:";
            // 
            // email_upr
            // 
            this.email_upr.AutoSize = true;
            this.email_upr.Location = new System.Drawing.Point(71, 186);
            this.email_upr.Name = "email_upr";
            this.email_upr.Size = new System.Drawing.Size(51, 16);
            this.email_upr.TabIndex = 2;
            this.email_upr.Text = "* email:";
            this.email_upr.Click += new System.EventHandler(this.label2_Click);
            // 
            // geslo_upr
            // 
            this.geslo_upr.AutoSize = true;
            this.geslo_upr.Location = new System.Drawing.Point(71, 221);
            this.geslo_upr.Name = "geslo_upr";
            this.geslo_upr.Size = new System.Drawing.Size(52, 16);
            this.geslo_upr.TabIndex = 3;
            this.geslo_upr.Text = "* geslo:";
            // 
            // sola_upr
            // 
            this.sola_upr.AutoSize = true;
            this.sola_upr.Location = new System.Drawing.Point(71, 262);
            this.sola_upr.Name = "sola_upr";
            this.sola_upr.Size = new System.Drawing.Size(46, 16);
            this.sola_upr.TabIndex = 4;
            this.sola_upr.Text = "* Sola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "PODATKI VPISNIKA";
            // 
            // ime_uporabnika
            // 
            this.ime_uporabnika.Location = new System.Drawing.Point(165, 99);
            this.ime_uporabnika.Name = "ime_uporabnika";
            this.ime_uporabnika.Size = new System.Drawing.Size(151, 22);
            this.ime_uporabnika.TabIndex = 6;
            // 
            // priimek_uporabnika
            // 
            this.priimek_uporabnika.Location = new System.Drawing.Point(165, 143);
            this.priimek_uporabnika.Name = "priimek_uporabnika";
            this.priimek_uporabnika.Size = new System.Drawing.Size(151, 22);
            this.priimek_uporabnika.TabIndex = 7;
            // 
            // email_uporabnika
            // 
            this.email_uporabnika.Location = new System.Drawing.Point(165, 186);
            this.email_uporabnika.Name = "email_uporabnika";
            this.email_uporabnika.Size = new System.Drawing.Size(151, 22);
            this.email_uporabnika.TabIndex = 8;
            // 
            // geslo_uporabnika
            // 
            this.geslo_uporabnika.Location = new System.Drawing.Point(165, 221);
            this.geslo_uporabnika.Name = "geslo_uporabnika";
            this.geslo_uporabnika.Size = new System.Drawing.Size(151, 22);
            this.geslo_uporabnika.TabIndex = 9;
            // 
            // sola_uporabnika
            // 
            this.sola_uporabnika.Location = new System.Drawing.Point(165, 262);
            this.sola_uporabnika.Name = "sola_uporabnika";
            this.sola_uporabnika.Size = new System.Drawing.Size(151, 22);
            this.sola_uporabnika.TabIndex = 10;
            // 
            // kraj_upr
            // 
            this.kraj_upr.AutoSize = true;
            this.kraj_upr.Location = new System.Drawing.Point(71, 303);
            this.kraj_upr.Name = "kraj_upr";
            this.kraj_upr.Size = new System.Drawing.Size(41, 16);
            this.kraj_upr.TabIndex = 11;
            this.kraj_upr.Text = "* Kraj:";
            // 
            // kraj_uporabnika
            // 
            this.kraj_uporabnika.Location = new System.Drawing.Point(165, 303);
            this.kraj_uporabnika.Name = "kraj_uporabnika";
            this.kraj_uporabnika.Size = new System.Drawing.Size(151, 22);
            this.kraj_uporabnika.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "NASTAVITVE";
            // 
            // ozadje_barva
            // 
            this.ozadje_barva.AutoSize = true;
            this.ozadje_barva.Location = new System.Drawing.Point(538, 105);
            this.ozadje_barva.Name = "ozadje_barva";
            this.ozadje_barva.Size = new System.Drawing.Size(90, 16);
            this.ozadje_barva.TabIndex = 14;
            this.ozadje_barva.Text = "Barva ozadja:";
            // 
            // font_upr
            // 
            this.font_upr.AutoSize = true;
            this.font_upr.Location = new System.Drawing.Point(541, 149);
            this.font_upr.Name = "font_upr";
            this.font_upr.Size = new System.Drawing.Size(52, 16);
            this.font_upr.TabIndex = 15;
            this.font_upr.Text = "Pisava:";
            // 
            // comboBox_barva
            // 
            this.comboBox_barva.FormattingEnabled = true;
            this.comboBox_barva.Location = new System.Drawing.Point(665, 105);
            this.comboBox_barva.Name = "comboBox_barva";
            this.comboBox_barva.Size = new System.Drawing.Size(121, 24);
            this.comboBox_barva.TabIndex = 16;
            // 
            // comboBox_pisava
            // 
            this.comboBox_pisava.FormattingEnabled = true;
            this.comboBox_pisava.Location = new System.Drawing.Point(665, 150);
            this.comboBox_pisava.Name = "comboBox_pisava";
            this.comboBox_pisava.Size = new System.Drawing.Size(121, 24);
            this.comboBox_pisava.TabIndex = 17;
            // 
            // Ustvali
            // 
            this.Ustvali.Location = new System.Drawing.Point(709, 474);
            this.Ustvali.Name = "Ustvali";
            this.Ustvali.Size = new System.Drawing.Size(100, 47);
            this.Ustvali.TabIndex = 18;
            this.Ustvali.Text = "Ustvari";
            this.Ustvali.UseVisualStyleBackColor = true;
            // 
            // Ustavi_uporabnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 600);
            this.Controls.Add(this.Ustvali);
            this.Controls.Add(this.comboBox_pisava);
            this.Controls.Add(this.comboBox_barva);
            this.Controls.Add(this.font_upr);
            this.Controls.Add(this.ozadje_barva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kraj_uporabnika);
            this.Controls.Add(this.kraj_upr);
            this.Controls.Add(this.sola_uporabnika);
            this.Controls.Add(this.geslo_uporabnika);
            this.Controls.Add(this.email_uporabnika);
            this.Controls.Add(this.priimek_uporabnika);
            this.Controls.Add(this.ime_uporabnika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sola_upr);
            this.Controls.Add(this.geslo_upr);
            this.Controls.Add(this.email_upr);
            this.Controls.Add(this.priimek_upr);
            this.Controls.Add(this.ime_upr);
            this.Name = "Ustavi_uporabnika";
            this.Text = "Ustavi_uporabnika";
            this.Load += new System.EventHandler(this.Ustavi_uporabnika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ime_upr;
        private System.Windows.Forms.Label priimek_upr;
        private System.Windows.Forms.Label email_upr;
        private System.Windows.Forms.Label geslo_upr;
        private System.Windows.Forms.Label sola_upr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ime_uporabnika;
        private System.Windows.Forms.TextBox priimek_uporabnika;
        private System.Windows.Forms.TextBox email_uporabnika;
        private System.Windows.Forms.TextBox geslo_uporabnika;
        private System.Windows.Forms.TextBox sola_uporabnika;
        private System.Windows.Forms.Label kraj_upr;
        private System.Windows.Forms.TextBox kraj_uporabnika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ozadje_barva;
        private System.Windows.Forms.Label font_upr;
        private System.Windows.Forms.ComboBox comboBox_barva;
        private System.Windows.Forms.ComboBox comboBox_pisava;
        private System.Windows.Forms.Button Ustvali;
    }
}