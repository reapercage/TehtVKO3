using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko3
{
    class Opiskelija
    {
        public String Nimi { get; set; }
        public String Ryhmä { get; set; }
        public String Osoite { get; set; }
        public String Puh { get; set; }
        /*
         * Tunnus
         * ikä
         * email
         * */

        /*private string[] nimet = new string[5];

        public string this[int i]
        {
            get
            {
                return nimet[i];
            }
            set
            {
                nimet[i] = value;
            }
        }*/
        public Opiskelija(string nimi, string ryhmä, string osoite, string puh)
        {
            Nimi = nimi;
            Ryhmä = ryhmä;
            Osoite = osoite;
            Puh = puh;
        }
        //konstruktori
        public Opiskelija()
        {

        }

        public void NäytäTiedot()
        {
            //Parempi ratkaisu palauttaa String
            Console.WriteLine(Nimi + " " +  Ryhmä + " " + Osoite + " " + Puh);
        }
    }
}
