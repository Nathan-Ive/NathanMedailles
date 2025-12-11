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

        static bool programStart = true;
        static string startingInput;
        static List<string> characterNames = new List<string>();
        static string playerTextInput;
        static int inputLevel;
        static List<int> characterLevels = new List<int>();
        static List<int> characterIDList = new List<int>();
        static int playerIDValue = 0;
        static int leftoverCharacters = 3;
        static List<int> characterLives = new List<int>();
        static List<string> characterDifficulty = new List<string>();





        static void Main(string[] args)
        {
            while (programStart)
            {
                Console.WriteLine("Which task do you want to start?");
                Console.WriteLine();
                Console.Write("Input Field: ");
                startingInput = Console.ReadLine();
                Console.Clear();

                switch (startingInput.ToLower()) 
                {
                    case "task1":
                    case "task 1":
                    case "opdracht1":
                    case "opdracht 1":
                    case "1":
                Opdracht1 task1 = new Opdracht1();      ///Turned In 3/3 


                        task1.Start();
                        programStart = false;
                        break;
                    case "task2":
                    case "task 2":
                    case "opdracht2":
                    case "opdracht 2":
                    case "2":
                        Opdracht2 task2 = new Opdracht2();      //Incomplete 
                                                                //(Still needs a win condition for every route)

                        task2.Start();
                        programStart = false;
                        break;
                    case "task3":
                    case "task 3":
                    case "opdracht3":
                    case "opdracht 3":
                    case "3":
                        Opdracht3 task3 = new Opdracht3();      ///Turned In 3/3


                        task3.Start();
                        programStart = false;
                        break;
                    case "task4":
                    case "task 4":
                    case "opdracht4":
                    case "opdracht 4":
                    case "4":
                        Opdracht4 task4 = new Opdracht4();      //Semi-Complete 1/3
                                                                //(Still needs leap year calculation, but normal years are complete.) 
                                                                //(I also need to add the input saying whether or not someone can vote.)

                        task4.Start();
                        programStart = false;
                        break;
                    case "task5":
                    case "task 5":
                    case "opdracht5":
                    case "opdracht 5":
                    case "5":
                        Opdracht5 task5 = new Opdracht5();      ///Turned In 3/3


                        task5.Start();
                        programStart = false;
                        break;
                    case "task6":
                    case "task 6":
                    case "opdracht6":
                    case "opdracht 6":
                    case "6":
                        Opdracht6 task6 = new Opdracht6();      ///Turned In 3/3


                        task6.Start();
                        programStart = false;
                        break;



                    case "task7":
                    case "task 7":
                    case "opdracht7":
                    case "opdracht 7":
                    case "7":
                        Opdracht7 task7 = new Opdracht7();      ///Turned In 3/3


                        task7.Start();
                        programStart = false;
                        break;
                    case "task8":
                    case "task 8":
                    case "opdracht8":
                    case "opdracht 8":
                    case "8":
                        //Opdracht8 Start                       //Complete [I made it friendly for user input. You can choose a name, level, and the amount of lives you want.]
                                                                //It prints everything at the end, showing name, level and lives.
                                                                //I have also added an extra part where it prints everything in a for loop.
                                                                //This shows that I can pull both the values from the Class/Constructor as well as from the variables in the List above.

                        while (playerIDValue <= 2)
                        {

                            Console.Clear();
                            Console.WriteLine($"Welcome to the program, you will be creating 3 characters.");
                            Console.WriteLine($"You have {leftoverCharacters} left to make.");
                            Console.WriteLine("");
                            Console.WriteLine("Please input the name of your character.");
                            Console.WriteLine("");
                            Console.Write("Name input: ");

                            characterNames.Add(Console.ReadLine());

                            Console.Clear();
                            Console.WriteLine($"Now input your desired starting level for {characterNames[playerIDValue]}.");
                            Console.WriteLine();
                            Console.Write("Level input: ");
                            playerTextInput = Console.ReadLine();
                            Console.Clear();

                            if (Int32.TryParse(playerTextInput, out inputLevel))
                            {
                                characterLevels.Add(inputLevel);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"The input wasn't a number, so level will be set to 1");
                                Console.WriteLine("Once you understand this, press enter to continue.");
                                Console.ReadLine();
                                characterLevels.Add(1);
                            }


                            Console.Clear();
                            Console.WriteLine($"Next, input your desired difficulty: Easy, Normal, Hard");
                            Console.WriteLine();
                            Console.Write("Difficulty input: ");
                            playerTextInput = Console.ReadLine();


                            Console.Clear();
                            switch (playerTextInput.ToLower())
                            {
                                case "easy":
                                    Console.Clear();
                                    characterDifficulty.Add("Easy");
                                    characterLives.Add(10);
                                    break;
                                case "normal":
                                    Console.Clear();
                                    characterDifficulty.Add("Normal");
                                    characterLives.Add(5);
                                    break;

                                case "hard":
                                    Console.Clear();
                                    characterDifficulty.Add("Hard");
                                    characterLives.Add(3);
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Incorrect input, the difficulty will default to Normal.");
                                    Console.WriteLine("After reading this warning, press enter to continue.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    characterDifficulty.Add("Normal");
                                    characterLives.Add(5);
                                    break;
                            }

                            Console.WriteLine($"Thank you for filling in all the fields, your character will be made.");
                            Console.ReadLine();
                            Console.Clear();

                            characterIDList.Add(playerIDValue);
                            leftoverCharacters--;
                            playerIDValue++;
                        }

                        Console.Clear();

                        Opdracht8 character1 = new Opdracht8(characterNames[characterIDList[0]], characterLevels[characterIDList[0]], characterLives[characterIDList[0]]);
                        character1.ShowStats();
                        Opdracht8 character2 = new Opdracht8(characterNames[characterIDList[1]], characterLevels[characterIDList[1]], characterLives[characterIDList[1]]);
                        character2.ShowStats();
                        Opdracht8 character3 = new Opdracht8(characterNames[characterIDList[2]], characterLevels[characterIDList[2]], characterLives[characterIDList[2]]);
                        character3.ShowStats();

                        Console.WriteLine("");
                        Console.WriteLine("To see these stats printed in a for loop, press enter.");
                        Console.ReadLine();
                        Console.Clear();

                        foreach (int id in characterIDList)
                        {
                            Console.WriteLine($"{characterNames[id]} is level {characterLevels[id]}.");
                            Console.WriteLine($"{characterNames[id]}, having chosen {characterDifficulty[id]} difficulty has {characterLives[id]} initial lives");
                            Console.WriteLine("");

                        }

                        //Opdracht 8 End
                        programStart = false;
                        break;
                    case "task9":
                    case "task 9":
                    case "opdracht9":
                    case "opdracht 9":
                    case "9":
                        Opdracht9 task9 = new Opdracht9();      //Not Started
                                                                //(This task is similar to 8, but constructing weapons instead of characters.)
                                                                //(The goals are similar, they just require different stats.)
                                                                //(The main idea is that the weapon has an upgrade level.)

                        programStart = false;
                        break;
                    case "task10":
                    case "task 10":
                    case "opdracht10":
                    case "opdracht 10":
                    case "10":
                        Opdracht10 task10 = new Opdracht10();   //Not Started


                        programStart = false;
                        break;
                    case "task11":
                    case "task 11":
                    case "opdracht11":
                    case "opdracht 11":
                    case "11":
                        Opdracht11 task11 = new Opdracht11();   //Not Started


                        programStart = false;
                        break;


                    case "exit":
                    case "quit":
                    case "end":
                        programStart = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input, try either inputting 'task [number]' or typing an exit command.");
                        break;
                }

                
            }
            

            

        }
    }
}
