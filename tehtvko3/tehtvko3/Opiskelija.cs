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

        private string[] strings = new string[100];

        public string this[int i]
        {
            get
            {
                return strings[i];
            }
            set
            {
                strings[i] = value;
            }
        }

        public void NäytäTiedot()
        {
            Console.WriteLine(Nimi + " " +  Ryhmä + " " + Osoite + " " + Puh);
        }
    }
}
