using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko4
{
    class Vahvistin
    {
        int volume;
        //lisää voimakkuutta
        //vähennä voimakkuutta
        //on/off
        public int Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                if(volume > 100)
                {
                    volume = 100;
                }
                if (volume < 0)
                {
                    volume = 0;
                }

            }
        }
    }
}
