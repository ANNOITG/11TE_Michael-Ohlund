using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Elev : Person
    {
        private string klass;
        private List<string> kurserE;

        public Elev()
        {
           
        }
        public Elev(string namn, string adress, string pnr, string telenr, string klass, List<String> kurserE) /*Mycket bra med 2 konstrutorer. */
        {
            setNamn(namn);
            setAdress(adress);
            setPnr(pnr);
            setTelenr(telenr);
            this.klass = klass;
            this.kurserE = kurserE;
        }
        public void betygavlärare(string betyg, Lärare lärare, string kurs)
        {
            string elevkursbetyg = kurs + ":" + betyg + "Lärare:" + lärare;
        }

        public override string ToString()
        {
            return getNamn()+ " " + getPnr()+ " "+ getAdress() + " " + getTelenr() + ".";
        }
    }   
}
