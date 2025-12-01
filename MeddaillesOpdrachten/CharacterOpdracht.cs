using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdracht2
{
    internal class CharacterOpdracht
    {
        private string _characterName;
        private int _health;

        public CharacterOpdracht(string characterName, int hp, bool spawned, float speed)
        {
            _characterName = characterName;
            _health = hp;
            Console.WriteLine($"A character with the name {_characterName} has been made.");

        }

        public void SayHello()
        {
            Console.WriteLine("Hey, nice to meet you.");
        }


        public void DamageTaken(int damageAmount) 
        {
            Console.WriteLine($"{_characterName} has taken {damageAmount} damage.");
            _health -= damageAmount;
            Console.WriteLine($"They have {_health} HP left.");
            
        }




    }
}
