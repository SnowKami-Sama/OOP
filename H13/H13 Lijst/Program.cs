using System;
using System.Collections.Generic;

namespace H13_Lijst
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, int> contact = new Dictionary<string, int>();

            Console.WriteLine("Wil je een naam en nummer inlezen ?");

            string input2 = "";
            do
            {
                Console.Write("Naam: ");
                string naam = Console.ReadLine();
                Console.Write("Nummer: ");
                int nummer = int.Parse(Console.ReadLine());
                contact.Add(naam, nummer);

                Console.WriteLine("wil je nog een nummer inlezen? ja/nee");
                input2 = Console.ReadLine();
            } while (input2.ToLower() != "nee");

            foreach (var item in contact)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }
    }
}