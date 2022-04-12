using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BtsAssist.Fenetres
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            pnlNav.Height = BtnGestionUtilisateurs.Height;
            pnlNav.Top = BtnGestionUtilisateurs.Top;
            pnlNav.Left = BtnGestionUtilisateurs.Left;
            BtnGestionUtilisateurs.BackColor = Color.FromArgb(0, 5, 46);

            TitlePanel.Text = "Gestion des utilisateurs";
            this.PnlFormLoader.Controls.Clear();
            FormUtilisateurs frmUtilisateurs = new FormUtilisateurs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.PnlFormLoader.Controls.Add(frmUtilisateurs);
            frmUtilisateurs.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void BtnGestionUtilisateurs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnGestionUtilisateurs.Height;
            pnlNav.Top = BtnGestionUtilisateurs.Top;
            pnlNav.Left = BtnGestionUtilisateurs.Left;
            BtnGestionUtilisateurs.BackColor = Color.FromArgb(0, 5, 46);

            TitlePanel.Text = "Gestion des utilisateurs";
            this.PnlFormLoader.Controls.Clear();
            FormUtilisateurs frmUtilisateurs = new FormUtilisateurs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.PnlFormLoader.Controls.Add(frmUtilisateurs);
            frmUtilisateurs.Show();
        }

        private void BtnGestionFilActualite_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnGestionFilActualite.Height;
            pnlNav.Top = BtnGestionFilActualite.Top;
            pnlNav.Left = BtnGestionFilActualite.Left;
            BtnGestionFilActualite.BackColor = Color.FromArgb(0, 5, 46);

            TitlePanel.Text = "Gestion du fil d'actualité";
            this.PnlFormLoader.Controls.Clear();
            FormFilActualite frmFilActualite = new FormFilActualite() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.PnlFormLoader.Controls.Add(frmFilActualite);
            frmFilActualite.Show();
        }

        private void BtnGestionCours_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnGestionCours.Height;
            pnlNav.Top = BtnGestionCours.Top;
            pnlNav.Left = BtnGestionCours.Left;
            BtnGestionCours.BackColor = Color.FromArgb(0, 5, 46);

            TitlePanel.Text = "Gestion des cours";
            this.PnlFormLoader.Controls.Clear();
            FormCours frmCours = new FormCours() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.PnlFormLoader.Controls.Add(frmCours);
            frmCours.Show();
        }

        private void BtnGestionExercices_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnGestionExercices.Height;
            pnlNav.Top = BtnGestionExercices.Top;
            pnlNav.Left = BtnGestionExercices.Left;
            BtnGestionExercices.BackColor = Color.FromArgb(0, 5, 46);

            TitlePanel.Text = "Gestion des exercices";
            this.PnlFormLoader.Controls.Clear();
            FormExercices frmExercices = new FormExercices() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.PnlFormLoader.Controls.Add(frmExercices);
            frmExercices.Show();
        }

        private void BtnGestionBTS_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnGestionBTS.Height;
            pnlNav.Top = BtnGestionBTS.Top;
            pnlNav.Left = BtnGestionBTS.Left;
            BtnGestionBTS.BackColor = Color.FromArgb(0, 5, 46);

            TitlePanel.Text = "Gestion des BTS";
            this.PnlFormLoader.Controls.Clear();
            FormBTS frmBts = new FormBTS() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.PnlFormLoader.Controls.Add(frmBts);
            frmBts.Show();
        }

        private void BtnGestionMatieres_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnGestionMatieres.Height;
            pnlNav.Top = BtnGestionMatieres.Top;
            pnlNav.Left = BtnGestionMatieres.Left;
            BtnGestionMatieres.BackColor = Color.FromArgb(0, 5, 46);

            TitlePanel.Text = "Gestion des matières";
            this.PnlFormLoader.Controls.Clear();
            FormMatieres frmMatieres = new FormMatieres() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.PnlFormLoader.Controls.Add(frmMatieres);
            frmMatieres.Show();
        }
        private void BtnGestionNotes_Click(object sender, EventArgs e)
        {
            pnlNav.Height = BtnGestionNotes.Height;
            pnlNav.Top = BtnGestionNotes.Top;
            pnlNav.Left = BtnGestionNotes.Left;
            BtnGestionNotes.BackColor = Color.FromArgb(0, 5, 46);

            TitlePanel.Text = "Gestion des notes";
            this.PnlFormLoader.Controls.Clear();
            FormNotes frmNotes = new FormNotes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.PnlFormLoader.Controls.Add(frmNotes);
            frmNotes.Show();
        }

        private void BtnGestionUtilisateurs_Leave(object sender, EventArgs e)
        {
            BtnGestionUtilisateurs.BackColor = Color.FromArgb(0, 5, 85);
        }

        private void BtnGestionFilActualite_Leave(object sender, EventArgs e)
        {
            BtnGestionFilActualite.BackColor = Color.FromArgb(0, 5, 85);
        }

        private void BtnGestionCours_Leave(object sender, EventArgs e)
        {
            BtnGestionCours.BackColor = Color.FromArgb(0, 5, 85);
        }

        private void BtnGestionExercices_Leave(object sender, EventArgs e)
        {
            BtnGestionExercices.BackColor = Color.FromArgb(0, 5, 85);
        }

        private void BtnGestionBTS_Leave(object sender, EventArgs e)
        {
            BtnGestionBTS.BackColor = Color.FromArgb(0, 5, 85);
        }

        private void BtnGestionMatieres_Leave(object sender, EventArgs e)
        {
            BtnGestionMatieres.BackColor = Color.FromArgb(0, 5, 85);
        }
        private void BtnGestionNotes_Leave(object sender, EventArgs e)
        {
            BtnGestionNotes.BackColor = Color.FromArgb(0, 5, 85);
        }

        private void BtnDeconnexion_Click(object sender, EventArgs e)
        {
            FormConnexion formConnexion = new FormConnexion();
            this.Hide();
            formConnexion.Show();
        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
