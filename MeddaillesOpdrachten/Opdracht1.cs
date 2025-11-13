using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdrachten
{
    internal class Opdracht1
    {
        public void Start()
        {
            String naamInput;
            String gebruikerNaam;
            String ageInput;
            int gebruikerAge;



            Console.WriteLine("Hello user, what is your name?");
            naamInput = Console.ReadLine();
            gebruikerNaam = naamInput;

            Console.WriteLine("Welcome " + gebruikerNaam + " can you fill in your age next?");
            ageInput = Console.ReadLine();

            if (!Int32.TryParse(ageInput, out gebruikerAge))
            {
                Console.WriteLine(gebruikerNaam + ", please try and input an age exclusively using numbers. Thank you.");
            }
            else { Console.WriteLine("Hello, " + gebruikerNaam + ". Your age is " + gebruikerAge); }
        }
    }
}
