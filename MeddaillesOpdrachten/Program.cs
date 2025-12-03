using MeddaillesOpdracht2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        //static List <string> userNames = new List<string>();
        //static List <string> userPasswords = new List<string>();
        //static List <int> userAges = new List<int>();
        //static List <int> userIDs = new List<int>();
        //static string userInput;
        //static int newUserAge;
        //static int usersIDValue;
        


        static void Main(string[] args)
        {

            Opdracht1 task1 = new Opdracht1();      ///Turned In
            Opdracht2 task2 = new Opdracht2();      //Incomplete 
                                                        //(Still needs a win condition for every route)
            Opdracht3 task3 = new Opdracht3();      ///Complete (as far as I can tell)
            Opdracht4 task4 = new Opdracht4();      //Semi-Complete 
                                                        //(Still needs leap year calculation, but normal years are complete.) 
                                                        //(I also need to add the input saying whether or not someone can vote.)
            Opdracht5 task5 = new Opdracht5();      ///Turned In
            Opdracht6 task6 = new Opdracht6();      ///Complete
            Opdracht7 task7 = new Opdracht7();      ///Complete
            Opdracht8 task8 = new Opdracht8();      //Not started
                                                        //(The goal of this task is to make a game character using a Constructor.)
                                                        //(To get bronze you need to make a character with a name and level value.)
                                                        //(To get silver you need to make a second character and a ShowStats() function.)
                                                        //(To get gold you need to add lives. And print three characters' values using a loop.)

            Opdracht9 task9 = new Opdracht9();      //Not Started
                                                        //(This task is similar to 8, but constructing weapons instead of characters.)
                                                        //(The goals are similar, they just require different stats.)
                                                        //(The main idea is that the weapon has an upgrade level.)
            
            
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


            //Console.WriteLine($"Welcome to the program, if you want to make a new user, please start by inputting your name.");
            //userNames.Add(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine($"Now input your password {userNames[0]}.");
            //userPasswords.Add(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine($"Next, input your age.");
            //userInput = Console.ReadLine();


            //Console.Clear();
            //if (Int32.TryParse(userInput, out newUserAge))
            //{
            //    userAges.Add(newUserAge);
            //    usersIDValue++;
            //}
            //else 
            //{
            //    Console.WriteLine($"The input wasn't a number, so age will be set to 0");
            //    Console.WriteLine("");
            //    userAges.Add(0);
            //    usersIDValue++;
            //}

            //userIDs.Add(usersIDValue);

            //Console.WriteLine($"Thank you for filling in all the fields, your account will be made.");


            

        }
    }
}
