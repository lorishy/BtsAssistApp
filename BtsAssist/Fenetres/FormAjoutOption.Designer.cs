﻿
namespace BtsAssist.Fenetres
{
    partial class FormAjoutOption
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
            this.Fermer = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.titreOption = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListeBts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Fermer)).BeginInit();
            this.SuspendLayout();
            // 
            // Fermer
            // 
            this.Fermer.BackColor = System.Drawing.Color.Transparent;
            this.Fermer.ErrorImage = null;
            this.Fermer.Image = global::BtsAssist.Properties.Resources.btnClose;
            this.Fermer.Location = new System.Drawing.Point(568, 9);
            this.Fermer.Name = "Fermer";
            this.Fermer.Size = new System.Drawing.Size(16, 16);
            this.Fermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fermer.TabIndex = 12;
            this.Fermer.TabStop = false;
            this.Fermer.Click += new System.EventHandler(this.Fermer_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(207, 36);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.Text = "Ajouter une Option";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-9, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 4);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nom de l\'option :";
            // 
            // titreOption
            // 
            this.titreOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(150)))));
            this.titreOption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titreOption.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreOption.ForeColor = System.Drawing.Color.White;
            this.titreOption.Location = new System.Drawing.Point(78, 148);
            this.titreOption.Name = "titreOption";
            this.titreOption.Size = new System.Drawing.Size(441, 20);
            this.titreOption.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(78, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 3);
            this.panel2.TabIndex = 19;
            // 
            // ListeBts
            // 
            this.ListeBts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(150)))));
            this.ListeBts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListeBts.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeBts.ForeColor = System.Drawing.Color.White;
            this.ListeBts.FormattingEnabled = true;
            this.ListeBts.Location = new System.Drawing.Point(78, 259);
            this.ListeBts.Name = "ListeBts";
            this.ListeBts.Size = new System.Drawing.Size(441, 31);
            this.ListeBts.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "BTS :";
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(46)))));
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Poppins ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.White;
            this.Ajouter.Location = new System.Drawing.Point(233, 355);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(129, 44);
            this.Ajouter.TabIndex = 22;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // FormAjoutOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(596, 431);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListeBts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.titreOption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.Fermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjoutOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAjoutOption";
            ((System.ComponentModel.ISupportInitialize)(this.Fermer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Fermer;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titreOption;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ListeBts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ajouter;
    }
}