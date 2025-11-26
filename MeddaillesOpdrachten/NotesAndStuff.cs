using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdracht2
{
    internal class NotesAndStuff
    {
        //for loops
        //for each
        //while
        //do while

        private bool _running = true;
        private int _whileNumbers = 0;
        private int _forNumbers = 1;
        private int[] _eachNumbers = new int [10];
        private int _doNumbers = 0;

        public void Start() 
        {


            do
            {
                _doNumbers++;
                Console.WriteLine("These are do while numbers: " + _doNumbers);

            } while (_doNumbers < 10);

            while (_running) 
            {
                _whileNumbers++;
                Console.WriteLine("      These are while numbers: " + _whileNumbers);

                if(_whileNumbers >= 10)
                {
                    _running = false;
                }
                
            }

            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine("         These are for loop numbers: " + i);
            }

            foreach (int number in _eachNumbers) 
            {
                Console.WriteLine("            These are for each numbers: " + _forNumbers++);
            }

        }
    }
}
