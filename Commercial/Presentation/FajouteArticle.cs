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
    public partial class FajouteArticle : Form
    {
        private Article _art;

        /// <summary>
        /// Initialiser
        /// </summary>
        public FajouteArticle()
        {
            InitializeComponent();
            _art = new Article();

            // Actions des boutons
            this.AcceptButton = submit_button;
            submit_button.DialogResult = DialogResult.OK;
            btn_cancel.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Initialiser avec une commande
        /// </summary>
        /// <param name="cmd">Commande initialisée qui sera modifiée</param>
        /// <param name="modifier">true si la fenêtre est une fenêtre de modification</param>
        public FajouteArticle(Article art, bool modifier = false)
        {
            InitializeComponent();
            _art = art;

            // Actions des boutons
            this.AcceptButton = submit_button;
            submit_button.DialogResult = DialogResult.OK;
            btn_cancel.DialogResult = DialogResult.Cancel;

            // copier les données s'il y en a pour les afficher
            tb_noart.Text = _art.No_article;
            tb_libelle.Text = _art.Lib_article;
            tb_quantite.Value = decimal.Parse(_art.Qte_dispo);
            tb_ville.Text = _art.Ville_art;
            tb_prix.Text = _art.Prix_art;
            if (_art.Interrompu == "F")
            {
                rb_f_non.Checked = true;
                rb_f_oui.Checked = false;
            }
            else
            {
                rb_f_oui.Checked = true;
                rb_f_non.Checked = false;
            }

            if (modifier)
            {
                tb_noart.Enabled = false;
                lbl_titre.Text = "Modifier un article";
                this.Text = "Modifier una article";
            }
            testSubmitPossible();
        }


        /// <summary>
        /// Si on coche oui pour interrompu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_f_oui_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton oui = (RadioButton)sender;
            if (oui.Checked)
            {
                rb_f_non.Checked = false;
                _art.Interrompu = "T";
            }
        }

        /// <summary>
        /// Si on coche non pour interrompu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_f_non_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton non = (RadioButton)sender;
            if (non.Checked)
            {
                rb_f_oui.Checked = false;
                _art.Interrompu = "F";
            }
        }

        /// <summary>
        /// vérifier que le numéro de l'article est libre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_noart_verifier(object sender, EventArgs e)
        {
            Article art = new Article();
            bool test = art.NumeroLibre(tb_noart.Text);
            if (!test)
            {
                if (MessageBox.Show("Un article avec ce numéro existe déjà.", "Erreur", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    tb_noart.Text = "";
                    tb_noart_verifier(sender, e);
                }
                else
                {
                    tb_noart.Focus();
                }
            }
        }

        /// <summary>
        /// Vérifier si le formulaire est prêt à être validé
        /// </summary>
        private void testSubmitPossible()
        {
            bool res = true;

            if (tb_noart.Text.Length == 0)
                res = false;

            if (tb_libelle.Text.Length == 0)
                res = false;

            submit_button.Enabled = res;
        }

        /// <summary>
        /// en cliquant sur le bouton de validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submit_button_Click(object sender, EventArgs e)
        {
            // on récupère les données du formualaire
            // pour les mettre dans l'article "retournée"
            _art.No_article = tb_noart.Text;
            _art.Lib_article = tb_libelle.Text;
            _art.Qte_dispo = tb_quantite.Value.ToString();
            _art.Ville_art = tb_ville.Text;
            _art.Prix_art = tb_prix.Text;
            _art.Interrompu = (rb_f_oui.Checked ? "T" : "F");

            this.Close();
        }


        /// <summary>
        /// Clic sur le bouton annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Empêcher la saisie de caractères autres que numériques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_prix_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si ce n'est pas une touche numérique qui est appuyée, on annule
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)46))
                e.Handled = false;
            else
                e.Handled = true;
        }

        /// <summary>
        /// On vérifie que la validation est possible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_noart_TextChanged(object sender, EventArgs e)
        {
            testSubmitPossible();
        }

        private void tb_libelle_TextChanged(object sender, EventArgs e)
        {
            testSubmitPossible();
        }

    }
}
