using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; //added this

namespace UnittestAAAA
{
    class Program
    {
        static int health = 100;

        static void Main(string[] args)
        {
            Unittest();
            BetterUnitTest();

            Console.ReadKey(true);
        }

        static void Heal(int hp)
        {
            health += hp;
        }

        static void TakeDamage(int damage)
        {
            health -= damage;
        }

        static void BetterUnitTest()
        {
            //Debug.Assert(2 + 2 == 4); // is true
            //Debug.Assert(2 + 2 == 5); //is not true

            Debug.Assert(health <= 100);
            Debug.Assert(health >= 0);
        }

        static void Unittest()
        {

            Console.WriteLine("Testing Heal() respects health range 0..100");
            Console.WriteLine(health);
            Heal(10);
            if (health > 100) // ! is not equal to
            {
                Console.WriteLine("ERROR health = " + health);
            }
            else
            {
                Console.WriteLine("success!");
            }

            health = 100; //reset

            Console.WriteLine("Testing TakeDamage() respects health range 0..100");
            TakeDamage(110);
        }
    }
}
