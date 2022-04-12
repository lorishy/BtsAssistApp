using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using BtsAssist.Modeles;

namespace BtsAssist.Modeles
{
    using BCrypt.Net;
    class Utilisateur : Modele
    {
        public int IdUtilisateur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Pseudo { get; set; }
        public string Email { get; set; }
        public string Mdp { get; set; }
        public int IdRole { get; set; }

        public bool connexion(string email, string mdp)
        {
            bool EmailExiste = false;
            bool connected = false;

            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@email", email);
            requete.CommandText = "SELECT id_utilisateur, nom, prenom, pseudo, email, mdp, id_role FROM utilisateurs WHERE email = @email";
            MySqlDataReader reader = requete.ExecuteReader();

            
            while (reader.Read())
            {

                IdUtilisateur = reader.GetInt32(0);
                Nom = reader.GetString(1);
                Prenom = reader.GetString(2);
                Pseudo = reader.GetString(3);
                Email = reader.GetString(4);
                Mdp = reader.GetString(5);
                IdRole = reader.GetInt32(6);
            }
           
            if(!string.IsNullOrEmpty(Email))
            {
                EmailExiste = true;
            }


            if (EmailExiste != false)
            {
                if (BCrypt.Verify(mdp, Mdp))
                {
                    if(IdRole == 3)
                    {
                        connected = true;
                    }else
                    {
                        MessageBox.Show("Vous devez être administrateur");
                    }
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect !");
                }
            }
            else
            {
                MessageBox.Show("Cet email n'existe pas");
                    
            }
            conn.Close();
            return connected;
        }

        public MySqlDataAdapter recupererInfosUtilisateur()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT id_utilisateur as '#', nom as Nom, prenom as Prenom, pseudo as Pseudo, email as Email, mdp as Mdp, mention_legale as 'Mention legale', id_role as Role, date_creation as 'Date de creation' FROM utilisateurs", conn);
            MySqlDataAdapter result = new MySqlDataAdapter(command);
            conn.Close();
            return result;
        }

        public void DeleteUtilisateur(int idUtilisateur)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_utilisateur", idUtilisateur);
            requete.CommandText = "DELETE FROM utilisateurs WHERE id_utilisateur = @id_utilisateur";
            requete.ExecuteNonQuery();
            conn.Close();
        }
        public void editRoleEleve(int idUtilisateur)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_utilisateur", idUtilisateur);
            requete.CommandText = "UPDATE utilisateurs SET id_role = 1 WHERE id_utilisateur = @id_utilisateur";
            requete.ExecuteNonQuery();
            conn.Close();
        }

        public void editRoleProf(int idUtilisateur)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_utilisateur", idUtilisateur);
            requete.CommandText = "UPDATE utilisateurs SET id_role = 2 WHERE id_utilisateur = @id_utilisateur";
            requete.ExecuteNonQuery();
            conn.Close();
        }
        public void editRoleAdmin(int idUtilisateur)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_utilisateur", idUtilisateur);
            requete.CommandText = "UPDATE utilisateurs SET id_role = 3 WHERE id_utilisateur = @id_utilisateur";
            requete.ExecuteNonQuery();
            conn.Close();
        }
    }
}