
namespace BtsAssist.Fenetres
{
    partial class FormNotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridNotes = new System.Windows.Forms.DataGridView();
            this.SupprimerNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridNotes
            // 
            this.DataGridNotes.AllowUserToAddRows = false;
            this.DataGridNotes.AllowUserToDeleteRows = false;
            this.DataGridNotes.AllowUserToResizeColumns = false;
            this.DataGridNotes.AllowUserToResizeRows = false;
            this.DataGridNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridNotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            this.DataGridNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridNotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridNotes.EnableHeadersVisualStyles = false;
            this.DataGridNotes.Location = new System.Drawing.Point(12, 77);
            this.DataGridNotes.MultiSelect = false;
            this.DataGridNotes.Name = "DataGridNotes";
            this.DataGridNotes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridNotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridNotes.RowHeadersVisible = false;
            this.DataGridNotes.RowHeadersWidth = 51;
            this.DataGridNotes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridNotes.RowTemplate.Height = 24;
            this.DataGridNotes.ShowEditingIcon = false;
            this.DataGridNotes.Size = new System.Drawing.Size(1025, 473);
            this.DataGridNotes.TabIndex = 2;
            this.DataGridNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridNotes_CellClick);
            // 
            // SupprimerNote
            // 
            this.SupprimerNote.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SupprimerNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupprimerNote.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerNote.ForeColor = System.Drawing.Color.White;
            this.SupprimerNote.Location = new System.Drawing.Point(577, 12);
            this.SupprimerNote.Name = "SupprimerNote";
            this.SupprimerNote.Size = new System.Drawing.Size(307, 35);
            this.SupprimerNote.TabIndex = 5;
            this.SupprimerNote.Text = "Supprimer";
            this.SupprimerNote.UseVisualStyleBackColor = true;
            this.SupprimerNote.Click += new System.EventHandler(this.SupprimerNote_Click);
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1049, 589);
            this.Controls.Add(this.SupprimerNote);
            this.Controls.Add(this.DataGridNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNotes";
            this.Text = "FormNotes";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridNotes;
        private System.Windows.Forms.Button SupprimerNote;
    }
}