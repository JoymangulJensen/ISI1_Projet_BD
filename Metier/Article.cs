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
using Persistance;

namespace Metier
{
    public class Article
    {
        private String no_article;
        private String lib_article;
        private String qte_dispo;
        private String ville_art;
        private String prix_art;
        private String interrompu;

        /// <summary>
        /// Initialisation
        /// </summary>
        public Article()
        {
            no_article = lib_article = ville_art = interrompu = "";
            qte_dispo = "0";
            prix_art = "0";
        }

        public String No_article
        {
            get { return no_article; }
            set { no_article = value; }
        }
        public String Lib_article
        {
            get { return lib_article; }
            set { lib_article = value; }
        }
        public String Qte_dispo
        {
            get { return qte_dispo; }
            set { qte_dispo = value; }
        }
        public String Ville_art
        {
            get { return ville_art; }
            set { ville_art = value; }
        }
        public String Prix_art
        {
            get { return prix_art; }
            set { prix_art = value; }
        }
        public String Interrompu
        {
            get { return interrompu; }
            set { interrompu = value; }
        }

        /// <summary>
        /// Augmenter ou diminuer tous les prix
        /// </summary>
        /// <param name="pourcentage"></param>
        public static void ModifierPrix(String pourcentage)
        {
            ModifierPrixHelper(pourcentage, true);
        }

        private static bool ModifierPrixHelper(String pourcentage, bool procedure_ok)
        {
            DataTable dt;
            sErreurs err = new sErreurs("", "");

            String mysql;
            try
            {

                /*
                 * Code SQL de création de la procédure stockée :
                 
                 CREATE PROCEDURE `modifier_prix` ( IN `pourcentage` INT )
                 COMMENT 'Augmenter ou diminuer les prix d''un pourcentage.' NOT DETERMINISTIC MODIFIES SQL DATA SQL SECURITY DEFINER
                 BEGIN
                    UPDATE articles SET prix_art = prix_art * ( 1 + pourcentage /100 );
                 END
                 
                */
                
                if (procedure_ok)
                {
                    // appel de la procédure stockée
                    mysql = "CALL modifier_prix(" + pourcentage + ");";
                }
                else
                {
                    // mais si la procédure n'existe pas ...
                    mysql = "UPDATE articles SET prix_art = prix_art * ( 1 + "+pourcentage+" /100 );";
                }

                dt = DbInterface.Lecture(mysql, err);
            }
            catch (MonException erreur)
            {
                if (procedure_ok)
                {
                    return ModifierPrixHelper(pourcentage, false); // On réessaie sans la procédure stockée
                }
                // Une erreur ne concernant pas la procedure stockée a été rencontrée
                erreur.MsgUtilisateur += "Une erreur est intervenue lors de la mise à jour des prix des articles ";
                throw erreur;
            }

            return true;
        }

        /// <summary>
        /// Augmenter ou diminuer tous les prix en appelant la procédure stockée
        /// </summary>
        /// <param name="pourcentage"></param>
        public static void AugmenterPrix(String pourcentage)
        {
            AugmenterPrixHelper(pourcentage, true);
        }

        /// <summary>
        /// Utilitaire permettant d'augmenter ou de diminuer tous les prix des articles
        /// </summary>
        /// <param name="pourcentage"></param>
        /// <param name="procedure_ok">Indique si une erreur est intervenue ou non lors de l'execution de la requète</param>
        private static bool AugmenterPrixHelper(String pourcentage, bool procedure_ok)
        {
            DataTable dt;
            sErreurs err = new sErreurs("", "");

            String mysql;
            try
            {

                /*
                 * Code SQL de création de la procédure stockée :
                 
                 CREATE DEFINER=`root`@`localhost` PROCEDURE articles_augm_prix(IN augmente DOUBLE)
                BEGIN
	                DECLARE done INT DEFAULT 0; #Permet de controler si on est arrivé à la fin du curseur
                        DECLARE var_no CHAR(6);
                        DECLARE var_prix DECIMAL(8,2);
                        DECLARE curseur1 CURSOR FOR SELECT NO_ARTICLE, PRIX_ART FROM ARTICLES;
	                DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET done = 1;
                        OPEN curseur1; # ouverture du curseur1
                        REPEAT
                                FETCH curseur1 INTO var_no, var_prix;
                
                                IF done = 0 THEN
                	                SET var_prix:= var_prix * augmente;
                                        UPDATE ARTICLES SET PRIX_ART = var_prix WHERE NO_ARTICLE = var_no;
                                END IF;
                        UNTIL done
                        END REPEAT;
 
                        CLOSE curseur1; # fermeture du curseur1
                END

                 
                */

                if (procedure_ok)
                {
                    // appel de la procédure stockée
                    mysql = "CALL articles_augm_prix(1 + " + pourcentage + " / 100 );";
                }
                else
                {
                    // mais si la procédure n'existe pas 
                    mysql = "UPDATE articles SET prix_art = prix_art * ( 1 + "+pourcentage+" /100 );";
                }
                
                dt = DbInterface.Lecture(mysql, err);
            }
            catch (MonException erreur)
            {
                if (procedure_ok)
                {
                    return AugmenterPrixHelper(pourcentage, false); // On réessaie sans la procédure stockée
                }
                // Une erreur ne concernant pas la procedure stockée a été rencontrée
                erreur.MsgUtilisateur += "Une erreur est intervenue lors de la mise à jour des prix des articles ";
                throw erreur;
            }
            return true;
        }

