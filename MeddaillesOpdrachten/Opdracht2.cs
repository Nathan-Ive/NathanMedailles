using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddaillesOpdrachten
{
    internal class Opdracht2
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
            Boolean gameWin = false; // The successful end of the game, whether that's good, bad, or neutral.
            Boolean gameLose = false; // The failure of the game. 

            //These values give you a certain ending depending on which one is the highest.
            int winValue = 0;
            int neutralValue = 0;
            int loseValue = 0;

            
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
                        loseValue++;
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
                        neutralValue++;
                        roomOneEnter = false;
                        roomTwoEnter = true;
                        roomThreeEnter = false;
                        enteringDoor = false;
                        insideOfRoom = true;
                    }
                    else if (currentDirection == "right") // A seemingly neutral room that ends up being far better than you first realize.
                    {
                        Console.WriteLine("Entering the right door you feel as if... you've entered a room. Nothing special stands out.");
                        winValue++;
                        roomOneEnter = false;
                        roomTwoEnter = false;
                        roomThreeEnter = true;
                        enteringDoor = false;
                        insideOfRoom = true;
                    }
                }
                while (insideOfRoom) {
                    if (roomOneEnter) {
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

                                break;
                            case "step forward":
                            case "Step forward":

                                break;
                            case "go along the walls":
                            case "Go along the walls":
                                break;
                        }
                    }
                }


            }
        }

    }
}
