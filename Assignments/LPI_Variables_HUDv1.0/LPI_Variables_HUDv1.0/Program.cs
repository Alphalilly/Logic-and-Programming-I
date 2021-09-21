using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPI_Variables_HUDv1._0
{
	class Program
	{
		// Create a game HUD that shows pretend gameplay taking place, modifying the values of ints, strings and floats via hard coding, and showing those changes in the console output.
		// Variables: health, score, attack, lives. damage.
		// operators: Score Multiplier. Starting with (x2) and muliplies in by the power of 2 (x4, x6, x8, x10)
		// extra: Formatted Ascii text, Coloured text, a score divider? (when damage taken, lose score beased on damage taken)

		static string somthing; //what could I use with string? storing certain repetitve sentonces, and plugging them into other strings.


		//Variables
		static int health;
		static int attack;
		static int lives;
		static int damage;
		static int heal;
		static float score; //needs a multiplier

		/*
		static void Multiplier()
		{
			for (int multi = 1)
			{
				int multiplier;
				multi = multi* 2;
				multiplier = multi;

				Console.WriteLine(multi);
				Console.ReadKey(true);
			}
		}
		*/

		static void Main(string[] args)
        {
			//starting values 
			health = 100;
			attack = 50;
			damage = 20;
			heal = 10;
			lives = 3;
			score = 0f;

			//output
			Console.WriteLine("NSCC Game Dev");
			Console.WriteLine("Totally not a Game");
			Console.ReadKey(true);

			Console.WriteLine();

			Console.WriteLine("Player name: Dumb Protagonist");
			Console.WriteLine("Health: " + health);
			Console.WriteLine("Attack Power: " + attack);
			Console.WriteLine("Lives: " + lives);
			Console.WriteLine("Score: " + score); //wip
			Console.ReadKey(true);

			Console.WriteLine();

			Console.WriteLine("An Enemey Has appeared!");
			Console.ReadKey(true);

			Console.WriteLine();

			Console.WriteLine("Player Attacked! Player dealt " + attack + " in damage to Enemy");
			Console.ReadKey(true);

			Console.WriteLine();

			score = score + 5.5f;
			Console.WriteLine("Player gained 5.5 Score"); //wip
			Console.ReadKey(true);

			Console.WriteLine();

			Console.WriteLine("Player name: Dumb Protagonist");
			Console.WriteLine("Health: " + health);
			Console.WriteLine("Attack Power: " + attack);
			Console.WriteLine("Lives: " + lives);
			Console.WriteLine("Score: " + score); //wip
			Console.ReadKey(true);

			Console.WriteLine();

			health = health - damage;
			Console.WriteLine("Enemy Attacked! Player has taken " + damage + " in damage From Enemy");
			Console.ReadKey(true);

			Console.WriteLine();

			Console.WriteLine("Player name: Dumb Protagonist");
			Console.WriteLine("Health: " + health);
			Console.WriteLine("Attack Power: " + attack);
			Console.WriteLine("Lives: " + lives);
			Console.WriteLine("Score: " + score); //wip
			Console.ReadKey(true);

			Console.WriteLine();

			health = health + heal;
			Console.WriteLine("Player healed " + heal + " HP");
			Console.ReadKey(true);

			Console.WriteLine();

			Console.WriteLine("Player name: Dumb Protagonist");
			Console.WriteLine("Health: " + health);
			Console.WriteLine("Attack Power: " + attack);
			Console.WriteLine("Lives: " + lives);
			Console.WriteLine("Score: " + score); //wip
			Console.ReadKey(true);

			Console.WriteLine();

			damage = damage + 70;
			health = health - damage;
			Console.WriteLine("Enemy Attacked! Player has take " + damage + " in damage From Enemy, its a critical hit!");
			Console.ReadKey(true);

			Console.WriteLine();

			Console.WriteLine("Player name: Dumb Protagonist");
			Console.WriteLine("Health: " + health);
			Console.WriteLine("Attack Power: " + attack);
			Console.WriteLine("Lives: " + lives);
			Console.WriteLine("Score: " + score); //wip
			Console.ReadKey(true);

			Console.WriteLine();

			lives = lives - 1;
			health = health + 100;
			Console.WriteLine("Player Revives! " + lives + " Lives Remain");
			Console.ReadKey(true);

			Console.WriteLine();

			Console.WriteLine("Player name: Dumb Protagonist");
			Console.WriteLine("Health: " + health);
			Console.WriteLine("Attack Power: " + attack);
			Console.WriteLine("Lives: " + lives);
			Console.WriteLine("Score: " + score); //wip
			Console.ReadKey(true);

			Console.WriteLine();

			attack = attack + 100;
			Console.WriteLine("Player Attacked! Player dealt " + attack + " in damage to Enemy. Its a Critical hit!");
			Console.ReadKey(true);

			Console.WriteLine();

			Console.WriteLine("Enemy Dies");
			Console.ReadKey(true);

			Console.WriteLine();

			score = score + 50.5f;
			Console.WriteLine("Player gained 50.5 Score"); //wip
			Console.ReadKey(true);

			Console.WriteLine();

			Console.WriteLine("Player name: Dumb Protagonist");
			Console.WriteLine("Health: " + health);
			Console.WriteLine("Attack Power: " + attack);
			Console.WriteLine("Lives: " + lives);
			Console.WriteLine("Score: " + score); //wip
			Console.ReadKey(true);

			Console.WriteLine("game End");
			Console.ReadKey(true);
		}
	}
}
