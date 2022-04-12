using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BtsAssist.Modeles;

namespace BtsAssist.Fenetres
{
    public partial class FormFilActualite : Form
    {
        int idArticle = 0;
        int idCommentaire = 0;
        public FormFilActualite()
        {
            InitializeComponent();
            DataGridArticles_Load();
            DataGridCommentaires_Load();
        }

        public void DataGridArticles_Load()
        {
            Article article = new Article();
            DataTable dt = new DataTable();
            article.recupererInfosArticles().Fill(dt);
            DataGridArticles.DataSource = dt;
            this.DataGridArticles.Sort(this.DataGridArticles.Columns["#"], ListSortDirection.Ascending);
        }
        public void DataGridCommentaires_Load()
        {
            Commentaire commentaire = new Commentaire();
            DataTable dt = new DataTable();
            commentaire.recupererInfosCommentaires().Fill(dt);
            DataGridCommentaires.DataSource = dt;
            this.DataGridCommentaires.Sort(this.DataGridCommentaires.Columns["#"], ListSortDirection.Ascending);
        }

        private void DataGridArticles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridArticles.Rows[e.RowIndex].Cells[0].Value != null)
            {
                idArticle = Convert.ToInt32(DataGridArticles.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void DataGridCommentaires_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridCommentaires.Rows[e.RowIndex].Cells[0].Value != null)
            {
                idCommentaire = Convert.ToInt32(DataGridCommentaires.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void SupprimerCommentaire_Click(object sender, EventArgs e)
        {
            Commentaire commentaire = new Commentaire();
            commentaire.DeleteCommentaire(idCommentaire);
            DataGridCommentaires.DataSource = null;
            DataGridCommentaires_Load();
        }

        private void SupprimerArticle_Click(object sender, EventArgs e)
        {
            Article article = new Article();
            Commentaire commArticle = new Commentaire();

            bool result = commArticle.CommentaireArticle(idArticle);

            if(result == true)
            {
                commArticle.DeleteCommentaireArticle(idArticle);
                
            }
            article.DeleteArticle(idArticle);
            DataGridCommentaires.DataSource = null;
            DataGridArticles.DataSource = null;
            DataGridCommentaires_Load();
            DataGridArticles_Load();
        }
    }
    
}
