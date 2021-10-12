using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before Arrays");
            // STORE AMMO OF ALL WEAPONS
            //pistol = 6/6
            //shotgun = 2/2
            // etc
            int weapon = 1; //WEAPON INDEX. 0 = pistol, 1 = shotgun, etc

            int pistolAmmo = 6;
            int shotgunAmmo = 2;

            //how to show the ammo of current weapon (without hardcoding)

            if (weapon == 0)
            {
                Console.WriteLine("pistol ammo " + pistolAmmo);
            }
            else if (weapon == 1)
            {
                Console.WriteLine("shot Gun " + shotgunAmmo);
            }
            //etc

            Console.WriteLine("Arrays");
            //its litrally an Array of something. a way to store a list of something (except lists are also its own thing)
            // better and effeicant way to store variables

            int[] ammo; //declaration (ammo is an array of ints)
            ammo = new int[3]; //initialisation 1 (initialisation of the index. hpw much room it has)
            ammo[0] = 6; // pistol ammo // initialisation 2 (initialisation of the values in the array) 
            ammo[1] = 2; //shotgun ammo

            string[] weaponName = new string[2];
            weaponName[0] = "pistol";
            weaponName[1] = "shotgun";

            //how to show the ammo of current weapon (without hardcoding)

            Console.WriteLine("pistol ammo " + ammo[0]); //hard coded
            Console.WriteLine("shotgun ammo " + ammo[1]); //hard coded

            if (weapon == 0)
            {
                Console.WriteLine("pistol ammo " + ammo[0]); 

            }
            else if (weapon == 1)
            {
                Console.WriteLine("shotgun ammo " + ammo[1]);
            }

            //very cool solution this is better XD
            Console.WriteLine(weaponName[weapon] + ammo[weapon]); //displays the ammo for the current weapon (without all the "if" noise)
            // well heck i guess you can put other ints into arrays XDDD
            // not to misunderstand. int weapon is only storeing the number 1 (currently). 
            // so pluggging in int weapon into ammo[] or weaponName[] is the same as putting in ammo[1] or weaponName[1]
            // it just looks more elegent in practice to use the already int weapon with the value of 1, then just ammo[1]

            
            args[0] = "this";
            args[1] = "is";
            args[3] = "an";
            args[4] = "array";

            void weapon(int[] ammo) // so i guess i can do this too
            {

            }
        }
    }
}
