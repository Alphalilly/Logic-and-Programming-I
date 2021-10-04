using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals3
{
    class Program
    {
        static bool isAlive = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals 3");

            isAlive = true;

            //if (alive == true)
            if (isAlive)
            {
                Console.WriteLine("you are alive");
            }
            else
            {
                Console.WriteLine("you are dead");
            }

            Console.ReadKey(true);


        }
    }
}
