using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko4
{
    class Media : Tavara
    {
        private String muoto;
        private String sisältö;

        public String Muoto
        {
            get
            {
                return muoto;
            }
            set
            {
                if (value == "cd" || value == "dvd" || value == "bluray" || value == "muistitikku")
                {
                    muoto = value;
                }
            }
        }
        public String Sisältö
        {
            get
            {
                return sisältö;
            }
            set
            {
                if (value == "musiikki" || value == "elokuva" || value == "data")
                {
                    sisältö = value;
                }
            }
        }

        //konstruktori
        public Media()
        {
        }
        //konstruktori parametreillä
        public Media(string nimi, string tyyppi, string muoto, string sisältö)
            : base(nimi,tyyppi)
        {
            Muoto = muoto;
            Sisältö = sisältö;
        }

        //luokan metodi
        public void MediaMetodi()
        {

        }

        public override string ToString()
        {
            return base.ToString() + " " + muoto + " " + sisältö;
        }

    }
}
