﻿namespace Biblioteka_AS
{
    partial class Korisnici
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
            this.ispisKorisnicitxt = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.osvjezibtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.spremikorisnikbtn = new System.Windows.Forms.Button();
            this.uploadkorisnikbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ispisKorisnicitxt
            // 
            this.ispisKorisnicitxt.BackColor = System.Drawing.Color.LavenderBlush;
            this.ispisKorisnicitxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ispisKorisnicitxt.Location = new System.Drawing.Point(12, 57);
            this.ispisKorisnicitxt.Name = "ispisKorisnicitxt";
            this.ispisKorisnicitxt.Size = new System.Drawing.Size(776, 368);
            this.ispisKorisnicitxt.TabIndex = 0;
            this.ispisKorisnicitxt.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ime",
            "Prezime",
            "Rok"});
            this.comboBox1.Location = new System.Drawing.Point(307, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sortiraj po:";
            // 
            // osvjezibtn
            // 
            this.osvjezibtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.osvjezibtn.Location = new System.Drawing.Point(434, 28);
            this.osvjezibtn.Name = "osvjezibtn";
            this.osvjezibtn.Size = new System.Drawing.Size(75, 23);
            this.osvjezibtn.TabIndex = 3;
            this.osvjezibtn.Text = "Osvježi";
            this.osvjezibtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Natrag";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // spremikorisnikbtn
            // 
            this.spremikorisnikbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spremikorisnikbtn.Location = new System.Drawing.Point(634, 25);
            this.spremikorisnikbtn.Name = "spremikorisnikbtn";
            this.spremikorisnikbtn.Size = new System.Drawing.Size(75, 23);
            this.spremikorisnikbtn.TabIndex = 10;
            this.spremikorisnikbtn.Text = "Spremi ";
            this.spremikorisnikbtn.UseVisualStyleBackColor = true;
            // 
            // uploadkorisnikbtn
            // 
            this.uploadkorisnikbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uploadkorisnikbtn.Location = new System.Drawing.Point(713, 25);
            this.uploadkorisnikbtn.Name = "uploadkorisnikbtn";
            this.uploadkorisnikbtn.Size = new System.Drawing.Size(75, 23);
            this.uploadkorisnikbtn.TabIndex = 11;
            this.uploadkorisnikbtn.Text = "Upload";
            this.uploadkorisnikbtn.UseVisualStyleBackColor = true;
            // 
            // Korisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uploadkorisnikbtn);
            this.Controls.Add(this.spremikorisnikbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.osvjezibtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ispisKorisnicitxt);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Name = "Korisnici";
            this.Text = "Korisnici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ispisKorisnicitxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button osvjezibtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button spremikorisnikbtn;
        private System.Windows.Forms.Button uploadkorisnikbtn;
    }
}