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
    }
}
