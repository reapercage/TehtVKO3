using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko4
{
    class Program
    {
        static void Main(string[] args)
        {
            HissinKäyttö();
        }

        static void HissinKäyttö()
        {
            int h1 = 1;
            Hissi elevator = new Hissi();
            elevator.Kerrokseen = 1;
            Console.WriteLine("Hissi on nyt kerroksessa " + elevator.Kerrokseen + ".");
            Console.Write("Kutsu hissiä kerroksesta > ");
            h1 = System.Convert.ToInt32(Console.ReadLine());
            if(h1 => 1 && h1 =< 5)
            {

            }
            elevator.Kerrokseen = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hissi on nyt kerroksessa " + elevator.Kerrokseen + ".");
            Console.ReadKey();
        }
    }
}
