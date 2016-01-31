﻿/*
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
        private List<Commande> mesCommandes;

        public FListeCdes()
        {
            InitializeComponent();

            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            // Affiche l'entête du tableau

            Numcheck.Checked = true;
            AfficherListe();
        }

        /// <summary>
        /// Affiche la liste des commandes
        /// </summary>
        private void AfficherListe()
        {
            lvcdes.Columns.Clear();
            lvcdes.Items.Clear();
            lvcdes.View = View.Details;
            lvcdes.Columns.Add("1","Numero", 100, HorizontalAlignment.Left,0);
            lvcdes.Columns.Add("2", "Numéro Vendeur", 100, HorizontalAlignment.Left,0);
            lvcdes.Columns.Add("3", "Numéro Client", 100, HorizontalAlignment.Left,0);
            lvcdes.Columns.Add("4", "Date Commande", 100, HorizontalAlignment.Left,0);
            lvcdes.Columns.Add("5", "Facture", 100, HorizontalAlignment.Left,0);

            Commande unecommande = new Commande();
            string numCde, numVend, NumCli, facture, datecde;
            ListViewItem lvitem_cde;

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
            Commande cmd = new Commande();
            FajouteCdes f = new FajouteCdes(cmd);
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                try
                {
                    cmd.ajouterCommande();
                    MessageBox.Show("Commande ajoutée avec succès.");
                    AfficherListe();
                }
                catch (MonException excep)
                {
                    MessageBox.Show(excep.MessageSysteme(), "Erreur d'ajout");
                }
            }
        }

        private void lvcdes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for(int i= 0;i<lvcdes.SelectedIndices.Count;i++)
            {
                String no_cmd = lvcdes.Items[lvcdes.SelectedIndices[i]].Text;
                FDetailsCde dt = new FDetailsCde(no_cmd);
                DialogResult res = dt.ShowDialog();
            }
           
        }

        private void NumClicheck_CheckStateChanged(object sender, EventArgs e)
        {
            this.AfficherListe();
        }

        private void Numcheck_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficherListe();  
        }

        private void NumVencheck_CheckStateChanged(object sender, EventArgs e)
        {
            this.AfficherListe();
        }

        private void Datecheck_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficherListe();
        }

        private void Facturecheck_CheckedChanged(object sender, EventArgs e)
        {
            this.AfficherListe();
        }

        private void détailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvcdes.SelectedIndices.Count; i++)
            {
                String no_cmd = lvcdes.Items[lvcdes.SelectedIndices[i]].Text;
                FDetailsCde dt = new FDetailsCde(no_cmd);
                DialogResult res = dt.ShowDialog();
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvcdes.SelectedIndices.Count; i++)
            {
                String no_cmd = lvcdes.Items[lvcdes.SelectedIndices[i]].Text;
                Commande c = this.getCommandeByNum(no_cmd);
                FajouteCdes f = new FajouteCdes(c, true);
                DialogResult res = f.ShowDialog();
                if (res == DialogResult.OK)
                {
                    try
                    {
                        c.modifierCommande();
                        MessageBox.Show("Modification de commande réussite ! ", "Commande modifiée avec succès !");
                        AfficherListe();
                    }
                    catch (MonException excep)
                    {
                        MessageBox.Show(excep.MessageSysteme(), "Erreur de modification");
                    }
                }
            }
        }

        private Commande getCommandeByNum(String no_cmd)
        {
            foreach (Commande c in mesCommandes)
            {

                if (no_cmd == c.NoCommande)
                {
                    return c;
                }
            }
            throw new MonException("Commande introuvable", "Erreur pour trouver une commande", "Erreur");
        }
    }
}
