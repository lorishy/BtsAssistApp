using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BtsAssist.Modeles
{
    class BTS : Modele
    {
        public int idBTS { get; set; }
        public string libelle { get; set; }

        public MySqlDataAdapter recupererInfosBTS()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT id_bts as '#', libelle as 'Nom du BTS' FROM bts", conn);
            MySqlDataAdapter result = new MySqlDataAdapter(command);
            conn.Close();
            return result;
        }

        public void DeleteBTS(int idBTS)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_bts", idBTS);
            requete.CommandText = "DELETE FROM bts WHERE id_bts = @id_bts";
            requete.ExecuteNonQuery();
            conn.Close();
        }
        public void insertBTS(string libelle)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@libelle", libelle);
            requete.CommandText = "INSERT INTO bts (libelle) VALUES (@libelle)";
            requete.ExecuteNonQuery();
            conn.Close();
        }
    }
}
