using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko4
{
    class Hissi
    {
        //int kerros;
        int kerrokseen;
        /*public int Kerros
        {
            get { return kerros; }
            set
            {
                kerros = value;
                if(kerros < 1 || kerros > 5)
                {
                    kerros = 1;
                }
            }

        }*/
        //if kerros on epäkelpo anna uusi kerros else siirry kerrokseen
        public int Kerrokseen
        {
            get { return kerrokseen; }
            set
            {
                kerrokseen = value;
                if (kerrokseen < 1 || kerrokseen > 5)
                {
                    kerrokseen = 1;
                }
            }
        }
    }
}
