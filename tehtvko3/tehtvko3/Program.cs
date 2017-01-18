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
            Console.WriteLine();
            if (pertti.Päällä == true)
            {
                Console.WriteLine("Pesukone on nyt päällä.");
            }
            else
            {
                Console.WriteLine("Pesukone ei ole päällä.");
            }
            Console.WriteLine("Pesuohjelmaksi on valittu ohjelma " + pertti.Ohjelma + ".");
            Console.WriteLine("Lämpötila on säädetty " + pertti.Lämpötila + " celsius asteeseen.");
            if(pertti.Linkous == true)
            {
                Console.WriteLine("Linkous on käytössä. Linkouksen voimakkuus on " + pertti.LinkousKierrokset + "rpm.");
            }
            else
            {
                Console.WriteLine("Linkous ei ole käytössä.");
            }
            Console.WriteLine("Pesun kesto on " + pertti.Pesunkesto + " min.");
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
            /*Opiskelija oppilas1 = new Opiskelija("Pasi", "7A", "Harju 1A", "456875");
            Opiskelija oppilas2 = new Opiskelija("Jyri", "7A", "Harju 1A", "456875");
            Opiskelija oppilas3 = new Opiskelija("Tytti", "7A", "Harju 1A", "456875");
            Opiskelija oppilas4 = new Opiskelija("Suvi", "7A", "Harju 1A", "456875");
            Opiskelija oppilas5 = new Opiskelija("Anssi", "7A", "Harju 1A", "456875");*/
            Opiskelija[] oppilas = new Opiskelija[5];
            //students[0] = new Student { Fristname = "pökö", };
            //oppilas[0] = new Opiskelija { "Pasi", "7A", "Harju 1A", "456875" };
            oppilas[0].Nimi = "Pasi";
            oppilas[1].Nimi = "Jyri";
            oppilas[2].Nimi = "Tytti";
            oppilas[3].Nimi = "Suvi";
            oppilas[4].Nimi = "Anssi";
            oppilas[0].Ryhmä = "7A";
            oppilas[1].Ryhmä = "7A";
            oppilas[2].Ryhmä = "7A";
            oppilas[3].Ryhmä = "8B";
            oppilas[4].Ryhmä = "8B";
            oppilas[0].Osoite = "Harju 1A";
            oppilas[1].Osoite = "Harju 2B";
            oppilas[2].Osoite = "Viitaniemi 4C";
            oppilas[3].Osoite = "Harju 2C";
            oppilas[4].Osoite = "Voionmaa 4A";
            oppilas[0].Puh = "456875";
            oppilas[1].Puh = "789456";
            oppilas[2].Puh = "123456";
            oppilas[3].Puh = "645987";
            oppilas[4].Puh = "321654";
            for(int i = 0; i < 5; i++)
            {
                oppilas[i].NäytäTiedot();
            }
            Console.ReadKey();

        }
    }

}
