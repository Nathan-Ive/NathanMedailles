using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdracht2
{
    internal class User
    {
        private string _name;
        private string _password;
        private int _age;
        private int _userID;
        private bool _administrator;

        public User(string name, string password, int age, int userID) 
        {
            _name = name;
            _password = password;
            _age = age;
            _userID = userID;

            if (_name.ToLower() == "nathan")
            {
                _administrator = true;
            }
            else 
            {
                _administrator = false;
            }

            if (_administrator)
            {
                Console.WriteLine($"This is an administrator account. Welcome {_name}");
            }
            else
            {
                Console.WriteLine($"A new user with the name {_name} has been successfully created.");

            }

            Console.WriteLine($"The user ID for {_name} is {_userID}");



        }


    }
}
