
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    public class Cursus
    {
        public static Cursus[] AlleCursussen = new Cursus[10];
        private static int maxId = 1;
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Titel;
        public Student[] Studenten;
        public Cursus(string titel, Student[] studenten, byte studiepunten)
        {
            this.Titel = titel;
            this.Studenten = studenten;
            this.id = Cursus.maxId;
            this.Studiepunten = studiepunten;
            RegistreerCursus(this);
            Cursus.maxId++;
        }
        public Cursus(string titel, Student[] studenten) : this(titel, studenten, 3)
        {
        }
        public Cursus(string titel) : this(titel, new Student[2])
        {
        }
        private byte studiepunten;
        public byte Studiepunten
        {
            get
            {
                return studiepunten;
            }
            private set
            {
                studiepunten = value;
            }
        }

        public void ToonOverzicht()
        {
            Console.WriteLine($"{Titel} ({Id} - {Studiepunten} stp)");
            for (int i = 0; i < Studenten.Length; i++)
            {
                if (Studenten[i] != null)
                {
                    Console.WriteLine($"{Studenten[i].Naam}");
                }
            }
            Console.WriteLine();
        }
        public static void RegistreerCursus(Cursus cursus)
        {
            int? vrijePositie = null;
            for (int i = 0; i < AlleCursussen.Length && vrijePositie is null; i++)
            {
                if (AlleCursussen[i] is null)
                {
                    vrijePositie = i;
                }
            }
            if (vrijePositie != null)
            {
                AlleCursussen[(int)vrijePositie] = cursus;
            }
            else
            {
                Console.WriteLine("Er zijn geen vrije posities meer");
            }
        }
        public static Cursus ZoekCursusOpId(int id)
        {
            for (int i = 0; i < AlleCursussen.Length; i++)
            {
                if (AlleCursussen[i].Id == id)
                {
                    return AlleCursussen[i];
                }
            }
            return null;
        }
        public static void DemonstreerCursussen()
        {
            Cursus communicatie = new Cursus("Communicatie", new Student[2]);
            Cursus programmeren = new Cursus("Programmeren");
            Cursus webtechnologie = new Cursus("Webtechnologie", new Student[5], 6);
            Cursus databanken = new Cursus("Databanken", new Student[7], 5);

            Student student1 = new Student();
            student1.Geboortedatum = new DateTime(2001, 1, 3);
            student1.Naam = "Said Aziz";


            Student student2 = new Student();
            student2.Geboortedatum = new DateTime(2000, 2, 1);
            student2.Naam = "Mieke Vermeulen";

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

            Cursus cursus = ZoekCursusOpId(3);
            cursus.ToonOverzicht();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int keuze = 0;
            Console.WriteLine($"Wat wil je demonstreren?\n\t1. Studenten\n\t2. Cursussen\n\t3. Student Uit tekst\n\t4. StudieProgramma\n");
            keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1)
            {
                Student.DemonstreerStudenten();
            }
            else if (keuze == 2)
            {
                Cursus.DemonstreerCursussen();
            }
            else if (keuze == 3)
            {
                Student.DemonstreerStudentUitTekstFormaat();
            }
            else if (keuze == 4)
            {
                StudieProgramma.DemonstreerStudieProgrmma();
            }
        }
    }


}
