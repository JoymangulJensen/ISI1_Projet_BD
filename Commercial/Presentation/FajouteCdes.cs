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
    public partial class FajouteCdes : Form
    {
        private Commande _cmd;

        /// <summary>
        /// Initialiser
        /// </summary>
        public FajouteCdes()
        {
            InitializeComponent();
            _cmd = new Commande();

            // Actions des boutons
            this.AcceptButton = submit_button;
            submit_button.DialogResult = DialogResult.OK;
            btn_cancel.DialogResult = DialogResult.Cancel;

            ChargerDonnees();
        }


        #region Initialisation

        /// <summary>
        /// Charger les données pour les listes déroulantes de clients et vendeurs
        /// </summary>
        private void ChargerDonnees()
        {
            List<String> mesNumeros;
            try
            {
                Clientel unClient = new Clientel();
                mesNumeros = unClient.LectureNoClient();
                foreach (String item in mesNumeros)
                {
                    cb_noclient.Items.Add(item);
                }

                Vendeur unVendeur = new Vendeur();
                mesNumeros = unVendeur.LectureNoVendeur();
                foreach (String item in mesNumeros)
                {
                    cb_novendeur.Items.Add(item);
                }

            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
        }

        #endregion

        /// <summary>
        /// Si on coche oui pour la facture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_f_oui_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton oui = (RadioButton)sender;
            if (oui.Checked)
            {
                rb_f_non.Checked = false;
                _cmd.Facture = "T";
            }
        }

        /// <summary>
        /// Si on coche non pour la facture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_f_non_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton non = (RadioButton)sender;
            if (non.Checked)
            {
                rb_f_oui.Checked = false;
                _cmd.Facture = "F";
            }
        }

        /// <summary>
        /// Bouton valider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submit_button_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Bouton annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
