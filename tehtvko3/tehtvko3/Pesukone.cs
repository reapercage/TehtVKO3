using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko3
{
    class Pesukone
    {
        public int Kesto { get; set; }
        public bool Linkous { get; set; }
        public bool Päällä { get; set; }
        int kierrokset;
        int pesuohjelma;
        int lämpö;
        string linko;
        int kesto;
        string käynnistys;

        //pesuohjelma
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
        public string Lingotaanko
        {
            get { return linko; }
            set
            {
                linko = value;
                if (linko == "K" || linko == "k")
                {
                    Linkous = true;
                }
                else
                {
                    Linkous = false;
                }
            }
        }
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
        public int Pesunkesto
        {
            get { return kesto; }
            set
            {
                kesto = value;
                if (kesto < 0 || kesto > 60)
                {
                    kesto = 0;
                }
            }

        }
        public string Käynnistä
        {
            get { return käynnistys; }
            set
            {
                käynnistys = value;
                if (linko == "K" || linko == "k")
                {
                    Päällä = true;
                }
                else
                {
                    Päällä = false;
                }
            }

        }
    }
    }
}
