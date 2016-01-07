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
    public class Vendeur
    {
        private String noVendeur;
        private String noChef;
        private String nomVend;
        private String prenomVend;
        private DateTime dateEmbau;
        private String villeVend;
        private double salaireVend;
        private double commission;

        /// <summary>
        /// Initialisation avec les paramètres
        /// </summary>
        public Vendeur(String noVendeur, String nomVend, String prenomVend,
            DateTime dateEmbau, String villeVend, double salaireVend,
            double commission)
        {
            this.noVendeur = noVendeur;
            this.nomVend = nomVend;
            this.prenomVend = prenomVend;
            this.dateEmbau = dateEmbau;
            this.villeVend = villeVend;
            this.salaireVend = salaireVend;
            this.commission = commission;
        }

        public Vendeur()
        {
            this.noVendeur = "";
            this.nomVend = "";
            this.prenomVend = "";
            this.noChef = "";
            this.dateEmbau = new DateTime();
            this.villeVend = "";
            this.salaireVend = 0;
            this.commission = 0;
        }

        public String NoVendeur
        {
            get { return noVendeur; }
            set { noVendeur = value; }
        }
        public String NoChef
        {
            get { return noChef; }
            set { noChef = value; }
        }
        public String NomVend
        {
            get { return nomVend; }
            set { nomVend = value; }
        }
        public String PrenomVend
        {
            get { return prenomVend; }
            set { prenomVend = value; }
        }
        public DateTime DateEmbau
        {
            get { return dateEmbau; }
            set { dateEmbau = value; }
        }
        public String VilleVend
        {
            get { return villeVend; }
            set { villeVend = value; }
        }
        public double SalaireVend
        {
            get { return salaireVend; }
            set { salaireVend = value; }
        }
        public double Commission
        {
            get { return commission; }
            set { commission = value; }
        }

        /// <summary>
        /// Lister les venderus de la base
        /// </summary>
        /// <returns>liste de vendeurs</returns>
        public List<String> LectureNoVendeur()
        {
            List<String> mesNumeros = new List<String>();
            DataTable dt;
            sErreurs er = new sErreurs("Erreur sur lecture du vendeur.", "Vendeur.LectureNoVendeur()");
            try
            {

                String mysql = "SELECT DISTINCT NO_VENDEUR FROM VENDEUR ORDER BY NO_VENDEUR";
                dt = DbInterface.Lecture(mysql, er);

                foreach (DataRow dataRow in dt.Rows)
                {
                    mesNumeros.Add((dataRow[0]).ToString());
                }

                return mesNumeros;
            }
            catch (MySqlException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        /// <summary>
        /// Cherhcer les informations d'un vendeur d'après son numéro
        /// </summary>
        /// <param name="numVen"></param>
        /// <returns></returns>
        public Vendeur RechercheUnVendeur(String numVen)
        {

            String mysql;
            DataTable dt;
            sErreurs er = new sErreurs("Erreur sur recherche d'un vendeur.", "Vendeur.RechercheUnVendeur()");
            try
            {

                mysql = "SELECT NO_VEND_CHEF_EQ, NOM_VEND, PRENOM_VEND,";
                mysql += "DATE_EMBAU, VILLE_VEND, SALAIRE_VEND, COMMISSION ";
                mysql += "FROM VENDEUR WHERE NO_VENDEUR='" + numVen + "'";
                dt = DbInterface.Lecture(mysql, er);

                if (dt.IsInitialized)
                {
                    DataRow dataRow = dt.Rows[0];
                    this.noVendeur = numVen;
                    this.noChef = dataRow[0].ToString();
                    this.nomVend = dataRow[1].ToString();
                    this.prenomVend = dataRow[2].ToString();
                    this.dateEmbau = Fonctions.StringToDate(dataRow[3].ToString());
                    this.villeVend = dataRow[4].ToString();
                    this.salaireVend = double.Parse(dataRow[5].ToString());
                    this.commission = double.Parse(dataRow[6].ToString());

                    return this;
                }
                else
                    return null;
            }
            catch (MySqlException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }
    }
}
