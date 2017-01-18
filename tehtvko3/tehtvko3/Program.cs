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
            //Tehtävä 1
            //KiukaanLämmitys();
            //Tehtävä 2
            //PesukoneKäyttö();
            //Tehtävä 4
            //VehicleOne();
            //Tehtävä 5
            Opiskelijat();
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
        static void VehicleOne()
        {
            Vehicle Vehicle1 = new tehtvko3.Vehicle();
            Vehicle1.Name = "Booster Prototype";
            Vehicle1.Speed = 310;
            Vehicle1.Tyres = 4;
            Vehicle1.PrintData();
        }
        static void Opiskelijat()
        {
            Opiskelija[] Oppilas = new tehtvko3.Opiskelija[5];
            Oppilas[0].Nimi = "Pasi";
            Oppilas[1].Nimi = "Jyri";
            Oppilas[2].Nimi = "Tytti";
            Oppilas[3].Nimi = "Suvi";
            Oppilas[4].Nimi = "Anssi";
            Oppilas[0].Ryhmä = "7A";
            Oppilas[1].Ryhmä = "7A";
            Oppilas[2].Ryhmä = "7A";
            Oppilas[3].Ryhmä = "8B";
            Oppilas[4].Ryhmä = "8B";
            Oppilas[0].Osoite = "Harju 1A";
            Oppilas[1].Osoite = "Harju 2B";
            Oppilas[2].Osoite = "Viitaniemi 4C";
            Oppilas[3].Osoite = "Harju 2C";
            Oppilas[4].Osoite = "Voionmaa 4A";
            Oppilas[0].Puh = "456875";
            Oppilas[1].Puh = "789456";
            Oppilas[2].Puh = "123456";
            Oppilas[3].Puh = "645987";
            Oppilas[4].Puh = "321654";
            for(int i = 0; i < 5; i++)
            {
                Oppilas[i].NäytäTiedot();
            }
            Console.ReadKey();

        }
    }

}
