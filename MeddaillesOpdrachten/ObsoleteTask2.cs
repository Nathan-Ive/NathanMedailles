using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdrachten
{
    internal class ObsoleteTask2
    {
        public void Start()
        {
            Boolean startingRoom = true;
            Boolean doorApproached = false;
            Boolean inspectingDoor = false;
            Boolean enteringDoor = false;
            Boolean roomOneEnter = false; // Represents the left door.
            Boolean roomTwoEnter = false; // Represents the middle door.
            Boolean roomThreeEnter = false; // Represents the right door.
            Boolean insideOfRoom = false; // Checks whether or not the player has finally entered a room.
            Boolean endingReached = false; // Checks to see if the player reach the end of a route.
            Boolean gameWin = false; // The successful end of the game, whether that's good, bad, or neutral.
            Boolean gameLose = false; // The failure of the game. 

            //These values give you a certain ending depending on which one is the highest.
            double winValue = 0;
            double neutralValue = 0;
            double loseValue = 0;

            
            String firstChoice = "Null";
            String secondChoice = "Null";
            String thirdChoice = "Null";
            String currentDirection = "Null";
            String textSeperator = "________________________________________________________________________________________________________________________";

            Console.WriteLine("When presented with a choice, input one of the three written options.");
            Console.WriteLine("If you want your decision to be registered properly, either fully type in lowercase or only capitalize the first letter in your choice.");
            Console.WriteLine("Write your decision in any other way, or write a invalid decision and you will be asked to write your decision again until you write it properly.");
            Console.WriteLine("If there is no option, like now, press Enter to continue to the next line of text.");
            Console.WriteLine("It doesn't matter whether you type something or not in these cases.");
            Console.ReadLine();

            while (!gameWin || !gameLose) {
                while (startingRoom)
                {
                    Console.Clear();
                    Console.WriteLine("You enter a room, faced with three doors you think of which one to open.");
                    Console.WriteLine("The [left] one, the [middle] one, or the [right] one?.");
                    Console.WriteLine("");
                    Console.Write("Input your direction here: ");

                    firstChoice = Console.ReadLine();

                    switch (firstChoice)
                    {
                        case "Left":
                        case "left":
                            Console.Clear();
                            Console.WriteLine("You approach the door on the left.");
                            currentDirection = "left";
                            doorApproached = true;
                            startingRoom = false;
                            break;
                        case "Middle":
                        case "middle":
                            Console.Clear();
                            Console.WriteLine("You approach the door in the middle.");
                            currentDirection = "middle";
                            doorApproached = true;
                            startingRoom = false;
                            break;
                        case "Right":
                        case "right":
                            Console.Clear();
                            Console.WriteLine("You approach the door on the right.");
                            currentDirection = "right";
                            doorApproached = true;
                            startingRoom = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("You stand there not moving in any direction...");
                            Console.WriteLine("input either [left], [right], or [middle] to approach one of the rooms.");
                            doorApproached = false;
                            startingRoom = true;
                            Console.WriteLine(textSeperator);
                            Console.WriteLine("");
                            break;
                    }

                }

                while (doorApproached) {
                    Console.WriteLine("Having approached the " + currentDirection + " door. Will you [inspect] it, [go back], or [enter]?");
                    Console.WriteLine("");
                    Console.Write("Input your action here: ");
                    secondChoice = Console.ReadLine();

                    switch (secondChoice)
                    {
                        case "inspect":
                        case "Inspect":
                            Console.Clear();
                            Console.WriteLine("You look at the " + currentDirection + " door...");
                            inspectingDoor = true;
                            if (currentDirection == "left" && inspectingDoor)
                            {
                                Console.WriteLine("You look at the door and notice its pristine condition. This is a very well cared for door...");
                                Console.WriteLine("It's made of a high quality, shiny wood and is practically begging to be entered.");
                                Console.WriteLine("Yes... this door, it must be the right one.");
                                Console.WriteLine(textSeperator);
                                Console.WriteLine("");

                            }
                            if (currentDirection == "middle" && inspectingDoor)
                            {
                                Console.WriteLine("You look at the door seeing that it's slightly open. Behind it is a pitch black room.");
                                Console.WriteLine("It's made of a hard, cold stone that matches the walls. It'd be hard to tell it apart from just touch alone.");
                                Console.WriteLine("A blind person would have an extremely hard time finding this door...");
                                Console.WriteLine(textSeperator);
                                Console.WriteLine("");

                            }
                            if (currentDirection == "right" && inspectingDoor)
                            {
                                Console.WriteLine("You look at the door and see that it's... a door. It has a handle and it's made of wood.");
                                Console.WriteLine("Nothing special.");
                                Console.WriteLine(textSeperator);
                                Console.WriteLine("");

                            }
                            break;
                        case "go back":
                        case "Go back":
                        case "Go Back":
                            Console.Clear();
                            Console.WriteLine("You take a step back, returning to your starting position facing three doors.");
                            Console.WriteLine(textSeperator);
                            Console.WriteLine("");
                            doorApproached = false;
                            startingRoom = true;
                            break;
                        case "enter":
                        case "Enter":
                            Console.Clear();
                            Console.WriteLine("You put your hand on the handle and turn it, opening the door in front of you.");
                            Console.WriteLine(textSeperator);
                            Console.WriteLine("");
                            startingRoom = false;
                            doorApproached = false;
                            enteringDoor = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("What? Nothing? Let's try that again.");
                            Console.WriteLine(textSeperator);
                            Console.WriteLine("");
                            break;
                    }
                }

                while (enteringDoor) {
                    if (currentDirection == "left") //A seemingly great room that's actually dangerous.
                    {
                        Console.WriteLine("The high quality of the left door, the satisfying turn of the knob, the comforting creak it creates.");
                        Console.WriteLine("Without even having entered this room, you can tell that there's something special about it.");
                        Console.WriteLine("");
                        Console.WriteLine("You keep your eyes closed as you open the door, wanting to be lost in the suspense of entering the room behind it."); 
                        Console.WriteLine("This room is sure to be just as great as the entrance protecting it...");
                        loseValue = loseValue + 2;
                        roomOneEnter = true;
                        roomTwoEnter = false;
                        roomThreeEnter = false;
                        enteringDoor = false;
                        insideOfRoom = true;
                    }
                    else if (currentDirection == "middle") //A suspensful and slightly unsettling room that's actually not all that special.
                    {
                        Console.WriteLine("As you enter the middle door and close it behind you come to realize how dark this room is.");
                        Console.WriteLine("Unable to see anything you try to turn back and realize that the door has seemingly dissapeared.");
                        Console.WriteLine("You feel around and do your best to find it, but the door really is nowhere to be found, leaving you in a dark room.");
                        neutralValue = neutralValue + 2;
                        roomOneEnter = false;
                        roomTwoEnter = true;
                        roomThreeEnter = false;
                        enteringDoor = false;
                        insideOfRoom = true;
                    }
                    else if (currentDirection == "right") // A seemingly neutral room that ends up being far better than you first realize.
                    {
                        Console.WriteLine("Entering the right door you feel as if... you've entered a room. Nothing special stands out.");
                        winValue = winValue + 2;
                        roomOneEnter = false;
                        roomTwoEnter = false;
                        roomThreeEnter = true;
                        enteringDoor = false;
                        insideOfRoom = true;
                    }
                }
                while (insideOfRoom) 
                {
                    if (roomOneEnter) 
                    {
                        Console.WriteLine("");
                        Console.WriteLine(textSeperator);
                        Console.WriteLine("");
                        Console.WriteLine("Still having your eyes closed in an attempt to hold onto this moment, you're left with few options.");
                        Console.WriteLine("You can either [open eyes], finally taking this magnificent room in.");
                        Console.WriteLine("You could [step forward], going further into this room while keeping yourself blind to what's inside.");
                        Console.WriteLine("On the other hand, moving foward without seeing is dangerous. So you might want to [go along the walls] and feel your way through instead.");
                        Console.WriteLine("");
                        Console.Write("You choose to: ");
                        thirdChoice = Console.ReadLine();

                        switch (thirdChoice) 
                        {
                            case "open eyes":
                            case "Open eyes":
                            case "open my eyes":
                            case "Open my eyes":
                                loseValue = loseValue - 0.5;
                                Console.WriteLine("You open your eyes, and the horrors you see are indescribable. It terrifies you down to the core.");
                                Console.WriteLine("Frozen in fear you make the right decision, turning around and leaving.");
                                Console.WriteLine("You can't stop shaking after what you saw, but at least you didn't wander in further.");
                                Console.WriteLine("After taking a moment to yourself you resolve to never think of this again, forgetting the room as quickly as you left it.");
                                insideOfRoom = false;
                                endingReached = true;
                                break;
                            case "step forward":
                            case "Step forward":
                                loseValue = loseValue + 0.5;
                                Console.WriteLine("You take a step forward, your feet land on something that immediately gives you the feeling that you made a mistake.");
                                Console.WriteLine("You try to take a step back, but before you know it you fall over.");
                                Console.WriteLine("Bracing for impact, you move your hands to your head to protect it until you realize that you're being dragged down.");
                                Console.WriteLine("You open your eyes to see what's going on, but it's too late. You look up to see a light growing more distant.");
                                Console.WriteLine("Having been dragged down a random hole, all you can do is wait until you reach the bottom...");
                                insideOfRoom = false;
                                endingReached = true;
                                break;
                            case "go along the walls":
                            case "Go along the walls":
                                Console.WriteLine("You put your hands on the walls, feeling the shape of the room as you walk across it. It's clearly a magnificent room.");
                                Console.WriteLine("The walls are smooth and... velvety. The floor is stable and... sticky?");
                                Console.WriteLine("No, it's just... squishy, yeah that's it. A carpet that sinks under the pressure of your shoes... Yeah!");
                                Console.WriteLine("The smell, ah the smell. It's... No, you must be mistaken. It's a great smell, of course it is!");
                                Console.WriteLine("Nodding to yourself, you keep feeling your way through the room until you reach the other side safely.");
                                Console.WriteLine("You put your hand on the perfectly normal, doorhandle. It may be covered in something wet, but... that's probably your own sweat. Right?");
                                Console.WriteLine("Having gotten through the wonderful room and leaving through its exit, you open your eyes, nodding to yourself at the masterful craftsmanship.");
                                Console.WriteLine("'What a great room!', you say to yourself as you leave. Convincing yourself that you were satisfied with your experience.");
                                insideOfRoom = false;
                                endingReached = true;
                                break;
                        }
                    }

                    if (roomTwoEnter)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(textSeperator);
                        Console.WriteLine("");
                        Console.WriteLine("Still having your eyes closed in an attempt to hold onto this moment, you're left with few options.");
                        Console.WriteLine("You can either [open eyes], finally taking this magnificent room in.");
                        Console.WriteLine("You could [step forward], going further into this room while keeping yourself blind to what's inside.");
                        Console.WriteLine("On the other hand, moving foward without seeing is dangerous. So you might want to [go along the walls] and feel your way through instead.");
                        Console.WriteLine("");
                        Console.Write("You choose to: ");
                        thirdChoice = Console.ReadLine();

                        switch (thirdChoice)
                        {
                            case "open eyes":
                            case "Open eyes":
                            case "open my eyes":
                            case "Open my eyes":
                                loseValue = loseValue - 0.5;
                                Console.WriteLine("You open your eyes, and the horrors you see are indescribable. It terrifies you down to the core.");
                                Console.WriteLine("Frozen in fear you make the right decision, turning around and leaving.");
                                Console.WriteLine("You can't stop shaking after what you saw, but at least you didn't wander in further.");
                                Console.WriteLine("After taking a moment to yourself you resolve to never think of this again, forgetting the room as quickly as you left it.");
                                insideOfRoom = false;
                                endingReached = true;
                                break;
                            case "step forward":
                            case "Step forward":
                                loseValue = loseValue + 0.5;
                                Console.WriteLine();
                                insideOfRoom = false;
                                break;
                            case "go along the walls":
                            case "Go along the walls":
                                Console.WriteLine();
                                insideOfRoom = false;
                                break;
                        }
                    }


                    if (roomThreeEnter)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(textSeperator);
                        Console.WriteLine("Looking across the dissapointing room, you do notice quite a few things. But not much of it catches your eye.");
                        Console.WriteLine("With the room being a dissapointment, that's to be expected.");
                        Console.WriteLine("Anyway, the things that do interest you are [the puzzle] on the table, seemingly set up like the puzzle for an escape room. Could kill your boredom");
                        Console.WriteLine("There's also a part of [the floor], it suspiciously stands out among the rest of the room. Though, it could just be a broken floor boards. In fact, it most likely is.");
                        Console.WriteLine("And of course, [the door] that'll let you leave this room and never see the dimensions of its underwhelming walls again.");
                        Console.WriteLine("");
                        Console.Write("You choose to interact with: ");
                        thirdChoice = Console.ReadLine();

                        switch (thirdChoice)
                        {
                            case "the door":
                            case "The door":
                            case "door":
                            case "Door":
                                winValue = winValue - 0.5;
                                Console.WriteLine("You leave this boring room, hoping to never be this dissapointed again for the rest of your life.");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                insideOfRoom = false;
                                endingReached = true;
                                break;
                            case "the floor":
                            case "The floor":
                            case "floor":
                            case "Floor":
                                winValue = winValue + 0.5;
                                Console.WriteLine("You walk towards the odd looking part of the floor, grabbing it with your hands and lifting it up. It moves quite easily.");
                                Console.WriteLine("In fact, it opens. It wasn't a broken part of the floor, it was a basement door, it just didn't have a handle.");
                                Console.WriteLine("Feeling like you found a secret, you feel a slight bit of excitement as you enter.");
                                Console.WriteLine("This was a lucky find, as the basement is filled with bags and bags of money.");
                                Console.WriteLine("You begin to celebrate at the great find, elated that this boring room turned out to be so fruitful.");
                                Console.WriteLine("Little did you know that the money was very old, and not exactly usable in the modern day.");
                                Console.WriteLine("But that doesn't matter, as this moment that turned from dissapointment to excitement and joy will stick with you forever as a fun memory.");
                                insideOfRoom = false;
                                endingReached = true;
                                break;
                            case "the puzzle":
                            case "The puzzle":
                            case "puzzle":
                            case "Puzzle":
                                Console.WriteLine("You sit down and start messing around with the puzzle. It's nothing special, but it's a surprisingly fun way to spend your time.");
                                Console.WriteLine("Before you know it, time flies and you've spent a couple hours in the room only stopping when you get hungry.");
                                Console.WriteLine("You get up and decide to take the puzzle with you, deciding to get back to it after you've eaten a good meal.");
                                insideOfRoom = false;
                                endingReached = true;
                                break;
                        }
                    }

                }

                while (endingReached) {
                    
                    //Bad Endings
                    if (loseValue == 5.5)
                    {

                        Console.WriteLine("Well done on reaching an ending. This was the 'win' ending for the left door route.");
                    }
                    else if (loseValue == 6.5)
                    {
                        Console.WriteLine("Well done on reaching an ending. This was the 'lose' ending for the left door route.");
                    }
                    else if (loseValue == 6) 
                    {
                        Console.WriteLine("Well done on reaching an ending. This was the 'neutral' ending for the left door route.");
                    }

                    //Good endings
                    if (winValue == 5.5)
                    {

                        Console.WriteLine("Well done on reaching an ending. This was the 'lose' ending for the right door route.");
                    }
                    else if (winValue == 6.5)
                    {
                        Console.WriteLine("Well done on reaching an ending. This was the 'win' ending for the right door route.");
                    }
                    else if (winValue == 6)
                    {
                        Console.WriteLine("Well done on reaching an ending. This was the 'neutral' ending for the right door route.");
                    }

                    //Neutral Endings
                    if (neutralValue == 5.5)
                    {

                        Console.WriteLine("Well done on reaching an ending. This was the 'lose' ending for the middle door route.");
                    }
                    else if (neutralValue == 6.5)
                    {
                        Console.WriteLine("Well done on reaching an ending. This was the 'win' ending for the middle door route.");
                    }
                    else if (neutralValue == 6)
                    {
                        Console.WriteLine("Well done on reaching an ending. This was the 'neutral' ending for the middle door route.");
                    }

                }

            }
        }

    }
}
