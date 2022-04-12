using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BtsAssist.Modeles
{
    class Cours : Modele
    {
        int idCours { get; set; }
        string titre { get; set; }
        string contenu { get; set; }
        int idMatiere { get; set; }

        public MySqlDataAdapter recupererInfosCours()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT cours.id_cours as '#', cours.titre as Titre, cours.contenu as Contenu, matieres_bts.libelle as Matiere FROM cours join matieres_bts on matieres_bts.id_matiere_bts = cours.id_matiere_bts", conn);
            MySqlDataAdapter result = new MySqlDataAdapter(command);
            conn.Close();
            return result;
        }

        public void DeleteCours(int idCours)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_cours", idCours);
            requete.CommandText = "DELETE FROM cours WHERE id_cours = @id_cours";
            requete.ExecuteNonQuery();
            conn.Close();
        }
        public bool CoursMatiere(int idMatiere)
        {
            bool CoursExiste;

            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_matiere_bts", idMatiere);
            requete.CommandText = "SELECT COUNT(id_cours) FROM cours WHERE id_matiere_bts = @id_matiere_bts";
            int resultat = Convert.ToInt32(requete.ExecuteScalar());

            if (resultat > 0)
            {
                CoursExiste = true;
            }
            else
            {
                CoursExiste = false;
            }
            conn.Close();
            return CoursExiste;
        }

        public List<int> recuperationIdCoursParMatiere(int idMatiere)
        {
            List<int> listIdCours = new List<int>();

            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_cours", idCours);
            requete.CommandText = "SELECT id_cours FROM cours WHERE id_matiere_bts = @id_matiere_bts";
            MySqlDataReader reader = requete.ExecuteReader();


            while (reader.Read())
            {
                listIdCours.Add(reader.GetInt32(0));
            }
            conn.Close();
            return listIdCours;
        }
    }
}
