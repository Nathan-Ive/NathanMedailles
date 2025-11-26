using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdrachten
{
    internal class Opdracht6
    {

        private bool _settingMaximum = true;
        private bool _userIsGuessing = false;
        private string _userGuessInput;
        private int _userGuessNumber;
        private string _desiredMaxInput;
        private int _desiredMax;
        private int _guessAmount = 0;

        public void Start()
        {

            while (_settingMaximum)
            {
                Console.WriteLine("Hello, please input the desired maximum number you'd like to guess for.");
                Console.Write("Input your number here: ");
                _desiredMaxInput = Console.ReadLine();

                if (Int32.TryParse(_desiredMaxInput, out _desiredMax))
                {
                    if (_desiredMax < 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Please do not put in a number that is lower than 1. Thank you.");
                    }
                    else 
                    {
                        _settingMaximum = false;
                        _userIsGuessing = true;
                        Console.Clear();
                    }

                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("That is not a number, please try again, inputting a number this time.");
                }

            }

            Random randomNumber = new Random();



            int theNumber = randomNumber.Next(1, _desiredMax);


            while (_userIsGuessing)
            {
                Console.WriteLine("The program has generated a number between 1 and " + _desiredMax + ", guess until you get it right.");
                Console.Write("Fill in your number here: ");
                _userGuessInput = Console.ReadLine();
                if (Int32.TryParse(_userGuessInput, out _userGuessNumber))
                {
                    if (_userGuessNumber < theNumber)
                    {
                        _guessAmount++;
                        if (_userGuessNumber - theNumber >= -10)
                        {
                            Console.Clear();
                            Console.WriteLine("You're close, your number is at least 10 lower than the generated number. Try again until you get it right.");
                            Console.WriteLine("");
                            Console.WriteLine("");

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Your guess is lower than the generated number. Try again until you get it right.");
                            Console.WriteLine("");
                            Console.WriteLine("");

                        }

                    }
                    else if (_userGuessNumber > theNumber)
                    {
                        _guessAmount++;
                        if (_userGuessNumber - theNumber <= 10)
                        {
                            Console.Clear();
                            Console.WriteLine("You're close, your guess is at least 10 higher than the generated number. Try again until you get it right.");
                            Console.WriteLine("");
                            Console.WriteLine("");

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Your guess is higher than the generated number. Try again until you get it right.");
                            Console.WriteLine("");
                            Console.WriteLine("");

                        }

                    }
                    else if (_userGuessNumber == theNumber)
                    {
                        _guessAmount++;
                        Console.Clear();
                        Console.WriteLine("Congratulations, you got the right number! You're done guessing!");
                        Console.WriteLine("You got the number after " + _guessAmount + " guesses.");
                        _userIsGuessing = false;
                    }
                    
                    
                    if (_userGuessNumber > _desiredMax) 
                    {
                        _guessAmount--;
                        Console.Clear();
                        Console.WriteLine("This won't count as a guess, but please input a number that is lower than the one you set.");
                    }


                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Please input a number.");
                }


            }
        }
    }
}
