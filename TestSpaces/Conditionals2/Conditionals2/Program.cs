using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals2
{
    class Program
    {
        static int score = 0;
        static int lives = 3; //lives left
        static bool alive = true; //true if alive, false if dead

        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals2");


            lives = lives - 1; //player died
            if(lives < 0)
            {
                lives = 0; //range check it to 0
                alive = false;
            }

            if (lives == 0)
            {
                alive = true; //player is still alive even if lives is 0. bacuse your on your last life
            }
            Console.ReadKey(true);
        }
    }
}
