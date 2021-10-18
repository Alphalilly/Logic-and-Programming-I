using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before Loops");
            Console.WriteLine();

            //display numbers fom 1 to 10:

            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Console.WriteLine(7);
            Console.WriteLine(8);
            Console.WriteLine(9);
            Console.WriteLine(10);
            Console.WriteLine();

            int count;
            count = 1;

            //display numbers fom 1 to 50:

            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;
            Console.WriteLine(count); count = count + 1;

            Console.WriteLine();

            //display numbers fom 1 to 10000000: ????

            Console.WriteLine("Loops");
            Console.WriteLine();

            // for loop components
            //  int i = 1  declaration/initialisation of loop variable
            //  i <= 10    stop condition
            //  i++        incriment loop variable

            // order of operations:
            // initialisation of loop variable
            // check stop condition
            // preform loop
            // increment loop variable
            // loop!

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i);
                Console.Write(", ");
                Console.ReadKey(true);
            }
            Console.WriteLine();


            /* can look like this
            for (
                    int i;
                    i = 1; 
                    i <= 10; 
                    i = i + 1
                )
            {
                Console.WriteLine(i);
            }
            */

            //arrays and loops

            /*
            int[] w = new int[3];
            w[0] = 1;
            w[1] = 2;
            w[3] = 3;

            int[] a = new int[3];
            a[0] = 10;
            a[1] = 50;
            a[2] = 40;

            string[] n = new string[3];
            n[0] = "pistol";
            n[1] = "BFG";
            n[2] = "shotgun";

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i] + ": " + a[i] + "/");
            }
            Console.WriteLine();
            */


            // double nested loops

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    //count up the other loop. for every "i" it counts all of "j"
                    Console.WriteLine(i + ", " + j); // its like counting up 01. 02. 03. 04. 05..... 10. 11. 12....
                    //starts with the loop on the inside, then continues with the first loop (outside loop)
                }
            }

            /* so basically this
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("i =" + i);


                for (int j = 0; j <= 9; j++)
                {
                    
                    Console.WriteLine("j =" + j);
                    
                }
            }
            */

            //extra: while loop

            bool gameOver = false;
            while (gameOver == false)
            {
                //Console.WriteLine(".");

                //only ends when gameOver = true;


                //methods can give back a value int     this = canUseThis();
                //string is an array of chars


                char input;
                ConsoleKeyInfo readKeyInput;
                readKeyInput = Console.ReadKey(true);
                input = readKeyInput.KeyChar;

                Console.WriteLine("User input = " + input);
            }


            Console.ReadKey(true);
        }
    }
}
