/*
 * THIBAULT LAZERT P1003011
 * UE ISI Polytech'Lyon
 * semestre automne 2012
 * 
 * Application gestion commerciale
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using Utilitaires;
using Persistance;


namespace Metier
{
    public class Commande
    {
        private Clientel client;
        private String noCommande;
        private DateTime dateCommande;
        private String facture;
        private Vendeur vendeur;


        public String NoCommande
        {
            get { return noCommande; }
            set { noCommande = value; }
        }
        public Vendeur Vendeur
        {
            get { return vendeur; }
            set { vendeur = value; }
        }
        public Clientel Client
        {
            get { return client; }
            set { client = value; }
        }
        public DateTime DateCommande
        {
            get { return dateCommande; }
            set { dateCommande = value; }
        }
        public String Facture
        {
            get { return facture; }
            set { facture = value; }
        }

        /// <summary>
        /// Initialisation
        /// </summary>
        public Commande()
        {
            noCommande = "";
            facture = "";
            vendeur = new Vendeur();
            client = new Clientel();
            dateCommande = DateTime.Today;
        }

        /// <summary>
        /// Initialisation avec les paramètres
        /// </summary>
        public Commande(String noC, DateTime dateC, String factC, Vendeur ven, Clientel cli)
        {
            noCommande = noC;
            dateCommande = dateC;
            facture = factC;
            vendeur = ven;
            client = cli;
        }

        public List<Commande> getLesCommandes(String tri, String ordre)
        {
            DataTable dt;
            String mysql = "SELECT NO_COMMAND, NO_VENDEUR, NO_CLIENT, DATE_CDE, FACTURE ";
            mysql += "FROM COMMANDES ";
            mysql += "ORDER BY " + tri + " " + ordre;
            sErreurs er = new sErreurs("Erreur sur lecture des commandes", "Commande.getLesCommandes()");
            try
            {
                dt = DbInterface.Lecture(mysql, er);
                List<Commande> mesCdes = new List<Commande>();
                foreach (DataRow dataRow in dt.Rows)
                {
                    Vendeur unvd = new Vendeur();
                    unvd.NoVendeur = dataRow[1].ToString();
                    Clientel uncli = new Clientel();
                    uncli.NoCl = dataRow[2].ToString();
                    Commande unecde = new Commande(dataRow[0].ToString(),
                                                    ((DateTime)dataRow[3]),
                                                   dataRow[4].ToString(), unvd, uncli);
                    mesCdes.Add(unecde);
                }
                return mesCdes;
            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }

        public List<Commande> getLesCommandes()
        {
            DataTable dt;
            String mysql = "SELECT NO_COMMAND, NO_VENDEUR, NO_CLIENT, DATE_CDE, FACTURE ";
            mysql += "FROM COMMANDES ";
            sErreurs er = new sErreurs("Erreur sur lecture des commandes", "Commande.getLesCommandes()");
            try
            {
                dt = DbInterface.Lecture(mysql, er);
                List<Commande> mesCdes = new List<Commande>();
                foreach (DataRow dataRow in dt.Rows)
                {
                    Vendeur unvd = new Vendeur();
                    unvd.NoVendeur = dataRow[1].ToString();
                    Clientel uncli = new Clientel();
                    uncli.NoCl = dataRow[2].ToString();
                    Commande unecde = new Commande(dataRow[0].ToString(),
                                                    ((DateTime)dataRow[3]),
                                                   dataRow[4].ToString(), unvd, uncli);
                    mesCdes.Add(unecde);
                }
                return mesCdes;
            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }

        /// <summary>
        /// Modifier les informations de la commande dans la base de données
        /// </summary>
        public void modifierCommande()
        {
            DataTable dt;
            sErreurs err = new sErreurs("", "");

            String mysql;
            try
            {
                // actualiser les infoamtions dans la base
                mysql = "UPDATE COMMANDES SET NO_VENDEUR = '";
                mysql += this.Vendeur.NoVendeur;
                mysql += "', NO_CLIENT = '";
                mysql += this.Client.NoCl;
                mysql += "', DATE_CDE = '";
                mysql += this.dateCommande.ToString("yyyy-MM-dd");
                 mysql += "', FACTURE = '";
                mysql += this.facture;
                mysql += "' WHERE NO_COMMAND = '" + this.noCommande + "';";
                dt = DbInterface.Lecture(mysql, err);

            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }

        public void ajouterCommande()
        {
            DataTable dt;
            sErreurs err = new sErreurs("", "");

            String mysql;
            try
            {
                // enregistrer les détails de l'article
                mysql = "INSERT INTO COMMANDES (NO_COMMAND, NO_CLIENT, NO_VENDEUR, FACTURE, DATE_CDE) VALUES ('";
                mysql += this.noCommande;
                mysql += "', '";
                mysql += this.client.NoCl;
                mysql += "', '";
                mysql += this.vendeur.NoVendeur;
                mysql += "', '";
                mysql += this.facture;
                mysql += "', '";
                mysql += this.dateCommande.ToString("yyyy-MM-dd");
                mysql += "');";
                dt = DbInterface.Lecture(mysql, err);

            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }

        public void suppCmd(int[] noCmd)
        {
            DataTable dt;

            sErreurs err = new sErreurs("", "");

            try
            {
                    for (int i= 0;i < noCmd.Length; i++)
                    {
                        String mysql1 = "DELETE FROM detail_cde WHERE NO_COMMAND = " + noCmd[i];
                        dt = DbInterface.Lecture(mysql1, err);
                        String mysql2 = "DELETE FROM commandes WHERE NO_COMMAND = " + noCmd[i];
                        dt = DbInterface.Lecture(mysql2, err);

                    }
                
            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }
    }
}
