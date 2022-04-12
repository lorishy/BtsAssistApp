
namespace BtsAssist.Fenetres
{
    partial class FormBTS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridBTS = new System.Windows.Forms.DataGridView();
            this.SupprimerOption = new System.Windows.Forms.Button();
            this.AjoutOption = new System.Windows.Forms.Button();
            this.DataGridOptions = new System.Windows.Forms.DataGridView();
            this.TitleBTS = new System.Windows.Forms.Label();
            this.TitleOption = new System.Windows.Forms.Label();
            this.AjoutBTS = new System.Windows.Forms.Button();
            this.SupprimerBTS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridBTS
            // 
            this.DataGridBTS.AllowUserToAddRows = false;
            this.DataGridBTS.AllowUserToDeleteRows = false;
            this.DataGridBTS.AllowUserToResizeColumns = false;
            this.DataGridBTS.AllowUserToResizeRows = false;
            this.DataGridBTS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridBTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridBTS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.DataGridBTS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridBTS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBTS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridBTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBTS.EnableHeadersVisualStyles = false;
            this.DataGridBTS.Location = new System.Drawing.Point(12, 116);
            this.DataGridBTS.MultiSelect = false;
            this.DataGridBTS.Name = "DataGridBTS";
            this.DataGridBTS.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBTS.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridBTS.RowHeadersVisible = false;
            this.DataGridBTS.RowHeadersWidth = 51;
            this.DataGridBTS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridBTS.RowTemplate.Height = 24;
            this.DataGridBTS.ShowEditingIcon = false;
            this.DataGridBTS.Size = new System.Drawing.Size(480, 460);
            this.DataGridBTS.TabIndex = 1;
            this.DataGridBTS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridBTS_CellClick);
            // 
            // SupprimerOption
            // 
            this.SupprimerOption.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SupprimerOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupprimerOption.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerOption.ForeColor = System.Drawing.Color.White;
            this.SupprimerOption.Location = new System.Drawing.Point(870, 12);
            this.SupprimerOption.Name = "SupprimerOption";
            this.SupprimerOption.Size = new System.Drawing.Size(167, 35);
            this.SupprimerOption.TabIndex = 2;
            this.SupprimerOption.Text = "Supprimer";
            this.SupprimerOption.UseVisualStyleBackColor = true;
            this.SupprimerOption.Click += new System.EventHandler(this.SupprimerOption_Click);
            // 
            // AjoutOption
            // 
            this.AjoutOption.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AjoutOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjoutOption.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjoutOption.ForeColor = System.Drawing.Color.White;
            this.AjoutOption.Location = new System.Drawing.Point(557, 12);
            this.AjoutOption.Name = "AjoutOption";
            this.AjoutOption.Size = new System.Drawing.Size(167, 35);
            this.AjoutOption.TabIndex = 3;
            this.AjoutOption.Text = "Ajouter";
            this.AjoutOption.UseVisualStyleBackColor = true;
            this.AjoutOption.Click += new System.EventHandler(this.AjoutOption_Click);
            // 
            // DataGridOptions
            // 
            this.DataGridOptions.AllowUserToAddRows = false;
            this.DataGridOptions.AllowUserToDeleteRows = false;
            this.DataGridOptions.AllowUserToResizeColumns = false;
            this.DataGridOptions.AllowUserToResizeRows = false;
            this.DataGridOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridOptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridOptions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.DataGridOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridOptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridOptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridOptions.EnableHeadersVisualStyles = false;
            this.DataGridOptions.Location = new System.Drawing.Point(557, 117);
            this.DataGridOptions.MultiSelect = false;
            this.DataGridOptions.Name = "DataGridOptions";
            this.DataGridOptions.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridOptions.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridOptions.RowHeadersVisible = false;
            this.DataGridOptions.RowHeadersWidth = 51;
            this.DataGridOptions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridOptions.RowTemplate.Height = 24;
            this.DataGridOptions.ShowEditingIcon = false;
            this.DataGridOptions.Size = new System.Drawing.Size(480, 460);
            this.DataGridOptions.TabIndex = 4;
            this.DataGridOptions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridOptions_CellClick);
            // 
            // TitleBTS
            // 
            this.TitleBTS.AutoSize = true;
            this.TitleBTS.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBTS.ForeColor = System.Drawing.Color.White;
            this.TitleBTS.Location = new System.Drawing.Point(225, 77);
            this.TitleBTS.Name = "TitleBTS";
            this.TitleBTS.Size = new System.Drawing.Size(66, 36);
            this.TitleBTS.TabIndex = 5;
            this.TitleBTS.Text = "BTS  :";
            // 
            // TitleOption
            // 
            this.TitleOption.AutoSize = true;
            this.TitleOption.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleOption.ForeColor = System.Drawing.Color.White;
            this.TitleOption.Location = new System.Drawing.Point(743, 77);
            this.TitleOption.Name = "TitleOption";
            this.TitleOption.Size = new System.Drawing.Size(106, 36);
            this.TitleOption.TabIndex = 6;
            this.TitleOption.Text = "Options :";
            // 
            // AjoutBTS
            // 
            this.AjoutBTS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AjoutBTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjoutBTS.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjoutBTS.ForeColor = System.Drawing.Color.White;
            this.AjoutBTS.Location = new System.Drawing.Point(12, 12);
            this.AjoutBTS.Name = "AjoutBTS";
            this.AjoutBTS.Size = new System.Drawing.Size(167, 35);
            this.AjoutBTS.TabIndex = 7;
            this.AjoutBTS.Text = "Ajouter";
            this.AjoutBTS.UseVisualStyleBackColor = true;
            this.AjoutBTS.Click += new System.EventHandler(this.AjoutBTS_Click);
            // 
            // SupprimerBTS
            // 
            this.SupprimerBTS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SupprimerBTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupprimerBTS.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerBTS.ForeColor = System.Drawing.Color.White;
            this.SupprimerBTS.Location = new System.Drawing.Point(325, 12);
            this.SupprimerBTS.Name = "SupprimerBTS";
            this.SupprimerBTS.Size = new System.Drawing.Size(167, 35);
            this.SupprimerBTS.TabIndex = 8;
            this.SupprimerBTS.Text = "Supprimer";
            this.SupprimerBTS.UseVisualStyleBackColor = true;
            this.SupprimerBTS.Click += new System.EventHandler(this.SupprimerBTS_Click);
            // 
            // FormBTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1049, 589);
            this.Controls.Add(this.SupprimerBTS);
            this.Controls.Add(this.AjoutBTS);
            this.Controls.Add(this.TitleOption);
            this.Controls.Add(this.TitleBTS);
            this.Controls.Add(this.DataGridOptions);
            this.Controls.Add(this.AjoutOption);
            this.Controls.Add(this.SupprimerOption);
            this.Controls.Add(this.DataGridBTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBTS";
            this.Text = "FormBTS";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridBTS;
        private System.Windows.Forms.Button SupprimerOption;
        private System.Windows.Forms.Button AjoutOption;
        private System.Windows.Forms.DataGridView DataGridOptions;
        private System.Windows.Forms.Label TitleBTS;
        private System.Windows.Forms.Label TitleOption;
        private System.Windows.Forms.Button AjoutBTS;
        private System.Windows.Forms.Button SupprimerBTS;
    }
}