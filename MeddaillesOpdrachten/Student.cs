using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdracht2
{
    internal class Student
    {
        //Make a student class
        //give them the following traits
        ///Name
        ///Age
        ///Last Name
        //Fill in the traits in a constructor
        //Make a function that prints the first and last name
        //Make two instances of students
        //Use the function that was described earlier???

        private int _studentAge;
        private string _studentFirstName;
        private string _studentLastName;


        public Student(string name, string lastName, int age) 
        {
            _studentAge = age;
            _studentFirstName = name;
            _studentLastName = lastName;
        }

        public void namePrinter() 
        {
            Console.WriteLine($"This student's name is {_studentFirstName} {_studentLastName}.");

        }


    }
}
