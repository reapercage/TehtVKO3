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
            KiukaanLämmitys();
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
    }

}