        /// <summary>
        /// Récupérer la liste des articles
        /// </summary>
        /// <param name="tri">champ de tri</param>
        /// <param name="ordre">sens du tri</param>
        /// <returns>lste d'articles</returns>
        public List<Article> getLesArticles(String tri = "NO_ARTICLE", String ordre = "ASC")
        {
            DataTable dt;
            sErreurs err = new sErreurs("", "");
            //MySqlConnection cnx = Connexion.getInstance().getConnexion();

            String mysql = "SELECT NO_ARTICLE, LIB_ARTICLE, QTE_DISPO, VILLE_ART, PRIX_ART, INTERROMPU ";
            mysql += "FROM ARTICLES ";
            mysql += "ORDER BY " + tri + " " + ordre;
            try
            {
                dt = DbInterface.Lecture(mysql, err);
                List<Article> mesArt = new List<Article>();
                foreach (DataRow dataRow in dt.Rows)
                {
                    Article unart = new Article();
                    unart.no_article = dataRow[0].ToString();
                    unart.lib_article = dataRow[1].ToString();
                    unart.qte_dispo = dataRow[2].ToString();
                    unart.ville_art = dataRow[3].ToString();
                    unart.prix_art = dataRow[4].ToString();
                    unart.interrompu = dataRow[5].ToString();

                    mesArt.Add(unart);
                }
                return mesArt;
            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }

        /// <summary>
        /// Détermine si un numéro d'article est libre ou déjà utilisé
        /// </summary>
        /// <param name="no">numéro d'article</param>
        /// <returns>booléen</returns>
        public bool NumeroLibre(String no)
        {
            List<Article> tous = getLesArticles();
            foreach (Article art in tous)
                if (art.no_article == no)
                    return false;
            return true;
        }

        /// <summary>
        /// Ajouter l'article courant dans la base de données
        /// </summary>
        public void ajouterArticle()
        {
            DataTable dt;
            sErreurs err = new sErreurs("", "");

            String mysql;
            try
            {
                // enregistrer les détails de l'article
                mysql = "INSERT INTO ARTICLES (NO_ARTICLE, LIB_ARTICLE, QTE_DISPO, VILLE_ART, PRIX_ART, INTERROMPU) VALUES ('";
                mysql += this.no_article;
                mysql += "', '";
                mysql += this.lib_article;
                mysql += "', '";
                mysql += this.qte_dispo;
                mysql += "', '";
                mysql += this.ville_art;
                mysql += "', '";
                mysql += this.prix_art;
                mysql += "', '";
                mysql += this.interrompu;
                mysql += "');";
                dt = DbInterface.Lecture(mysql, err);

            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }

        /// <summary>
        /// Modifier les informations de l'article courant dans la base de données
        /// </summary>
        public void modifierArticle()
        {
            DataTable dt;
            sErreurs err = new sErreurs("", "");

            String mysql;
            try
            {
                // actualiser les infoamtions dans la base
                mysql = "UPDATE ARTICLES SET LIB_ARTICLE = '";
                mysql += this.lib_article;
                mysql += "', QTE_DISPO = '";
                mysql += this.qte_dispo;
                mysql += "', VILLE_ART = '";
                mysql += this.ville_art;
                mysql += "', PRIX_ART = '";
                mysql += this.prix_art;
                mysql += "', INTERROMPU = '";
                mysql += this.interrompu;
                mysql += "' WHERE NO_ARTICLE = '" + this.no_article + "';";
                dt = DbInterface.Lecture(mysql, err);

            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }

        /// <summary>
        /// Rechercher un article d'après son numéro
        /// </summary>
        /// <param name="no_cmd">Numéro de l'article</param>
        /// <returns>article courante</returns>
        public Article RechercheArticle(String no_art)
        {

            String mysql;
            DataTable dt;
            sErreurs er = new sErreurs("Erreur sur recherche d'un article.", "Article.RechercheArticle()");
            try
            {

                mysql = "SELECT NO_ARTICLE, LIB_ARTICLE, QTE_DISPO, VILLE_ART, PRIX_ART, INTERROMPU ";
                mysql += "FROM ARTICLES ";
                mysql += "WHERE NO_ARTICLE = '" + no_art + "'";
                dt = DbInterface.Lecture(mysql, er);

                if (dt.IsInitialized)
                {
                    DataRow dataRow = dt.Rows[0];
                   
                    this.no_article = dataRow[0].ToString();
                    this.lib_article = dataRow[1].ToString();
                    this.qte_dispo = dataRow[2].ToString();
                    this.ville_art = dataRow[3].ToString();
                    this.prix_art = dataRow[4].ToString();
                    this.interrompu = dataRow[5].ToString();

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
