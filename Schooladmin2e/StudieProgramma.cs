
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    public class StudieProgramma
    {
        private string naam;
        public string Naam
        {
            get
            {
                return naam;
            }
        }
        private Cursus[] cursussen = new Cursus[20];
        public Cursus[] Cursussen
        {
            get
            {
                return cursussen;
            }
            set
            {
                if (value is null)
                {
                    Console.WriteLine("Null is niet toegelaten");
                }
                else
                {
                    cursussen = value;
                }
            }
        }
        public StudieProgramma(string naam)
        {
            this.naam = naam;
        }
        public void ToonOverzicht()
        {
            Console.WriteLine($"{Naam}:");
            // for (int i = 0; i < Cursussen.Length; i++)
            foreach (var cursus in cursussen)
            {
                if (cursus != null)
                {
                    cursus.ToonOverzicht();
                }
            }
        }
        public static void DemonstreerStudieProgrmma()
        {
            /* Stap 1
	        Cursus communicatie = new Cursus("Communicatie");
            Cursus programmeren = new Cursus("Programmeren");
            Cursus databanken = new Cursus("Databanken", new Student[7], 5);
            Cursus[] cursussenProgrammeren = { communicatie, programmeren, databanken };
            Cursus[] cursussenSnb = { communicatie, programmeren, databanken };
            StudieProgramma programmerenProgramma = new StudieProgramma("Programmeren");
            StudieProgramma snbProgramma = new StudieProgramma("Systeem- en netwerkbeheer");
            programmerenProgramma.cursussen = cursussenProgrammeren;
            snbProgramma.cursussen = cursussenSnb;
            // later wordt Databanken geschrapt uit het programma SNB
            snbProgramma.cursussen[2] = null;
            programmerenProgramma.ToonOverzicht();
            snbProgramma.ToonOverzicht();
            */
            Cursus communicatie = new Cursus("Communicatie");
            Cursus programmeren = new Cursus("Programmeren");
            Cursus databanken = new Cursus("Databanken", new Student[7], 5);
            Cursus[] cursussenProgrammeren = { communicatie, programmeren, databanken };
            Cursus[] cursussenSnb = { communicatie, programmeren, databanken };
            StudieProgramma programmerenProgramma = new StudieProgramma("Programmeren");
            StudieProgramma snbProgramma = new StudieProgramma("Systeem- en netwerkbeheer");
            programmerenProgramma.cursussen = cursussenProgrammeren;
            snbProgramma.cursussen = cursussenSnb;
            // later wordt Databanken geschrapt uit het programma SNB
            // voor SNB wordt bovendien Programmeren hernoemd naar Scripting
            Cursus scripting = new Cursus("Scripting");
            snbProgramma.cursussen[2] = null;
            snbProgramma.cursussen[1] = scripting; ;
            programmerenProgramma.ToonOverzicht();
            snbProgramma.ToonOverzicht();
        }
    }
}
