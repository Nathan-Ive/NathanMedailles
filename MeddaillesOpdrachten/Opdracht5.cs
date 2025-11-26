using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdrachten
{
    internal class Opdracht5
    {


        private bool _runningFirstPhase = true;
        private bool _runningSecondPhase = true;
        private int _userDesiredNumber;
        private string _userNumberInput;
        private int _userDesiredAmount;
        private string _userAmountInput;


        public void Start()
        {

            while (_runningFirstPhase) 
            {
                Console.WriteLine("Input your desired number for multiplication tables.");
                _userNumberInput = Console.ReadLine();
                if (Int32.TryParse(_userNumberInput, out _userDesiredNumber))
                {
                    _runningFirstPhase = false;
                }
                else 
                {
                    Console.WriteLine("Please try again, and input a number this time.");
                }

            }


            while (_runningSecondPhase) 
            {
                Console.Clear();
                Console.WriteLine("Now input your desired amount of multiplications.");
                _userAmountInput = Console.ReadLine();
                if (Int32.TryParse(_userAmountInput, out _userDesiredAmount))
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for your input, here is your multiplication table: ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    for (int i = 0; i <= _userDesiredAmount; i++)
                    {
                        Console.WriteLine(_userDesiredNumber * i);
                    }

                    _runningSecondPhase = false;
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Please try again, and input a number this time");
                }


            }
        }
    }
}
