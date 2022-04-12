using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicilyAPP.Controleur;
using SicilyAPP.Modele;
using SicilyAPP.DAL;
using SicilyAPP.Vue;

namespace SicilyAPP.Vue
{
    /// <summary>
    /// class tarif 
    /// </summary>
    public partial class Tarif : Form
    {
        Mgr monManager;
        /// <summary>
        /// liste de tarifer
        /// </summary>
        public List<Tarifer> lstT = new List<Tarifer>();
        /// <summary>
        /// liste de Liaison
        /// </summary>
        public List<Liaison> lstL = new List<Liaison>();
        private Liaison l;
        /// <summary>
        /// class tarif avec une liaison en paramètre
        /// </summary>
        /// <param name="uneLiaison"></param>
        public Tarif(Liaison uneLiaison)
        {
            InitializeComponent();
            monManager = new Mgr();
            this.l = uneLiaison;
        }

        private void Tarif_Load(object sender, EventArgs e)
        {

                lstT = monManager.chargementTDBD(this.l);
                if (lstT.Count != 0) { rafraichirListBox(0); }
            
        }


        private void rafraichirListBox(int index)
        {
            LB1.DataSource = null;
            // lBox.DataSource = lstL.Values.ToList();
            LB1.DataSource = lstT;
            LB1.DisplayMember = "Description";
            LB1.SetSelected(index, true);
        }

        private void LB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = LB1.SelectedIndex;
            if (i != -1)
            {
                Tarifer t = lstT[i];
                TB1.Text = t.Tarif.ToString(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j;
            j = LB1.SelectedIndex;
            if (j != -1)
            {
                Tarifer t = lstT[j];

                t.setTarif(Convert.ToDouble(TB1.Text));
                monManager.updateTarif(t);

            }
            rafraichirListBox(j);
        }
    }
}
