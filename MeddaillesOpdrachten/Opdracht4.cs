using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdrachten
{
    internal class Opdracht4
    {


        private List<string> _monthList = new List<string>() 
        {
            "january", 
            "february", 
            "march", 
            "april", 
            "may", 
            "june", 
            "july", 
            "august", 
            "september", 
            "october", 
            "november", 
            "december" 
        };
        
        private List<string> _monthListCap = new List<string>()
        { 
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };

        private int _currentYear = DateTime.Now.Year;
        private int _currentMonth = DateTime.Now.Month;
        private int _currentDay = DateTime.Now.Day;
        private int _currentDayRaw;
        private int _monthMaxValue = 12;
        private int[] _dayMaxValue = 
        { 
            28,
            30,
            31,
            29
        };

        private int _userYear;
        private int _userMonth;
        private string _userMonthText;
        private int _userDay;
        private int _userDayRaw;
        private string _userYearInput;
        private string _userMonthInput;
        private string _userDayInput;

        private Boolean _currentLeapYear = false;
        private Boolean _userLeapYear = false;
        private int _normalYearMaxDays = 365;
        private int _leapYearMaxDays = 366;
        private int[] _dayInMonthValues = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };
        private int[] _dayInMonthValuesLeap = { 0, 31, 60, 91, 121, 152, 182, 213, 244, 274, 305, 335 };


        private Boolean _validYearInput = false;
        private Boolean _validMonthInput = false;
        private Boolean _validDayInput = false;
        private Boolean _userIsItFebruary = false; //Checks to see if it's february, which has 28 or 29 days depending on whether or not it's a leap year.
        private Boolean _userMonthHighDays = false; //Months that contain 31 days {January[0], March[2], May[4], July[6], August[7], October[9], December[11]}
        private Boolean _userMonthLowDays = false; //Months that contain 30 days {April[3], June[5], September[8], November[10]}


        public void Start()
        {
            //The task is to make a calculator for someone's age based on their input.
            //The program will explain what it is, and ask for different fields to be entered.
            //For year, they shouldn't be allowed to type higher than the current year.
            //For month, they shouldn't be allowed to type higher than twelve.
            ///Or I could have them type the month with text instead of numbers. I could also have them be allowed to do both.
            //For the day, the user shouldn't be allowed to go above a certain number depending on the month they entered in the input.
            ///And in the case that they're born in a leap year, this limit has to be different for a couple of months.
            //The task also requests that I give a different response depending on their age. Specifically, three different responses for those older than 18.


            //There's a couple ways to do all of this. I could seperate the months through 12 if statements, or seperate them using a switch statement with 12 cases.
            ///I think I'll do the switch cases, since it's easier to account for "or" in those.
            //For years and days, I could settle for simple checks if they're adhering to a certain set of rules.
            //Regardless, years come first to check for leap years. Then months to check if the month is impacted by that, and based on those two inputs the limit on days is set.
            //As for the responses to age, under 18 should say something like "you can't vote". And over 18 should say the opposite.
            //Then the three unique responses for various milestones over 18 like "young adult", "adult", and "senior".
            //It's also easy to make a response set for those who are older than 18 years, but happen to have a low number due to being born in a leap year.


            //I think that I've considered every possibility now. I just have to find a way to calculate this accurately.
            //I could make a method that calculates age by checking each value and subtracting their year from the current year, executing it at the end of the program.
            //This doesn't account for leap years however.

            //Leap years work on the following rules:
            ///They happen once every 4 years. Years divisible by 100 are skipped, unless those years that are divisible by 100 are also divisible by 400.
            ///Basically, if someone is typing a realistic year like 2000, then they are born in a leap year because that year was divisible by 400.
            ///However, if someone writes down that they were born in the year 1900, then not only are they the oldest person currently alive, but they also got skipped because 1900 isn't divisble by 400.
            ///This rule also applies to the years 400, 800, 1200, 1600 and 2400. However, I won't have to account for that because this is a random program for a gold medal, and not something that'll be used in the distant future.
            ///I kind of want to though, just for fun. But I'll make the basic calculator and program first.


            //The variables I need are as follows:
            ///currentYear = intiger
            ///currentMonth = intiger
            ///currentDay = intiger
            //------------------------------------------------//
            ///userYear = intiger
            ///userMonth = intiger
            ///userDay = intiger
            ///leapYearCheck = boolean
            //------------------------------------------------//
            ///yearDifference = intiger - //Can be dirrectly calculated, no conversion needed
            ///monthDifference = intiger - //Needs to be calculated in a difference of 12
            ///dayDifference = intiger - //Needs to be calculated in a difference of 365
            //------------------------------------------------//
            ///checkAdulthood = boolean
            ///adulthoodCheckpoint1 = intiger - //Checks if the user is older than 25
            ///adulthoodCheckpoint2 = intiger - //Checks if the user is older than 40
            ///adulthoodCheckpoint3 = intiger - //Checks if the user is older than 65
            ///adulthoodTooOld = intiger - //Checks if the user is older than 100
            ///recordBreaker = intiger - //Checks if the user is older than 122 (The documented oldest age a person has lived)
            ///impossibleAge = boolean - //Checks if the user is younger than 0
            //------------------------------------------------//
            ///ageCalculator = method // receives three values (userDay, userMonth, userYear), and calculates them by comparing them and following an equation based on the current day, month, and year based on the PCs calendar


            while (!_validYearInput)
            {
                Console.Clear();
                Console.WriteLine("Please input the year of your birth.");
                _userYearInput = Console.ReadLine();

                if (Int32.TryParse(_userYearInput, out _userYear) && _userYear <= _currentYear && _userYear > 0)
                {
                    _validYearInput = true;
                }
                else {
                    _validYearInput = false;
                    Console.Clear();
                    Console.WriteLine("Please try again, inputting a year that is lower than or equal to the current one.");
                }

            }


            //System clock leap year check
            if (_currentYear % 4 == 0 && _currentYear % 100 != 0 || _currentYear % 400 == 0)
            {
                _currentLeapYear = true;
            }
            else
            {
                _currentLeapYear = false;
            }

            //User leap year check.
            if (_userYear % 4 == 0 && _userYear % 100 != 0 || _userYear % 400 == 0)
            {
                _userLeapYear = true;
            }
            else
            {
                _userLeapYear = false;
            }


            while (!_validMonthInput)
            {
                Console.Clear();
                Console.WriteLine("Please input the month of your birth numerically.");
                _userMonthInput = Console.ReadLine();

                if (Int32.TryParse(_userMonthInput, out _userMonth) && _userMonth > 0 && _userMonth <= _monthMaxValue) 
                {
                    _userMonthInput = _monthListCap[_userMonth - 1];

                    switch (_userMonthInput) {
                        case "January":
                        case "March":
                        case "May":
                        case "July":
                        case "August":
                        case "October":
                        case "December":
                            _userMonthHighDays = true;
                            _userMonthLowDays = false;
                            _userIsItFebruary = false;
                            break;
                        case "April":
                        case "June":
                        case "September":
                        case "November":
                            _userMonthHighDays = false;
                            _userMonthLowDays = true;
                            _userIsItFebruary = false;
                            break;
                        case "February":
                            _userMonthHighDays = false;
                            _userMonthLowDays = false;
                            _userIsItFebruary = true;
                            break;
                    }
                        _validMonthInput = true;
                }
                else
                {
                    _validMonthInput = false;
                    Console.Clear();
                    Console.WriteLine("Please try again, inputting a month value that is also lower than twelve.");
                }

            }

            while (!_validDayInput) {
                Console.Clear();
                Console.WriteLine("Please input the relevant day of your birth.");
                _userDayInput = Console.ReadLine();

                if (Int32.TryParse(_userDayInput, out _userDay) && _userDay > 0)
                {
                    _validDayInput = true;

                    if (_userMonthHighDays)
                    {
                        if (_userDay > _dayMaxValue[2])
                        {
                            _validDayInput = false;
                        }
                    }
                    else if (_userMonthLowDays)
                    {
                        if (_userDay > _dayMaxValue[1])
                        {
                            _validDayInput = false;
                        }
                    }
                    else if (_userIsItFebruary && _userLeapYear)
                    {
                        if (_userDay > _dayMaxValue[3])
                        {
                            _validDayInput = false;
                        }
                    }
                    else if (_userIsItFebruary && !_userLeapYear)
                    {
                        if (_userDay > _dayMaxValue[0])
                        {
                            _validDayInput = false;
                        }
                    }
                }
                
                if (!_validDayInput)
                {
                    Console.Clear();
                    Console.WriteLine("Please try again, inputting a day value appropriate to the month you chose.");
                }

            }



            if (!_currentLeapYear)
            {
                Console.Clear();
                _currentDayRaw = _currentDay + _dayInMonthValues[_currentMonth - 1];
                _userDayRaw = _userDay + _dayInMonthValues[_userMonth - 1];

                if (_currentDayRaw <= _normalYearMaxDays)
                {
                    Console.WriteLine("The current year is: Year " + _currentYear);
                    Console.WriteLine("The current month is: Month " + _currentMonth + " - Which is " + _monthListCap[_currentMonth - 1]);
                    Console.WriteLine("The current day is: Day " + _currentDay + " - that's day " + _currentDayRaw + " of the year.");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Your birth year is: Year " + _userYear);
                    Console.WriteLine("The month of your birth is: Month " + _userMonth + " - Which is " + _monthListCap[_userMonth - 1]);
                    Console.WriteLine("The day of your birth is: Day " + _userDay + " - Which is day " + _userDayRaw + " of that year.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("According to the information you have given, there's a difference of " + (_currentYear - _userYear) + " years between your birth year and the current year.");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    if (_userMonth < _currentMonth) 
                    {
                        Console.WriteLine("Your birth month is lower than the current month.");
                        Console.WriteLine("Based on this information you are " + ((_currentYear + _userYear) - 1) + " years old.");
                    }
                    else if (_userMonth > _currentMonth) 
                    {
                        Console.WriteLine("Your birth month comes after the current month.");
                        Console.WriteLine("This means your birthday is still approaching, which makes you " + (_currentYear - _userYear) + " years old.");
                    }
                    else if (_userMonth == _currentMonth) 
                    {
                        Console.WriteLine("The current month and your birth month match up.");
                        Console.WriteLine("This makes the day of your birth relevant as well.");

                        if (_userDay < _currentDay)
                        {
                            Console.WriteLine("Your birth day is lower than the current day.");
                            Console.WriteLine("With the current day having passed your birthday this month you are now " + ((_currentYear + _userYear)) + " years old. A late happy birthday to you.");

                        }
                        else if (_userDay > _currentDay)
                        {
                            Console.WriteLine("Your birth day is greater than the current day.");
                            Console.WriteLine("Since we're still approaching your birthday  you are" + ((_currentYear - _userYear)) + " years old.");

                        }
                        else if (_userDay == _currentDay) 
                        {
                            Console.WriteLine("Your birth day is equal to the current day.");
                            Console.WriteLine("Happy birthday! You've become " + ((_currentYear + _userYear)) + " years old today. Congratulations.");

                        }
                    }
                }
                else 
                {
                    Console.WriteLine("You have somehow input a value that allowed you to exceed the maximum amount of days within a normal year, please restart the program.");

                }


            }
            else
            {
                Console.Clear();
                _currentDayRaw = _currentDay + _dayInMonthValuesLeap[_currentMonth - 1];
                _userDayRaw = _userDay + _dayInMonthValuesLeap[_userMonth - 1];


                if (_currentDayRaw <= _leapYearMaxDays)
                {
                    Console.WriteLine("The current year is: Year " + _currentYear);
                    Console.WriteLine("The current month is: Month " + _currentMonth + " - Which is " + _monthListCap[_currentMonth - 1]);
                    Console.WriteLine("The current day is: Day " + _currentDay + " - that's day " + _currentDayRaw + " of the year.");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Your birth year is: Year " + _userYear);
                    Console.WriteLine("The month of your birth is: Month " + _userMonth + " - Which is " + _monthListCap[_userMonth - 1]);
                    Console.WriteLine("The day of your birth is: Day " + _userDay + " - Which is day " + _userDayRaw + " of that year.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("According to the information you have given, your age is calculated at " + (_currentYear - _userYear) + " years old.");
                }
                else
                {
                    Console.WriteLine("You have somehow input a value that allowed you to exceed the maximum amount of days within a leap year, please restart the program.");
                }

            }



        }
    }
}
