
namespace BtsAssist.Fenetres
{
    partial class FormMatieres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridMatiere = new System.Windows.Forms.DataGridView();
            this.Supprimer = new System.Windows.Forms.Button();
            this.AjoutMatiere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMatiere)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridMatiere
            // 
            this.DataGridMatiere.AllowUserToAddRows = false;
            this.DataGridMatiere.AllowUserToDeleteRows = false;
            this.DataGridMatiere.AllowUserToResizeColumns = false;
            this.DataGridMatiere.AllowUserToResizeRows = false;
            this.DataGridMatiere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridMatiere.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridMatiere.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.DataGridMatiere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridMatiere.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridMatiere.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridMatiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMatiere.EnableHeadersVisualStyles = false;
            this.DataGridMatiere.Location = new System.Drawing.Point(12, 77);
            this.DataGridMatiere.MultiSelect = false;
            this.DataGridMatiere.Name = "DataGridMatiere";
            this.DataGridMatiere.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridMatiere.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridMatiere.RowHeadersVisible = false;
            this.DataGridMatiere.RowHeadersWidth = 51;
            this.DataGridMatiere.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridMatiere.RowTemplate.Height = 24;
            this.DataGridMatiere.ShowEditingIcon = false;
            this.DataGridMatiere.Size = new System.Drawing.Size(1025, 473);
            this.DataGridMatiere.TabIndex = 2;
            this.DataGridMatiere.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMatiere_CellClick);
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
            this.Supprimer.TabIndex = 5;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // AjoutMatiere
            // 
            this.AjoutMatiere.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AjoutMatiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjoutMatiere.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjoutMatiere.ForeColor = System.Drawing.Color.White;
            this.AjoutMatiere.Location = new System.Drawing.Point(583, 13);
            this.AjoutMatiere.Name = "AjoutMatiere";
            this.AjoutMatiere.Size = new System.Drawing.Size(167, 35);
            this.AjoutMatiere.TabIndex = 6;
            this.AjoutMatiere.Text = "Ajouter";
            this.AjoutMatiere.UseVisualStyleBackColor = true;
            this.AjoutMatiere.Click += new System.EventHandler(this.AjoutMatiere_Click);
            // 
            // FormMatieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1049, 589);
            this.Controls.Add(this.AjoutMatiere);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.DataGridMatiere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMatieres";
            this.Text = "FormMatieres";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMatiere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridMatiere;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button AjoutMatiere;
    }
}