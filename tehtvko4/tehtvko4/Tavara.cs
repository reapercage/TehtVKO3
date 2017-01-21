using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko4
{
    class Tavara
    {
        private string nimi;
        private string tyyppi;

        public String Nimi { get; set; }
        public String Tyyppi
        {
            get
            {
                return tyyppi;
            }
            set
            {
                if (value == "media" || value == "laite" || value == "kirja" || value == "lehti")
                {
                    tyyppi = value;
                }
            }
        }

        public Tavara()
        {
        }

        public Tavara(string nimi, string tyyppi)
        {
            Nimi = nimi;
            Tyyppi = tyyppi;
        }

        public void TavaraMetodi()
        {

        }

        public override string ToString()
        {
            return Nimi + " " + Tyyppi;
        }
    }
}
