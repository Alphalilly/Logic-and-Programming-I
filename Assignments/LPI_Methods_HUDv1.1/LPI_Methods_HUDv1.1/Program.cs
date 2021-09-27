using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPI_Methods_HUDv1._1
{
    class Program
    {
		// use HUD From previous assignment and clean up the Code. Displaying the same aspects of the pervious assignment. And demonstrate the use of Methods
		// Variables: health, score, attack, lives. damage.
		// Methods:  ShowHUD(), TakeDamage(int damage), AddScore(int enemyValue, int scoreMultiplier)
		// operators: Score Multiplier. Starting with (x2) and muliplies in by the power of 2 (x4, x6, x8, x10)
		// extra: Formatted Ascii text, Coloured text, a score subtractor/divider? (when damage taken, lose score beased on damage taken)

		//Variables
		static int health;
		static int attack; //player attack
		static int lives;
		static int heal;
		static float score; // overall score

		static float points; //incoming points (to be multiplied)

		static void ShowHUD()
        {
			Console.WriteLine("Player name: Dumb Protagonist");
			Console.WriteLine("Health: " + health);
			Console.WriteLine("Attack Power: " + attack);
			Console.WriteLine("Lives: " + lives);
			Console.WriteLine("Score: " + score);
		}

		static void takeDamage(int damage) //enemy attack
		{
			health = health - damage;
        }

		static void AddScore(int points, int scoreMulti)
        {
			score = score + points * scoreMulti; //sortaaaa
        }


		static void Main(string[] args)
		{
			game();

		}

		


		static void game()
		{
			//starting values 
			health = 100;
			attack = 50;
			heal = 10;
			lives = 3;
			score = 200.7f;

			//output
			Console.WriteLine("> NSCC Game Dev");
			Console.WriteLine("> Totally not a Game");
			Console.ReadKey(true);

			Console.WriteLine();

			ShowHUD();
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
				Console.WriteLine("Player gained " + points + " Score");
				Console.ReadKey(true);

				Console.WriteLine();

				ShowHUD();
				Console.ReadKey(true);

				Console.WriteLine();
			}

			void event2()
			{
				health = health - damage;
				Console.WriteLine("Enemy Attacked! Player has taken " + damage + " in damage From Enemy");
				Console.ReadKey(true);

				Console.WriteLine();

				ShowHUD();
				Console.ReadKey(true);

				Console.WriteLine();

				health = health + heal;
				Console.WriteLine("Player healed " + heal + " HP");
				Console.ReadKey(true);

				Console.WriteLine();

				ShowHUD();
				Console.ReadKey(true);

				Console.WriteLine();
			}

			void event3()
			{
				damage = damage + 70; //make damage 70 here
				health = health - damage;
				Console.WriteLine("Enemy Attacked! Player has take " + damage + " in damage From Enemy, its a critical hit!");
				Console.ReadKey(true);

				Console.WriteLine();

				ShowHUD();
				Console.ReadKey(true);

				Console.WriteLine();

				lives = lives - 1;
				health = health + 100;
				Console.WriteLine("Player Revives! " + lives + " Lives Remain");
				Console.ReadKey(true);

				Console.WriteLine();

				ShowHUD();
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
				Console.WriteLine("Player gained " + points + " points");
				Console.ReadKey(true);

				Console.WriteLine();

				Multiplier(2); //score multiplier of 2 currently applied
				Console.WriteLine("Player points doubled! now is " + points);
				Console.ReadKey(true);


				Console.WriteLine();

				ShowHUD();
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

