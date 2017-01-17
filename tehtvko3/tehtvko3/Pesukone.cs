using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko3
{
    class Pesukone
    {
        public bool Päällä { get; set; }
        public int Kesto { get; set; }
        public bool Linkous { get; set; }
        int kierrokset;
        int pesuohjelma;
        int lämpö;

        //pesuohjelma
        public int LinkousKierrokset
        {
            get { return kierrokset; }
            set
            {
                kierrokset = value;
                if (kierrokset < 0 || kierrokset > 2000)
                {
                    kierrokset = 0;
                }
            }

        }
        public int Ohjelma
        {
            get { return pesuohjelma; }
            set
            {
                pesuohjelma = value;
                if (pesuohjelma < 0 || pesuohjelma > 5)
                {
                    pesuohjelma = 1;
                }
            }

        }
        public int Lämpötila
        {
            get { return lämpö; }
            set
            {
                lämpö = value;
                if (lämpö < 0 || lämpö > 60)
                {
                    lämpö = 0;
                }
            }

        }
    }
}
