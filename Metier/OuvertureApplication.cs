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
using Persistance;
using Utilitaires;

namespace Metier
{
    public class OuvertureApplication
    {
        /// <summary>
        /// Tentative de connexion à la base
        /// </summary>
        /// <returns></returns>
        static public bool getOuverture()
        {
            try
            {
                Connexion macnx = Connexion.getInstance();
                MySqlConnection mysqlcnx = macnx.getConnexion();
                return true;
            }
            catch (MonException excep)
            {
                throw excep;
            }
        }
    }
}