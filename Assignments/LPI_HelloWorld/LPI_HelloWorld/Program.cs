using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDMI_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello World!");
            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Im back boiiisss! Logic and programing 2 electric boogaloo XD");
            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Also pretty colours");
            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You can type stuff now! press enter to close the program.");
            Console.ReadLine();

            //dw about this i tried and failed. and i wanna try later XD
            //Console.WriteLine("You can type stuff now. Press 1 2 or 3 to change colours while typing! :3c ");
            //string typeStuff = Console.ReadLine();
            //Console.WriteLine(typeStuff);
            //int convertToNum = Convert.ToInt32(typeStuff);
        }
    }
}
