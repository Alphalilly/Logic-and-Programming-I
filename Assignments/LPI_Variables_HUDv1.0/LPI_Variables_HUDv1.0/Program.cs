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

		//static string somthing; //what could I use with string? storing certain repetitve sentonces, and plugging them into other strings.


		//Variables
		static int health;
		static int attack;
		static int lives;
		static int damage;
		static int heal;
		static float score; //needs a multiplier

		static float points; //incoming points (to be multiplied)

		
		static void Multiplier(int multiplier)
		{
			/* Attepmt number 1
				for (int multi = 1)
				{
					int multiplier;
					multi = multi* 2;
					multiplier = multi;

					Console.WriteLine(multi);
					Console.ReadKey(true);
				}
			*/

			// "Multiply incoming score" -matt
			// I though to multiply the existing score, but this way seems a lot simpler and easier
			// score multiplier will be activated everytime the player lands a critical hit

			// whenever Multiplier is executed, I want to take "points", that will store the incoming points, and multiply it by 2. Then add it onto the total score
			// I also wanted to stack this as well. landing consecutive crit hits, will multiply the multiplier by 2 every time. (with the cap of a x8 score multiplier)
			// ^^^ but this part seems a little bit complex ><'

			// I could also add a score divider, or a better name for it be a score "subtractor".
			//.. that will subtract points from the player score whenever the player is hit thats half the enemy's damage.
			// ^^^ thats if I have the time to do so.

			points = points * multiplier;
			score = score + points;

			// score = score + points * multiplier
			// ^ is the right answer XD. I didnt even need a method.
			// the way I did it still works, its just not correct implementation, also the multiplier number shouldnt be a magic number
		}


		static void Main(string[] args)
        {
			game();

			//debug();

		}

		static void debug()
        {
			points = 2.6f;
			score = 75.5f;

			Console.WriteLine("Score: " + score);
			Console.ReadKey(true);

			Console.WriteLine("incoming points: " + points);
			Console.ReadKey(true);

			Console.WriteLine();


			Multiplier(2);
			Console.WriteLine("Multiplier x2");
			Console.ReadKey(true);


			Console.WriteLine();


			Console.WriteLine("modified points: " + points);
			Console.ReadKey(true);

			Console.WriteLine("current Score: " + score);
			Console.ReadKey(true);

			Console.WriteLine();


			points = 2.6f;
			score = 75.5f;
			Console.WriteLine("stats reset to defult");
			Console.ReadKey(true);

			Console.WriteLine();


			Multiplier(4);
			Console.WriteLine("Multiplier x4");
			Console.ReadKey(true);

			Console.WriteLine();


			Console.WriteLine("modified points: " + points);
			Console.ReadKey(true);

			Console.WriteLine("current Score: " + score);
			Console.ReadKey(true);

			Console.WriteLine();
		}


		static void game()
		{
			//starting values 
			health = 100;
			attack = 50;
			damage = 20;
			heal = 10;
			lives = 3;
			score = 200.7f;

			//output
			Console.WriteLine("> NSCC Game Dev");
			Console.WriteLine("> Totally not a Game");
			Console.ReadKey(true);

			Console.WriteLine();

			Console.WriteLine("Player name: Dumb Protagonist");
			Console.WriteLine("Health: " + health);
			Console.WriteLine("Attack Power: " + attack);
			Console.WriteLine("Lives: " + lives);
			Console.WriteLine("Score: " + score); //wip
			Console.ReadKey(true);

			Console.WriteLine();

			void event1()
            {
				Console.WriteLine("An Enemey Has appeared!");
				Console.ReadKey(true);

				Console.WriteLine();

				Console.WriteLine("Player Attacked! Player dealt " + attack + " in damage to Enemy");
				Console.ReadKey(true);

				Console.WriteLine();

				points = 5.5f;
				Multiplier(1); //no multiplier curently applied
				Console.WriteLine("Player gained "+ points + " Score");
				Console.ReadKey(true);

				Console.WriteLine();

				Console.WriteLine("Player name: Dumb Protagonist");
				Console.WriteLine("Health: " + health);
				Console.WriteLine("Attack Power: " + attack);
				Console.WriteLine("Lives: " + lives);
				Console.WriteLine("Score: " + score);
				Console.ReadKey(true);

				Console.WriteLine();
			}

			void event2()
            {
				health = health - damage;
				Console.WriteLine("Enemy Attacked! Player has taken " + damage + " in damage From Enemy");
				Console.ReadKey(true);

				Console.WriteLine();

				Console.WriteLine("Player name: Dumb Protagonist");
				Console.WriteLine("Health: " + health);
				Console.WriteLine("Attack Power: " + attack);
				Console.WriteLine("Lives: " + lives);
				Console.WriteLine("Score: " + score);
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
				Console.WriteLine("Score: " + score);
				Console.ReadKey(true);

				Console.WriteLine();
			}

			void event3()
            {
				damage = damage + 70;
				health = health - damage;
				Console.WriteLine("Enemy Attacked! Player has take " + damage + " in damage From Enemy, its a critical hit!");
				Console.ReadKey(true);

				Console.WriteLine();

				Console.WriteLine("Player name: Dumb Protagonist");
				Console.WriteLine("Health: " + health);
				Console.WriteLine("Attack Power: " + attack);
				Console.WriteLine("Lives: " + lives);
				Console.WriteLine("Score: " + score);
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
				Console.WriteLine("Score: " + score);
				Console.ReadKey(true);

				Console.WriteLine();
			}

			void event4()
            {
				attack = attack + 100;
				Console.WriteLine("Player Attacked! Player dealt " + attack + " in damage to Enemy. Its a Critical hit!");
				Console.ReadKey(true);

				Console.WriteLine();

				Console.WriteLine("Enemy Dies");
				Console.ReadKey(true);

				Console.WriteLine();


				points = 50.5f;
				Console.WriteLine("Player gained " + points +  " points");
				Console.ReadKey(true);

				Console.WriteLine();

				Multiplier(2); //score multiplier of 2 currently applied
				Console.WriteLine("Player points doubled! now is " + points);
				Console.ReadKey(true);


				Console.WriteLine();

				Console.WriteLine("Player name: Dumb Protagonist");
				Console.WriteLine("Health: " + health);
				Console.WriteLine("Attack Power: " + attack);
				Console.WriteLine("Lives: " + lives);
				Console.WriteLine("Score: " + score);
				Console.ReadKey(true);

				Console.WriteLine();

			}

			event1();

			event2();

			event3();

			event4();

			Console.WriteLine("> game End");
			Console.ReadKey(true);
		}
	}
}
