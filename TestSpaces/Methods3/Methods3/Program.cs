using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Program
    {
        static long count;
        //static int count;

        static void Loop()
        {
            count = count + 1;
            Console.WriteLine("This is a loop # " + count);
            Loop();

            // biggest int - This is a loop # 13505
            // biggest long - This is a loop # 13504
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Methods 3");
            Console.ReadKey(true);

            Loop();
        }
    }
}
