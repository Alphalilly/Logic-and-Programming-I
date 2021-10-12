using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPI_Arrrays_AmmoSystem
{
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

            choiceAmmo = choiceAmmo - 1;

            Console.WriteLine("now " + weaponName[choiceWeapon] + " With ammo " + ammo[choiceAmmo]);

        }

        static void Reload(int choiceWeapon, int choiceAmmo) //adds ammo
        {
            Console.WriteLine("Relaod " + weaponName[choiceWeapon] + " With ammo " + ammo[choiceAmmo]);

            choiceAmmo = choiceAmmo + 1;

            Console.WriteLine("now " + weaponName[choiceWeapon] + " With ammo " + ammo[choiceAmmo]);
        }

    }
}
