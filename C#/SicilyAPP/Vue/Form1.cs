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
namespace SicilyAPP
{
    public partial class Form1 : Form
    {
        Mgr monManager;
        /// <summary>
        /// liste de tarifer
        /// </summary>
        public List<Tarifer> lstT = new List<Tarifer>();
        /// <summary>
        /// liste de liaison
        /// </summary>
        public List<Liaison> lstL = new List<Liaison>();



        /// <summary>
        /// public form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            monManager = new Mgr();
        }





        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lBox.SelectedIndex;
            if (i != -1)
            {
                Liaison li = lstL[i];
                TB1.Text = li.Port_depart_id.ToString();
                TB2.Text = li.Port_arrivee_id.ToString();
                TB3.Text = li.Duree.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstL = monManager.chargementLDBD();

            if (lstL.Count != 0) { rafraichirListBox(0); }


            monManager.remplir2CB(CB1);
            monManager.remplir2CB(CB2);
            
        }


        private void rafraichirListBox(int index)
        {

            lBox.DataSource = null;
            // lBox.DataSource = lstL.Values.ToList();
            lBox.DataSource = lstL;
            lBox.DisplayMember = "Description";
            lBox.SetSelected(index, true);

        }
        private void rafraichirListBox()
        {

            lBox.DataSource = null;
            // lBox.DataSource = lstL.Values.ToList();
            lBox.DataSource = lstL;
            lBox.DisplayMember = "Description";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j;
            j = lBox.SelectedIndex;
            if (j != -1)
            {
                Liaison l = lstL[j];

                l.setDuree(TimeSpan.Parse(TB3.Text));
                monManager.updateDuree(l);

            }
            rafraichirListBox(j);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int j;
            j = lBox.SelectedIndex;
            if (j != -1)
            {
                Liaison l = lstL[j];
                monManager.suppLiaison(l);

                lstL = monManager.chargementLDBD();
                rafraichirListBox(0);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            monManager.insertLiaison(TimeSpan.Parse(TB4.Text), CB1.Text.ToString(), CB2.Text.ToString());
            lstL = monManager.chargementLDBD();
            rafraichirListBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            int i;

            i = lBox.SelectedIndex;

            Liaison l = lstL[i];

            Tarif t = new Tarif(l);
            t.ShowDialog();
            monManager.chargementTDBD(l);
            rafraichirListBox(i);
        }
        }
    }

