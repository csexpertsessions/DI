using ConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //opret en ny kontakt
            Kontakt k = new Kontakt();
            Console.WriteLine("Indtast navn:");
            k.Navn = Console.ReadLine();
            Console.WriteLine("Indtast email:");
            k.Email = Console.ReadLine();
            k.OprettelsesDato = DateTime.Now;

            //Instansier repository
            DataRepository rep = new DataRepository();
            rep.OpretKontakt(k);

            Console.WriteLine("Kontakter:");
            Console.WriteLine("-------------------------------------------");
            foreach (var item in rep.HentKntakter())
            {
                Console.WriteLine($"({item.KontaktId}) {item.Navn} - {item.Email}");
            }
            Console.WriteLine("-------------------------------------------");
            Console.ReadLine();

        }
    }
}
