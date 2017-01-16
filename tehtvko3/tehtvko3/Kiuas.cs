using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko3
{
    public class Kiuas
    {
        public bool Päällä { get; set; }
        public double Lämpötila { get; set; }
        //public double Kosteus { get; set; }
        double kosteus;
        //float kosteus;
        public double Kosteus
        {
            get { return kosteus; }
            set
            {
                kosteus = value;
                if (kosteus < 0 || kosteus > 100)
                {
                    kosteus = 0;
                }
            }

        }

    }
}
