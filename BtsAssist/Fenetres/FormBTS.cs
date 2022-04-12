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
    public partial class FormBTS : Form
    {
        int idOption = 0;
        int idBTS = 0;
        public FormBTS()
        {
            InitializeComponent();
            DataGridBTS_Load();
            DataGridOptions_Load();
        }

        public void DataGridBTS_Load()
        {
            BTS bts = new BTS();
            DataTable dt = new DataTable();
            bts.recupererInfosBTS().Fill(dt);
            DataGridBTS.DataSource = dt;
            this.DataGridBTS.Sort(this.DataGridBTS.Columns["#"], ListSortDirection.Ascending);
        }

        public void DataGridOptions_Load()
        {
            Option option = new Option();
            DataTable dt = new DataTable();
            option.recupererInfosOptions().Fill(dt);
            DataGridOptions.DataSource = dt;
            this.DataGridOptions.Sort(this.DataGridOptions.Columns["#"], ListSortDirection.Ascending);
        }

        private void DataGridBTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DataGridBTS.Rows[e.RowIndex].Cells[0].Value != null)
            {
                idBTS = Convert.ToInt32(DataGridBTS.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void SupprimerBTS_Click(object sender, EventArgs e)
        {
            BTS bts = new BTS();
            bts.DeleteBTS(idBTS);
            DataGridBTS.DataSource = null;
            DataGridBTS_Load();
        }

        private void DataGridOptions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridOptions.Rows[e.RowIndex].Cells[0].Value != null)
            {
                idOption = Convert.ToInt32(DataGridOptions.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void SupprimerOption_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            option.DeleteOption(idOption);
            DataGridOptions.DataSource = null;
            DataGridOptions_Load();
        }

        private void AjoutBTS_Click(object sender, EventArgs e)
        {
            FormAjoutBTS formAjoutBTS = new FormAjoutBTS();
            formAjoutBTS.Show();
        }

        private void AjoutOption_Click(object sender, EventArgs e)
        {
            FormAjoutOption formAjoutOption = new FormAjoutOption();
            formAjoutOption.Show();
        }
    }
}
