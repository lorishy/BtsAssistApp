using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BtsAssist.Modeles
{
    class Commentaire : Modele
    {
        int idCommentaire { get; set; }
        string contenu { get; set; }
        int idUtilisateur { get; set; }
        DateTime dateCreation { get; set; }
        int idArticle { get; set; }

        public MySqlDataAdapter recupererInfosCommentaires()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT id_commentaire as '#', contenu as Contenu, id_utilisateur as Utilisateur, date_creation as Timestamp, id_article as Article FROM commentaires", conn);
            MySqlDataAdapter result = new MySqlDataAdapter(command);
            conn.Close();
            return result;
        }

        public void DeleteCommentaire(int idCommentaire)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_commentaire", idCommentaire);
            requete.CommandText = "DELETE FROM commentaires WHERE id_commentaire = @id_commentaire";
            requete.ExecuteNonQuery();
            conn.Close();
        }
        public bool CommentaireArticle(int idArticle)
        {
            bool commentaireExiste;

            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_article", idArticle);
            requete.CommandText = "SELECT COUNT(id_commentaire) FROM commentaires WHERE id_article = @id_article";
            int resultat = Convert.ToInt32(requete.ExecuteScalar());

            if (resultat > 0)
            {
                commentaireExiste = true;
            } else
            {
                commentaireExiste = false;
            }
            conn.Close();
            return commentaireExiste;
        }

        public void DeleteCommentaireArticle(int idArticle)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_article", idArticle);
            requete.CommandText = "DELETE FROM commentaires WHERE id_article = @id_article";
            requete.ExecuteNonQuery();
            conn.Close();
        }

    }

}
