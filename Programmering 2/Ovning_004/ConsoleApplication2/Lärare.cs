using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Lärare : Person
    {
        private int lon;
        
        public Lärare()
        {
            
        }
        public Lärare(string namn, string adress, string pnr, string telenr, int lon, List<string> kurser)
        {
            setNamn(namn);
            setAdress(adress);
            setPnr(pnr);
            setTelenr(telenr);
            this.kurser = kurser;
            this.lon = lon;
        }

        public void HojLon(int hojning)
        {
            this.lon += hojning;
        }

        public override string ToString()
        {
            return getNamn() + " " + getPnr() + " " + getAdress() + " " + getTelenr() + ".";
        }
    }
}
