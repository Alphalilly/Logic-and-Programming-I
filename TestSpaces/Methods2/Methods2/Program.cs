using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        //declaration
        static int score;
        static int health;

        static void ShowHUD()
        {
            Console.WriteLine("health: " + health); //show hud
            Console.ReadKey(true);
        }

        static void TakeDamage(int damage)
        {
            health = health - damage;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Methods 2");
            Console.ReadKey(true);

            //initialisation
            score = 0;
            health = 100;

            //Console.WriteLine("health: " + health); //show hud
            ShowHUD();
            //health = health - 30; // take damage
            TakeDamage(10);
            //Console.WriteLine("health: " + health); //show hud
            ShowHUD();
            //health = health - 20; // take damage
            TakeDamage(40);
            //Console.WriteLine("health: " + health); //show hud
            ShowHUD();

            //you can go even further and loop both TakeDamage and ShowHUD


        }
    }
}
