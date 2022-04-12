
namespace BtsAssist
{
    partial class FormConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MotdepasseInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Connexion = new System.Windows.Forms.Button();
            this.Fermer = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fermer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 552);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "BtsAssist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(419, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 1);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(419, 249);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 1);
            this.panel3.TabIndex = 2;
            // 
            // MotdepasseInput
            // 
            this.MotdepasseInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.MotdepasseInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MotdepasseInput.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotdepasseInput.ForeColor = System.Drawing.Color.White;
            this.MotdepasseInput.Location = new System.Drawing.Point(419, 219);
            this.MotdepasseInput.Name = "MotdepasseInput";
            this.MotdepasseInput.Size = new System.Drawing.Size(400, 30);
            this.MotdepasseInput.TabIndex = 4;
            this.MotdepasseInput.Text = "Mot de passe";
            this.MotdepasseInput.Enter += new System.EventHandler(this.MotdepasseInput_Enter);
            this.MotdepasseInput.Leave += new System.EventHandler(this.MotdepasseInput_Leave);
            // 
            // EmailInput
            // 
            this.EmailInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.EmailInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailInput.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInput.ForeColor = System.Drawing.Color.White;
            this.EmailInput.Location = new System.Drawing.Point(419, 127);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(400, 30);
            this.EmailInput.TabIndex = 3;
            this.EmailInput.Text = "Email";
            this.EmailInput.Enter += new System.EventHandler(this.EmailInput_Enter);
            this.EmailInput.Leave += new System.EventHandler(this.EmailInput_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(511, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Connexion";
            // 
            // Connexion
            // 
            this.Connexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Connexion.FlatAppearance.BorderSize = 0;
            this.Connexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.Connexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.Connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connexion.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connexion.ForeColor = System.Drawing.Color.White;
            this.Connexion.Location = new System.Drawing.Point(419, 331);
            this.Connexion.Name = "Connexion";
            this.Connexion.Size = new System.Drawing.Size(400, 40);
            this.Connexion.TabIndex = 6;
            this.Connexion.Text = "Se connecter";
            this.Connexion.UseVisualStyleBackColor = false;
            this.Connexion.Click += new System.EventHandler(this.Connexion_Click);
            // 
            // Fermer
            // 
            this.Fermer.BackColor = System.Drawing.Color.Transparent;
            this.Fermer.Image = global::BtsAssist.Properties.Resources.btnClose;
            this.Fermer.Location = new System.Drawing.Point(920, 12);
            this.Fermer.Name = "Fermer";
            this.Fermer.Size = new System.Drawing.Size(16, 16);
            this.Fermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fermer.TabIndex = 8;
            this.Fermer.TabStop = false;
            this.Fermer.Click += new System.EventHandler(this.Fermer_Click);
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(948, 552);
            this.Controls.Add(this.Fermer);
            this.Controls.Add(this.Connexion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MotdepasseInput);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Righteous", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fermer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox MotdepasseInput;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Connexion;
        private System.Windows.Forms.PictureBox Fermer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

