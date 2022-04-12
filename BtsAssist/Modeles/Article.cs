using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BtsAssist.Modeles
{
    class Article : Modele
    {
        int idArticle { get; set; }
        string titre { get; set; }
        string contenu { get; set; }
        DateTime dateCreation { get; set; }
        int idUtilisateur { get; set; }
        string imageArticle { get; set; }

        public MySqlDataAdapter recupererInfosArticles()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT id_article as '#', titre as Titre, contenu as Contenu, date_creation as 'Date creation', id_utilisateur as Utilisateur FROM articles", conn);
            MySqlDataAdapter result = new MySqlDataAdapter(command);
            conn.Close();
            return result;
        }
        
        public void DeleteArticle(int idArticle)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_article", idArticle);
            requete.CommandText = "DELETE FROM articles WHERE id_article = @id_article";
            requete.ExecuteNonQuery();
            conn.Close();
        }
    }

}
