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
        private int _userAge;

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
                        _userAge = (_currentYear - _userYear);
                        Console.WriteLine("Your birth month is lower than the current month.");
                        Console.WriteLine("Based on this information you are " + _userAge + " years old.");
                    }
                    else if (_userMonth > _currentMonth) 
                    {
                        _userAge = (_currentYear - _userYear) - 1;
                        Console.WriteLine("Your birth month comes after the current month.");
                        Console.WriteLine("This means your birthday is still approaching, which makes you " + _userAge + " years old.");
                    }
                    else if (_userMonth == _currentMonth) 
                    {
                        Console.WriteLine("The current month and your birth month match up.");
                        Console.WriteLine("This makes the day of your birth relevant as well.");

                        if (_userDay < _currentDay)
                        {
                            _userAge = (_currentYear - _userYear);
                            Console.WriteLine("Your birth day is lower than the current day.");
                            Console.WriteLine("With the current day having passed your birthday this month you are now " + _userAge + " years old. A late happy birthday to you.");

                        }
                        else if (_userDay > _currentDay)
                        {
                            _userAge = (_currentYear - _userYear) - 1;
                            Console.WriteLine("Your birth day is greater than the current day.");
                            Console.WriteLine("Since we've passed your birthday  you are" + _userAge + " years old.");

                        }
                        else if (_userDay == _currentDay) 
                        {
                            _userAge = (_currentYear - _userYear);
                            Console.WriteLine("Your birth day is equal to the current day.");
                            Console.WriteLine("Happy birthday! You've become " + _userAge + " years old today. Congratulations.");

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


            
            Console.ReadLine();
            if (_userAge >= 18)
            {

                Console.Clear();
                Console.WriteLine($"With your age being {_userAge}, you are allowed to vote.");
            }
            else 
            {
                Console.Clear();
                Console.WriteLine($"Since you're younger than 18, being {_userAge} years old, you cannot vote yet.");
            }


        }
    }
}
