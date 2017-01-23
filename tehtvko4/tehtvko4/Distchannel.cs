using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko4
{
    class Distchannel : Kitaravahvistin
    {
        private int dist;
        public int Dist
        {
            get { return dist; }
            set
            {
                dist = value;
                if (dist > 10)
                {
                    dist = 10;
                }
                if (dist < 0)
                {
                    dist = 0;
                }

            }
        }
        public Distchannel()
        {
        }
        //konstruktori parametreillä
        public Distchannel(int volume, int low, int mid, int high, int dist)
            : base(volume,low,mid,high)
        {
            Dist = dist;
        }

        //luokan metodi
        public void DistchannelMetodi()
        {

        }

        public override string ToString()
        {
            return base.ToString() + " Dist: " + dist;
        }
    }
}
