using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPI_Arrrays_AmmoSystem
{
    // Please ignore my mental breakdown in the code comments.
    // Disclaimer: This is probably very unprofessional and I promise I acknowledge that and wont do the same thing in an actual work enviornment plz and thanks.

    class Program
    {
        //make another array for capacity, this would work with the reload method.

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
        

        static void Main()
        {
            //weapon (the value of weapon[] is going to be plugged into ammo[] and weaponName[].
            weapon[0] = 0; // was weapon[0] = 1; im stupid. thats why my code was doing the dumb.
            weapon[1] = 1;
            weapon[2] = 2;
            weapon[3] = 3;
            weapon[4] = 4;

            //weapon ammo
            ammo[0] = 20; //lol this was the hint yesterday~ when i was plugging in the numbers back into the array and it broke~ WHY DIDNT I NOTICE IT SOONER THAT IT WAS THE SAME THING FOR weapon[0] ~
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

            // me yesterday: hol' up. Why does the output say "shot gun" and ammo "10", when I clearly specified weapon to be 0 in the array? 
            // me today: no i didnt you dunce, I assigned it a 1 not 0, the [0] is its position in the array.

            // i figured out why it wasnt displaying properly.  weapon[0] = 1  should be  weapon[0] = 0
            // ofcourse it didint work cuz im plugging the numbers back into the array in the mothods below. telling it to use the number to go to "x" position in the array. 
            // God what the hell. no one will know why I mean because im bad at comments and programming :)


            Fire(weapon[0]);

            Console.ReadKey(true);

            Reload(weapon[0]);

            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("+ Weapon Switch!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            DisplayGun(weapon[3]);
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey(true);

            Fire(weapon[3]);

            Console.ReadKey(true);

            Reload(weapon[3]);

            Console.ReadKey(true);

            Reload(weapon[3]);
            Reload(weapon[3]);
            Reload(weapon[3]);
            Reload(weapon[3]);

            Console.ReadKey(true);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("+ Weapon Switch!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            DisplayGun(weapon[1]);
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey(true);

            Fire(weapon[1]);
            Fire(weapon[1]);
            Fire(weapon[1]);
            Fire(weapon[1]);
            Fire(weapon[1]);
            Fire(weapon[1]);
            Fire(weapon[1]);
            Fire(weapon[1]);
            Fire(weapon[1]);
            Fire(weapon[1]);
            Fire(weapon[1]);
            Fire(weapon[1]);

            Console.ReadKey(true);

        }

        static void DisplayGun(int weapon)
        {
            Console.WriteLine();
            Console.WriteLine("Current Weapon: " + weaponName[weapon]); // or could be weaponName[weapon[0]] **cursed (array inside an array inside an array :3c)
            Console.WriteLine("Weapon Ammo: " + ammo[weapon]);
            Console.WriteLine();
        }

        static void Fire(int weapon) //decrements ammo
        {
            Console.WriteLine("> Weapon Fired!");

            ammo[weapon]--;

            if (ammo[weapon] < 0)
            {
                ammo[weapon] = 0;
            }

            DisplayGun(weapon);

            // this is   ammo[0]   so the if satement kinda looks like this     ammo[0] < 0     so then how do I tell it to compare    20 < 0  ?
            // wait...   20 < 0    ????
            // dont tell me ive been dumb this whole time.
            // it should be   20 > 0    shouldnt it?
            // matt im sorry ill go back to grade school math

            /* //this also worked, but its hella janky
            if (ammo[weapon] > 0) 
            {
                ammo[weapon]--;
            }
            else
            {

            }
            */
        }

        static void Reload(int weapon) //adds ammo (Broken)
        {
            //so i guess that the reload would set the ammo to max, not increment it ><
            //so it would be just this in the method   ammo[weapon] = cap[weapon]

            Console.WriteLine("> Weapon Reloaded!");

            //if ammo is more then itself
            if (ammo[weapon] >= ammo[weapon]) // this still broken I dont wanna fix it right now.
            {
                ammo[weapon]++;
            }
            else
            {

            }

            DisplayGun(weapon);
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
