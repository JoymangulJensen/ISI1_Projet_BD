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
    public partial class FListeCdes : Form
    {


        /// <summary>
        /// Initialisation
        /// </summary>
        /// <param name="choix">Option pour l'initialisation : affichage d'un message ou ouverture d'une fenêtre d'ajout</param>


        public FListeCdes()
        {
            InitializeComponent();

            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            // Affiche l'entête du tableau
            lvcdes.Items.Clear();
            lvcdes.View = View.Details;
            lvcdes.Columns.Add("Numéro", 100, HorizontalAlignment.Left);
            lvcdes.Columns.Add("Numéro Vendeur", 100, HorizontalAlignment.Left);
            lvcdes.Columns.Add("Numéro Client", 100, HorizontalAlignment.Left);
            lvcdes.Columns.Add("Date Commande", 100, HorizontalAlignment.Left);
            lvcdes.Columns.Add("Facture", 100, HorizontalAlignment.Left);

            AfficherListe();

        }

        /// <summary>
        /// Affiche la liste des commandes
        /// </summary>
        private void AfficherListe()
        {
            Commande unecommande = new Commande();
            List<Commande> mesCommandes;
            string numCde, numVend, NumCli, facture, datecde;
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
                mesCommandes = unecommande.getLesCommandes();

                foreach (Commande c in mesCommandes)
                {

                    numCde = c.NoCommande;
                    // On récupère la property NoVendeur
                    numVend = c.Vendeur.NoVendeur;
                    NumCli = c.Client.NoCl;
                    datecde = c.DateCommande.ToShortDateString();
                    facture = c.Facture;
                    lvitem_cde = new ListViewItem(new string[] { numCde, numVend, NumCli, datecde, facture }, -1, Color.Black, Color.LightGray, null);
                    lvcdes.Items.Add(lvitem_cde);
                }

                if (!Numcheck.Checked) lvcdes.Columns.RemoveByKey("1");
                if (!NumVencheck.Checked) lvcdes.Columns.RemoveByKey("2");
                if (!NumClicheck.Checked) lvcdes.Columns.RemoveByKey("3");
                if (!Datecheck.Checked) lvcdes.Columns.RemoveByKey("4");
                if (!Facturecheck.Checked) lvcdes.Columns.RemoveByKey("5");
                lvcdes.FullRowSelect = true;
                lvcdes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }



        // tester l'activation des menus en fonction de la sélection
        private void lvcdes_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestAccesMenu();
        }

        /// <summary>
        /// Tester l'accès au menus en fonction de la sélection
        /// </summary>
        private void TestAccesMenu()
        {
            if (lvcdes.SelectedIndices.Count == 1) // une ligne sélectionnée
            {
                commandeSélectionnéeToolStripMenuItem.Text = "Commande sélectionnée";
                commandeSélectionnéeToolStripMenuItem.Enabled = true;
                détailsToolStripMenuItem.Enabled = true;
                modifierToolStripMenuItem.Enabled = true;
                supprimerToolStripMenuItem.Enabled = true;
            }
            else if (lvcdes.SelectedIndices.Count == 0) // aucune ligne sélectionnée
            {
                commandeSélectionnéeToolStripMenuItem.Text = "Commande sélectionnée";
                commandeSélectionnéeToolStripMenuItem.Enabled = false;
            }
            else // plusieurs lignes sélectionnées
            {
                commandeSélectionnéeToolStripMenuItem.Text = "Commandes sélectionnées";
                commandeSélectionnéeToolStripMenuItem.Enabled = true;
                détailsToolStripMenuItem.Enabled = false;
                modifierToolStripMenuItem.Enabled = false;
                supprimerToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// Adapter la listeView à la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FListeCdes_Resize(object sender, EventArgs e)
        {
            lvcdes.Width = this.Width - 40;
            lvcdes.Height = this.Height - 120;
            lvcdes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

       

        /// <summary>
        /// Lien du menu pour ajouter une commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Affiche le formulaire d'ajout d'une nouvelle commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FajouteCdes f = new FajouteCdes();
            f.ShowDialog();
        }
    }
}
