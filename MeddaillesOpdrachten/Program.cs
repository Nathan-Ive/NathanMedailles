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
        //General Variables
        //-----------------------------------------------------------//
        static string playerTextInput;
        static string field = "Input Field: "; //To be used in Console.Write to show when the user needs to input something.
        static bool programStart = true;

        //-----------------------------------------------------------//

        //Task 8 Variables
        //-----------------------------------------------------------//
        static string startingInput;
        static List<Character> characters = new List<Character>(); //A List that contains each instance of the character object class
        static List<string> characterNames = new List<string>();
        static int inputLevel;
        static List<int> characterLevels = new List<int>();
        static int playerIDValue = 0; //represents the amount of characters that have been made.
        static int leftoverCharacters = 3; //represents the initial limit of creatable characters.
        static List<int> characterLives = new List<int>();
        static List<string> characterDifficulty = new List<string>();
        //-----------------------------------------------------------//



        //Task 9 Variables
        //-----------------------------------------------------------//
        static List<Weapons> weapons = new List<Weapons>();
        static List<int> itemIDList = new List<int>
        {
            0,
            1,
            2,
            3,
            4,
        };
        static List<string> itemNames = new List<string>
        {
            "Golden Stinger",
            "Silver Slasher",
            "Bronze Smasher",
            "Mercury Blaster",
            "Aluminum Dusters"
        };
        static List<string> itemTypes = new List<string>
        {
            "Spear",
            "Sword",
            "Hammer",
            "Gun",
            "Fists"
        };
        static List<int> itemLevels = new List<int> 
        {
            20,
            15,
            10,
            50,
            5
        };
        static List<int> itemBaseDamage = new List<int>
        {
            5,
            6,
            2,
            15,
            1
        };
        static bool checkingWeapons = true;
        static bool upgradingWeapons = false;
        static int upgradeAmount;
        //-----------------------------------------------------------//



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
                            Console.Write(field);

                            characterNames.Add(Console.ReadLine());

                            Console.Clear();
                            Console.WriteLine($"Now input your desired starting level for {characterNames[playerIDValue]}.");
                            Console.WriteLine();
                            Console.Write(field);
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
                            Console.Write(field);
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

                            leftoverCharacters--;
                            playerIDValue++;
                        }

                        Console.Clear();

                        for(int i = 0; i < playerIDValue; i++)
                        {
                            Character character = new Character(characterNames[i], characterLevels[i], characterLives[i], characterDifficulty[i]);
                            characters.Add(character);
                        }

                        foreach (Character player in characters)
                        {
                            player.ShowStats();
                        }

                        //Opdracht 8 End
                        programStart = false;
                        break;

                    case "task9":
                    case "task 9":
                    case "opdracht9":
                    case "opdracht 9":
                    case "9":
                        //Opdracht9 Start                       //Not Started
                                                                //Unlike task 8, no input here.
                                                                //Most games don't allow players to create weapons out of nothing.
                                                                //(This task is similar to 8, but constructing weapons instead of characters.)
                                                                //(The goals are similar, they just require different stats.)
                                                                //(The main idea is that the weapon has an upgrade level.)

                        foreach (int item in itemIDList) 
                        {
                            Weapons weapon = new Weapons
                            (
                                itemNames[item],
                                itemBaseDamage[item],
                                itemTypes[item],
                                itemLevels[item]
                            );

                        }
                        while (checkingWeapons) 
                        {
                            Console.WriteLine("Do you want to inspect a weapon or upgrade it?");
                            Console.WriteLine();
                            Console.Write(field);
                            playerTextInput = Console.ReadLine();
                            if (playerTextInput.ToLower() == "upgrade")
                            {
                                upgradingWeapons = true;
                                while (upgradingWeapons)
                                {
                                    Console.WriteLine("Which weapon do you want to upgrade?");
                                    Console.WriteLine();
                                    Console.Write(field);
                                    switch (playerTextInput.ToLower()) 
                                    {
                                        case "1":
                                        case "weapon 1":
                                            Console.Clear();
                                            Console.WriteLine($"You have selected {itemNames[itemIDList[0]]}");
                                            Console.WriteLine("By how much do you want to upgrade the weapon's level?");
                                            Console.WriteLine("One level adds 1 damage.");
                                            Console.WriteLine();
                                            Console.Write(field);
                                            if (Int32.TryParse(playerTextInput, out upgradeAmount))
                                            {
                                                weapon1.WeaponUpgrade(upgradeAmount);
                                                upgradingWeapons = false;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Try again, this time inputting a number.");
                                                Console.WriteLine();
                                            }
                                            break;
                                        case "2":
                                        case "weapon 2":
                                            Console.Clear();
                                            Console.WriteLine($"You have selected {itemNames[itemIDList[1]]}");
                                            Console.WriteLine("By how much do you want to upgrade the weapon's level?");
                                            Console.WriteLine("One level adds 1 damage.");
                                            Console.WriteLine();
                                            Console.Write(field);
                                            if (Int32.TryParse(playerTextInput, out upgradeAmount))
                                            {
                                                weapon2.WeaponUpgrade(upgradeAmount);
                                                upgradingWeapons = false;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Try again, this time inputting a number.");
                                                Console.WriteLine();
                                            }

                                            break;
                                        case "3":
                                        case "weapon 3":
                                            Console.Clear();
                                            Console.WriteLine($"You have selected {itemNames[itemIDList[2]]}");
                                            Console.WriteLine("By how much do you want to upgrade the weapon's level?");
                                            Console.WriteLine("One level adds 1 damage.");
                                            Console.WriteLine();
                                            Console.Write(field);
                                            if (Int32.TryParse(playerTextInput, out upgradeAmount))
                                            {
                                                weapon3.WeaponUpgrade(upgradeAmount);
                                                upgradingWeapons = false;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Try again, this time inputting a number.");
                                                Console.WriteLine();
                                            }

                                            break;
                                        case "4":
                                        case "weapon 4":
                                            Console.Clear();
                                            Console.WriteLine($"You have selected {itemNames[itemIDList[3]]}");
                                            Console.WriteLine("By how much do you want to upgrade the weapon's level?");
                                            Console.WriteLine("One level adds 1 damage.");
                                            Console.WriteLine();
                                            Console.Write(field);
                                            if (Int32.TryParse(playerTextInput, out upgradeAmount))
                                            {
                                                weapon4.WeaponUpgrade(upgradeAmount);
                                                upgradingWeapons = false;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Try again, this time inputting a number.");
                                                Console.WriteLine();
                                            }

                                            break;
                                        case "5":
                                        case "weapon 5":
                                            Console.Clear();
                                            Console.WriteLine($"You have selected {itemNames[itemIDList[4]]}");
                                            Console.WriteLine("By how much do you want to upgrade the weapon's level?");
                                            Console.WriteLine("One level adds 1 damage.");
                                            Console.WriteLine();
                                            Console.Write(field);
                                            if (Int32.TryParse(playerTextInput, out upgradeAmount))
                                            {
                                                weapon5.WeaponUpgrade(upgradeAmount);
                                                upgradingWeapons = false;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Try again, this time inputting a number.");
                                                Console.WriteLine();
                                            }

                                            break;
                                    }

                                }
                            }
                            Console.WriteLine("Which weapon do you want to see the stats for?");
                            Console.WriteLine();
                            Console.Write(field);
                            playerTextInput = Console.ReadLine();

                            switch (playerTextInput.ToLower())
                            {
                                case "1":
                                case "weapon 1":
                                case "golden stinger":
                                    weapon1.ShowStats();
                                        break;
                                case "2":
                                case "weapon 2":
                                case "silver slasher":
                                    weapon2.ShowStats();
                                    break;
                                case "3":
                                case "weapon 3":
                                case "bronze smasher":
                                    weapon3.ShowStats();
                                    break;
                                case "4":
                                case "weapon 4":
                                case "mercury blaster":
                                    weapon4.ShowStats();
                                    break;
                                case "5":
                                case "weapon 5":
                                case "aluminum dusters":
                                    weapon5.ShowStats();
                                    break;
                                case "exit":
                                case "stop":
                                case "leave":
                                case "none":
                                    checkingWeapons = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                        //Opdracht 9 End
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
