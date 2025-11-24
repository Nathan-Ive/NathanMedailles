using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdracht2
{
    internal class KlasOpdrachtFuncties
    {
        //Access modifier
        //1. Maak een functie die een boolean returned. Als parameter geef je een getal mee, In de functie check je of het getal groter is dan 0. zo ja dan return je true, zo nee return je false
        //2. maak een functie die 2 getallen bij elkaar optelt en deze getallen returned
        //3. maak een functie die ":)" achter je tekst (string) plakt en return deze tekst
        // print alle 3 de werkende functie resultaten uit.

        private Boolean validity;
        private int numbers;
        private String words;




        private Boolean PositivityCheck(int coolNumber) 
        {
            return coolNumber > 0;
        }

        private int NumberFuser(int firstNumber, int secondNumber) 
        {
            int theCombined = firstNumber + secondNumber;
            return theCombined;
        }

        private String SmileyMaker(String userText) 
        {
            String theSmile = userText + " :) ";

            return theSmile;
        }


        public void Start()
        {
            validity = PositivityCheck(1);
            numbers = NumberFuser(2, 5);
            words = SmileyMaker("This is my text.");

            Console.WriteLine(validity);
            Console.WriteLine(numbers);
            Console.WriteLine(words);
        }

        
    }
}
