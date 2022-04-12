using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BtsAssist.Modeles;
using BtsAssist.Fenetres;

namespace BtsAssist
{
    public partial class FormConnexion : Form 
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Connexion_Click(object sender, EventArgs e)
        {
            string email = EmailInput.Text;
            string mdp = MotdepasseInput.Text;

            if(email != "" && email != "Email")
            {
                if (mdp != "" && mdp != "Mot de passe")
                {
                    Utilisateur connect = new Utilisateur();
                        bool connected = connect.connexion(email, mdp);
                    if(connected == true)
                    {
                        Dashboard dashboard = new Dashboard();
                        this.Hide();
                        dashboard.Show();
                    } 
                } 
                else
                {
                    MessageBox.Show("Saisissez votre mot de passe");
                }
            }
            else
            {
                MessageBox.Show("Saisissez votre Email");
            }

            
        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmailInput_Enter(object sender, EventArgs e)
        {
            if (EmailInput.Text == "Email")
            {
                EmailInput.Text = "";
            }
        }

        private void EmailInput_Leave(object sender, EventArgs e)
        {
            if(EmailInput.Text == "") {
                EmailInput.Text = "Email";
            }
        }

        private void MotdepasseInput_Enter(object sender, EventArgs e)
        {
            if (MotdepasseInput.Text == "Mot de passe")
            {
                MotdepasseInput.Text = "";
                MotdepasseInput.UseSystemPasswordChar = true;
            }
        }

        private void MotdepasseInput_Leave(object sender, EventArgs e)
        {
            if (MotdepasseInput.Text == "")
            {
                MotdepasseInput.Text = "Mot de passe";
                MotdepasseInput.UseSystemPasswordChar = false; 
            }
        }
    }
}
