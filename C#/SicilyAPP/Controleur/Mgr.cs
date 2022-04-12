using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SicilyAPP.DAL;
using SicilyAPP.Modele;

namespace SicilyAPP.Controleur
{
    class Mgr
    {
        LiaisonDao Ld = new LiaisonDao();
        TariferDao Td = new TariferDao();



        // fonction pour la classe Liaison
        public List<Liaison> chargementLDBD()
        {
            return Ld.getLiaisons();
        }

        public void updateDuree(Liaison l)
        {
            Ld.updateLiaison(l);
        }

        public void suppLiaison(Liaison l)
        {
            Ld.suppLiaison(l);
        }


        // fonction pour la classe Tarifer
        public List<Tarifer> chargementTDBD()
        {
            return Td.getTarifer();
        }

        public List<Tarifer> chargementTDBD(Liaison li)
        {
            return Td.getTarifer(li);
        }

        public void updateTarif(Tarifer t)
        {
            Td.updateTarif(t);
        }

        public void insertLiaison(TimeSpan duree, string nomPortDepart, string nomPortArrivee)
        {
            Ld.insertLiaison(duree, nomPortDepart, nomPortArrivee);
        }

        public void remplir2CB(ComboBox cb)
        {
            Ld.remplirCB(cb);
        }

    }
}
