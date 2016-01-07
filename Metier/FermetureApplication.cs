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
    public class FermetureApplication
    {
        /// <summary>
        /// Déconnexion de la base
        /// </summary>
        static public void getFermeture()
        {
            Connexion.closeConnexion();
        }
    }
}

