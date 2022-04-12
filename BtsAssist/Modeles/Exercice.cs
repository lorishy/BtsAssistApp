using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BtsAssist.Modeles
{
    class Exercice : Modele
    {
        int idExercice { get; set; }
        string titre { get; set; }
        int idCours { get; set; }

        public MySqlDataAdapter recupererInfosExercice()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT exercices.id_exercice as '#', exercices.titre as Titre, cours.titre as Cours FROM exercices join cours where exercices.id_cours = cours.id_cours", conn);
            MySqlDataAdapter result = new MySqlDataAdapter(command);
            conn.Close();
            return result;
        }

        public void DeleteExercice(int idExercice)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_exercice", idExercice);
            requete.CommandText = "DELETE FROM exercices WHERE id_exercice = @id_exercice";
            requete.ExecuteNonQuery();
            conn.Close();
        }
        public bool ExerciceCours(int idCours)
        {
            bool exerciceExiste;

            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_cours", idCours);
            requete.CommandText = "SELECT COUNT(id_exercice) FROM exercices WHERE id_cours = @id_cours";
            int resultat = Convert.ToInt32(requete.ExecuteScalar());

            if (resultat > 0)
            {
                exerciceExiste = true;
            }
            else
            {
                exerciceExiste = false;
            }
            conn.Close();
            return exerciceExiste;
        }
        public List<int> recuperationIdExerciceParCours(int idCours)
        {
            List<int> listIdExercice = new List<int>();

            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_cours", idCours);
            requete.CommandText = "SELECT id_exercice FROM exercices WHERE id_cours = @id_cours";
            MySqlDataReader reader = requete.ExecuteReader();


            while (reader.Read())
            {
                listIdExercice.Add(reader.GetInt32(0));
            }
            conn.Close();
            return listIdExercice;
        }
    }
}
