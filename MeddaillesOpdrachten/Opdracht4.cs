using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdrachten
{
    internal class Opdracht4
    {
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

            String[] monthList = { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
            String[] monthListCap = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            String [] currentMonthText = monthListCap;
            int currentDay = DateTime.Now.Day;
            int currentDayRaw;
            int monthMaxValue = 12;
            int[] dayMaxValue = { 28, 30, 31 };
            int[] dayMaxValueLeap = { 29, 30, 31};


            int userYear = 2000;
            int userMonth = 1;
            String[] userMonthText = monthListCap;
            int userDay = 1;
            int userDayRaw;
            String userYearInput;
            String userMonthInput;
            String userDayInput;

            Boolean currentLeapYear = false;
            Boolean userLeapYear = false;
            int normalYearMaxDays = 365;
            int leapYearMaxDays = 366;
            int[] dayInMonthValues = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };
            int[] dayInMonthValuesLeap = { 0, 31, 60, 91, 121, 152, 182, 213, 244, 274, 305, 335 };


            Boolean validYearInput = false;
            Boolean validMonthInput = false;
            Boolean validDayInput = false;



                    while (!validYearInput){
                Console.WriteLine("Please input the year of your birth.");
                userYearInput = Console.ReadLine();

                if (!Int32.TryParse(userYearInput, out userYear) && userYear <= currentYear)
                {
                    validYearInput = true;
                }
                else {
                    validYearInput = false;
                    Console.Clear();
                    Console.WriteLine("Please try again, inputting a year that is lower than the current one.");
                }

            }

            //System clock leap year check
            if (currentYear % 4 == 0 && currentYear % 100 != 0 || currentYear % 400 == 0)
            {
                currentLeapYear = true;
            }
            else
            {
                currentLeapYear = false;
            }

            //User leap year check.
            if (userYear % 4 == 0 && userYear % 100 != 0 || userYear % 400 == 0)
            {
                userLeapYear = true;
            }
            else
            {
                userLeapYear = false;
            }


            while (!validMonthInput)
            {
                Console.WriteLine("Please input the month of your birth.");
                userMonthInput = Console.ReadLine();

                if (!Int32.TryParse(userMonthInput, out userMonth)) 
                {
                    validMonthInput = true;
                }
                else
                {
                    validMonthInput = false;
                    Console.Clear();
                    Console.WriteLine("Please try again, inputting a month value that is lower than twelve, or the name of a month.");
                }

            }

            while (!validDayInput) {
                Console.WriteLine("Please input the relevant day of your birth.");
                userDayInput = Console.ReadLine();
            }



            if (!currentLeapYear)
            {
                currentDayRaw = currentDay + dayInMonthValues[currentMonth - 1];
                userDayRaw = userDay + dayInMonthValues[userMonth - 1];

                if (currentDayRaw <= normalYearMaxDays)
                {
                    Console.WriteLine("The current year is: Year " + currentYear);
                    Console.WriteLine("The current month is: Month " + currentMonth + " - Which is " + currentMonthText[currentMonth - 1]);
                    Console.WriteLine("The current day is: Day " + currentDay + " - that's day " + currentDayRaw + " of the year.");

                    Console.WriteLine("Your birth year is: Year " + userYear);
                    Console.WriteLine("The month of your birth is: Month " + userMonth + " - Which is " + userMonthText[userMonth - 1]);
                    Console.WriteLine("The day of your birth is: Day " + userDay + " - Which is day " + userDayRaw + " of that year.");
                }


            }
            else
            {
                currentDayRaw = currentDay + dayInMonthValuesLeap[currentMonth - 1];
                userDayRaw = userDay + dayInMonthValuesLeap[userMonth - 1];
            }



        }
    }
}
