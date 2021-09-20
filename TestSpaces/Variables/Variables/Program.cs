using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables");
            Console.ReadKey(true);

            // Achivement: "you have declared a variable!"

            // tis a Data type int. (takes numbers)
            // said int has an identifier (poptarts) and is assigned (=) a value
            //holds a whole number, cant store decimal numbers
            int poptarts;

            poptarts = 0; // assigned poptarts a value of 0
            Console.WriteLine("The ammount of poptarts are: " + poptarts);
            Console.ReadKey(true);

            poptarts = 1000; // assigned poptarts a value of 1000
            Console.WriteLine("The ammount of poptarts are: " + poptarts);
            Console.ReadKey(true);

            // tis another Data type, string. (takes letters)
            //said string also has an identifeir (angy) and is assigned a value as well
            //although instead of being just one value, its a bunch of values that form a letter
            //its a char array. and a char is basically a single letter or symbole that is made up of ascii numbers.
            string angy;
            string veryAngy = "I WANTS A POPTART";

            angy = "no i wants a poptart"; //assigned a string variable
            Console.WriteLine(angy);
            Console.ReadKey(true);

            angy = "hey gimme poptart "; //assigned a string variable
            Console.WriteLine(angy + veryAngy);
            Console.ReadKey(true);

            // tis yet another Data type. float (takes numbers with decimals)
            // said float also has an identifeir (price) and is assigned a value of a decimal number. with (f) telling the program that its type float
            // this is f*king weird cuz i guess its set up in a way to tell the computer that its a decimal number.
            // so i guess a float can technically be bigger then an int, dispite holding decimal numbers
            // yes scary math things https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
            float price;

            price = 1.23f; // assigned price a decimal value
            Console.WriteLine("Chocolate poptart is: $" + price);
            Console.ReadKey(true);

            price = 1.23f + 3; // assigned price a decimal value, adding a whole number to it
            Console.WriteLine("Chocolate poptart and orenge poptart is: $" + price);
            Console.ReadKey(true);
        }
    }
}
