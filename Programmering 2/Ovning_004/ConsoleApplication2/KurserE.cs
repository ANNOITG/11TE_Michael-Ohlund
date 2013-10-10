using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class KurserE
    {
        public string kursNamn { get; set; }
        public string kursKod { get; set; }
        public Lärare lärare { get; set; }

        public List<Elev> elever = new List<Elev>();


    }
}
