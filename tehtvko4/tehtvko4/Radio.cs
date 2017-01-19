using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko4
{
    class Radio
    {
        private Boolean päällä;
        private int volume;
        private double frequency;

        public Boolean Päällä
        {
            get { return päällä; }
            set { päällä = value; }
        }
        public int Volume
        {
            get { return volume; }
            set {
                volume = value;
                if(volume > 9)
                {
                    volume = 9;
                }
                if(volume < 0)
                {
                    volume = 0;
                }
            }
        }
        public double Frequency
        {
            get { return frequency; }
            set
            {
                frequency = value;
                if(frequency < 2000)
                {
                    frequency = 2000.0;
                }
                if (frequency > 26000)
                {
                    frequency = 26000.0;
                }
            }
        }
        /*arvot
boolean on/off
int volume 0-9
double frequency = 2000.0 - 26000.0

metodit
päälle/pois
volume
tajuusvalinta*/
    }
}
