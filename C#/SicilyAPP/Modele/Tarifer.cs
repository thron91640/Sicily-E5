using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyAPP.Modele
{
    /// <summary>
    /// class tarifer
    /// </summary>
    [Serializable]
    public class Tarifer
    {
        private int id;
        private int type_id;
        private string type;
        private int periode_id;
        private DateTime dateDebut;
        private DateTime dateFin;
        private int liaison_id;
        private double tarif;
        /// <summary>
        /// 
        /// </summary>
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// 
        /// </summary>
        public int Type_id { get => type_id; set => type_id = value; }
        /// <summary>
        /// 
        /// </summary>
        public int Periode_id { get => periode_id; set => periode_id = value; }
        /// <summary>
        /// 
        /// </summary>
        public int Liaison_id { get => liaison_id; set => liaison_id = value; }
        /// <summary>
        /// 
        /// </summary>
        public double Tarif { get => tarif; set => tarif = value; }
        /// <summary>
        /// 
        /// </summary>
        public string Type { get => type; set => type = value; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
        /// <summary>
        /// class tarifer surcharger
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type_id"></param>
        /// <param name="type"></param>
        /// <param name="periode_id"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="liaison_id"></param>
        /// <param name="tarif"></param>
        public Tarifer(int id, int type_id,string type, int periode_id, DateTime dateDebut, DateTime dateFin, int liaison_id, double tarif)
        {
            this.id=id;
            this.type_id=type_id;
            this.type = type;
            this.periode_id=periode_id;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.liaison_id=liaison_id;
            this.tarif=tarif;
        }
        /// <summary>
        /// class tarifer initialisé
        /// </summary>
        public Tarifer()
        {

        }
        /// <summary>
        /// Tostring de tarifer
        /// </summary>
        /// <returns></returns>
        public override string ToString()

        {
            return ("Le tarif pour la liaison numéro : " + this.liaison_id + ", le type : " + this.type + ",la période du : " + this.dateDebut.ToString("yyyy-MM-dd") + " au :" + this.dateFin.ToString("yyyy-MM-dd") + " est de : " + this.tarif);
        }
        /// <summary>
        /// set Tarif
        /// </summary>
        /// <param name="tarif"></param>
        public void setTarif(double tarif)
        {
            this.tarif = tarif;
        }
    }
}
