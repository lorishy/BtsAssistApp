using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BtsAssist.Modeles
{
    class Option : Modele
    {
        public int idOption { get; set; }
        public string libelle { get; set; }
        public int idBts { get; set; }

        public MySqlDataAdapter recupererInfosOptions()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT options.id_option as '#', options.libelle as 'Nom option', bts.libelle as 'Nom du BTS' from options inner join bts on options.id_bts = bts.id_bts", conn);
            MySqlDataAdapter result = new MySqlDataAdapter(command);
            conn.Close();
            return result;
        }

        public void DeleteOption(int idOption)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_option", idOption);
            requete.CommandText = "DELETE FROM options WHERE id_option = @id_option";
            requete.ExecuteNonQuery();
            conn.Close();
        }
        public void insertOption(string libelle, int idBts)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@libelle", libelle);
            requete.Parameters.AddWithValue("@idBts", idBts);
            requete.CommandText = "INSERT INTO options (libelle, id_bts) VALUES (@libelle, @idBts)";
            requete.ExecuteNonQuery();
            conn.Close();
        }
    }
}
