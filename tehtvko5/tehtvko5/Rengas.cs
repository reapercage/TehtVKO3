using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko5
{
    class Rengas
    {
        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public string Rengaskoko { get; set; }
        public Rengas()
        {

        }
        public override string ToString()
        {
            return "Valmistaja: " + Valmistaja + " Malli: " + Malli + " Rengaskoko: " + Rengaskoko;
        }
    }
}
