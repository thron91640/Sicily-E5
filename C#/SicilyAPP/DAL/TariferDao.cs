using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SicilyAPP.Modele;

namespace SicilyAPP.DAL
{
    class TariferDao
    {
        private Liaison li;

        private ConnectionSql maConnexionSql;




        private MySqlCommand Ocom;

        private LiaisonDao lid;




        public List<Tarifer> getTarifer()
        {

            List<Tarifer> lt = new List<Tarifer>();

            try
            {

                maConnexionSql = ConnectionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("SELECT ta.id, ta.type_id, ta.periode_id, ta.liaison_id, ta.tarif, ty.libelle, p.date_debut, p.date_fin FROM periode p inner join tarifer ta ON p.id = ta.periode_id inner join type ty on ta.type_id = ty.id");

                MySqlDataReader reader = Ocom.ExecuteReader();

                lid = new LiaisonDao();


                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    int type_id = (int)reader.GetValue(1);
                    int periode_id = (int)reader.GetValue(2);
                    int liaison_id = (int)reader.GetValue(3);
                    double tarif = (double)reader.GetValue(4);
                    string libelle = (string)reader.GetValue(5);
                    DateTime dateDebut = (DateTime)reader.GetValue(6);
                    DateTime dateFin = (DateTime)reader.GetValue(7);

                    Tarifer t = new Tarifer(id, type_id, libelle, periode_id, dateDebut, dateFin, liaison_id, tarif);


                    lt.Add(t);



                }

                reader.Close();

                maConnexionSql.closeConnection();


                return (lt);

            }

            catch (Exception emp)
            {

                MessageBox.Show(emp.Message);

            }
            return (lt);
        }


        public List<Tarifer> getTarifer(Liaison li)
        {

            List<Tarifer> ltli = new List<Tarifer>();

            try
            {

                maConnexionSql = ConnectionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);




                maConnexionSql.openConnection();



                Ocom = maConnexionSql.reqExec("SELECT ta.id, ta.type_id, ta.periode_id, ta.liaison_id, ta.tarif, ty.libelle, p.date_debut, p.date_fin FROM periode p inner join tarifer ta ON p.id = ta.periode_id inner join type ty on ta.type_id = ty.id WHERE liaison_id= " + li.Id);

                MySqlDataReader reader = Ocom.ExecuteReader();


                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    int type_id = (int)reader.GetValue(1);
                    int periode_id = (int)reader.GetValue(2);
                    int liaison_id = (int)reader.GetValue(3);
                    double tarif = (double)reader.GetValue(4);
                    string libelle = (string)reader.GetValue(5);
                    DateTime dateDebut = (DateTime)reader.GetValue(6);
                    DateTime dateFin = (DateTime)reader.GetValue(7);

                    Tarifer t = new Tarifer(id, type_id, libelle, periode_id, dateDebut, dateFin, liaison_id, tarif);


                    ltli.Add(t);



                }

                reader.Close();

                maConnexionSql.closeConnection();






            }
            catch (Exception emp)
            {

                throw emp;

            }
            return (ltli);

        }



        public void updateTarif(Tarifer t)
        {
            try
            {

                maConnexionSql = ConnectionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);




                maConnexionSql.openConnection();



                Ocom = maConnexionSql.reqExec("update tarifer set tarif ='" + t.Tarif + "' where id =" + t.Id);
                int i = Ocom.ExecuteNonQuery();


            }
            catch (Exception emp)
            {

                throw emp;

            }
        }
    }
}
