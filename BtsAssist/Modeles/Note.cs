using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BtsAssist.Modeles
{
    class Note : Modele
    {
        int idNote { get; set; }
        int note { get; set; }
        int idUtilisateur { get; set; }
        int idExercice { get; set; }
        DateTime dateNote { get; set; }

        public MySqlDataAdapter recupererInfosNotes()
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command = new MySqlCommand("SELECT notes.id_note as '#', notes.note as Note, notes.id_exercice as Exercice, matieres_bts.libelle as Matiere, notes.date_note as Date, utilisateurs.pseudo as Utilisateur FROM notes join utilisateurs on notes.id_utilisateur = utilisateurs.id_utilisateur join exercices on exercices.id_exercice = notes.id_exercice join cours on exercices.id_cours = cours.id_cours join matieres_bts on cours.id_matiere_bts = matieres_bts.id_matiere_bts order by utilisateurs.id_utilisateur desc", conn);
            MySqlDataAdapter result = new MySqlDataAdapter(command);
            conn.Close();
            return result;
        }

        public void DeleteNote(int idNote)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_note", idNote);
            requete.CommandText = "DELETE FROM notes WHERE id_note = @id_note";
            requete.ExecuteNonQuery();
            conn.Close();
        }
        public bool NoteExercice(int idExercice)
        {
            bool noteExiste;

            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_exercice", idExercice);
            requete.CommandText = "SELECT COUNT(id_note) FROM notes WHERE id_exercice = @id_exercice";
            int resultat = Convert.ToInt32(requete.ExecuteScalar());

            if (resultat > 0)
            {
                noteExiste = true;
            }
            else
            {
                noteExiste = false;
            }
            conn.Close();
            return noteExiste;
        }
        public void DeleteNoteExercice(int idExercice)
        {
            conn.Open();
            MySqlCommand requete = conn.CreateCommand();
            requete.Parameters.AddWithValue("@id_exercice", idExercice);
            requete.CommandText = "DELETE FROM notes WHERE id_exercice = @id_exercice";
            requete.ExecuteNonQuery();
            conn.Close();
        }
    }
}
