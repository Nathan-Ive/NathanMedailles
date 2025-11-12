using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user, what is your name?");
            String naamInput = Console.ReadLine();
            String gebruikerNaam = naamInput;
            Console.WriteLine("Welcome " + gebruikerNaam + " can you fill in your age next?");
            String ageInput = Console.ReadLine();
            int gebruikerAge;
            Boolean ageNumberCheck;
            if (!Int32.TryParse(ageInput, out gebruikerAge)) {
                Console.WriteLine(gebruikerNaam + ", please try and input an age exclusively using numbers. Thank you.");
            }
            else { Console.WriteLine("Hello, " + gebruikerNaam + ". Your age is " + gebruikerAge); }
        }
    }
}
