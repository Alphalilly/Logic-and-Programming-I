using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Methods"); //AKA procedures, functions, routines etc.
            Console.ReadKey(true);

            int money;
            string name;
            int poptarts;

            //init
            name = "hhhhhheeeeeleeeeeen";
            money = 0;
            poptarts = 0;

            //hud
            Console.WriteLine("name = " + name);
            Console.WriteLine("score = " + money);
            Console.WriteLine("xp = " + poptarts);
            Console.ReadKey(true);

            //pretend gameplay
            money = money + 200;
            poptarts = poptarts + 5;

            //hud
            Console.WriteLine("name = " + name);
            Console.WriteLine("score = " + money);
            Console.WriteLine("xp = " + poptarts);
            Console.ReadKey(true);
            // ^ this dumb. copy paste copy paste copy paste copy paste. no
        }
    }
}
