using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        //declarations
        static int money;
        static string name;
        static int poptarts;

        static void Main(string[] args)
        {
            Console.WriteLine("Methods"); //AKA procedures, functions, routines etc.
            Console.ReadKey(true);

            //init
            name = "hhhhhheeeeeleeeeeen";
            money = 0;
            poptarts = 0;

            ShowHUD(); //very clean lol

            ////hud
            //Console.WriteLine("name = " + name);
            //Console.WriteLine("score = " + money);
            //Console.WriteLine("xp = " + poptarts);
            //Console.WriteLine();
            //Console.ReadKey(true);

            //pretend gameplay
            money = money + 200;
            poptarts = poptarts + 5;

            ShowHUD();

            ////hud
            //Console.WriteLine("name = " + name);
            //Console.WriteLine("score = " + money);
            //Console.WriteLine("xp = " + poptarts);
            //Console.ReadKey(true);
            //// ^ this dumb. copy paste copy paste copy paste copy paste. no
        }
        // a method that showes a HUD
        static void ShowHUD()
        {
            Console.WriteLine("name = " + name);
            Console.WriteLine("money = " + money);
            Console.WriteLine("poptarts = " + poptarts);
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
