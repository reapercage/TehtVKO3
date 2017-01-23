using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko5
{
    class Auto
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public List<Rengas> Renkaat { get; }
        private int renkaidenLkm = 0;
        private const int maxRenkaidenLkm = 4;
        //LisäRengas(Rengas rengas)

        public Auto()
        {
            Renkaat = new List<Rengas>();
        }
        public void LisääRengas(Rengas rengas)
        {
            if(renkaidenLkm < maxRenkaidenLkm)
            {
                Renkaat.Add(rengas);
                renkaidenLkm++;
                Console.WriteLine("Rengas {0} lisätty ajoneuvoon {1}", rengas.Malli, Merkki);

            }
            else
            {
                Console.WriteLine("Ei paikkaa uudelle renkaalle.");
            }
        }
        public override string ToString()
        {
            //string
            return "Merkki: " + Merkki + " Malli: " + Malli;
            //string s = "Autossa: " + Nimi + "malli";
        }
    }
}
