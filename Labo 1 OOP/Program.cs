using System;

namespace Labo_1_OOP
{
    internal class DateTimeOefeningen
    {
        static void NietMain(string[] args)
        {

            Console.WriteLine("Wat wil je doen?");
            Console.WriteLine("1. DemonstreerStudenten uitvoeren");
            Console.WriteLine("2. DemonstreerCursussen uitvoeren");
            int keuze = Convert.ToInt32(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    Student.DemonstreerStudenten();
                    break;
                case 2:
                    Cursus.DemonstreerCursussen();
                    break;
                default:
                    break;

            }
        }

        public static void Toonsubmenu()
        {
            while (true)
            {
                Console.WriteLine("Welkom bij de demo Objectgeoriënteerd Programmeren!");
                Console.WriteLine("Topic van de uit te voeren oefening?");
                Console.WriteLine("\n1: Date Time");
                Console.WriteLine("2: EigenObjectOefeningen.");
                Console.WriteLine("3: Close program");
                Console.Write("\nKeuze:");
                int keuze = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (keuze)
                {
                    case 1:
                        Console.WriteLine("Uit te voeren oefening?");
                        Console.WriteLine("\n1: WeekdagProgramma() ");
                        Console.WriteLine("2: Ticks2000Programma()");
                        Console.WriteLine("3: SchrikkeljaarProgramma()");
                        Console.WriteLine("4: ArrayTimerProgramma()");
                        Console.WriteLine("5: VerjaardagProgramma()");
                        Console.WriteLine("6: Dagvanhetjaar()");
                        Console.Write("\nKeuze:");
                        int tweedeKeuze = int.Parse(Console.ReadLine());

                        switch (tweedeKeuze)
                        {
                            case 1:
                                Console.Clear();
                                WeekdagProgramma();
                                break;

                            case 2:
                                Console.Clear();
                                Ticks2000Programma();
                                break;

                            case 3:
                                Console.Clear();
                                SchrikkeljaarProgramma();
                                break;

                            case 4:
                                Console.Clear();
                                ArrayTimerProgramma();
                                break;

                            case 5:
                                Console.Clear();
                                VerjaardagProgramma();
                                break;

                            case 6:
                                Console.Clear();
                                Dagvanhetjaar();
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Uit te voeren oefening?");
                        Console.WriteLine("\n1: GetallenCombinatie() ");
                        Console.Write("\nKeuze:");
                        tweedeKeuze = int.Parse(Console.ReadLine());

                        switch (tweedeKeuze)
                        {
                            case 1:
                                Console.Clear();
                                GetallenCombinatie test = new GetallenCombinatie();
                                test.num1 = 19;
                                test.num2 = 12;
                                Console.Clear();

                                Console.WriteLine("Paar:" + test.num1 + ", " + test.num2);
                                Console.WriteLine("Som = " + test.Som());
                                Console.WriteLine("Verschil = " + test.Verschil());
                                Console.WriteLine("Product = " + test.Product());
                                Console.WriteLine("Quotient = " + test.Quotient());

                                Console.ReadLine();
                                Console.Clear();

                                break;
                        }
                        break;

                    case 3:
                        System.Environment.Exit(0);
                        break;
                }
            }
        }

        public static void WeekdagProgramma()
        {
            Console.Clear();

            Console.WriteLine("Welke Dag?");
            int Day = int.Parse(Console.ReadLine());

            Console.WriteLine("Welke Maand");
            int Month = int.Parse(Console.ReadLine());

            Console.WriteLine("Welke Jaar");
            int Year = int.Parse(Console.ReadLine());

            DateTime rndDate = new DateTime(Year, Month, Day);

            Console.WriteLine($"{rndDate.ToString("M")} {Year} is een {rndDate.DayOfWeek}");

            Console.ReadKey();
            Console.Clear();
        }

        public static void Ticks2000Programma()
        {
            Console.Clear();
            DateTime oldDate = new DateTime(1999, 1, 1);

            long ticks = DateTime.Today.Ticks - oldDate.Ticks;

            Console.WriteLine($"Sinds 1 januari 2000 zijn er {ticks} ticks voorbijgegaan.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ArrayTimerProgramma()
        {
            Console.Clear();
            DateTime start = DateTime.Now;
            int[] arr = new int[1000000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[0] += i;
            }

            DateTime stop = DateTime.Now;

            long timer = stop.Millisecond - start.Millisecond;

            Console.WriteLine($"Het duurt {timer} milliseconden om een array van een miljoen elementen aan te maken en op te vullen met opeenvolgende waarden.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void SchrikkeljaarProgramma()
        {
            Console.Clear();

            int schrikkelJarenTeller = 0;

            for (int i = 1799; i <= 2021; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    schrikkelJarenTeller++;
                }
            }

            Console.WriteLine($"Er zijn {schrikkelJarenTeller} schrikkeljaren tussen 1799 en 2021.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void VerjaardagProgramma()
        {
            Console.Clear();

            int dag;
            int maand;
            int teller = 0;
            Console.WriteLine("Welke dag?");
            dag = int.Parse(Console.ReadLine());
            Console.WriteLine("Welke maand?");
            maand = int.Parse(Console.ReadLine());
            DateTime today = DateTime.Today;

            do
            {
                today = today.AddDays(1);
                teller++;
            } while (today.Month != maand || today.Day != dag);

            Console.WriteLine($"Jou verjaardag is in {teller} dagen");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Dagvanhetjaar()
        {
            Console.Clear();
            Console.WriteLine("Geef een datum in: voorbeeld (1999/1/15)");
            DateTime datum = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Dit is de {datum.DayOfYear} ste/de van het jaar");
            Console.ReadKey();
            Console.Clear();
        }
    }

    public class GetallenCombinatie
    {
        public int num1;
        public double num2;

        public double Som()
        {
            return (num1 + num2);
        }

        public double Verschil()
        {
            return (num1 / num2);
        }

        public double Product()
        {
            return (num1 * num2);
        }

        public double Quotient()
        {
            return (num1 % num2);
        }
    }

    public class CursusResultaat
    {
        public string Naam;
        public byte Resultaat;
    }

    public class Student
    {
        public string Naam;
        public DateTime Geboortedatum;
        public uint Studentennummer;
        private CursusResultaat[] cursusResultaten = new CursusResultaat[5];
        public static uint StudentenTeller = 1;

        public string GenereerNaamkaartje()
        {
            return $"{this.Naam} (STUDENT)";
        }

        public double BepaalWerkbelasting()
        {
            double totaal = 0.0;
            for (int i = 0; i < cursusResultaten.Length; i++)
            {
                if (cursusResultaten[i] != null)
                {
                    totaal += 10;
                }
            }
            return totaal;
        }

        public void RegistreerCursusResultaat(string cursus, byte resultaat)
        {
            int vrijePositie = -1;
            for (int i = 0; i < cursusResultaten.Length && vrijePositie == -1; i++)
            {
                if (this.cursusResultaten[i] is null)
                {
                    vrijePositie = i;
                }
            }
            if (vrijePositie > -1)
            {
                CursusResultaat nieuwCursusResultaat = new CursusResultaat();
                cursusResultaten[vrijePositie] = nieuwCursusResultaat;
                nieuwCursusResultaat.Naam = cursus;
                this.Kwoteer((byte)vrijePositie, resultaat);
            }
        }

        public void Kwoteer(byte cursusIndex, byte behaaldCijfer)
        {
            if (behaaldCijfer < 0 || behaaldCijfer > 20 || cursusIndex >= cursusResultaten.Length || cursusResultaten[cursusIndex] is null)
            {
                Console.WriteLine("Ongeldig cijfer!");
            }
            else
            {
                this.cursusResultaten[cursusIndex].Resultaat = behaaldCijfer;
            }
        }

        public double Gemiddelde()
        {
            double totaal = 0;
            int aantalCijfers = 0;
            for (int i = 0; i < cursusResultaten.Length; i++)
            {
                if (cursusResultaten[i] != null)
                {
                    totaal += cursusResultaten[i].Resultaat;
                    aantalCijfers++;
                }
            }
            return totaal / aantalCijfers;
        }

        public void ToonOverzicht()
        {
            DateTime nu = DateTime.Now;
            int aantalJaar = nu.Year - this.Geboortedatum.Year - 1;
            if (nu.Month > this.Geboortedatum.Month || nu.Month == this.Geboortedatum.Month && nu.Day >= this.Geboortedatum.Day)
            {
                aantalJaar++;
            }
            Console.WriteLine($"{this.Naam}, {aantalJaar} jaar");
            Console.WriteLine();
            Console.WriteLine("Cijferrapport");
            Console.WriteLine("*************");
            for (int i = 0; i < cursusResultaten.Length; i++)
            {
                if (cursusResultaten[i] != null)
                {
                    Console.WriteLine($"{cursusResultaten[i].Naam}:\t{cursusResultaten[i].Resultaat}");
                }
            }
            Console.WriteLine($"Gemiddelde:\t{this.Gemiddelde():F1}\n");
        }

        public static void DemonstreerStudenten()
        {

            Student student1 = new Student();
            student1.Geboortedatum = new DateTime(2001, 1, 3);
            student1.Naam = "Said Aziz";
            student1.RegistreerCursusResultaat("Communicatie", 12);
            student1.RegistreerCursusResultaat("Programmeren", 15);
            student1.RegistreerCursusResultaat("Webtechnologie", 13);
            student1.ToonOverzicht();

            Student student2 = new Student();
            student2.Geboortedatum = new DateTime(2000, 2, 1);
            student2.Naam = "Mieke Vermeulen";
            student2.RegistreerCursusResultaat("Communicatie", 13);
            student2.RegistreerCursusResultaat("Programmeren", 16);
            student2.RegistreerCursusResultaat("Databanken", 14);
            student2.ToonOverzicht();
        }

    }


    public class Cursus
    {
        public string Titel;
        public Student[] Studenten = new Student[2];

        public void ToonOverzicht()
        {
            Console.WriteLine($"{this.Titel}");
            for (int i = 0; i < this.Studenten.Length; i++)
            {
                if (Studenten[i] != null)
                {
                    Console.WriteLine($"{Studenten[i].Naam}");
                }
            }
            Console.WriteLine();
        }

        public static void DemonstreerCursussen()
        {
            Cursus communicatie = new Cursus();
            communicatie.Titel = "Communicatie";
            Cursus programmeren = new Cursus();
            programmeren.Titel = "Programmeren";
            Cursus webtechnologie = new Cursus();
            webtechnologie.Titel = "Webtechnologie";
            Cursus databanken = new Cursus();
            databanken.Titel = "Databanken";

            Student student1 = new Student();
            student1.Geboortedatum = new DateTime(2001, 1, 3);
            student1.Naam = "Said Aziz";
            student1.RegistreerCursusResultaat(communicatie.Titel, 12);
            student1.RegistreerCursusResultaat(programmeren.Titel, 15);
            student1.RegistreerCursusResultaat(webtechnologie.Titel, 13);


            Student student2 = new Student();
            student2.Geboortedatum = new DateTime(2000, 2, 1);
            student2.Naam = "Mieke Vermeulen";
            student2.RegistreerCursusResultaat(communicatie.Titel, 13);
            student2.RegistreerCursusResultaat(programmeren.Titel, 16);
            student2.RegistreerCursusResultaat(databanken.Titel, 14);

            communicatie.Studenten[0] = student1;
            communicatie.Studenten[1] = student2;
            programmeren.Studenten[0] = student1;
            programmeren.Studenten[1] = student2;
            webtechnologie.Studenten[0] = student1;
            databanken.Studenten[0] = student2;

            communicatie.ToonOverzicht();
            programmeren.ToonOverzicht();
            webtechnologie.ToonOverzicht();
            databanken.ToonOverzicht();

        }


    }


}