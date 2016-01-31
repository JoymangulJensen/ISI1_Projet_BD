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
            testSubmitPossible();
        }

        public FajouteCdes(Commande cmd, bool modifier = false)
        {
            InitializeComponent();
            _cmd = cmd;

            // Actions des boutons
            this.AcceptButton = submit_button;
            submit_button.DialogResult = DialogResult.OK;
            btn_cancel.DialogResult = DialogResult.Cancel;

            if (modifier)
            {
                tb_nocmd.Enabled = false;
                lbl_titre.Text = "Modifier une commande";
                this.Text = "Modifier une commande";
            }

            ChargerDonnees();

            this.tb_nocmd.Text = _cmd.NoCommande;
            cb_novendeur.SelectedIndex = cb_novendeur.FindStringExact(_cmd.Vendeur.NoVendeur);
            cb_noclient.SelectedIndex = cb_noclient.FindStringExact(_cmd.Client.NoCl);
            dtp_date.Value = _cmd.DateCommande;
            if (_cmd.Facture == "F")
            {
                rb_f_oui.Checked = false;
                rb_f_non.Checked = true;
            }
            else
            {
                rb_f_oui.Checked = true;
                rb_f_non.Checked = false;
            }
            testSubmitPossible();
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
            _cmd.NoCommande = tb_nocmd.Text;
            _cmd.Client.NoCl = cb_noclient.SelectedItem.ToString();
            _cmd.Vendeur.NoVendeur = cb_novendeur.SelectedItem.ToString();
            _cmd.DateCommande = dtp_date.Value;
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

        /// <summary>
        /// Vérifier si le formulaire est prêt à être validé
        /// </summary>
        private void testSubmitPossible()
        {
            bool res = true;

            if (tb_nocmd.Text.Length == 0)
                res = false;
            if (cb_noclient.Text.Length == 0)
                res = false;
            if (cb_novendeur.Text.Length == 0)
                res = false;
            if (dtp_date.Value.ToString().Length == 0)
                res = false;
            submit_button.Enabled = res;
        }

        private void cb_noclient_SelectedIndexChanged(object sender, EventArgs e)
        {
            testSubmitPossible();
        }

        private void cb_novendeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            testSubmitPossible();
        }

        private void tb_nocmd_TextChanged(object sender, EventArgs e)
        {
            testSubmitPossible();
        }
    }
}
