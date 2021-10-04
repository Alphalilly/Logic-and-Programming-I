using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static int score = 0;
        static int lives = 3;
        static bool oneUp = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals");

            score = score + 100;
            Console.WriteLine("Score: " + score);
            Console.WriteLine("lives: " + lives);

            score = score + 100;
            Console.WriteLine("Score: " + score);
            Console.WriteLine("lives: " + lives);

            score = score + 100;
            Console.WriteLine("Score: " + score);
            Console.WriteLine("lives: " + lives);

            score = score + 100;
            Console.WriteLine("Score: " + score);
            Console.WriteLine("lives: " + lives);

            score = 1000;

            if (oneUp == false)
            {
                if (score >= 1000)
                {
                    lives = lives + 1;
                    oneUp = true;
                }
            }

            Console.WriteLine("Score: " + score);
            Console.WriteLine("lives: " + lives);

            Console.ReadKey(true);
        }
    }
}
