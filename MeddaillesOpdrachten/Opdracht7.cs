using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdrachten
{
    internal class Opdracht7
    {

        private bool _theQuestion = true;

        private string _rollAmountInput;
        private int _desiredRollAmount;

        private int _diceNumber;
        private int _rolledOneCount;
        private int _rolledTwoCount;
        private int _rolledThreeCount;
        private int _rolledFourCount;
        private int _rolledFiveCount;
        private int _rolledSixCount;


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
                        _rolledOneCount++;
                        break;
                    case 2:
                        _rolledTwoCount++;
                        break;
                    case 3:
                        _rolledThreeCount++;
                        break;
                    case 4:
                        _rolledFourCount++;
                        break;
                    case 5:
                        _rolledFiveCount++;
                        break;
                    case 6:
                        _rolledSixCount++;
                        break;
                }


            }

            Console.Clear();
            Console.WriteLine("The dice landed on one " + _rolledOneCount + " times.");
            Console.WriteLine("The dice landed on two " + _rolledTwoCount + " times.");
            Console.WriteLine("The dice landed on three " + _rolledThreeCount + " times.");
            Console.WriteLine("The dice landed on four " + _rolledFourCount + " times.");
            Console.WriteLine("The dice landed on five " + _rolledFiveCount + " times.");
            Console.WriteLine("The dice landed on six " + _rolledSixCount + " times.");




        }
    }
}
