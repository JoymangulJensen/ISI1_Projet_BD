/*
 * THIBAULT LAZERT P1003011
 * UE ISI Polytech'Lyon
 * semestre automne 2012
 * 
 * Application gestion commerciale
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Metier;
using Utilitaires;

namespace Commercial.Presentation
{
    public partial class FListeArticles : Form
    {
        String tri;
        String ordre;

        /// <summary>
        /// Initialisation
        /// </summary>
        public FListeArticles()
        {
            InitializeComponent();

            // tri par défaut
            tri = "NO_ARTICLE";
            ordre = "ASC";
            croissantToolStripMenuItem.Checked = true;
            menu_tri_no.Checked = true;
            menu_articleselectionne.Enabled = false;

            AfficherListe();
            
        }

        /// <summary>
        /// Chargement de la liste des articles de la base
        /// </summary>
        private void AfficherListe()
        {
            Article unarticle = new Article();
            List<Article> mesArticles;
            ListViewItem lvitem_art;

            lvart.Items.Clear();
            lvart.Columns.Clear();
            lvart.View = View.Details;
            lvart.Columns.Add("0", "Numéro");
            lvart.Columns.Add("1", "Libellé");
            lvart.Columns.Add("2", "Qté");
            lvart.Columns[2].TextAlign = HorizontalAlignment.Right;
            lvart.Columns.Add("3", "Ville");
            lvart.Columns.Add("4", "Prix");
            lvart.Columns[4].TextAlign = HorizontalAlignment.Right;
            lvart.Columns.Add("5", "Int");
            try
            {
                mesArticles = unarticle.getLesArticles(tri,ordre);
                int i = 0;
                foreach (Article a in mesArticles)
                {
                    i++;
                    lvitem_art = new ListViewItem(new string[] { a.No_article, a.Lib_article, a.Qte_dispo, a.Ville_art, a.Prix_art, a.Interrompu }, -1, Color.Black, Color.White, null);
                    // couleur de fond alternée
                    if (i % 2 == 0)
                        lvitem_art.BackColor = Color.FromArgb(20, 240, 240, 255);
                    else
                        lvitem_art.BackColor = Color.FromArgb(20, 230, 230, 250);
                    lvart.Items.Add(lvitem_art);

                }
                lvart.FullRowSelect = true;

                lvart.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (MonException excep)
            {
                MessageBox.Show(excep.MessageSysteme(), "Erreur de listage.");
            }
        }

        /// <summary>
        /// ajuster la listeView à la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FListeArticles_Resize(object sender, EventArgs e)
        {
            lvart.Width = this.Width - 40;
            lvart.Height = this.Height - 100;
            lvart.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Summary :
        //  Les fonctions ci-dessous servent à changer l'ordre des données
        //----------------------

        private void croissantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            croissantToolStripMenuItem.Checked = true;
            décroissantToolStripMenuItem.Checked = false;
            ordre = "ASC";

            AfficherListe();
        }
        private void décroissantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            décroissantToolStripMenuItem.Checked = true;
            croissantToolStripMenuItem.Checked = false;
            ordre = "DESC";

            AfficherListe();
        }

        private void decocherTris()
        {
            menu_tri_no.Checked = false;
            menu_tri_libelle.Checked = false;
            menu_tri_quantite.Checked = false;
            menu_tri_ville.Checked = false;
            menu_tri_prix.Checked = false;
            menu_tri_interrompu.Checked = false;
        }

        private void menu_tri_no_Click(object sender, EventArgs e)
        {
            menu_tri_no.Checked = true;
            tri = "NO_ARTICLE";

            AfficherListe();
        }
        private void menu_tri_libelle_Click(object sender, EventArgs e)
        {
            menu_tri_libelle.Checked = true;
            tri = "LIB_ARTICLE";

            AfficherListe();
        }
        private void menu_tri_quantite_Click(object sender, EventArgs e)
        {
            menu_tri_quantite.Checked = true;
            tri = "QTE_DISPO";

            AfficherListe();
        }
        private void menu_tri_ville_Click(object sender, EventArgs e)
        {
            menu_tri_ville.Checked = true;
            tri = "VILLE_ART";

            AfficherListe();
        }
        private void menu_tri_prix_Click(object sender, EventArgs e)
        {
            menu_tri_prix.Checked = true;
            tri = "PRIX_ART";

            AfficherListe();
        }
        private void menu_tri_interrompu_Click(object sender, EventArgs e)
        {
            menu_tri_interrompu.Checked = true;
            tri = "INTERROMPU";

            AfficherListe();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Prix modifprix = new Prix();
            if(modifprix.ShowDialog() == DialogResult.OK)
                AfficherListe();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            nouvelleArticle(true);
        }

        /// <summary>
        /// Fonction qui ouvre une fenêtre de saisie et qui récupère les données
        /// pour les insérer dans la base
        /// </summary>
        /// <param name="actualiser">actualiser la liste après l'ajout ?</param>
        private void nouvelleArticle(bool actualiser = false)
        {
            Article art = new Article();
            FajouteArticle artnew = new FajouteArticle(art);
            DialogResult res = artnew.ShowDialog();
            if (res == DialogResult.OK)
            {
                try
                {
                    art.ajouterArticle();
                    if (actualiser)
                        AfficherListe();
                    else
                        MessageBox.Show("Article ajouté avec succès.");
                }
                catch (MonException excep)
                {
                    MessageBox.Show(excep.MessageSysteme(), "Erreur d'ajout");
                }
            }
        }

        private void lvart_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool res = false;
            if (lvart.SelectedItems.Count == 1)
                res = true;
            else
                res = false;

            menu_articleselectionne.Enabled = res;
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvart.SelectedIndices.Count == 1)
            {
                String no_cmd = lvart.Items[lvart.SelectedIndices[0]].Text;
                Article art = new Article();
                art.RechercheArticle(no_cmd);
                FajouteArticle modif = new FajouteArticle(art, true);
                DialogResult res = modif.ShowDialog();
                if (res == DialogResult.OK)
                {
                    try
                    {
                        art.modifierArticle();
                        AfficherListe();
                    }
                    catch (MonException excep)
                    {
                        MessageBox.Show(excep.MessageSysteme(), "Erreur de modification");
                    }
                }
            }
        }
    }
}
