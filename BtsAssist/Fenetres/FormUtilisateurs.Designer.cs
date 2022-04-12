
namespace BtsAssist.Fenetres
{
    partial class FormUtilisateurs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridUtilisateur = new System.Windows.Forms.DataGridView();
            this.Supprimer = new System.Windows.Forms.Button();
            this.btnRoleEleve = new System.Windows.Forms.Button();
            this.btnRoleProf = new System.Windows.Forms.Button();
            this.btnRoleAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridUtilisateur
            // 
            this.DataGridUtilisateur.AllowUserToAddRows = false;
            this.DataGridUtilisateur.AllowUserToDeleteRows = false;
            this.DataGridUtilisateur.AllowUserToResizeColumns = false;
            this.DataGridUtilisateur.AllowUserToResizeRows = false;
            this.DataGridUtilisateur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridUtilisateur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridUtilisateur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.DataGridUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridUtilisateur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridUtilisateur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridUtilisateur.EnableHeadersVisualStyles = false;
            this.DataGridUtilisateur.Location = new System.Drawing.Point(12, 77);
            this.DataGridUtilisateur.MultiSelect = false;
            this.DataGridUtilisateur.Name = "DataGridUtilisateur";
            this.DataGridUtilisateur.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridUtilisateur.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridUtilisateur.RowHeadersVisible = false;
            this.DataGridUtilisateur.RowHeadersWidth = 51;
            this.DataGridUtilisateur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridUtilisateur.RowTemplate.Height = 24;
            this.DataGridUtilisateur.ShowEditingIcon = false;
            this.DataGridUtilisateur.Size = new System.Drawing.Size(1025, 473);
            this.DataGridUtilisateur.TabIndex = 0;
            this.DataGridUtilisateur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridUtilisateur_CellClick);
            // 
            // Supprimer
            // 
            this.Supprimer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supprimer.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.ForeColor = System.Drawing.Color.White;
            this.Supprimer.Location = new System.Drawing.Point(790, 13);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(167, 35);
            this.Supprimer.TabIndex = 1;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // btnRoleEleve
            // 
            this.btnRoleEleve.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRoleEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleEleve.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleEleve.ForeColor = System.Drawing.Color.White;
            this.btnRoleEleve.Location = new System.Drawing.Point(583, 13);
            this.btnRoleEleve.Name = "btnRoleEleve";
            this.btnRoleEleve.Size = new System.Drawing.Size(167, 35);
            this.btnRoleEleve.TabIndex = 2;
            this.btnRoleEleve.Text = "Mettre role élève";
            this.btnRoleEleve.UseVisualStyleBackColor = true;
            this.btnRoleEleve.Click += new System.EventHandler(this.btnRoleEleve_Click);
            // 
            // btnRoleProf
            // 
            this.btnRoleProf.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRoleProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleProf.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleProf.ForeColor = System.Drawing.Color.White;
            this.btnRoleProf.Location = new System.Drawing.Point(286, 13);
            this.btnRoleProf.Name = "btnRoleProf";
            this.btnRoleProf.Size = new System.Drawing.Size(249, 35);
            this.btnRoleProf.TabIndex = 3;
            this.btnRoleProf.Text = "Mettre role professeur";
            this.btnRoleProf.UseVisualStyleBackColor = true;
            this.btnRoleProf.Click += new System.EventHandler(this.btnRoleProf_Click);
            // 
            // btnRoleAdmin
            // 
            this.btnRoleAdmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRoleAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleAdmin.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleAdmin.ForeColor = System.Drawing.Color.White;
            this.btnRoleAdmin.Location = new System.Drawing.Point(31, 13);
            this.btnRoleAdmin.Name = "btnRoleAdmin";
            this.btnRoleAdmin.Size = new System.Drawing.Size(202, 35);
            this.btnRoleAdmin.TabIndex = 4;
            this.btnRoleAdmin.Text = "Mettre role admin";
            this.btnRoleAdmin.UseVisualStyleBackColor = true;
            this.btnRoleAdmin.Click += new System.EventHandler(this.btnRoleAdmin_Click);
            // 
            // FormUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1049, 589);
            this.Controls.Add(this.btnRoleAdmin);
            this.Controls.Add(this.btnRoleProf);
            this.Controls.Add(this.btnRoleEleve);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.DataGridUtilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUtilisateurs";
            this.Text = "FormUtilisateurs";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUtilisateur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridUtilisateur;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button btnRoleEleve;
        private System.Windows.Forms.Button btnRoleProf;
        private System.Windows.Forms.Button btnRoleAdmin;
    }
}