using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdrachten
{
    internal class Opdracht3
    {
        public void Start()
        {
            String temperatureInput = "Null";
            String weatherInput = "Null";
            int currentTemperature = 0;
            Boolean validWeather = false;
            Boolean validTemp = false;
            Boolean validValues = false;
            Boolean hintFinished = false;
            Boolean programCompletion = false;


            while (!programCompletion)
            {

                Console.WriteLine("This program will give you hints based on the weather you input.");
                Console.WriteLine("What is the current weather?");

                while (!validWeather)
                {

                    Console.Write("Please input sunny, rainy or cloudy: ");
                    weatherInput = Console.ReadLine();
                    switch (weatherInput) {
                        case "Sunny":
                        case "sunny":
                        case "Rainy":
                        case "rainy":
                        case "Cloudy":
                        case "cloudy":
                            Console.WriteLine("Thank you, next put in the temperature please.");
                            Console.Write("The temperature must be a number: ");
                            validWeather = true;
                            break;
                        default:
                            Console.WriteLine("This is not one of the three valid Weather types, please try again.");
                            Console.WriteLine("");
                            validWeather = false;
                            break;
                    }
                }

                while (!validTemp) 
                {
                    temperatureInput = Console.ReadLine();


                    if (!Int32.TryParse(temperatureInput, out currentTemperature))
                    {
                        Console.WriteLine("This temperature isn't valid, please try again.");
                        Console.WriteLine("");
                        Console.Write("The temperature must be a number: ");
                        validTemp = false;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the input. Press Enter to check your given Temperature and Weather.");
                        Console.WriteLine("Press Enter again to see your hint.");
                        Console.ReadLine();
                        validTemp = true;
                    }
                }


                if (validWeather && validTemp) 
                {
                    validValues = true;
                }

                

                if (validValues && currentTemperature > 30) {
                    Console.Clear();
                    Console.WriteLine("With the temperature being over 30 degrees, you should just be wearing short clothes, regardless of the weather.");
                    Console.WriteLine("Be sure to bring some water.");
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________");
                    Console.WriteLine("");
                    Console.Write("Once you've finished reading, press Enter to finish the program:");
                    Console.ReadLine();
                    hintFinished = true;
                } 
                else if (validValues && currentTemperature < 0) 
                {
                    Console.Clear();
                    Console.WriteLine("It's freezing, so you should bring a big coat and wear thick pants regardless of the weather.");
                    Console.WriteLine("Don't forget to wear some gloves too.");
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________");
                    Console.WriteLine("");
                    Console.Write("Once you've finished reading, press Enter to finish the program:");
                    Console.ReadLine();
                    hintFinished = true;
                }
                else if (validValues && (weatherInput == "Sunny" || weatherInput == "sunny"))
                {
                    Console.Clear();
                    if (currentTemperature <= 30)
                    {
                        Console.WriteLine("It's hot and sunny out. Wear short clothes and put on some sunscreen. Enjoy the sun with some sunglasses.");
                    }
                    else if (currentTemperature <= 20)
                    {
                        Console.WriteLine("The temperature is comfortable and it's sunny. You don't need a coat, wear what you want and enjoy the weather.");
                    }
                    else if (currentTemperature <= 10)
                    {
                        Console.WriteLine("The temeprature is somewhat low. So despite the sun being out, you should wear a coat to stay comfortable. Either way, enjoy the sun!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________");
                    Console.WriteLine("");
                    Console.Write("Once you've finished reading, press Enter to finish the program:");
                    Console.ReadLine();
                    hintFinished = true;
                }
                else if (validValues && (weatherInput == "Cloudy" || weatherInput == "cloudy"))
                {
                    Console.Clear();
                    if (currentTemperature <= 30)
                    {
                        Console.WriteLine("It's hot and cloudy. You should be fine wearing short clothes, but take an umbrella just in case it decides to rain.");
                    }
                    else if (currentTemperature <= 20)
                    {
                        Console.WriteLine("It's cloudy. With the temperature being comfortable, you can wear what you want. But you might want to wear a raincoat just in case.");
                    }
                    else if (currentTemperature <= 10)
                    {
                        Console.WriteLine("With the temperature being low, and the sky being cloudy you should wear a winter coat.");
                        Console.WriteLine("Without the sun it'll be cold, so it's nice to have something warm and fluffy while it isn't raining.");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________");
                    Console.WriteLine("");
                    Console.Write("Once you've finished reading, press Enter to finish the program:");
                    Console.ReadLine();
                    hintFinished = true;
                }
                else if (validValues && (weatherInput == "Rainy" || weatherInput == "Rainy"))
                {
                    Console.Clear();
                    if (currentTemperature <= 30)
                    {
                        Console.WriteLine("It's hot, but it's raining. With it being too warm to wear a coat, grab an umbrella and stay under it.");
                    }
                    else if (currentTemperature <= 20)
                    {
                        Console.WriteLine("It's raining. Wear a raincoat or take an umbrella. It's not too hot or cold out, so you can pick whichever you're more comfortable with.");
                    }
                    else if (currentTemperature <= 10)
                    {
                        Console.WriteLine("It's cold and it's raining. Wear a raincoat and something thick under it. Try not to get too cold in this weather, and avoid getting wet if you can.");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________");
                    Console.WriteLine("");
                    Console.Write("Once you've finished reading, press Enter to finish the program:");
                    Console.ReadLine();
                    hintFinished = true;
                }


                if (hintFinished)
                {
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("Thanks for using the program!");
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________");
                    programCompletion = true;
                }
            }
        }
    }
}
