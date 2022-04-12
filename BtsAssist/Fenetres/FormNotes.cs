using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BtsAssist.Modeles;

namespace BtsAssist.Fenetres
{
    public partial class FormNotes : Form
    {
        int idNote;
        public FormNotes()
        {
            InitializeComponent();
            DataGridNotes_Load();
        }

        public void DataGridNotes_Load()
        {
            Note notes = new Note();
            DataTable dt = new DataTable();
            notes.recupererInfosNotes().Fill(dt);
            DataGridNotes.DataSource = dt;
        }

        private void DataGridNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridNotes.Rows[e.RowIndex].Cells[0].Value != null)
            {
                idNote = Convert.ToInt32(DataGridNotes.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void SupprimerNote_Click(object sender, EventArgs e)
        {
            Note notes = new Note();
            notes.DeleteNote(idNote);
            DataGridNotes.DataSource = null;
            DataGridNotes_Load();
        }
    }
}
