
namespace BtsAssist.Fenetres
{
    partial class FormFilActualite
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridArticles = new System.Windows.Forms.DataGridView();
            this.DataGridCommentaires = new System.Windows.Forms.DataGridView();
            this.SupprimerArticle = new System.Windows.Forms.Button();
            this.SupprimerCommentaire = new System.Windows.Forms.Button();
            this.TitleArticle = new System.Windows.Forms.Label();
            this.TitleCommentaire = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCommentaires)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridArticles
            // 
            this.DataGridArticles.AllowUserToAddRows = false;
            this.DataGridArticles.AllowUserToDeleteRows = false;
            this.DataGridArticles.AllowUserToResizeColumns = false;
            this.DataGridArticles.AllowUserToResizeRows = false;
            this.DataGridArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridArticles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.DataGridArticles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridArticles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridArticles.EnableHeadersVisualStyles = false;
            this.DataGridArticles.Location = new System.Drawing.Point(12, 117);
            this.DataGridArticles.MultiSelect = false;
            this.DataGridArticles.Name = "DataGridArticles";
            this.DataGridArticles.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridArticles.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridArticles.RowHeadersVisible = false;
            this.DataGridArticles.RowHeadersWidth = 51;
            this.DataGridArticles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridArticles.RowTemplate.Height = 24;
            this.DataGridArticles.ShowEditingIcon = false;
            this.DataGridArticles.Size = new System.Drawing.Size(480, 460);
            this.DataGridArticles.TabIndex = 2;
            this.DataGridArticles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridArticles_CellClick);
            // 
            // DataGridCommentaires
            // 
            this.DataGridCommentaires.AllowUserToAddRows = false;
            this.DataGridCommentaires.AllowUserToDeleteRows = false;
            this.DataGridCommentaires.AllowUserToResizeColumns = false;
            this.DataGridCommentaires.AllowUserToResizeRows = false;
            this.DataGridCommentaires.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridCommentaires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridCommentaires.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.DataGridCommentaires.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridCommentaires.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCommentaires.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridCommentaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCommentaires.EnableHeadersVisualStyles = false;
            this.DataGridCommentaires.Location = new System.Drawing.Point(557, 117);
            this.DataGridCommentaires.MultiSelect = false;
            this.DataGridCommentaires.Name = "DataGridCommentaires";
            this.DataGridCommentaires.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCommentaires.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridCommentaires.RowHeadersVisible = false;
            this.DataGridCommentaires.RowHeadersWidth = 51;
            this.DataGridCommentaires.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridCommentaires.RowTemplate.Height = 24;
            this.DataGridCommentaires.ShowEditingIcon = false;
            this.DataGridCommentaires.Size = new System.Drawing.Size(480, 460);
            this.DataGridCommentaires.TabIndex = 3;
            this.DataGridCommentaires.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCommentaires_CellClick);
            // 
            // SupprimerArticle
            // 
            this.SupprimerArticle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SupprimerArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupprimerArticle.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerArticle.ForeColor = System.Drawing.Color.White;
            this.SupprimerArticle.Location = new System.Drawing.Point(12, 76);
            this.SupprimerArticle.Name = "SupprimerArticle";
            this.SupprimerArticle.Size = new System.Drawing.Size(480, 35);
            this.SupprimerArticle.TabIndex = 9;
            this.SupprimerArticle.Text = "Supprimer l\'article";
            this.SupprimerArticle.UseVisualStyleBackColor = true;
            this.SupprimerArticle.Click += new System.EventHandler(this.SupprimerArticle_Click);
            // 
            // SupprimerCommentaire
            // 
            this.SupprimerCommentaire.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SupprimerCommentaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupprimerCommentaire.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerCommentaire.ForeColor = System.Drawing.Color.White;
            this.SupprimerCommentaire.Location = new System.Drawing.Point(557, 76);
            this.SupprimerCommentaire.Name = "SupprimerCommentaire";
            this.SupprimerCommentaire.Size = new System.Drawing.Size(480, 35);
            this.SupprimerCommentaire.TabIndex = 10;
            this.SupprimerCommentaire.Text = "Supprimer le commentaire";
            this.SupprimerCommentaire.UseVisualStyleBackColor = true;
            this.SupprimerCommentaire.Click += new System.EventHandler(this.SupprimerCommentaire_Click);
            // 
            // TitleArticle
            // 
            this.TitleArticle.AutoSize = true;
            this.TitleArticle.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleArticle.ForeColor = System.Drawing.Color.White;
            this.TitleArticle.Location = new System.Drawing.Point(198, 20);
            this.TitleArticle.Name = "TitleArticle";
            this.TitleArticle.Size = new System.Drawing.Size(108, 36);
            this.TitleArticle.TabIndex = 11;
            this.TitleArticle.Text = "Articles  :";
            // 
            // TitleCommentaire
            // 
            this.TitleCommentaire.AutoSize = true;
            this.TitleCommentaire.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleCommentaire.ForeColor = System.Drawing.Color.White;
            this.TitleCommentaire.Location = new System.Drawing.Point(707, 20);
            this.TitleCommentaire.Name = "TitleCommentaire";
            this.TitleCommentaire.Size = new System.Drawing.Size(184, 36);
            this.TitleCommentaire.TabIndex = 12;
            this.TitleCommentaire.Text = "Commentaires  :";
            // 
            // FormFilActualite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1049, 589);
            this.Controls.Add(this.TitleCommentaire);
            this.Controls.Add(this.TitleArticle);
            this.Controls.Add(this.SupprimerCommentaire);
            this.Controls.Add(this.SupprimerArticle);
            this.Controls.Add(this.DataGridCommentaires);
            this.Controls.Add(this.DataGridArticles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFilActualite";
            this.Text = "FormFilActualite";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCommentaires)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridArticles;
        private System.Windows.Forms.DataGridView DataGridCommentaires;
        private System.Windows.Forms.Button SupprimerArticle;
        private System.Windows.Forms.Button SupprimerCommentaire;
        private System.Windows.Forms.Label TitleArticle;
        private System.Windows.Forms.Label TitleCommentaire;
    }
}