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
            //Tehtävä 3 kesken
            //Työntekijät();
            //Tehtävä 5
            //Radiohead();
            KirjahyllyJärjestykseen();
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
        static void Radiohead()
        {
            Radio pioneer = new Radio();
            pioneer.Päällä = false;
            pioneer.Frequency = 2000.0;
            String onoff;
            String syöte;
            Console.WriteLine("-- Radio --");
            while(pioneer.Päällä == false)
            {
                Console.Write("Turn radio on (ON/OFF) > ");
                onoff = Console.ReadLine();
                if (onoff == "ON" || onoff == "on")
                {
                    Console.WriteLine("Radio is on.");
                    Console.WriteLine("You can turn off the radio anytime by pressing OFF.");
                    pioneer.Päällä = true;
                }
            }
            while(pioneer.Päällä == true)
            {
                Console.Write("Adjust volume (0-9) > ");
                syöte = Console.ReadLine();
                if (syöte == "off" || syöte == "OFF")
                {
                    Console.WriteLine("Radio is turned off.");
                    pioneer.Päällä = false;
                    break;
                }
                else
                {
                    pioneer.Volume = System.Convert.ToInt32(syöte);
                    Console.WriteLine("Volume : " + pioneer.Volume);
                }
                Console.Write("Change frequency (2000.0 - 26000.0) > ");
                syöte = Console.ReadLine();
                if (syöte == "off" || syöte == "OFF")
                {
                    Console.WriteLine("Radio is turned off.");
                    pioneer.Päällä = false;
                    break;
                }
                else
                {
                    //if syöte sisältää piste convert to pilkku
                    pioneer.Frequency = System.Convert.ToDouble(syöte);
                    Console.WriteLine("Frequency : " + pioneer.Frequency);
                }
            }
            //
            Console.ReadKey();
        }
        static void KirjahyllyJärjestykseen()
        {

        }
    }
}
