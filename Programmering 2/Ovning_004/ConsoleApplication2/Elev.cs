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
        public string betyg { get; set; }

        public Elev()
        {
           
        }
        public Elev(string namn, string adress, string pnr, string telenr, string klass) /*Mycket bra med 2 konstrutorer. */
        {
            setNamn(namn);
            setAdress(adress);
            setPnr(pnr);
            setTelenr(telenr);
            this.klass = klass;
        }
        public void betygavlärare(string betyg, KurserE kurs)
        {
            kurs.elever.Single(e => e.getPnr() == this.getPnr()).betyg = betyg;
        }

        public override string ToString()
        {
            return getNamn()+ " " + getPnr()+ " "+ getAdress() + " " + getTelenr() + ".";
        }
    }   
}
