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
    public partial class FormAjoutOption : Form
    {
        public FormAjoutOption()
        {
            InitializeComponent();
            ListeBTS_Load();
        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ListeBTS_Load()
        {
            BTS bts = new BTS();
            DataTable dt = new DataTable();
            bts.recupererInfosBTS().Fill(dt);
            ListeBts.DataSource = dt;
            ListeBts.ValueMember = "#";
            ListeBts.DisplayMember = "Nom du BTS";
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string libelle = titreOption.Text;

            if (!string.IsNullOrEmpty(libelle))
            {
                int idBts = Convert.ToInt32(ListeBts.SelectedValue);
                Option option = new Option();
                option.insertOption(libelle, idBts);
                MessageBox.Show("Option bien ajoutée !");
            }
            else
            {
                MessageBox.Show("Veuillez saisir le titre de l'option");
            }
        }
    }
}
