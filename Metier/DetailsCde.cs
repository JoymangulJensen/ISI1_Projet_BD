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

       
    }
}
