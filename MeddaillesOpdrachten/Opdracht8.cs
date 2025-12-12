using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdrachten
{
    internal class Opdracht8
    {
        private string _characterName;
        private int _characterLevel;
        private int _characterLives; // 3 lives = hard | 5 lives = normal | 10 lives = easy

        public Opdracht8(string name, int level, int lives)
        {
            _characterName = name;
            _characterLevel = level;
            _characterLives = lives;
            
            Console.WriteLine($"A character with the name {_characterName} has been made.");

        }

        public void ShowStats()
        {
            Console.WriteLine();
            Console.WriteLine($"These are the stats for the character {_characterName}");
            Console.WriteLine();
            Console.WriteLine($"Level: {_characterLevel}");
            Console.WriteLine($"Lives: {_characterLives}");
            Console.WriteLine();
            Console.WriteLine("____________________________________________________________");
        }



        
    }
}
