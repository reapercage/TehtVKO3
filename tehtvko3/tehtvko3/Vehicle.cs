using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko3
{
    class Vehicle
    {
        public String Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Name: " + Name +
            " Speed: " + System.Convert.ToString(Speed) +
            " Tyres: " + System.Convert.ToString(Tyres));
            Console.ReadKey();
        }
    }
}
