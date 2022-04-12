using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SicilyAPP.Modele;


namespace SicilyAPP.DAL
{
    class LiaisonDao
    {


        private ConnectionSql maConnexionSql;
        private List<string> lp = new List<string>();

        private MySqlCommand Ocom;
        int port_depart_id = 0;
        int port_arrivee_id = 0;
        public Liaison getLaison(int unId)
        {

            try
            {
                Liaison Li = new Liaison();



                maConnexionSql = ConnectionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT l.id, l.duree, l.port_depart_id, l.port_arrivee_id, pd.nom, pa.nom from liaison l INNER JOIN port pd on l.port_depart_id = pd.id INNER JOIN port pa on l.port_arrivee_id = pa.id");


                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    int id = (int)reader1.GetValue(0);
                    TimeSpan duree = (TimeSpan)reader1.GetValue(1);
                    int port_depart_id = (int)reader1.GetValue(2);
                    int port_arrivee_id = (int)reader1.GetValue(3);
                    string nom_port_depart = (string)reader1.GetValue(4);
                    string nom_port_arrivee = (string)reader1.GetValue(5);

                    Li = new Liaison(id, duree, port_depart_id, port_arrivee_id, nom_port_arrivee, nom_port_depart);

                    
                }

                

                reader1.Close();

                maConnexionSql.closeConnection();


                return (Li);

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }


        public void suppLiaison(Liaison l)
        {
            try
            {
                maConnexionSql = ConnectionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("delete from secteur where liaison_id="+l.Id+";delete from traversee where liaison_id="+l.Id+"; delete from liaison where id="+l.Id+"; ");


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();
                
                



            }
            catch (Exception emp)
            {

                throw (emp);
            }


        }




        public int getPortDepart(string portDepart)
        {
            
            try
            {
                maConnexionSql = ConnectionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("select port.id from port where port.nom='" + portDepart + "';");

                MySqlDataReader reader2 = Ocom.ExecuteReader();

                while (reader2.Read())
                {
                    int id = (int)reader2.GetValue(0);
                    port_depart_id = id;

                }
                maConnexionSql.closeConnection();

            }
            catch (Exception emp)
            {
                throw (emp);
            }
            return port_depart_id;
        }

        public int getPortArrive(string portArrivee)
        {

            try
            {
                maConnexionSql = ConnectionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("select port.id from port where port.nom='" + portArrivee + "';");

                MySqlDataReader reader2 = Ocom.ExecuteReader();

                while (reader2.Read())
                {
                    int id = (int)reader2.GetValue(0);
                    port_arrivee_id = id;
                }

                maConnexionSql.closeConnection();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
            return port_arrivee_id;
        }





        public void insertLiaison(TimeSpan duree, string portDepart, string portArrivee)
        {
            int idA = getPortArrive(portArrivee);
            int idD = getPortDepart(portDepart);
            try
            {
                maConnexionSql = ConnectionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("insert into liaison(duree, port_depart_id, port_arrivee_id) values('"+ duree + "',"+ idD + ","+ idA + ")");


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();

                
            }
            catch (Exception emp)
            {
                throw (emp);
            }

        }

    
        







        public void updateLiaison(Liaison l)
        {

            try
            {




                maConnexionSql = ConnectionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("update liaison set duree = '" + l.Duree + "' where id = " + l.Id);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }


        public List<Liaison> getLiaisons()
        {

            List<Liaison> li = new List<Liaison>();

            try
            {

                maConnexionSql = ConnectionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT l.id, l.duree, l.port_depart_id, l.port_arrivee_id, pd.nom, pa.nom from liaison l INNER JOIN port pd on l.port_depart_id = pd.id INNER JOIN port pa on l.port_arrivee_id = pa.id");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Liaison l;




                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    TimeSpan duree = (TimeSpan)reader.GetValue(1);
                    int port_depart_id = (int)reader.GetValue(2);
                    int port_arrivee_id = (int)reader.GetValue(3);
                    string nom_port_depart = (string)reader.GetValue(4);
                    string nom_port_arrivee = (string)reader.GetValue(5);

                    l = new Liaison(id, duree, port_depart_id, port_arrivee_id, nom_port_arrivee, nom_port_depart);

                    li.Add(l);


                }



                reader.Close();

                maConnexionSql.closeConnection();


            }




            catch (Exception emp)
            {

                MessageBox.Show(emp.Message);

            }

            return (li);
        }


        public void remplirCB(ComboBox cb)
        {

            try
            {
                maConnexionSql = ConnectionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT nom from port");


                MySqlDataReader reader1 = Ocom.ExecuteReader();


                while (reader1.Read())
                {

                    lp.Add((string)reader1.GetValue(0));
                }
                cb.DataSource = lp;

                lp.Clear();

                reader1.Close();

                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }



    }
}


