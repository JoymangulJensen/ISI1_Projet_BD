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

namespace Utilitaires
{
    /// <summary>
    /// Diverses fonctions utilisées dans l'application
    /// </summary>
    public class Fonctions
    {
        /// <summary>
        /// Convertir une chaine date de mysql en datetime
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime StringToDate(String dt)
        {
            String[] coupehr = dt.Split(' ');
            String[] coupedt = coupehr[0].Split('/');
            return new DateTime(int.Parse(coupedt[2]), int.Parse(coupedt[1]), int.Parse(coupedt[0]));
        }

        /// <summary>
        /// Convertir une datetime en chaine pour mysql
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static String DateToString(DateTime dt)
        {
            String retour = "";
            retour += dt.Year + "-";
            retour += dt.Month + "-";
            retour += dt.Day + " ";
            retour += dt.Hour + ":";
            retour += dt.Minute + ":";
            retour += dt.Second;
            return retour;
        }
    }
}
