
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eachfor
{

    public class Datastructuren
    {
        public static void Boodschappen()
        {

            bool loop = true;
            int i = 0;
            List<string> boodschappen = new List<string>();
            do
            {
                Console.WriteLine($"wat is item {i + 1} op je lijst? Geef een lege regel om te stoppen.");
                string input = Console.ReadLine();
                if (input == string.Empty) loop = false;
                else boodschappen.Add(input);
                i++;

            } while (loop);
            i = 1;
            boodschappen.Sort();
            Console.WriteLine("Dit is je gesorteerde lijst");
            foreach (var boodschap in boodschappen)
            {
                Console.WriteLine(i + " " + boodschap);
                i++;
            }

            Console.WriteLine("Op naar de winkel!");
            loop = true;
            do
            {
                Console.WriteLine("Welke item heb je gekocht? Geef de naam exact zoals hij op het lijst staat.");
                string items = Console.ReadLine();
                if (boodschappen.FirstOrDefault(x => x.Contains(items)) != null)
                {
                    boodschappen.Remove(items);
                }
                else
                {
                    Console.WriteLine("Dit item bevindt zich niet op de lijst!");
                };
                Console.WriteLine("Nog Winkelen? (Ja of Nee)");
                if (Console.ReadLine().ToUpper() == "NEE") loop = false;
            } while (loop);
            Console.WriteLine("Naar huis met de boodschappen");
            if (boodschappen.Count() == 0) Console.WriteLine("Proficiat! Je hebt alle boodschappen gekocht.");
            else
            {
                Console.WriteLine("Volgende items van je lijst ben je vergeten te kopen:");
                foreach (var boodschap in boodschappen)
                {
                    Console.WriteLine(boodschap);
                }
            }
        }
    }
}