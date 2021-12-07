using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace readWritetofile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Story = File.ReadAllLines(@"StoryData.txt");

            for (int i = 0; i < Story.Length; i++)
            {
                Console.WriteLine(Story[i]);
            }

            Console.ReadKey(true);
        }
    }
}
