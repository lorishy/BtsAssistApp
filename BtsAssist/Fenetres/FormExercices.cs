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
    public partial class FormExercices : Form
    {
        int idExercice;
        public FormExercices()
        {
            InitializeComponent();
            DataGridExercice_Load();
            DataGridQuestion_Load();
            DataGridReponse_Load();
        }

        public void DataGridExercice_Load()
        {
            Exercice exercice = new Exercice();
            DataTable dt = new DataTable();
            exercice.recupererInfosExercice().Fill(dt);
            DataGridExercice.DataSource = dt;
            this.DataGridExercice.Sort(this.DataGridExercice.Columns["#"], ListSortDirection.Ascending);
        }

        public void DataGridQuestion_Load()
        {
            Question question = new Question();
            DataTable dt = new DataTable();
            question.recupererInfosQuestion().Fill(dt);
            DataGridQuestion.DataSource = dt;
            this.DataGridQuestion.Sort(this.DataGridQuestion.Columns["Exercice"], ListSortDirection.Ascending);
        }

        public void DataGridReponse_Load()
        {
            Reponse reponse = new Reponse();
            DataTable dt = new DataTable();
            reponse.recupererInfosReponse().Fill(dt);
            DataGridReponse.DataSource = dt;
        }

        private void DataGridExercice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridExercice.Rows[e.RowIndex].Cells[0].Value != null)
            {
                idExercice = Convert.ToInt32(DataGridExercice.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void SupprimerExercice_Click(object sender, EventArgs e)
        {
            Exercice exercice = new Exercice();
            Question question = new Question();
            Reponse reponse = new Reponse();
            Note note = new Note();

            List<int> resultIdQ = question.recuperationIdQuestionParExercice(idExercice);
            
            foreach (int idQ in resultIdQ)
            {
                reponse.DeleteReponse(idQ);
            }
            question.DeleteQuestion(idExercice);

            bool noteExistenote = note.NoteExercice(idExercice);
            if (noteExistenote == true)
            {
                note.DeleteNoteExercice(idExercice);
            }
            exercice.DeleteExercice(idExercice);

            DataGridExercice.DataSource = null;
            DataGridQuestion.DataSource = null;
            DataGridReponse.DataSource = null;
            DataGridExercice_Load();
            DataGridQuestion_Load();
            DataGridReponse_Load();

        }

    }
}
