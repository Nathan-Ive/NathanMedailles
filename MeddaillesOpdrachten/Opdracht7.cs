using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdrachten
{
    internal class Opdracht7
    {

        private bool _theQuestion = true;

        private string _rollAmountInput;
        private int _desiredRollAmount;
        private int _mostRolledDice;


        private int _diceNumber;
        private float[] _rolledCount = new float[6];
        private string[] _writtenCount =
        {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six"
        };


        public void Start()
        {
            Random diceRoll = new Random();

            while (_theQuestion)
            {

                Console.WriteLine("How many times do you want to roll the dice?");
                Console.Write("Insert the amount here:");
                _rollAmountInput = Console.ReadLine();
                if (Int32.TryParse(_rollAmountInput, out _desiredRollAmount))
                {
                    _theQuestion = false;
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Please input a number.");
                }



            }



            for (int i = 0; i < _desiredRollAmount; i++) 
            {
                _diceNumber = diceRoll.Next(1, 7);

                switch (_diceNumber)
                {
                    case 1:
                        _rolledCount[0]++;
                        break;
                    case 2:
                        _rolledCount[1]++;
                        break;
                    case 3:
                        _rolledCount[2]++;
                        break;
                    case 4:
                        _rolledCount[3]++;
                        break;
                    case 5:
                        _rolledCount[4]++;
                        break;
                    case 6:
                        _rolledCount[5]++;
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("After rolling the dice " + _desiredRollAmount + " times.");


            for (int calculate = 0; calculate < _rolledCount.Length; calculate++)
            {
                float totalPercentage = (_rolledCount[calculate] / _desiredRollAmount) * 100;

                Console.WriteLine("The dice landed on " + _writtenCount[calculate] + " " + System.Math.Round(totalPercentage,2) + "% of the time.");
            }


            _mostRolledDice = _rolledCount.ToList().IndexOf(_rolledCount.Max());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("The the dice landed on " + _writtenCount[_mostRolledDice] + " the most.");
            Console.WriteLine("Landing a total of " + _rolledCount[_mostRolledDice] + " times.");


        }
    }
}
