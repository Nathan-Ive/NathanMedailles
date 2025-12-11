using MeddaillesOpdrachten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdracht2
{
    /// <summary>
    /// In order to somewhat clean up the Program Class, I decided to put all notes or tasks made and done during a lesson to be stored here.
    /// This way I can pull from my notes without making a hard to read mess with the amount of notes around.
    /// </summary>



    internal class ProgramLeftovers
    {



        ///Lesson Notes & Tasks

        //        private static string[] _studentFirstName = { "Nathan", "Totally" };
        //        private static string[] _studentLastName = { "Ivens", "Real" };
        //        private static int[] _studentAge = { 22, -100 };

        //        static List<string> userNames = new List<string>();
        //        static List<string> userPasswords = new List<string>();
        //        static List<int> userAges = new List<int>();
        //        static List<int> userIDs = new List<int>();
        //        static string userInput;
        //        static int newUserAge;
        //        static int usersIDValue;






        //        KlasOpdrachtFuncties taskExtra1 = new KlasOpdrachtFuncties();
        //        KlasOpdrachtArraysAndLists taskExtra2 = new KlasOpdrachtArraysAndLists();
        //        NotesAndStuff notes = new NotesAndStuff();


        //        notes.Start();


        //                KlasOpdrachtStudent student1 = new KlasOpdrachtStudent(_studentFirstName[0], _studentLastName[0], _studentAge[0]);
        //        KlasOpdrachtStudent student2 = new KlasOpdrachtStudent(_studentFirstName[1], _studentLastName[1], _studentAge[1]);

        //        student1.namePrinter();
        //                student2.namePrinter();


        //                Console.WriteLine($"Welcome to the program, if you want to make a new user, please start by inputting your name.");
        //                userNames.Add(Console.ReadLine());

        //                Console.Clear();
        //                Console.WriteLine($"Now input your password {userNames[0]}.");
        //                userPasswords.Add(Console.ReadLine());

        //                Console.Clear();
        //                Console.WriteLine($"Next, input your age.");
        //                userInput = Console.ReadLine();


        //                Console.Clear();
        //                if (Int32.TryParse(userInput, out newUserAge))
        //                {
        //                    userAges.Add(newUserAge);
        //                    usersIDValue++;
        //                }
        //                else 
        //                {
        //                    Console.WriteLine($"The input wasn't a number, so age will be set to 0");
        //                    Console.WriteLine("");
        //                    userAges.Add(0);
        //                    usersIDValue++;
        //                }

        //userIDs.Add(usersIDValue);

        //Console.WriteLine($"Thank you for filling in all the fields, your account will be made.");



        ///Task 8 switch case attempt


        //static List<string> characterNames = new List<string>();
        //static string playerTextInput;
        //static int inputLevel;
        //static List<int> characterLevels = new List<int>();
        //static int[] characterLives = { 3, 5, 10 }; // 3 lives = hard | 5 lives = normal | 10 lives = easy
        //static List<int> characterIDList = new List<int>();
        //static int playerIDValue = 0;
        //static int difficultyValue;
        //static string operationRequestInput;


        //        Console.WriteLine($"Welcome to the program, if you want to make a new character, please input 'New Character'.");
        //            Console.WriteLine($"If you want to check a character that you made, input their name.");
        //            Console.WriteLine($"If you forgot your character's name, you can input 'help', and a list of every character will be displayed");
        //            Console.WriteLine($"If you want to end the program, input 'Exit'");
        //            Console.WriteLine("");
        //            Console.Write("Input Field: ");
        //            operationRequestInput = Console.ReadLine();

        //            switch (operationRequestInput.ToLower())
        //            {
        //                case "New Character":
        //                        characterNames.Add(Console.ReadLine());

        //                        Console.Clear();
        //                        Console.WriteLine($"Now input your desired starting level {characterNames[playerIDValue]}.");
        //                        playerTextInput = Console.ReadLine();

        //                        Console.Clear();
        //                        if (Int32.TryParse(playerTextInput, out inputLevel))
        //                        {
        //                            characterLevels.Add(inputLevel);
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine($"The input wasn't a number, so level will be set to 1");
        //                            Console.WriteLine("");
        //                            characterLevels.Add(1);
        //                        }


        //Console.Clear();
        //Console.WriteLine($"Next, input your desired difficulty: Easy, Normal, Hard");
        //playerTextInput = Console.ReadLine();


        //Console.Clear();
        //switch (playerTextInput)
        //{
        //    case "Easy":
        //        difficultyValue = 2;
        //        playerIDValue++;
        //        break;
        //    case "Normal":
        //        difficultyValue = 1;
        //        playerIDValue++;
        //        break;

        //    case "Hard":
        //        difficultyValue = 0;
        //        playerIDValue++;
        //        break;
        //    default:
        //        Console.WriteLine("Incorrect input, the difficulty will default to Normal.");
        //        difficultyValue = 1;
        //        playerIDValue++;

        //        characterIDList.Add(playerIDValue);

        //        Console.WriteLine($"Thank you for filling in all the fields, your character will be made.");
        //        break;

        //}
        //break;

        //                case "Help":

        //    break;

        //case "Exit":
        //    break;

        //default:
        //    break;



















//        Opdracht1 task1 = new Opdracht1();      ///Turned In 3/3 
//        Opdracht2 task2 = new Opdracht2();      //Incomplete 
//                                                //(Still needs a win condition for every route)
//        Opdracht3 task3 = new Opdracht3();      ///Turned In 3/3
//        Opdracht4 task4 = new Opdracht4();      //Semi-Complete 1/3
//                                                //(Still needs leap year calculation, but normal years are complete.) 
//                                                //(I also need to add the input saying whether or not someone can vote.)
//        Opdracht5 task5 = new Opdracht5();      ///Turned In 3/3
//        Opdracht6 task6 = new Opdracht6();      ///Turned In 3/3
//        Opdracht7 task7 = new Opdracht7();      ///Turned In 3/3
            
            
            
//            //Opdracht8 Start                       //Complete [I made it friendly for user input. You can choose a name, level, and the amount of lives you want.]
//                                                    //It prints everything at the end, showing name, level and lives.
//                                                    //I have also added an extra part where it prints everything in a for loop.
//                                                    //This shows that I can pull both the values from the Class/Constructor as well as from the variables in the List above.

//            while (playerIDValue <= 2)
//            {

//                Console.Clear();
//                Console.WriteLine($"Welcome to the program, you will be creating 3 characters.");
//                Console.WriteLine($"You have {leftoverCharacters} left to make.");
//                Console.WriteLine("");
//                Console.WriteLine("Please input the name of your character.");
//                Console.WriteLine("");
//                Console.Write("Name input: ");

//                characterNames.Add(Console.ReadLine());

//                Console.Clear();
//                Console.WriteLine($"Now input your desired starting level for {characterNames[playerIDValue]}.");
//                Console.WriteLine();
//                Console.Write("Level input: ");
//                playerTextInput = Console.ReadLine();
//                Console.Clear();
                
//                if (Int32.TryParse(playerTextInput, out inputLevel))
//                {
//                    characterLevels.Add(inputLevel);
//                }
//                else
//                {
//                    Console.Clear();
//                    Console.WriteLine($"The input wasn't a number, so level will be set to 1");
//                    Console.WriteLine("Once you understand this, press enter to continue.");
//                    Console.ReadLine();
//                    characterLevels.Add(1);
//                }


//Console.Clear();
//Console.WriteLine($"Next, input your desired difficulty: Easy, Normal, Hard");
//playerTextInput = Console.ReadLine();


//Console.Clear();
//switch (playerTextInput.ToLower())
//{
//    case "easy":
//        Console.Clear();
//        characterDifficulty.Add("Easy");
//        characterLives.Add(10);
//        break;
//    case "normal":
//        Console.Clear();
//        characterDifficulty.Add("Normal");
//        characterLives.Add(5);
//        break;

//    case "hard":
//        Console.Clear();
//        characterDifficulty.Add("Hard");
//        characterLives.Add(3);
//        break;
//    default:
//        Console.Clear();
//        Console.WriteLine("Incorrect input, the difficulty will default to Normal.");
//        Console.WriteLine("After reading this warning, press enter to continue.");
//        Console.ReadLine();
//        Console.Clear();
//        characterDifficulty.Add("Normal");
//        characterLives.Add(5);
//        break;
//}

//Console.WriteLine($"Thank you for filling in all the fields, your character will be made.");
//Console.ReadLine();
//Console.Clear();

//characterIDList.Add(playerIDValue);
//leftoverCharacters--;
//playerIDValue++;
//            }

//            Console.Clear();

//Opdracht8 character1 = new Opdracht8(characterNames[characterIDList[0]], characterLevels[characterIDList[0]], characterLives[characterIDList[0]]);
//character1.ShowStats();
//Opdracht8 character2 = new Opdracht8(characterNames[characterIDList[1]], characterLevels[characterIDList[1]], characterLives[characterIDList[1]]);
//character2.ShowStats();
//Opdracht8 character3 = new Opdracht8(characterNames[characterIDList[2]], characterLevels[characterIDList[2]], characterLives[characterIDList[2]]);
//character3.ShowStats();

//Console.WriteLine("");
//Console.WriteLine("To see these stats printed in a for loop, press enter.");
//Console.ReadLine();
//Console.Clear();

//foreach (int id in characterIDList)
//{
//    Console.WriteLine($"{characterNames[id]} is level {characterLevels[id]}.");
//    Console.WriteLine($"{characterNames[id]}, having chosen {characterDifficulty[id]} difficulty has {characterLives[id]} initial lives");
//    Console.WriteLine("");

//}

////Opdracht 8 End


//Opdracht9 task9 = new Opdracht9();      //Not Started
//                                        //(This task is similar to 8, but constructing weapons instead of characters.)
//                                        //(The goals are similar, they just require different stats.)
//                                        //(The main idea is that the weapon has an upgrade level.)


//Opdracht10 task10 = new Opdracht10();   //Not Started


//Opdracht11 task11 = new Opdracht11();   //Not Started

//            //task7.Start();


            



    }
}
