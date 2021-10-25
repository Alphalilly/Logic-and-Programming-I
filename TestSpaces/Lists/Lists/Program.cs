using System;
using System.Collections.Generic; // this is needed for a list
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lists");
            Console.WriteLine();

            // var: you dont know what type its going to be. (or just an undefined type and let the compiler do the job and decide lel)

            // var i = 0;
            // var j = "YourMom";


            //list is a List<T> (list of type T) like var, could be of any type.

            // Can be 
            //List<string> names = new List<string> { "<name>", "Dylan", "Theta" };
            var names = new List<string> { "new friend", "Dylan", "Jack"};

            names.Add("Carter");
            names.Add("Ben");
            //names.Remove("Jack");
            //names.Add("Theta");

            names.Sort(); // sorts alphabetically by default (numaric value of every first char. Ascii numbers)
            foreach (var name in names )
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();


            Console.WriteLine(names[0]); //its like Arrays!
            Console.WriteLine();



            /* EX 1
            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!"); // $ is to put code inside of strings (lol dumb explination but it works)
            }
            */

            // this ↑ and this ↓ do the same thing.
            // ↓ is what you would expect to see in an array. and you can use lists as an array.
            // but ↑ is "nicer". and easier to read.

            /* EX 2
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!"); // names[] is the arraylist. name is a variable that stores what names[] could be

            }
            */



            // var index;  // I guess initialisng a var just like that gives me ( Implicitly typed locals must be initialized )

            //var index = names.IndexOf("Jack");
            //Console.WriteLine($"Found Jack at {index}");

            //var index = names.IndexOf("Theta");
            //Console.WriteLine($"Found Jack at {index}");

            var index = names.IndexOf("Theta");
            if (index == -1) //something not in the list returns a -1. when removed.
            {
                Console.WriteLine($"Couldnt find Theta at {index}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Found Theta at {index}");
                Console.WriteLine();
            }


            // count should be a number thats less then the size?
            var fibonacciNumbers = new List<int> { 1, 1 }; // not THE way to do the fibonacci sequence. A way
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1]; // its -1 because the index starts at 0
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2]; // getting the last 2

            fibonacciNumbers.Add(previous + previous2);

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item); // dont need {} here because its just one line
            Console.WriteLine();


            // "off by one"

            var fibonacci = new List<int> { 1, 1 };
            //loop on a changing target
            while (fibonacci.Count < 20) // can be <= 19, if its <= 20 it will run one more time. because it starts at 0
            {
                // this loop is to add more numbers into the list.
                var prev = fibonacci[fibonacci.Count - 1];
                var prev2 = fibonacci[fibonacci.Count - 2];

                fibonacci.Add(prev + prev2);
            }

            // this loop is to print
            foreach (var item in fibonacci)
                Console.WriteLine(item);
            Console.WriteLine();



            Console.ReadKey(true);



            var fibonacciENDLESS = new List<int> { 1, 1 };
            while (true) // oh no
            {
                var prev = fibonacciENDLESS[fibonacciENDLESS.Count - 1];
                var prev2 = fibonacciENDLESS[fibonacciENDLESS.Count - 2];

                foreach (var item in fibonacciENDLESS)
                    Console.WriteLine(item);
                Console.WriteLine();

                fibonacci.Add(prev + prev2);
            }

            // what's the difference between .Count and .Length?

            // .Count tells you the size of a List
            // .Length does the same thing but for Arrays


            // lists
            // arrays
            // multidimensional array??
            // arraylists???? 
            // Dictionaries???!??!?!?!?!?! (access something by name)
        }
    }
}
