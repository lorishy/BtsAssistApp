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
    public partial class FormUtilisateurs : Form
    {
        int idUtilisateur = 0;
        public FormUtilisateurs()
        {
            InitializeComponent();
            DataGridUtilisateur_Load();
        }

        public void DataGridUtilisateur_Load()
        {
            Utilisateur user = new Utilisateur();
            DataTable dt = new DataTable();
            user.recupererInfosUtilisateur().Fill(dt);
            DataGridUtilisateur.DataSource = dt;
            this.DataGridUtilisateur.Sort(this.DataGridUtilisateur.Columns["#"], ListSortDirection.Ascending);
        }

        private void DataGridUtilisateur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridUtilisateur.Rows[e.RowIndex].Cells[0].Value != null)
            {
                idUtilisateur = Convert.ToInt32(DataGridUtilisateur.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {  
            Utilisateur user = new Utilisateur();
            user.DeleteUtilisateur(idUtilisateur);
            DataGridUtilisateur.DataSource = null;
            DataGridUtilisateur_Load();
        }

        private void btnRoleEleve_Click(object sender, EventArgs e)
        {
            Utilisateur user = new Utilisateur();
            user.editRoleEleve(idUtilisateur);
            DataGridUtilisateur.DataSource = null;
            DataGridUtilisateur_Load();
        }

        private void btnRoleProf_Click(object sender, EventArgs e)
        {
            Utilisateur user = new Utilisateur();
            user.editRoleProf(idUtilisateur);
            DataGridUtilisateur.DataSource = null;
            DataGridUtilisateur_Load();
        }

        private void btnRoleAdmin_Click(object sender, EventArgs e)
        {
            Utilisateur user = new Utilisateur();
            user.editRoleAdmin(idUtilisateur);
            DataGridUtilisateur.DataSource = null;
            DataGridUtilisateur_Load();
        }
    }
}
