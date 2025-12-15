using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdrachten
{
    internal class Character
    {
        private string _characterName;
        private int _characterLevel;
        private int _characterLives; // 3 lives = hard | 5 lives = normal | 10 lives = easy
        private string _characterDifficulty;

        public Character(string name, int level, int lives, string difficulty)
        {
            _characterName = name;
            _characterLevel = level;
            _characterLives = lives;
            _characterDifficulty = difficulty;
            
            Console.WriteLine($"A character with the name {_characterName} has been made.");

        }

        public void ShowStats()
        {
            Console.WriteLine();
            Console.WriteLine($"These are the stats for the character {_characterName}");
            Console.WriteLine();
            Console.WriteLine($"Level: {_characterLevel}");
            Console.WriteLine($"Lives: {_characterLives}");
            Console.WriteLine($"The character {_characterName} has chosen the {_characterDifficulty} difficulty.");
            Console.WriteLine();
            Console.WriteLine("____________________________________________________________");
        }



        
    }
}
