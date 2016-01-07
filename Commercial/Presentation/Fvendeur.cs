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

namespace Commercial
{
    public partial class Fvendeur : Form
    {
        /// <summary>
        /// Initialisation
        /// </summary>
        public Fvendeur()
        {
            InitializeComponent();

            lbl_nom.Text = "";
            lbl_prenom.Text = "";
            lbl_dtEmb.Text = "";
            lbl_ville.Text = "";
            lbl_sal.Text = "";
            lbl_com.Text = "";
            lbl_sup.Text = "";

            btn_details.Visible = false;

            // on essaie d'aller chercher la liste des vendeurs dans la base de données
            List<String> mesNumeros;
            try
            {
                Vendeur unVendeur = new Vendeur();
                mesNumeros = unVendeur.LectureNoVendeur();
                foreach (String item in mesNumeros)
                {
                    cb_listeven.Items.Add(item);
                }

            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }

        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            ActualiserListe();
        }

        /// <summary>
        /// Afficher les informations sur le vendeur sélectionné
        /// </summary>
        private void ActualiserListe()
        {
            Vendeur monvendeur = new Vendeur();
            Vendeur sup = new Vendeur();
            int index = cb_listeven.SelectedIndex;
            if (index != -1)
            {
                monvendeur.RechercheUnVendeur(cb_listeven.Items[index].ToString());

                lbl_nom.Text = monvendeur.NomVend;
                lbl_prenom.Text = monvendeur.PrenomVend;
                lbl_dtEmb.Text = monvendeur.DateEmbau.Day.ToString() + "/" + monvendeur.DateEmbau.Month.ToString() + "/" + monvendeur.DateEmbau.Year.ToString();
                lbl_ville.Text = monvendeur.VilleVend;
                lbl_sal.Text = monvendeur.SalaireVend.ToString() + " €";
                lbl_com.Text = monvendeur.Commission.ToString();
                if (monvendeur.NoChef != cb_listeven.Items[index].ToString())
                {
                    // si le vendeur à un chef, on affiche un lien qui
                    // permet de visualiser les informations du chef
                    sup.RechercheUnVendeur(monvendeur.NoChef);
                    label8.Text = "Supérieur";
                    lbl_sup.Text = monvendeur.NoChef + " : " + sup.NomVend + " " + sup.PrenomVend + "";
                }
                else
                {
                    // sinon, pas de chef (soit c'est le boss, soit il travail tout seul) ;-)
                    label8.Text = "";
                    lbl_sup.Text = "";
                }


                lbl_noclient.Text = "Vendeur n°" + cb_listeven.Items[index].ToString();
            }
            else // aucun index de la liste déroulante selctionné, on vide l'affichage
            {
                lbl_nom.Text = "";
                lbl_prenom.Text = "";
                lbl_dtEmb.Text = "";
                lbl_ville.Text = "";
                lbl_sal.Text = "";
                lbl_com.Text = "";
                lbl_sup.Text = "";

                lbl_noclient.Text = "Veuillez choisir un vendeur";
            }
        }

        /// <summary>
        /// Clic sur le lien pour afficher les informations sur le supérieur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_sup_Click(object sender, EventArgs e)
        {
            Label champ = (Label)sender;
            if (champ.Text != "")
            {
                // comme le texte du champ est de la forme :
                // numchef : prenomchef nomchef
                // on ne récupère que le début avant les ":"
                String[] coupe = champ.Text.Split(':');
                cb_listeven.Text = coupe[0].Trim();
                btn_details_Click(champ, e);
            }
        }

        private void cb_listeven_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualiserListe();
        }

        /// <summary>
        /// empêcher la saisie de caractères non numériques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_listeven_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
