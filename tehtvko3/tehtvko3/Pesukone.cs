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
        public int Lämpö { get; set; }
        public bool Linkous { get; set; }
        int kierrokset;

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
    }
}
