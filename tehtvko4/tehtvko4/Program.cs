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
            //Tehtävä 1
            //HissinKäyttö();
            //Tehtävä 2
            //VahvistimenVoimakkuus();
            //Tehtävä 3
            Työntekijät();
        }

        static void HissinKäyttö()
        {
            Hissi elevator = new Hissi();
            elevator.Vaara = true;
            elevator.Kerrokseen = 1;
            int h1 = 1;
            //if x or X poistu hissistä (door open) else
            while (elevator.Vaara == true)
            {
                Console.WriteLine("Hissi on nyt kerroksessa " + elevator.Kerrokseen + ".");
                Console.Write("Kutsu hissiä kerrokseen > ");
                h1 = System.Convert.ToInt32(Console.ReadLine());
                if(h1 >= 1 && h1 <= 5)
                {
                    elevator.Kerrokseen = h1;
                    elevator.Vaara = false;
                }
                else
                {
                    Console.WriteLine("Kerrosta ei ole olemassa.");
                    elevator.Vaara = true;
                }

            }
            Console.WriteLine("Hissi on nyt kerroksessa " + elevator.Kerrokseen + ".");
            Console.ReadKey();
        }
        static void VahvistimenVoimakkuus()
        {
            Vahvistin vahvari = new Vahvistin();
            vahvari.Volume = 0;
            Console.WriteLine("-- Amplifier --");
            Console.WriteLine("Volume: " + vahvari.Volume);
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Adjust volume (0-100) > ");
                vahvari.Volume = System.Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Volume: " + vahvari.Volume);

            }
            Console.ReadKey();
        }
        static void Työntekijät()
        {

        }
    }
}
