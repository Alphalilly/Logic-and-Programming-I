using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPI_Arrrays_AmmoSystem
{
    class Program
    {
        public static int[] weapon = new int[5]; //this means that there are 5 slots. not the slots in the index go up to the number 5
        //I keep getting a NullReferenceException when I do this. and I dont know why >< 
        // https://stackoverflow.com/questions/779091/what-does-object-reference-not-set-to-an-instance-of-an-object-mean
        //{
        //    weapon[0] = 1,
        //    weapon[1] = 2,
        //    weapon[2] = 3,
        //    weapon[3] = 4,
        //    weapon[4] = 5
        //};

        static int[] ammo = new int[5];
        //here too
        //{
        //    ammo[0] = 20,
        //    ammo[1] = 10,
        //    ammo[2] = 30,
        //    ammo[3] = 50,
        //    ammo[4] = 5
        //};

        static string[] weaponName = new string[5];
        // and here. so I just moved it back in Main()
        //{
        //    weaponName[0] = "Pistol",
        //    weaponName[1] = "Shotgun",
        //    weaponName[2] = "Sniper",
        //    weaponName[3] = "Lazer Gun",
        //    weaponName[4] = "BFG"
        //};


        static void Main(string[] args)
        {
            //weapon
            weapon[0] = 1;
            weapon[1] = 2;
            weapon[2] = 3;
            weapon[3] = 4;
            weapon[4] = 5;

            //weapon ammo
            ammo[0] = 20;
            ammo[1] = 10;
            ammo[2] = 30;
            ammo[3] = 50;
            ammo[4] = 5;
            
            //weapon name
            weaponName[0] = "Pistol";
            weaponName[1] = "Shotgun";
            weaponName[2] = "Sniper";
            weaponName[3] = "Lazer Gun";
            weaponName[4] = "BFG";

            Fire(weapon[0]); //hol' up. Why does the output say "shot gun" and ammo "10", when I clearly specified weapon to be 0 in the array?
                             // aaaa i dont have time to think of an answer.
            Console.ReadKey(true);

            Reload(weapon[0]);

            Console.ReadKey(true);

        }

        // would be nice to create method that displays all the weapon status

        static void Fire(int weapon) //decrements ammo
        {
            Console.WriteLine("Fired " + weaponName[weapon] + " With ammo " + ammo[weapon]);

            //if ammo is more then 0
            if (ammo[weapon] < 0)
            {
                ammo[weapon]--;
            }
            else
            {

            }

            Console.WriteLine("now " + weaponName[weapon] + " With ammo " + ammo[weapon]); //fpr some reason the ammo value dosnt change dispite being decremented ><

        }

        static void Reload(int weapon) //adds ammo
        {
            Console.WriteLine("Relaod " + weaponName[weapon] + " With ammo " + ammo[weapon]);

            //if ammo is less then itself

            if (ammo[weapon] > ammo[weapon])
            {
                ammo[weapon]++;
            }
            else
            {

            }

            Console.WriteLine("now " + weaponName[weapon] + " With ammo " + ammo[weapon]);
        }

    }

    /* my dumb ass's fist attempt omg im dumb
    class Program
    {
        static int[] weapon = new int[5]; //this means that there are 5 slots. not the slots in the index go up to the number 5
        static int[] ammo = new int[5];
        static string[] weaponName = new string[5];
        

        static void Main(string[] args)
        {
            //Weapons
            weapon[0] = 1;
            weapon[1] = 2;
            weapon[2] = 3;
            weapon[3] = 4;
            weapon[4] = 5;

            //Ammo
            ammo[0] = 20;
            ammo[1] = 10;
            ammo[2] = 30;
            ammo[3] = 50;
            ammo[4] = 5;

            //weapon Names
            weaponName[0] = "Pistol";
            weaponName[1] = "Shotgun";
            weaponName[2] = "Sniper";
            weaponName[3] = "Lazer Gun";
            weaponName[4] = "BFG";

            test(ammo[0]);

            //Fire(weapon[0], ammo[0]); //this is yucky cuz im basically just saying (0, 0). its the same value! but i guessed being used in differnt ways lel

            Console.ReadKey(true);

            //Reload(weapon[0], ammo[0]);

            Console.ReadKey(true);
        }

        // create method that displays all the weapon status

        static void test(int choiceAmmo)
        {
            Console.WriteLine(choiceAmmo);
        }

        static void Fire(int choiceWeapon, int choiceAmmo) //decriments ammo
        {
            Console.WriteLine("Fired " + weaponName[choiceWeapon] + " With ammo " + ammo[choiceAmmo]); //honestly I could have just put ammo[choiceWeapon] and it would still be the same
            //wait this dosnt work cuz im doing a fucky and puttingthe value of 20 back into the ammo[]

            //if ammo is more then 0

            choiceAmmo = choiceAmmo - 1;

            Console.WriteLine("now " + weaponName[choiceWeapon] + " With ammo " + ammo[choiceAmmo]);

        }

        static void Reload(int choiceWeapon, int choiceAmmo) //adds ammo
        {
            Console.WriteLine("Relaod " + weaponName[choiceWeapon] + " With ammo " + ammo[choiceAmmo]);

            //if ammo is less then itself

            choiceAmmo = choiceAmmo + 1;

            Console.WriteLine("now " + weaponName[choiceWeapon] + " With ammo " + ammo[choiceAmmo]);
        }

    }
    */
}
