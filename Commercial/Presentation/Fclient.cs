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
    public partial class Fclient : Form
    {
        /// <summary>
        /// Initialisation
        /// </summary>
        public Fclient()
        {
            InitializeComponent();

            lbl_nom.Text = "";
            lbl_prenom.Text = "";
            lbl_scte.Text = "";
            lbl_adresse.Text = "";
            lbl_ville.Text = "";
            lbl_cp.Text = "";
            btn_details.Visible = false;

            List<String> mesNumeros;
            try
            {
                Clientel unClient = new Clientel();
                mesNumeros = unClient.LectureNoClient();
                foreach (String item in mesNumeros)
                {
                    cb_listecli.Items.Add(item);
                }

            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }

        }

        /// <summary>
        /// Fermer la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            ActualiserListe();
        }

        /// <summary>
        /// Charger les informations sur le client sélectionné dans la liste déroulante
        /// </summary>
        private void ActualiserListe()
        {
            Clientel monclient = new Clientel();
            int index = cb_listecli.SelectedIndex;
            if (index != -1)
            {
                monclient.RechercheUnClient(cb_listecli.Items[index].ToString());

                lbl_nom.Text = monclient.NomCl;
                lbl_prenom.Text = monclient.PrenomCl;
                lbl_scte.Text = monclient.Societe;
                lbl_adresse.Text = monclient.AdresseCl;
                lbl_ville.Text = monclient.VilleCl;
                lbl_cp.Text = monclient.CodePostCl;

                lbl_noclient.Text = "Client n°" + cb_listecli.Items[index].ToString();
            }
            else
            {
                lbl_nom.Text = "";
                lbl_prenom.Text = "";
                lbl_scte.Text = "";
                lbl_adresse.Text = "";
                lbl_ville.Text = "";
                lbl_cp.Text = "";

                lbl_noclient.Text = "Veuillez choisir un client";
            }
        }

        private void cb_listecli_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualiserListe();
        }

        private void cb_listecli_TextChanged(object sender, EventArgs e)
        {
            ActualiserListe();
        }

        /// <summary>
        /// empêcher la saisie à la main d'un numéro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_listecli_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
