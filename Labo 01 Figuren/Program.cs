using System;

namespace Labo_01_Figuren
{
    class Program
    {
        static void Main(string[] args)
        {

           // DemonstreerFiguren();



        }


        public static void DemonstreerFiguren()
        {
            Rechthoek test = new Rechthoek();
            test.Breedte = -2;
            test.Hoogte = 4;
            Console.WriteLine($"Een rechthoek met een breedte van {test.Breedte}m en een hoogte van {test.Hoogte}m heeft een oppervlakte van {test.Oppervlakte}m²");
        }
    }


    public class Rechthoek
    {

        private double breedte= 1.0;
        public double Breedte { get { return breedte; }
            set {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een breedte van {value} in te stellen!");
                }
                else
                {
                    breedte = value;
                }
                }
            }

        private double hoogte = 1.0;
        public double Hoogte {
            get { return hoogte; }
            set
            {
                    if (value <= 0)
                    {
                        Console.WriteLine($"Het is verboden een hoogte van {value} in te stellen!");
                    }
                    else
                    {
                        hoogte = value;
                }
            }

        }



        public double Oppervlakte
        {
            get { return Math.Round(hoogte * breedte, 2); }
        }

    }

    public class Driehoek
    {

        private double basis = 1.0;
        public double Basis
        {
            get { return basis; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een (afmeting) van (waarde) in te stellen!");
                }
                else
                {
                    basis = value;
                }
            }
        }

        private double hoogte = 1.0;
        public double Hoogte
        {
            get { return hoogte; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een (afmeting) van (waarde) in te stellen!");
                }
                else
                {
                    hoogte = value;
                }
            }
        }

        public double Oppervlakte
        {
            get { return Math.Round((basis * hoogte) / 2.0, 2); }
        }

    }


}
