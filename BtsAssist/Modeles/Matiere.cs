using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace BtsAssist.Modeles
{
    class Matiere : Modele
    {
        int idMatiereBts { get; set; }
        string libelle { get; set; }
        int idMatiere { get; set; }
        int idBts { get; set; }
        int idOption { get; set; }

        public MySqlDataAdapter recupererInfosMatiere()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT matieres_bts.id_matiere_bts as '#', matieres_bts.libelle as Matiere, bts.libelle as BTS, options.libelle as 'Option' FROM matieres_bts join bts on matieres_bts.id_bts = bts.id_bts left join options on options.id_option = matieres_bts.id_option", conn);
            MySqlDataAdapter result = new MySqlDataAdapter(command);
            conn.Close();
            return result;
        }
        public void DeleteMatiere(int idMatiere)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_matiere_bts", idMatiere);
            requete.CommandText = "DELETE FROM matieres_bts WHERE id_matiere_bts = @id_matiere_bts";
            requete.ExecuteNonQuery();
            conn.Close();
        }

        public void insertMatiere(int idBts, string titre, int idOption)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_bts", idBts);
            requete.Parameters.AddWithValue("@libelle", titre);
            requete.Parameters.AddWithValue("@id_option", idOption);
            requete.CommandText = "INSERT INTO matieres_bts (id_bts, libelle, id_option) VALUES (@id_bts, @libelle, @id_option)";
            requete.ExecuteNonQuery();
            conn.Close();
        }

    }
}
