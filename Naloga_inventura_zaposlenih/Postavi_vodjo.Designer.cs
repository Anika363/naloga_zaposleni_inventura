namespace Naloga_inventura_zaposlenih
{
    partial class Postavi_vodjo
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
            this.listbox_zaposlenih = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listbox_projektov = new System.Windows.Forms.ListBox();
            this.btn_nastavi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "POSTAVI VODJO";
            // 
            // listbox_zaposlenih
            // 
            this.listbox_zaposlenih.FormattingEnabled = true;
            this.listbox_zaposlenih.ItemHeight = 16;
            this.listbox_zaposlenih.Location = new System.Drawing.Point(192, 141);
            this.listbox_zaposlenih.Name = "listbox_zaposlenih";
            this.listbox_zaposlenih.Size = new System.Drawing.Size(166, 308);
            this.listbox_zaposlenih.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime zaposlenih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Projekt:";
            // 
            // listbox_projektov
            // 
            this.listbox_projektov.FormattingEnabled = true;
            this.listbox_projektov.ItemHeight = 16;
            this.listbox_projektov.Location = new System.Drawing.Point(562, 141);
            this.listbox_projektov.Name = "listbox_projektov";
            this.listbox_projektov.Size = new System.Drawing.Size(163, 308);
            this.listbox_projektov.TabIndex = 4;
            // 
            // btn_nastavi
            // 
            this.btn_nastavi.Location = new System.Drawing.Point(407, 481);
            this.btn_nastavi.Name = "btn_nastavi";
            this.btn_nastavi.Size = new System.Drawing.Size(100, 51);
            this.btn_nastavi.TabIndex = 5;
            this.btn_nastavi.Text = "Nastavi Vodjo";
            this.btn_nastavi.UseVisualStyleBackColor = true;
            // 
            // Postavi_vodjo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 573);
            this.Controls.Add(this.btn_nastavi);
            this.Controls.Add(this.listbox_projektov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listbox_zaposlenih);
            this.Controls.Add(this.label1);
            this.Name = "Postavi_vodjo";
            this.Text = "Postavi_vodjo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listbox_zaposlenih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listbox_projektov;
        private System.Windows.Forms.Button btn_nastavi;
    }
}