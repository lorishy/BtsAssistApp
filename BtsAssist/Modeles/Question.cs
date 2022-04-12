using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BtsAssist.Modeles
{
    class Question : Modele
    {
        int idQuestion { get; set; }
        string question { get; set; }
        int idExercice { get; set; }

        public MySqlDataAdapter recupererInfosQuestion()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT questions.id_question as '#', questions.question as Question, exercices.titre as Exercice FROM questions join exercices on questions.id_exercice = exercices.id_exercice", conn);
            MySqlDataAdapter result = new MySqlDataAdapter(command);
            conn.Close();
            return result;
        }

        public List<int> recuperationIdQuestionParExercice(int idExercice)
        {
            List<int> listIdQuestion = new List<int>();

            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_exercice", idExercice);
            requete.CommandText = "SELECT id_question FROM questions WHERE id_exercice = @id_exercice";
            MySqlDataReader reader = requete.ExecuteReader();


            while (reader.Read())
            {
                listIdQuestion.Add(reader.GetInt32(0));
            }
            conn.Close();
            return listIdQuestion;
        }

        public void DeleteQuestion(int idExercice)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_exercice", idExercice);
            requete.CommandText = "DELETE FROM questions WHERE id_exercice = @id_exercice";
            requete.ExecuteNonQuery();
            conn.Close();
        }

    }
}
