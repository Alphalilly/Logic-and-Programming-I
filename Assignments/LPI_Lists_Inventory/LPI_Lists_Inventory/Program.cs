using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPI_Lists_Inventory
{
    /* Challenge - C# Fundamentals: Lists (Inventory System v1.0):*
       - Code and showcase the usages of an inventory system using C# Lists

       * Technical Specifications: *

       - Use a List of strings
       - Have an item maximum

       - PickUp() -- respects maximum limitations.
       - Drop()
       - Use() -- assume using an item destroys it if you wish.
       - ClearInventory() -- used on player death.
       - ShowInventory() -- could be called at bottom of all other methods.

       - Simulated Gameplay to showcase code functionality
       - Range checking
       - Error Checking
       - Demonstrate storing multiples of the same item.
       - Do not access list functionality in main. (use methods)
     */

    class Program
    {
        static void Main(string[] args)
        {
            var Test = new List<string>(8);
            //sets the capacity to 8 in the parameters.
            // If I dont set the Capacity then it will automatially keep expanding i guess. the more stuff I put in the list.
            // it expands nontheless. and it multiplies to capacity by 8. i guess it dosnt work the same as arrays?


            foreach (string item in Test)
            {
                Console.WriteLine(item);
            }

            if (Test.Count != 8)
            {
                Test.Add("a");
                Test.Add("b");
                Test.Add("c");
                Test.Add("d");
                Test.Add("e");
                Test.Add("f");
                Test.Add("g");
                Test.Add("h");
                Test.Add("i");
            }
            else
            {
                Console.WriteLine("do nothing");
                return;
            }

            foreach (string item in Test)
            {
                Console.WriteLine(item);
            }

            //a loop that adds stuff. and a loop that "lists" stuff?




            Console.WriteLine(Test.Capacity);
            Console.WriteLine(Test.Count);


            Console.ReadKey(true);
        }
    }
}
//if iList.Capacity = 8. then stop
// dont lists also have tags or IDs with every item? (item, id)