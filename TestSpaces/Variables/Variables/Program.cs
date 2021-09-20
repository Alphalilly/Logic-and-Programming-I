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

            // tis a Data type int. (takes numbers)
            // said int has an identifier (poptarts) and is assigned (=) a value
            int poptarts;

            poptarts = 0; // assigned poptarts a value of 0
            Console.WriteLine("The ammount of poptarts are: " + poptarts);
            Console.ReadKey(true);

            poptarts = 1000; // assigned poptarts a value of 1000
            Console.WriteLine("The ammount of poptarts are: " + poptarts);
            Console.ReadKey(true);


        }
    }
}
