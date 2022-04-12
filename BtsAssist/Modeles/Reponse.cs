using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BtsAssist.Modeles
{
    class Reponse : Modele
    {
        int idReponse { get; set; }
        string reponse { get; set; }
        int statut { get; set; }
        int idQuestion { get; set; }

        public MySqlDataAdapter recupererInfosReponse()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT reponses.id_reponse as '#', reponses.reponse as Reponse, CASE WHEN reponses.statut = 1 THEN 'Bonne reponse' ELSE 'Mauvaise reponse' END as Statut, questions.question as Question FROM reponses join questions on reponses.id_question = questions.id_question order by questions.id_question, reponses.statut desc", conn);
            MySqlDataAdapter result = new MySqlDataAdapter(command);
            conn.Close();
            return result;
        }

        public List<int> recuperationIdReponseParQuestion(int idQuestion)
        {
            List<int> listIdReponse = new List<int>();

            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_question", idQuestion);
            requete.CommandText = "SELECT id_reponse FROM reponse WHERE id_question = @id_question";
            MySqlDataReader reader = requete.ExecuteReader();


            while (reader.Read())
            {
                listIdReponse.Add(reader.GetInt32(0));
            }
            conn.Close();
            return listIdReponse;
        }

        public void DeleteReponse(int idQuestion)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_question", idQuestion);
            requete.CommandText = "DELETE FROM reponses WHERE id_question = @id_question";
            requete.ExecuteNonQuery();
            conn.Close();
        }
    }
}
