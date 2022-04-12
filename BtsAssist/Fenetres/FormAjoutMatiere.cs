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
    public partial class FormAjoutMatiere : Form
    {
        public FormAjoutMatiere()
        {
            InitializeComponent();
            ListeBTS_Load();
            ListeOption_Load();

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
        private void ListeOption_Load()
        {
            Option option = new Option();
            DataTable dt = new DataTable();
            option.recupererInfosOptions().Fill(dt);
            ListeOption.DataSource = dt;
            ListeOption.ValueMember = "#";
            ListeOption.DisplayMember = "Nom option";
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Matiere matiere = new Matiere();

            string Titre = titreMatiere.Text;
            int? idOption = null;


            if (!string.IsNullOrEmpty(Titre))
            {
                int idBts = Convert.ToInt32(ListeBts.SelectedValue);

                if (Convert.ToString(ListeOption.SelectedValue) != "")
                {
                    idOption = Convert.ToInt32(ListeOption.SelectedValue);
                }
                matiere.insertMatiere(idBts, Titre, Convert.ToInt32(idOption));
                MessageBox.Show("Matière ajoutée !");
            } else
            {
                MessageBox.Show("Veuillez saisir le titre de la matière");
            }
        }
    }
}
