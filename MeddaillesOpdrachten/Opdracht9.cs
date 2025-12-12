using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdrachten
{
    internal class Opdracht9
    {
        private string _weaponName;
        private int _weaponDamage; //Should be increaseable through a "WeaponUpgrade" function.
        private string _weaponType;
        private int _weaponUpgradeLevel;

        public Opdracht9(string name, int damage, string type, int level)
        {
            _weaponName = name;
            _weaponDamage = damage;
            _weaponType = type;
            _weaponUpgradeLevel = level;

            Console.WriteLine($"A weapon named {_weaponName} has been made.");

        }

        public void ShowStats()
        {
            Console.WriteLine();
            Console.WriteLine($"These are the stats for the weapon: {_weaponName}");
            Console.WriteLine();
            Console.WriteLine($"Damage: {_weaponDamage}");
            Console.WriteLine($"Type: {_weaponType}");
            Console.WriteLine($"Upgrades: {_weaponUpgradeLevel}");
            Console.WriteLine();
            Console.WriteLine("____________________________________________________________");
        }


        public int WeaponUpgrade(int damageToAdd) 
        {
            int levelIncrease = 1;



            return levelIncrease;
        }
    }
}
