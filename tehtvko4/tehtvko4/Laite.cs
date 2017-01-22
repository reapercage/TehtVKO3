using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko4
{
    class Laite : Tavara
    {
        private string mikäLaite;
        private string valmistaja;

        public string MikäLaite
        {
            get
            {
                return mikäLaite;
            }
            set
            {
                if (value == "kännykkä" || value == "tabletti" || value == "kannettava" || value == "stereot")
                {
                    mikäLaite = value;
                }
            }
        }
        public string Valmistaja {
            get
            {
                return valmistaja;
            }
            set
            {
                valmistaja = value;
            }
        }

        public Laite()
        {
        }
        public Laite(string nimi, string tyyppi, string mikäLaite, string valmistaja)
            : base(nimi,tyyppi)
        {
            MikäLaite = mikäLaite;
            Valmistaja = valmistaja;
        }
        
        //luokan metodi
        public void LaiteMetodi()
        {

        }

        public override string ToString()
        {
            return base.ToString() + " " + mikäLaite + " " + valmistaja;
        }
    }
}
