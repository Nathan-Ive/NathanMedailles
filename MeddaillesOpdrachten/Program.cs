using MeddaillesOpdracht2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdrachten
{
    internal class Program
    {
        //private static string[] _studentFirstName = { "Nathan", "Totally"  };
        //private static string[] _studentLastName = { "Ivens", "Real" };
        //private static int[] _studentAge = { 22, -100 };

        static void Main(string[] args)
        {

            Opdracht1 task1 = new Opdracht1();      ///Turned In
            Opdracht2 task2 = new Opdracht2();      //Incomplete 
                                                        //(Still needs a win condition for every route)
            Opdracht3 task3 = new Opdracht3();      ///Complete (as far as I can tell)
            Opdracht4 task4 = new Opdracht4();      //Incomplete 
                                                        //(Still needs leap year calculation, but normal years are complete.) 
                                                        //(I also need to add the input saying whether or not someone can vote.)
            Opdracht5 task5 = new Opdracht5();      ///Turned In
            Opdracht6 task6 = new Opdracht6();      ///Complete
            Opdracht7 task7 = new Opdracht7();      ///Complete
            Opdracht8 task8 = new Opdracht8();      //Not started
            Opdracht9 task9 = new Opdracht9();      //Not Started
            Opdracht10 task10 = new Opdracht10();   //Not Started
            Opdracht11 task11 = new Opdracht11();   //Not Started

            task4.Start();


            //KlasOpdrachtFuncties taskExtra1 = new KlasOpdrachtFuncties();
            //KlasOpdrachtArraysAndLists taskExtra2 = new KlasOpdrachtArraysAndLists();
            //NotesAndStuff notes = new NotesAndStuff();


            //notes.Start();


            //KlasOpdrachtStudent student1 = new KlasOpdrachtStudent(_studentFirstName[0], _studentLastName[0] , _studentAge[0]);
            //KlasOpdrachtStudent student2 = new KlasOpdrachtStudent(_studentFirstName[1], _studentLastName[1], _studentAge[1]);

            //student1.namePrinter();
            //student2.namePrinter();



        }
    }
}
