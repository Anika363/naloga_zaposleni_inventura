﻿namespace Naloga_inventura_zaposlenih
{
    partial class Ustvari_projekt
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
            this.ime_projekta = new System.Windows.Forms.TextBox();
            this.opis_projekta = new System.Windows.Forms.RichTextBox();
            this.btn_ustvari = new System.Windows.Forms.Button();
            this.btn_nazaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "USTVARI PROJEKT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis:";
            // 
            // ime_projekta
            // 
            this.ime_projekta.Location = new System.Drawing.Point(220, 177);
            this.ime_projekta.Name = "ime_projekta";
            this.ime_projekta.Size = new System.Drawing.Size(197, 22);
            this.ime_projekta.TabIndex = 3;
            this.ime_projekta.TextChanged += new System.EventHandler(this.ime_projekta_TextChanged);
            // 
            // opis_projekta
            // 
            this.opis_projekta.Location = new System.Drawing.Point(220, 338);
            this.opis_projekta.Name = "opis_projekta";
            this.opis_projekta.Size = new System.Drawing.Size(181, 96);
            this.opis_projekta.TabIndex = 4;
            this.opis_projekta.Text = "";
            // 
            // btn_ustvari
            // 
            this.btn_ustvari.Location = new System.Drawing.Point(714, 535);
            this.btn_ustvari.Name = "btn_ustvari";
            this.btn_ustvari.Size = new System.Drawing.Size(115, 55);
            this.btn_ustvari.TabIndex = 5;
            this.btn_ustvari.Text = "Ustvari";
            this.btn_ustvari.UseVisualStyleBackColor = true;
            this.btn_ustvari.Click += new System.EventHandler(this.btn_ustvari_Click);
            // 
            // btn_nazaj
            // 
            this.btn_nazaj.Location = new System.Drawing.Point(100, 525);
            this.btn_nazaj.Name = "btn_nazaj";
            this.btn_nazaj.Size = new System.Drawing.Size(105, 65);
            this.btn_nazaj.TabIndex = 6;
            this.btn_nazaj.Text = "Nazaj";
            this.btn_nazaj.UseVisualStyleBackColor = true;
            this.btn_nazaj.Click += new System.EventHandler(this.btn_nazaj_Click);
            // 
            // Ustvari_projekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 651);
            this.Controls.Add(this.btn_nazaj);
            this.Controls.Add(this.btn_ustvari);
            this.Controls.Add(this.opis_projekta);
            this.Controls.Add(this.ime_projekta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ustvari_projekt";
            this.Text = "Ustvari_projekt";
            this.Load += new System.EventHandler(this.Ustvari_projekt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ime_projekta;
        private System.Windows.Forms.RichTextBox opis_projekta;
        private System.Windows.Forms.Button btn_ustvari;
        private System.Windows.Forms.Button btn_nazaj;
    }
}