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
using System.Globalization;

namespace Commercial.Presentation
{
    public partial class FDetailsCde : Form
    {
        string noCmd;
        
        /// <summary>
        /// Initialisation
        /// </summary>
        public FDetailsCde()
        {
            InitializeComponent();
           
        }

        public FDetailsCde(string noCmd)
        {

            InitializeComponent();

            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            // Affiche l'entête du tableau
            lvart.Items.Clear();
            lvart.View = View.Details;
            lvart.Columns.Add("Numéro", 100, HorizontalAlignment.Left);
            lvart.Columns.Add("Libellé", 100, HorizontalAlignment.Left);
            lvart.Columns.Add("Ville", 100, HorizontalAlignment.Left);
            lvart.Columns.Add("Prix Unité", 100, HorizontalAlignment.Left);
            lvart.Columns.Add("Qté", 100, HorizontalAlignment.Left);
            lvart.Columns.Add("Prix totale", 100, HorizontalAlignment.Left);
            lvart.Columns.Add("Livré", 100, HorizontalAlignment.Left);
            this.noCmd = noCmd;
            this.lbl_titre.Text += " " + this.noCmd;
            AfficherListe();
            
        }

        private void AfficherListe()
        {
            DetailsCde unDetail =  new DetailsCde();
            List<DetailsCde> mesDetails;
            string numArt, libelle, ville, prixU, qte, prixT, livre;
            ListViewItem lvitem_cde;

            //lvcdes.Items.Clear();
            //lvcdes.Columns.Clear();
            //lvcdes.View = View.Details;
            //lvcdes.Columns.Add("1", "Numéro");
            //lvcdes.Columns.Add("2", "Numéro Vendeur");
            //lvcdes.Columns.Add("3", "Numéro Client");
            //lvcdes.Columns.Add("4", "Date Commande");
            //lvcdes.Columns.Add("5", "Facture");

            try
            {
                mesDetails = unDetail.getDetailsCde(noCmd);

                foreach (DetailsCde d in mesDetails)
                {

                    numArt = d.Art.No_article;
                    libelle = d.Art.Lib_article;
                    ville = d.Art.Ville_art;
                    prixU = d.Art.Prix_art;
                    qte = d.Qte_cdee;
                    prixT = d.Total;
                    livre = d.Livree;
                    lvitem_cde = new ListViewItem(new string[] { numArt, libelle, ville, prixU, qte, prixT, livre }, -1, Color.Black, Color.LightGray, null);
                    lvart.Items.Add(lvitem_cde);
                }
                lvart.FullRowSelect = true;
                lvart.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);           
            }
            catch (MonException erreur)
            {
                MessageBox.Show(erreur.MessageSysteme(), "Erreur de modification");
            }          
        }



    }
}
