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
    public partial class FormAjoutBTS : Form
    {
        public FormAjoutBTS()
        {
            InitializeComponent();
        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string libelle = titreBTS.Text;
            if (!string.IsNullOrEmpty(libelle))
            {
                BTS bts = new BTS();
                bts.insertBTS(libelle);
                MessageBox.Show("Bts bien ajouté !");
            }else
            {
                MessageBox.Show("Veuillez saisir le nom d'un BTS !");
            }
        }
    }
}
