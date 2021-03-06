using System;
using System.IO;

namespace CVS
{

    class MainClaas
    {
        static void Main(string[] args)
        {
            Extrastring.CVSinlezenvoorspelers();
        }
    }


    class Speler
    {

        private string naam;
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        private string achternaam;
        public string Achteraam
        {
            get { return achternaam; }
            set { achternaam = value; }
        }

        private int geboortejaar;
        public int Geboortejaar
        {
            get { return geboortejaar; }
            set { geboortejaar = value; }
        }


        public Speler(string naam, string achternaam, int geboorterjaar)
        {
            this.Naam = naam;
            this.Achteraam = achternaam;
            this.Geboortejaar = geboorterjaar;
        }

    }




    class Extrastring
    {

        public static void CVSinlezenvoorspelers()
        {
            string[] lijnen = File.ReadAllLines(@"C:\Spelers.csv");
            Speler[] spelers = new Speler[lijnen.Length];
            for (int i = 0; i < lijnen.Length; i++)
            {
                string[] kolomwaarden = lijnen[i].Split(',');
                spelers[i] = new Speler(kolomwaarden[0], kolomwaarden[1], Convert.ToInt32(kolomwaarden[2]));
                Console.WriteLine($"{spelers[i].Achteraam} - {spelers[i].Naam} - {spelers[i].Geboortejaar}");
            }

        }


    }
}
