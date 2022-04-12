﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SicilyAPP.DAL
{
    class ConnectionSql
    {
        private static ConnectionSql connection = null;

        private MySqlConnection oleCn;

        private static readonly object mylock = new object();

        private string connString;


        private ConnectionSql(string unProvider, string uneDataBase, string unUid, string unMdp)
        {


            try
            {
                connString = "SERVER=" + unProvider + ";" + "DATABASE=" +
                uneDataBase + ";" + "UID=" + unUid + ";" + "PASSWORD=" + unMdp + ";";
                try
                {
                    oleCn = new MySqlConnection(connString);
                }
                catch (Exception emp)
                {
                    throw (emp);
                }
            }
            catch (Exception emp)
            {
                throw (emp);
            }



        }



        /**
         * méthode de création d'une instance de connexion si elle n'existe pas (singleton)
         */
        public static ConnectionSql getInstance(string unProvider, string uneDataBase, string unUid, string unMdp)
        {

            //       lock ((mylock))
            //    {

            try
            {


                if (null == connection)
                { // Premier appel
                    connection = new ConnectionSql(unProvider, uneDataBase, unUid, unMdp);


                }

            }
            catch (Exception emp)
            {
                throw (emp);


            }
            return connection;

            //  }
        }





        /**
         * Ouverture de la connexion
         */
        public void openConnection()
        {

            if (oleCn.State == System.Data.ConnectionState.Closed)
                oleCn.Open();
        }

        //Close connection
        public void closeConnection()
        {
            if (oleCn.State == System.Data.ConnectionState.Open)
                oleCn.Close();
        }


        public bool isOpen()
        {
            bool res = false;
            if (oleCn.State == System.Data.ConnectionState.Open) { res = true; }

            return (res);
        }

        /**
         * Fermeture de la connexion
         */


        /**
         * Exécutiuon d'une requête
         */
        public MySqlCommand reqExec(string req)
        {
            MySqlCommand mysqlCom = new MySqlCommand(req, this.oleCn);
            return (mysqlCom);
        }
    }
}
