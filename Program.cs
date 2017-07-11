using System;
using System.Collections.Generic;
namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Camry");
            Showroom.Add("Avalon");
            Showroom.Add("TL");
            Showroom.Add("Altima");
            
            Console.WriteLine(Showroom.Count);

            Showroom.Add("Altima");

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("GIULIA");
            UsedLot.Add("SPIDER");

            Showroom.UnionWith(UsedLot);

            Console.WriteLine(Showroom.Count);

            Showroom.Remove("TL");

            Console.WriteLine(Showroom.Count);

            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Camry");
            Junkyard.Add("Avalon");
            Junkyard.Add("Ion");
            Junkyard.Add("Sonata");

            // Junkyard.IntersectWith(Showroom);
            
            // foreach (string car in Junkyard)
            // {
            //     Console.WriteLine(car);
            // }

            Showroom.UnionWith(Junkyard);

            foreach (string car in Showroom)
            {
                Console.WriteLine(car);
            }

            Showroom.Remove("Ion");
        }
    }
}
