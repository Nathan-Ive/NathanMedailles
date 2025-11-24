using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdracht2
{
    internal class KlasOpdrachtArraysAndLists
    {
        //maak 3 lists
        ///string
        ///int
        ///boolean
        //gebruik voor alle 3 de add functie
        //gebruik alle 3 de functies de je had opgeschreven vanuit de vorige opdracht
        //zoek op hoe je alle lists helemaal zou kunnen printen

        private List<string> theWords = new List<string>();
        private List<int> theNumbers = new List<int>();
        private List<Boolean> theTruth = new List<Boolean>();


        public void Start()
        {
            theWords.Add("This is how you use a list!");
            theWords.Add("You can just keep adding like this. There's also the AddRange command, but...");
            theWords.Add("I don't know how to use that.");
            theNumbers.Add(3);
            theNumbers.Add(15);
            theNumbers.Add(24);
            theTruth.Add(true);
            theTruth.Add(false);
            theTruth.Add(false);


            Console.WriteLine(theWords[1]);
            Console.WriteLine(theNumbers[1]);
            Console.WriteLine(theTruth[0]);


        }

    }
}
