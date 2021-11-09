using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string itemName;
            //string[] Inv = new string[10];

            //itemName = "hp potion";

            ////have something that sets everything in Inv[] to have "-"

            //for (int i = 0; i <= Inv.Length - 1; i++)
            //{
            //    Inv[1] = "";
            //}

            //void a(string pick)
            //{
            //    pick = itemName;
            //    itemName = Inv[0];

            //    if (pick == "-")
            //    {
            //        //dont do anything
            //    }
            //    else
            //    {
            //        // replace - with itemName
            //    }
            //}

            Console.WriteLine("Lists");

            List<string> //decloration
                inv = new List<string>(); //instantiation

            //_ = new List<string>();

            Console.WriteLine("Capacity: " + inv.Capacity);
            Console.WriteLine("Count: " + inv.Count);
            inv.Add("health potion");
            Console.WriteLine("Capacity: " + inv.Capacity);
            Console.WriteLine("Count: " + inv.Count);
            inv.Add("ring");
            Console.WriteLine("Capacity: " + inv.Capacity);
            Console.WriteLine("Count: " + inv.Count);
            inv.Add("bottle");
            Console.WriteLine("Capacity: " + inv.Capacity);
            Console.WriteLine("Count: " + inv.Count);
            inv.Add("pen");
            Console.WriteLine("Capacity: " + inv.Capacity);
            Console.WriteLine("Count: " + inv.Count);
            inv.Add("door");
            Console.WriteLine("Capacity: " + inv.Capacity);
            Console.WriteLine("Count: " + inv.Count);

            Console.WriteLine();

            for (int i = 0; i <= inv.Count - 1; i++) //not as nice
                Console.WriteLine(inv[i]);
            Console.WriteLine();

            foreach (string item in inv) //nice
                Console.WriteLine(item);
            Console.WriteLine();

            inv.Remove("ring");

            foreach (string item in inv)
                Console.WriteLine(item);
            Console.WriteLine();

            Console.ReadKey(true);

        }
    }
}
