using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko4
{
    class Kitaravahvistin
    {
        private int volume;
        private int low;
        private int mid;
        private int high;
        public int Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                if (volume > 10)
                {
                    volume = 10;
                }
                if (volume < 0)
                {
                    volume = 0;
                }

            }
        }
        public int Low
        {
            get { return low; }
            set
            {
                low = value;
                if (low > 10)
                {
                    low = 10;
                }
                if (low < 0)
                {
                    low = 0;
                }

            }
        }
        public int Mid
        {
            get { return mid; }
            set
            {
                mid = value;
                if (mid > 10)
                {
                    mid = 10;
                }
                if (mid < 0)
                {
                    mid = 0;
                }

            }
        }
        public int High
        {
            get { return high; }
            set
            {
                high = value;
                if (high > 10)
                {
                    high = 10;
                }
                if (high < 0)
                {
                    high = 0;
                }

            }
        }
        public Kitaravahvistin()
        {
        }

        public Kitaravahvistin(int volume, int low, int mid, int high)
        {
            Volume = volume;
            Low = low;
            Mid = mid;
            High = high;
        }

        public void KitaravahvistinMetodi()
        {

        }

        public override string ToString()
        {
            return "Kitaravahvistin -- Vol:" + Volume + " Low: " + Low + " Mid: " + Mid + " High: " + High;
        }
    }
}
