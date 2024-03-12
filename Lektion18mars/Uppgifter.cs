using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion18mars
{
    public class Uppgifter
    {
        public string Uppgift { get; set; }

        public string Datum { get; set; }

        public string Tid { get; set; }

        public Uppgifter(string uppgift, string datum, string tid)
        {
            Uppgift = uppgift;
            Datum = datum;
            Tid = tid;
        }
    }
}
