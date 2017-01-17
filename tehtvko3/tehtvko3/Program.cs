using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtvko3
{
    class Program
    {
        static void Main(string[] args)
        {
            //KiukaanLämmitys();
            PesukoneKäyttö();
        }
        static void KiukaanLämmitys()
        {
            Kiuas sampo = new tehtvko3.Kiuas();
            sampo.Päällä = false;
            sampo.Lämpötila = 0;
            sampo.Kosteus = 4;
            Console.Write("Laita kiuas päälle painamalla Enter");
            Console.ReadKey();
            sampo.Päällä = true;
            Console.WriteLine();
            if (sampo.Päällä == true)
            {
                Console.WriteLine("Kiuas on nyt päällä.");
            }
            Console.Write("Lisää lämpöä asteina > ");
            double lisäälämpö = 0;
            lisäälämpö = System.Convert.ToDouble(Console.ReadLine());
            sampo.Lämpötila = sampo.Lämpötila + lisäälämpö;
            Console.WriteLine("Kiukaan lämpötila on nyt "
                                + sampo.Lämpötila + " astetta ja ilmankosteus "
                                + sampo.Kosteus + " prosenttia.");
            Console.WriteLine("Lorota vettä kiukaalle > ");
            sampo.Kosteus = sampo.Kosteus + System.Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kiukaan lämpötila on nyt "
                                + sampo.Lämpötila + " astetta ja ilmankosteus "
                                + sampo.Kosteus + " prosenttia.");
            Console.ReadKey();


        }
        static void PesukoneKäyttö()
        {
            Pesukone pertti = new tehtvko3.Pesukone();
            pertti.Päällä = false;
            Console.WriteLine("**** Pesukoneen käyttö ****");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("Valitse pesuohjelma 1-5 > ");
            pertti.Ohjelma = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lämpötila > ");
            pertti.Lämpötila = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Käytetäänkö linkousta (K/E) > ");
            pertti.Lingotaanko = Console.ReadLine();
            Console.WriteLine("Linkouksen nopeus > ");
            pertti.LinkousKierrokset = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pesun kesto > ");
            pertti.Pesunkesto = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Käynnistä pesukone (K/E) > ");
            pertti.Käynnistä = Console.ReadLine();
            Console.ReadKey();

        }
    }

}
