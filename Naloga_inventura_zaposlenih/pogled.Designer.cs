namespace Naloga_inventura_zaposlenih
{
    partial class pogled
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
            this.ust_pro_btn = new System.Windows.Forms.Button();
            this.podaj_vodji_btn = new System.Windows.Forms.Button();
            this.uredi_btn = new System.Windows.Forms.Button();
            this.listBox1_zapo = new System.Windows.Forms.ListBox();
            this.ime_text = new System.Windows.Forms.TextBox();
            this.priimek_text = new System.Windows.Forms.TextBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.geslo_text = new System.Windows.Forms.TextBox();
            this.sola_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kraj_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.izbr_btn = new System.Windows.Forms.Button();
            this.id_lab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ust_pro_btn
            // 
            this.ust_pro_btn.Location = new System.Drawing.Point(56, 615);
            this.ust_pro_btn.Name = "ust_pro_btn";
            this.ust_pro_btn.Size = new System.Drawing.Size(111, 65);
            this.ust_pro_btn.TabIndex = 0;
            this.ust_pro_btn.Text = "Ustvari projekt";
            this.ust_pro_btn.UseVisualStyleBackColor = true;
            this.ust_pro_btn.Click += new System.EventHandler(this.ust_pro_btn_Click);
            // 
            // podaj_vodji_btn
            // 
            this.podaj_vodji_btn.Location = new System.Drawing.Point(201, 615);
            this.podaj_vodji_btn.Name = "podaj_vodji_btn";
            this.podaj_vodji_btn.Size = new System.Drawing.Size(111, 65);
            this.podaj_vodji_btn.TabIndex = 1;
            this.podaj_vodji_btn.Text = "Dodeli vodjo";
            this.podaj_vodji_btn.UseVisualStyleBackColor = true;
            this.podaj_vodji_btn.Click += new System.EventHandler(this.podaj_vodji_btn_Click);
            // 
            // uredi_btn
            // 
            this.uredi_btn.Location = new System.Drawing.Point(339, 615);
            this.uredi_btn.Name = "uredi_btn";
            this.uredi_btn.Size = new System.Drawing.Size(111, 65);
            this.uredi_btn.TabIndex = 2;
            this.uredi_btn.Text = "Uredi";
            this.uredi_btn.UseVisualStyleBackColor = true;
            this.uredi_btn.Click += new System.EventHandler(this.uredi_btn_Click);
            // 
            // listBox1_zapo
            // 
            this.listBox1_zapo.FormattingEnabled = true;
            this.listBox1_zapo.ItemHeight = 16;
            this.listBox1_zapo.Location = new System.Drawing.Point(25, 40);
            this.listBox1_zapo.Name = "listBox1_zapo";
            this.listBox1_zapo.Size = new System.Drawing.Size(195, 500);
            this.listBox1_zapo.TabIndex = 3;
            this.listBox1_zapo.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ime_text
            // 
            this.ime_text.Location = new System.Drawing.Point(372, 40);
            this.ime_text.Name = "ime_text";
            this.ime_text.Size = new System.Drawing.Size(159, 22);
            this.ime_text.TabIndex = 4;
            // 
            // priimek_text
            // 
            this.priimek_text.Location = new System.Drawing.Point(372, 101);
            this.priimek_text.Name = "priimek_text";
            this.priimek_text.Size = new System.Drawing.Size(159, 22);
            this.priimek_text.TabIndex = 5;
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(372, 157);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(159, 22);
            this.email_text.TabIndex = 6;
            // 
            // geslo_text
            // 
            this.geslo_text.Location = new System.Drawing.Point(372, 212);
            this.geslo_text.Name = "geslo_text";
            this.geslo_text.Size = new System.Drawing.Size(159, 22);
            this.geslo_text.TabIndex = 7;
            // 
            // sola_text
            // 
            this.sola_text.Location = new System.Drawing.Point(372, 274);
            this.sola_text.Name = "sola_text";
            this.sola_text.Size = new System.Drawing.Size(159, 22);
            this.sola_text.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Priimek:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Geslo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Šola:";
            // 
            // kraj_text
            // 
            this.kraj_text.Location = new System.Drawing.Point(372, 338);
            this.kraj_text.Name = "kraj_text";
            this.kraj_text.Size = new System.Drawing.Size(159, 22);
            this.kraj_text.TabIndex = 14;
            this.kraj_text.TextChanged += new System.EventHandler(this.kraj_text_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kraj:";
            // 
            // izbr_btn
            // 
            this.izbr_btn.Location = new System.Drawing.Point(478, 615);
            this.izbr_btn.Name = "izbr_btn";
            this.izbr_btn.Size = new System.Drawing.Size(111, 65);
            this.izbr_btn.TabIndex = 16;
            this.izbr_btn.Text = "Izbrisi";
            this.izbr_btn.UseVisualStyleBackColor = true;
            this.izbr_btn.Click += new System.EventHandler(this.izbr_btn_Click);
            // 
            // id_lab
            // 
            this.id_lab.AutoSize = true;
            this.id_lab.Location = new System.Drawing.Point(628, 39);
            this.id_lab.Name = "id_lab";
            this.id_lab.Size = new System.Drawing.Size(44, 16);
            this.id_lab.TabIndex = 17;
            this.id_lab.Text = "label7";
            // 
            // pogled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 751);
            this.Controls.Add(this.id_lab);
            this.Controls.Add(this.izbr_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kraj_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sola_text);
            this.Controls.Add(this.geslo_text);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.priimek_text);
            this.Controls.Add(this.ime_text);
            this.Controls.Add(this.listBox1_zapo);
            this.Controls.Add(this.uredi_btn);
            this.Controls.Add(this.podaj_vodji_btn);
            this.Controls.Add(this.ust_pro_btn);
            this.Name = "pogled";
            this.Text = "pogled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ust_pro_btn;
        private System.Windows.Forms.Button podaj_vodji_btn;
        private System.Windows.Forms.Button uredi_btn;
        private System.Windows.Forms.ListBox listBox1_zapo;
        private System.Windows.Forms.TextBox ime_text;
        private System.Windows.Forms.TextBox priimek_text;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.TextBox geslo_text;
        private System.Windows.Forms.TextBox sola_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kraj_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button izbr_btn;
        private System.Windows.Forms.Label id_lab;
    }
}