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
    public partial class Prix : Form
    {
        /// <summary>
        /// Initiaisation
        /// </summary>
        public Prix()
        {
            InitializeComponent();
            // actions des boutons
            this.AcceptButton = btn_valider;
            btn_valider.DialogResult = DialogResult.OK;
            btn_annuler.DialogResult = DialogResult.Cancel;
            rb_augmenter.Checked = true;
            rb_diminuer.Checked = false;
        }

        /// <summary>
        /// validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_valider_Click(object sender, EventArgs e)
        {
            String envoi = "";
            if (rb_diminuer.Checked)
                envoi += "-";
            envoi += tb_pourcentageAuto.Value.ToString();
            try
            {
                Article.ModifierPrix(envoi);
                MessageBox.Show("Opération effectuée avec succès !", "Ok");
            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
            
        }

        /// <summary>
        /// Empêcher la saisie de caractères autres que numériques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si ce n'est pas une touche numérique qui est appuyée, on annule
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)46))
                e.Handled = false;
            else
                e.Handled = true;
        }
    
        /// <summary>
        /// Cocher un choix pour augmenter ou diminuer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_diminuer_Click(object sender, EventArgs e)
        {
            rb_diminuer.Checked = true;
            rb_augmenter.Checked = false;
        }
        private void rb_augmenter_Click(object sender, EventArgs e)
        {
            rb_augmenter.Checked = true;
            rb_diminuer.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fprix_Load(object sender, EventArgs e)
        {

        }
    }
}
