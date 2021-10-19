using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPI_Loops_GameLoop
{
    class Program
    {
        // get player input
        // Draw player to screen
        // "move" player on screen
        // exit game
        // extra: keep player in bounds of screen. make bounds scaleable. press shift and move 2 chars over ? Sprint?

        static bool gameOver = false;
        static int x = 0;
        static int y = 0;

        static char input;
        static ConsoleKeyInfo readKeyInput;

        static void Main()
        {
            while (gameOver == false)
            {
                Draw();

                Update();
            }
        }

        static void InputTest() // I coded this in 2 different ways because I can :D
        {
            while (true)
            {
                ConsoleKeyInfo read = Console.ReadKey(true); //returns ConsoleKey info. 
                char input = read.KeyChar; //extracting char //This will be used to tell the program when to draw 

                Console.WriteLine((int)input); //owo whats this? ;3

                if (input == 'w') //make this a switch statement?
                {
                    Console.WriteLine("pressed: " + input);
                }
                else if (input == 'a')
                {
                    Console.WriteLine("pressed: " + input);
                }
                else if (input == 's')
                {
                    Console.WriteLine("pressed: " + input);
                }
                else if (input == 'd')
                {
                    Console.WriteLine("pressed: " + input);
                }
                else if ((int)input == 27) // boi this is bootleg but I like it. Is this considerd Hard Coding???
                {
                    Console.WriteLine("pressed: Escape key lel");
                    Console.ReadKey(true);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid keypress");
                }


                //aight, so ^^^^^ is one way to do it. I could have done it this way but eeehhh

                /*
                char input;
                ConsoleKeyInfo readKeyInput;
                readKeyInput = Console.ReadKey(true);
                input = readKeyInput.KeyChar; //This will be used to tell the program when to draw 

                if (readKeyInput.Key == ConsoleKey.W)
                {
                    Console.WriteLine("pressed: " + input);
                }
                else if (readKeyInput.Key == ConsoleKey.A)
                {
                    Console.WriteLine("pressed: " + input);
                }
                else if (readKeyInput.Key == ConsoleKey.S)
                {
                    Console.WriteLine("pressed: " + input);
                }
                else if (readKeyInput.Key == ConsoleKey.D)
                {
                    Console.WriteLine("pressed: " + input);
                }
                else if (readKeyInput.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("pressed: Escape key lel");
                    Console.ReadKey(true);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid keypress");
                }
                */


            }
        }

        static void Draw() // draws the player
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write("@");
        }

        static void Update() //changes the data
        {
            readKeyInput = Console.ReadKey(true);
            input = readKeyInput.KeyChar; // getChar???

            if (input == 'w')
            {
                y -= 1;
            }
            else if (input == 'a')
            {
                x -= 1;
            }
            else if (input == 's')
            {
                y += 1;
            }
            else if (input == 'd')
            {
                x += 1;
            }
            else if ((int)input == 27) // boi this is bootleg but I like it. Is this considered Hard Coding???
            {
                Console.WriteLine(" Game Exit");
                Console.ReadKey(true);
                gameOver = true;
            }
            else
            {

            }

            //another way I guess

            //if (readKeyInput.Key == ConsoleKey.W)
            //{
            //    y -= 1;
            //}
            //else if (readKeyInput.Key == ConsoleKey.A)
            //{
            //    x -= 1;
            //}
            //else if (readKeyInput.Key == ConsoleKey.S)
            //{
            //    y += 1;
            //}
            //else if (readKeyInput.Key == ConsoleKey.D)
            //{
            //    x += 1;
            //}
            //else if (readKeyInput.Key == ConsoleKey.Escape)
            //{
            //    Console.WriteLine(" Game Exit");
            //    Console.ReadKey(true);
            //    gameOver = true;
            //}
            //else
            //{

            //}
        }
    }
}
