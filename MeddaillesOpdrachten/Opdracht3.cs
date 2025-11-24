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
        private String _temperatureInput = "Null";
        private String _weatherInput = "Null";
        private int _currentTemperature = 0;
        private Boolean _validWeather = false;
        private Boolean _validTemp = false;
        private Boolean _userCheckingVariables = false;
        private Boolean _validValues = false;
        private Boolean _hintFinished = false;
        private Boolean _programCompletion = false;

        public void Start()
        {
            while (!_programCompletion)
            {
                Console.WriteLine("This program will give you hints based on the weather you input.");
                Console.WriteLine("What is the current weather?");

                while (!_validWeather)
                {

                    Console.Write("Please input sunny, rainy or cloudy: ");
                    _weatherInput = Console.ReadLine();
                    switch (_weatherInput) {
                        case "Sunny":
                        case "sunny":
                        case "Rainy":
                        case "rainy":
                        case "Cloudy":
                        case "cloudy":
                            Console.WriteLine("Thank you, next put in the temperature please.");
                            _validWeather = true;
                            break;
                        default:
                            Console.WriteLine("This is not one of the three valid Weather types, please try again.");
                            Console.WriteLine("");
                            _validWeather = false;
                            break;
                    }
                }

                while (!_validTemp) 
                {
                    Console.Write("The temperature must be a number: ");
                    _temperatureInput = Console.ReadLine();

                    if (!Int32.TryParse(_temperatureInput, out _currentTemperature))
                    {
                        Console.WriteLine("This temperature isn't valid, please try again.");
                        Console.WriteLine("");
                        Console.Write("The temperature must be a number: ");
                        _validTemp = false;
                    }
                    else
                    {
                        Console.WriteLine("Thanks for the input. Press Enter to check your given Temperature and Weather.");
                        Console.WriteLine("Press Enter to see your hint.");
                        Console.ReadLine();
                        _validTemp = true;
                    }
                }

                while (!_userCheckingVariables) 
                {
                    Console.Clear();
                    Console.WriteLine("Your weather is: " + _weatherInput);
                    Console.WriteLine("Your temperature is: " + _temperatureInput);
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("If this is wrong, please restart the program.");
                    Console.WriteLine("If this is right, press enter to continue.");
                    Console.ReadLine();
                    _userCheckingVariables = true;
                }

                if (_validWeather && _validTemp) 
                {
                    _validValues = true;
                }

                

                if (_validValues && _currentTemperature > 30) {
                    Console.Clear();
                    Console.WriteLine("With the temperature being over 30 degrees, you should just be wearing short clothes, regardless of the weather.");
                    Console.WriteLine("Be sure to bring some water.");
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________");
                    Console.WriteLine("");
                    Console.Write("Once you've finished reading, press Enter to finish the program:");
                    Console.ReadLine();
                    _hintFinished = true;
                } 
                else if (_validValues && _currentTemperature < 0) 
                {
                    Console.Clear();
                    Console.WriteLine("It's freezing, so you should bring a big coat and wear thick pants regardless of the weather.");
                    Console.WriteLine("Don't forget to wear some gloves too.");
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________");
                    Console.WriteLine("");
                    Console.Write("Once you've finished reading, press Enter to finish the program:");
                    Console.ReadLine();
                    _hintFinished = true;
                }
                else if (_validValues && (_weatherInput == "Sunny" || _weatherInput == "sunny"))
                {
                    Console.Clear();
                    if (_currentTemperature <= 30)
                    {
                        Console.WriteLine("It's hot and sunny out. Wear short clothes and put on some sunscreen. Enjoy the sun with some sunglasses.");
                    }
                    else if (_currentTemperature <= 20)
                    {
                        Console.WriteLine("The temperature is comfortable and it's sunny. You don't need a coat, wear what you want and enjoy the weather.");
                    }
                    else if (_currentTemperature <= 10)
                    {
                        Console.WriteLine("The temeprature is somewhat low. So despite the sun being out, you should wear a coat to stay comfortable. Either way, enjoy the sun!");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________");
                    Console.WriteLine("");
                    Console.Write("Once you've finished reading, press Enter to finish the program:");
                    Console.ReadLine();
                    _hintFinished = true;
                }
                else if (_validValues && (_weatherInput == "Cloudy" || _weatherInput == "cloudy"))
                {
                    Console.Clear();
                    if (_currentTemperature <= 30)
                    {
                        Console.WriteLine("It's hot and cloudy. You should be fine wearing short clothes, but take an umbrella just in case it decides to rain.");
                    }
                    else if (_currentTemperature <= 20)
                    {
                        Console.WriteLine("It's cloudy. With the temperature being comfortable, you can wear what you want. But you might want to wear a raincoat just in case.");
                    }
                    else if (_currentTemperature <= 10)
                    {
                        Console.WriteLine("With the temperature being low, and the sky being cloudy you should wear a winter coat.");
                        Console.WriteLine("Without the sun it'll be cold, so it's nice to have something warm and fluffy while it isn't raining.");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________");
                    Console.WriteLine("");
                    Console.Write("Once you've finished reading, press Enter to finish the program:");
                    Console.ReadLine();
                    _hintFinished = true;
                }
                else if (_validValues && (_weatherInput == "Rainy" || _weatherInput == "Rainy"))
                {
                    Console.Clear();
                    if (_currentTemperature <= 30)
                    {
                        Console.WriteLine("It's hot, but it's raining. With it being too warm to wear a coat, grab an umbrella and stay under it.");
                    }
                    else if (_currentTemperature <= 20)
                    {
                        Console.WriteLine("It's raining. Wear a raincoat or take an umbrella. It's not too hot or cold out, so you can pick whichever you're more comfortable with.");
                    }
                    else if (_currentTemperature <= 10)
                    {
                        Console.WriteLine("It's cold and it's raining. Wear a raincoat and something thick under it. Try not to get too cold in this weather, and avoid getting wet if you can.");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________");
                    Console.WriteLine("");
                    Console.Write("Once you've finished reading, press Enter to finish the program:");
                    Console.ReadLine();
                    _hintFinished = true;
                }


                if (_hintFinished)
                {
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("Thanks for using the program!");
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________");
                    _programCompletion = true;
                }
            }
        }
    }
}
