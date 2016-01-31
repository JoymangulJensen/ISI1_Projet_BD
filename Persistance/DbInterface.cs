﻿/*
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

namespace Persistance
{
    public class DbInterface
    {
        /// <summary>
        /// Exécution de la requête demandée en paramètre, req, 
        /// et retour du resultat : un DataTable
        /// Si tout se passe bien la connexion est prête à être fermée
        /// par le client qui utilisera cette connexion
        /// </summary>
        /// <param name="req">RequêteMySql à exécuter</param>
        /// <returns></returns>
        public static DataTable Lecture(String req, sErreurs er)
        {
            MySqlConnection cnx = null;
            try
            {
                cnx = Connexion.getInstance().getConnexion();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = req;
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;

                // Construire le DataSet
                DataSet ds = new DataSet();
                da.Fill(ds, "resultat");
                cnx.Close();

                // Retourner la table
                return (ds.Tables["resultat"]);
            }
            catch (MonException me)
            {
                throw (me);
            }
            catch (Exception e)
            {

                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
            finally
            {
                // S'il y a eu un problème, la connexion
                // peut être encore ouverte, dans ce cas
                // il faut la fermer.                 
                if (cnx != null)
                    cnx.Close();
            }
        }

        /// <summary>
        /// Insertion d'une requête avec OleDb
        /// </summary>
        /// <param name="requete"></param>
        public void Insertion_Donnees(String requete)
        {
            MySqlConnection cnx = null;
            try
            {
                // On ouvre une transaction 
                cnx = Connexion.getInstance().getConnexion();
                MySqlTransaction OleTrans = cnx.BeginTransaction();
                MySqlCommand OleCmd = new MySqlCommand();
                OleCmd = cnx.CreateCommand();
                OleCmd.Transaction = OleTrans;
                OleCmd.CommandText = requete;
                OleCmd.ExecuteNonQuery();
                OleTrans.Commit();
            }
            catch (MySqlException uneException)
            {
                throw new MonException(uneException.Message, "Insertion", "SQL");
            }
        }

        public void Suppression_Donnees(String requete)
        {
            MySqlConnection cnx = null;
            try
            {
                // On ouvre une transaction 
                cnx = Connexion.getInstance().getConnexion();
                MySqlTransaction OleTrans = cnx.BeginTransaction();
                MySqlCommand OleCmd = new MySqlCommand();
                OleCmd = cnx.CreateCommand();
                OleCmd.Transaction = OleTrans;
                OleCmd.CommandText = requete;
                OleCmd.ExecuteNonQuery();
                OleTrans.Commit();
            }
            catch (MySqlException uneException)
            {
                throw new MonException(uneException.Message, "Suppression", "SQL");
            }
        }
    }
}
