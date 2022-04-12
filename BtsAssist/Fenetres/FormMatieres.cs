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
    public partial class FormMatieres : Form
    {
        int idMatiere;
        public FormMatieres()
        {
            InitializeComponent();
            DataGridMatiere_Load();
        }

        public void DataGridMatiere_Load()
        {
            Matiere matiere = new Matiere();
            DataTable dt = new DataTable();
            matiere.recupererInfosMatiere().Fill(dt);
            DataGridMatiere.DataSource = dt;
            this.DataGridMatiere.Sort(this.DataGridMatiere.Columns["BTS"], ListSortDirection.Ascending);
        }
        private void DataGridMatiere_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridMatiere.Rows[e.RowIndex].Cells[0].Value != null)
            {
                idMatiere = Convert.ToInt32(DataGridMatiere.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            Matiere matiere = new Matiere();
            Cours cours = new Cours();
            Exercice exercice = new Exercice();
            Question question = new Question();
            Reponse reponse = new Reponse();
            Note note = new Note();

            bool coursExiste = cours.CoursMatiere(idMatiere);

            if (coursExiste == true)
            {
                List<int> resultIdCours = cours.recuperationIdCoursParMatiere(idMatiere);

                foreach (int idC in resultIdCours)
                {
                    bool exericeExiste = exercice.ExerciceCours(idC);

                    if (exericeExiste == true)
                    {
                        List<int> resultIdEx = exercice.recuperationIdExerciceParCours(idC);

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
                        cours.DeleteCours(idC);

                    }
                    else
                    {
                        cours.DeleteCours(idC);
                    }
                    
                }
                matiere.DeleteMatiere(idMatiere);

            }else
            {
                matiere.DeleteMatiere(idMatiere);
            }
            DataGridMatiere.DataSource = null;
            DataGridMatiere_Load();
        }

        private void AjoutMatiere_Click(object sender, EventArgs e)
        {
            FormAjoutMatiere addMatiere = new FormAjoutMatiere();
            addMatiere.Show();
        }
    }
}
