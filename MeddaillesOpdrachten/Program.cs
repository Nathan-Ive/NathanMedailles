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
        private static string[] _studentFirstName = { "Nathan", "Totally"  };
        private static string[] _studentLastName = { "Ivens", "Real" };
        private static int[] _studentAge = { 22, -100 };

        static void Main(string[] args)
        {

            Opdracht1 task1 = new Opdracht1();
            Opdracht2 task2 = new Opdracht2();
            Opdracht3 task3 = new Opdracht3();
            Opdracht4 task4 = new Opdracht4();
            Opdracht5 task5 = new Opdracht5();
            Opdracht6 task6 = new Opdracht6();
            Opdracht7 task7 = new Opdracht7();
            Opdracht8 task8 = new Opdracht8();
            Opdracht9 task9 = new Opdracht9();
            Opdracht10 task10 = new Opdracht10();
            Opdracht11 task11 = new Opdracht11();


            KlasOpdrachtFuncties taskExtra1 = new KlasOpdrachtFuncties();
            KlasOpdrachtArraysAndLists taskExtra2 = new KlasOpdrachtArraysAndLists();
            NotesAndStuff notes = new NotesAndStuff();


            //notes.Start();

            task7.Start();


            //Student student1 = new Student(_studentFirstName[0], _studentLastName[0] , _studentAge[0]);
            //Student student2 = new Student(_studentFirstName[1], _studentLastName[1], _studentAge[1]);

            //student1.namePrinter();
            //student2.namePrinter();



        }
    }
}
