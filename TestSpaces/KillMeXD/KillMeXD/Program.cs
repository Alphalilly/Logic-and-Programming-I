using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillMeXD
{
    class Program
    {
        static void Main(string[] args)
        {
            //string manipulation go brrrrrrrrr

            string choiceA = "This isnt what I was expecting lol";
            string choiceB = "no";

            bool Chosen = false; //false by defult, will be changed by a switch statement.

            ConsoleKey a = ConsoleKey.A;
            ConsoleKey b = ConsoleKey.B;

            //get input

            //switch () { }; //use a switch statement here
            

            Console.WriteLine($"You want some poptarts? I got some in the van ;3");
            Console.ReadKey(true);

            //choose between choice a and b. and the placeholder temp string will be replaced with either one. use a bool for thing?

            Console.WriteLine($"oh im not sure... {Chosen}");
            Console.ReadKey(true);
        }
    }
}
