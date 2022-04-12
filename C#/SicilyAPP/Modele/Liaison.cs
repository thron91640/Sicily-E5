using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyAPP.Modele
{
    /// <summary>
    /// class Liaison
    /// </summary>
    [Serializable]
    public class Liaison
    {
        private int id;
        private TimeSpan duree;
        private int port_depart_id;
        private int port_arrivee_id;
        private string nom_port_arrivee;
        private string nom_port_depart;
        /// <summary>
        /// get-set id
        /// </summary>
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// get-set Duree
        /// </summary>
        public TimeSpan Duree { get => duree; set => duree = value; }
        /// <summary>
        /// get-set Port_depart_id
        /// </summary>
        public int Port_depart_id { get => port_depart_id; set => port_depart_id = value; }
        /// <summary>
        /// get-set Port_arrivee_id
        /// </summary>
        public int Port_arrivee_id { get => port_arrivee_id; set => port_arrivee_id = value; }
        /// <summary>
        /// get-set Nom_port_arrivee
        /// </summary>
        public string Nom_port_arrivee { get => nom_port_arrivee; set => nom_port_arrivee = value; }
        /// <summary>
        /// get-set Nom_port_depart
        /// </summary>
        public string Nom_port_depart { get => nom_port_depart; set => nom_port_depart = value; }

        /// <summary>
        /// class liaison surcharger
        /// </summary>
        /// <param name="id"></param>
        /// <param name="duree"></param>
        /// <param name="port_depart_id"></param>
        /// <param name="port_arrivee_id"></param>
        /// <param name="nomA"></param>
        /// <param name="nomD"></param>
        public Liaison(int id, TimeSpan duree, int port_depart_id, int port_arrivee_id, string nomA, string nomD)
        {
            this.id=id;
            this.duree=duree;
            this.port_depart_id=port_depart_id;
            this.port_arrivee_id=port_arrivee_id;
            this.nom_port_arrivee = nomA;
            this.nom_port_depart = nomD;
        }
        /// <summary>
        /// class liaison initialisé
        /// </summary>
        public Liaison()
        {

        }
        /// <summary>
        /// toString liaison
        /// </summary>
        /// <returns></returns>
        public override string ToString()

        {
            return ("La liaison numéro : "+this.id + " correspond aux port de départ : " + this.nom_port_depart + " et aux port d'arrivé : " + this.nom_port_arrivee + ", d'une durée de : " + this.duree);
        }

        /// <summary>
        /// setDuree
        /// </summary>
        /// <param name="heure"></param>
        public void setDuree(TimeSpan heure)
        {
            duree = heure;
        }




    }
}
