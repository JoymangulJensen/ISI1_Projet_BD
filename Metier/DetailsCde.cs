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
    public class DetailsCde
    {
        private Article art;
        private String qte_cdee;
        private String livree;
        private String total;

        /// <summary>
        /// Initialisation
        /// </summary>
        public DetailsCde()
        {
            art = new Article();
            total = qte_cdee = "0";
            livree = "F";
        }

        public DetailsCde(Article a, string qt, String liv)
        {
            art = a;
            this.qte_cdee = qt;
            this.livree = liv;
            total = (Convert.ToInt32(qte_cdee) * Convert.ToDouble(art.Prix_art)).ToString();
        }


        public Article Art
        {
            get { return art; }
            set { art = value; }
        }
        public String Qte_cdee
        {
            get { return qte_cdee; }
            set { qte_cdee = value; }
        }
        public String Livree
        {
            get { return livree; }
            set { livree = value; }
        }
        public String Total
        {
            get { return total; }
            set { total = value; }
        }

        public List<DetailsCde> getDetailsCde(String noCmd)
        {
            DataTable dt;
            sErreurs err = new sErreurs("", "");
            //MySqlConnection cnx = Connexion.getInstance().getConnexion();

            String mysql = "SELECT articles.*, detail_cde.QTE_CDEE, detail_cde.LIVREE ";
            mysql += "FROM articles, detail_cde ";
            mysql += "WHERE detail_cde.NO_COMMAND = " + noCmd + " AND articles.NO_ARTICLE = detail_cde.NO_ARTICLE ";
            mysql += "ORDER BY NO_ARTICLE ASC";
            try
            {
                dt = DbInterface.Lecture(mysql, err);
                List<DetailsCde> mesDetails = new List<DetailsCde>();
                foreach (DataRow dataRow in dt.Rows)
                {
                    Article unart = new Article();
                    unart.No_article = dataRow[0].ToString();
                    unart.Lib_article = dataRow[1].ToString();
                    unart.Qte_dispo = dataRow[2].ToString();
                    unart.Ville_art = dataRow[3].ToString();
                    unart.Prix_art = dataRow[4].ToString();
                    unart.Interrompu = dataRow[5].ToString();
                    DetailsCde unDetail = new DetailsCde(unart, dataRow[6].ToString(), dataRow[7].ToString());
                    mesDetails.Add(unDetail);
                }
                return mesDetails;
            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }




    }
}
