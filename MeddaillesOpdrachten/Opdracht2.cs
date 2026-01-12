using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdrachten
{
    internal class Opdracht2
    {

        private bool _winCondition = false;
        private bool _loseCondition = false;
        private bool _gameRunning = true;
        private bool _firstPart = false;
        private bool _secondPart = false;

        private string _playerInput;
        private string _field = "Input Field: ";
        private int _roomNumber;


        public void Start()
        {

            //This time I will make this concicely so I can move on to doing other things relevant to school with no worry about C#.
            //Three paths with a simple start.
            //The player will wake up in their room and will decide on which room they want to enter. In that room they either choose the right or wrong option.
            //The right option gets a nice bit of text about how they did the task in that room correctly and won.
            //The wrong option gets a funny bit of text about how they failed the task in that room and lost.



            Console.WriteLine("When presented with a choice, input one of the options written in between brackets like [this].");
            Console.WriteLine("You can type the options in any way you like within reason, as long as it matches the way it is presented between the brackets in the text.");
            Console.WriteLine("Write your decision in any other way, or write a invalid decision and you will be asked to write your decision again until you write it properly.");
            Console.WriteLine("If there is no option or input field, like now, press Enter to continue to the next line of text.");
            Console.WriteLine("It doesn't matter whether you type something or not in these cases.");
            Console.ReadLine();
            Console.Clear();

            while(_gameRunning) 
            {
                _firstPart = true;
                while (_firstPart) 
                {
                    Console.WriteLine($"Waking up, you get up from your bed. After taking a couple moments to think you wonder what you should do first.");
                    Console.WriteLine($"Maybe entering another room in the house will help with that choice. You think of going to the [kitchen], the [bathroom], or the [living room].");
                    Console.WriteLine();
                    Console.Write(_field);
                    _playerInput = Console.ReadLine();

                    switch (_playerInput.ToLower())
                    {
                        case "kitchen":
                            _roomNumber = 1;
                            _firstPart = false;
                            break;
                        case "bathroom":
                            _roomNumber = 2;
                            _firstPart = false;
                            break;
                        case "living room":
                            _roomNumber = 3;
                            _firstPart = false;
                            break;
                    }
                    Console.Clear();
                }
                
                _secondPart = true;
                while (_secondPart) 
                {
                    switch (_roomNumber)
                    {
                        case 1: //The Kitchen
                                //The goal here is to cook breakfast.
                                //The good choice is to cook an egg. This will result in you making a high-quality meal for the morning. Feeling healthy, you're ready to tackle the day.
                                //The bad choice is to cook a grilled cheese. This will result you in burning down the house due to your inexeprience in cooking.
                            Console.WriteLine($"You head to the kitchen.");
                            Console.ReadLine();
                            Console.Clear();

                            Console.WriteLine($"Leaving your bedroom you enter the kitchen, heading to the fridge and seeing all the food immediately gets you hungry.");
                            Console.WriteLine($"That just leaves the question... What will you eat?");
                            Console.WriteLine($"Since you're hungry, you want to make something simple.");
                            Console.WriteLine($"After some time of considering things you decide that you either want an [egg] or a [grilled cheese] sandwich.");
                            Console.WriteLine();
                            Console.Write(_field);
                            _playerInput = Console.ReadLine();
                            Console.Clear();

                            if (_playerInput.ToLower() == "egg")
                            {
                                _winCondition = true;
                                Console.WriteLine($"You make a delicious egg. That in combination with the rest of your outstanding breakfast has fully woken you up.");
                                Console.WriteLine($"With the energy to handle the day at 100%, you achieve everything you set out to do.");
                                Console.WriteLine($"Having learned the importance of a good breakfast, every morning will surely be as good as this one.");

                            }
                            else if (_playerInput.ToLower() == "grilled cheese" || _playerInput.ToLower() == "grilled cheese sandwich")
                            {
                                _loseCondition = true;
                                Console.WriteLine($"You burn the sandwich without even melting the cheese.");
                                Console.WriteLine($"Thank god no one saw this. That was emberassing. Especially the part where you burned your house down.");
                                Console.WriteLine($"Well, maybe your next attempt at a grilled cheese will be more successful... Right?");


                            }


                            break;


                        case 2: //The Bathroom
                                //The goal here is to brush your teeth.
                                //The good choice is to grab the toothpaste. This will result in you picking up the toothbrush afterwards and simply brushing your teeth, resulting in a bright smile in the mirror.
                                //The bad choice is to grab the toothbrush. This will result in you lamenting the lack of toothpaste, throwing the brush in the toilet and flushing it.
                            Console.WriteLine($"You head to the bathroom.");
                            Console.ReadLine();
                            Console.Clear();


                            Console.WriteLine($"Leaving your bedroom you enter the bathroom, a good start to the day.");
                            Console.WriteLine($"There with the goal of waking yourself up you splash some water on your face before your eyes land on the toothbrush.");
                            Console.WriteLine($"Naturally you have to brush your teeth. Thankfully, with your brush always being in the same spot it's easy to find.");
                            Console.WriteLine($"However, you're unsure of where to start. You move your hand without thinking, and before you know it you have something in your hand.");
                            Console.WriteLine($"You haven't looked at it yet, so what could it be? Considering your goal it's either a [toothbrush] or a tube of [toothpaste].");
                            Console.WriteLine();
                            Console.Write(_field);
                            _playerInput = Console.ReadLine();
                            Console.Clear();

                            if (_playerInput.ToLower() == "toothpaste" || _playerInput.ToLower() == "paste")
                            {
                                _winCondition = true;
                                Console.WriteLine($"Looking down you see your toothpaste. What a relief! If that was your toothbrush, you would've had no idea where the toothpaste was.");
                                Console.WriteLine($"Grabbing your toothbrush with a sigh of relief, you put some toothpaste on the brush and complete your routine.");
                                Console.WriteLine($"Looking in the mirror you see a clean smile look back at you. The reward for good dental care!");
                            }
                            else if (_playerInput.ToLower() == "toothbrush" || _playerInput.ToLower() == "brush")
                            {
                                _loseCondition = true;
                                Console.WriteLine($"Looking down you see your toothbrush... This is not good...");
                                Console.WriteLine($"Yes...");
                                Console.WriteLine($"Not good. Not good at all.");
                                Console.WriteLine($"You try to think about it rationally. But seeing the toothbrush with no toothpaste, it drives you mad.");
                                Console.WriteLine($"You shout, speaking in a way you've never spoken before.");
                                Console.WriteLine($"'The blasphemy! Brushing my teeth without toothpaste?! Away with you!'");
                                Console.WriteLine($"Having lost all control of your mind and body at this point you toss the toothbrush in the toilet and flush it.");
                                Console.WriteLine($"Once you realize what you've just done, it's too late. The toothbrush is already gone.");
                                Console.WriteLine($"Baffeled you're forced to accept that you'll just have to settle with a quick rinse of your mouth until you can buy a new toothbrush.");
                                Console.WriteLine($"You note that next time, you should keep the toothpaste near your toothbrush.");

                            }


                            break;


                        case 3: //The Living Room
                                //The goal here is to watch TV.
                                //The good choice is to pick the correct remote. Which will have you relax and the couch and have a relaxing day watching your favorite shows.
                                //The wrong choice is to pick the incorrect remote. Which will result in you picking up a remote with a single button. After pressing this button your TV explodes and you can't watch TV.

                            Console.WriteLine($"You head to the living room.");
                            Console.ReadLine();
                            Console.Clear();

                            Console.WriteLine($"Leaving your bedroom you enter the living room, looking around you see your lovely couch, which is facing your TV.");
                            Console.WriteLine($"Suddenly, you get the urge to watch TV for the day. Looking for the remote you end up finding two of them.");
                            Console.WriteLine($"One of them, the black remote, has a large variety of buttons, confusing you.");
                            Console.WriteLine($"As for the other remote, a white remote single big red button... Seems user friendly and convenient!");
                            Console.WriteLine($"However, in the end, you want to watch TV. Which remote is the TV remote again? The [black remote] or the [white remote]");
                            Console.WriteLine();
                            Console.Write(_field);
                            _playerInput = Console.ReadLine();
                            Console.Clear();

                            if (_playerInput.ToLower() == "black remote" || _playerInput.ToLower() == "black")
                            {
                                _winCondition = true;
                                Console.WriteLine($"You pick the obvious TV remote. As nice as one button would be, you need to be able to choose a channel.");
                                Console.WriteLine($"You toss the white remote to the side and take a seat on the couch, turning on the TV with the power button on the rmote.");
                                Console.WriteLine($"After seeing it turn on you input the numbers to your favorite channel and lay back.");
                                Console.WriteLine($"Comfortable and satisfied with your impressive deductive skill in picking the right remote you spend the rest of your day happily consuming content.");
                            }
                            else if (_playerInput.ToLower() == "white remote" || _playerInput.ToLower() == "white")
                            {
                                _loseCondition = true;
                                Console.WriteLine($"You grab the white remote and immediately point it at the TV and press the button, not many buttons to choose from after all.");
                                Console.WriteLine($"Before you know it, your TV explodes leaving the shelf it previously stood on empty.");
                                Console.WriteLine($"All you can do is watch as you lose access to your favorite form of enertainment.");
                                Console.WriteLine($"You look down at the remote and turn it around. And silly you, it was a TV destruction remote.");
                                Console.WriteLine($"Seems like convenience came at a price. Better luck next time!");
                            }
                            break;

                    }
                    Console.ReadLine();
                    Console.Clear();

                    if (_winCondition) 
                    {
                        Console.WriteLine("Congratulations, you won!");
                        _secondPart = false;
                        _gameRunning = false;
                    }
                    else if (_loseCondition) 
                    {
                        Console.WriteLine("Sorry, you lose!");
                        _secondPart = false;
                        _gameRunning = false;
                    }

                }

            }
        }
    }
}
