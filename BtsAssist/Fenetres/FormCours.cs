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
    public partial class FormCours : Form
    {
        int idCours;
        public FormCours()
        {
            InitializeComponent();
            DataGridCours_Load();
        }

        public void DataGridCours_Load()
        {
            Cours cours = new Cours();
            DataTable dt = new DataTable();
            cours.recupererInfosCours().Fill(dt);
            DataGridCours.DataSource = dt;
            this.DataGridCours.Sort(this.DataGridCours.Columns["Matiere"], ListSortDirection.Ascending);
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            Cours cours = new Cours();
            Exercice exercice = new Exercice();
            Question question = new Question();
            Reponse reponse = new Reponse();
            Note note = new Note();

            bool exericeExiste = exercice.ExerciceCours(idCours);

            if(exericeExiste == true)
            {
                List<int> resultIdEx = exercice.recuperationIdExerciceParCours(idCours);

                foreach (int idEx in resultIdEx)
                {
                    List<int> resultIdQ = question.recuperationIdQuestionParExercice(idEx);

                    foreach (int idQ in resultIdQ)
                    {
                        reponse.DeleteReponse(idQ);
                    }
                    question.DeleteQuestion(idEx);

                    bool noteExistenote = note.NoteExercice(idEx);
                    if (noteExistenote == true)
                    {
                        note.DeleteNoteExercice(idEx);
                    }
                    exercice.DeleteExercice(idEx);
                }
                cours.DeleteCours(idCours);

            } else
            {
                cours.DeleteCours(idCours);
            }
            DataGridCours.DataSource = null;
            DataGridCours_Load();
        }

        private void DataGridCours_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridCours.Rows[e.RowIndex].Cells[0].Value != null)
            {
                idCours = Convert.ToInt32(DataGridCours.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}
