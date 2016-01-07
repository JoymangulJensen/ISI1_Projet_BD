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
using Utilitaires;
using Metier;
using Commercial.Presentation;

namespace Commercial
{
    public partial class Faccueil : Form
    {
        /// <summary>
        /// Initialsation
        /// </summary>
        public Faccueil()
        {
            InitializeComponent();
            connexion();
        }

        /// <summary>
        /// Lien pour quitter depuis le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // on se déconnecte de la base de données
            FermetureApplication.getFermeture();
            // on ferme la winfows form
            Application.Exit();
        }

        /// <summary>
        /// Lien connexion depuis le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connexion();
        }

        /// <summary>
        /// Connexion à la base de données
        /// en passant par la classe métier
        /// </summary>
        private void connexion()
        {
            try
            {
                bool rep;
                // on connecte l'application à la base de données
                rep = OuvertureApplication.getOuverture();
                // si la connexion a réussie : on active les menus
                if (rep)
                {
                
                    interrogerToolStripMenuItem.Enabled = true;
                    gérerToolStripMenuItem.Enabled = true;

                    lbl_etat.Text = "Etat : en ligne";
                    lbl_etat.ForeColor = Color.DarkGreen;
                }
                // sinon on désactive les menus
                else
                {
                   
                    interrogerToolStripMenuItem.Enabled = false;
                    gérerToolStripMenuItem.Enabled = false;

                    lbl_etat.Text = "Etat : hors ligne - erreur de connexion";
                    lbl_etat.ForeColor = Color.Red;
                }
            }
            catch (MonException excep)
            {
                MessageBox.Show(excep.MessageSysteme(),"Erreur de connexion");
               
                interrogerToolStripMenuItem.Enabled = false;
                gérerToolStripMenuItem.Enabled = false;
                lbl_etat.Text = excep.MessageSysteme();
                lbl_etat.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Lien de déconnexion depuis le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            déconnexion();
        }

        /// <summary>
        /// Fonction de déconnexion de la base de données
        /// </summary>
        private void déconnexion()
        {
            FermetureApplication.getFermeture();
          
            interrogerToolStripMenuItem.Enabled = false;
            gérerToolStripMenuItem.Enabled = false;

            lbl_etat.Text = "Etat : hors ligne";
            lbl_etat.ForeColor = Color.Black;
        }

        /// <summary>
        /// Ouvrir la fenêtre pour afficher les informations sur un client.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ficheClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fclient cli = new Fclient();
            cli.ShowDialog();
        }

        /// <summary>
        /// Ouvrir la fenêtre pour afficher les informations sur un vendeur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ficheVendeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fvendeur ven = new Fvendeur();
            ven.ShowDialog();
        }

        
        /// <summary>
        /// Fenêtre pour afficher des informations à propos de l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String message = "";
            message += "Application de gestion commerciale\n\n";
            message += "UE ISI\n";
            message += "Polytech'Lyon\n\n";
            message += "Semestre automne 2015\n";
            MessageBox.Show(message, "À propos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Faccueil_Load(object sender, EventArgs e)
        {
            try
            {
                bool rep;
                // on connecte l'application à la base de données
                rep = OuvertureApplication.getOuverture();
                // si la connexion a réussie : on active les menus
                if (rep)
                {
                   
                    interrogerToolStripMenuItem.Enabled = true;
                    gérerToolStripMenuItem.Enabled = true;

                    lbl_etat.Text = "Etat : en ligne";
                    lbl_etat.ForeColor = Color.DarkGreen;
                }
                // sinon on désactive les menus
                else
                {
                    
                    interrogerToolStripMenuItem.Enabled = false;
                    gérerToolStripMenuItem.Enabled = false;

                    lbl_etat.Text = "Etat : hors ligne - erreur de connexion";
                    lbl_etat.ForeColor = Color.Red;
                }
            }
            catch (MonException excep)
            {
                MessageBox.Show(excep.MessageSysteme(), "Erreur de connexion");
              
                interrogerToolStripMenuItem.Enabled = false;
                gérerToolStripMenuItem.Enabled = false;
                lbl_etat.Text = excep.MessageSysteme();
                lbl_etat.ForeColor = Color.Red;
            }

        }

        /// <summary>
        /// Ouvre la fenêtre liste des commandes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listeCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FListeCdes cdes = new FListeCdes();
            cdes.ShowDialog();
        }

        /// <summary>
        /// Affiche la fenêtre d'ajout d'une nouvelle commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FajouteCdes f = new FajouteCdes();
            f.ShowDialog();
        }

        private void listeArticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FListeArticles f = new FListeArticles();
            f.ShowDialog();
        }
    }
}
