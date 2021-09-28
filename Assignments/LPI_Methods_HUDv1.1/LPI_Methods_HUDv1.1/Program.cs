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
		// extra: Formatted Ascii text, more methods, Coloured text, a score subtractor/divider? (when damage taken, lose score beased on damage taken)

		//Variables (is a thing)
		static int health;
		static int attack;
		static float score;

		static int lives;

		static float points;
		static int damage;
		static int heal;
		static int powerUp;

		static void Main(string[] args) // do I even need args?
		{
			Game game = new Game();

			game.GameStart();
		}

		class Game
        {
			//methods (does a thing)
			static void ShowHUD()
			{
				Console.WriteLine("Player name: Dumb Protagonist");
				Console.WriteLine("Health: " + health);
				Console.WriteLine("Attack Power: " + attack);
				Console.WriteLine("Lives: " + lives);
				Console.WriteLine("Score: " + score);
				Console.WriteLine();
			}

			static void takeDamage(int damage)
			{
				health = health - damage;
			}

			static void Heal(int heal)
			{
				health = health + heal;
			}

			static void PowerUp(int powerUp)
            {
				attack = attack + powerUp;
			}

			static void Revive()
            {
				lives = lives - 1; //future refrence. if lives = 0. then dont run method. or run game over method.
				health = 100;
			}

			static void AddScore(float mPoints, int scoreMulti) 
			{
				mPoints = mPoints * scoreMulti;
				points = mPoints; 
				// ^^^ I did it this way instead of just {score + mpoints * scoreMulti} so what I did on line 187 would work, and display the doubled points properly.
				score = score + points;
			}

			public void GameStart()
			{
				//starting values 
				health = 100;
				attack = 50;
				lives = 3;
				score = 200.7f;

				//output
				Console.WriteLine("> NSCC Game Dev");
				Console.WriteLine("> Totally not a Game");
				Console.WriteLine();
				Console.ReadKey(true);

				ShowHUD();
				Console.ReadKey(true);

				void event1()
				{
					Console.WriteLine("An Enemey Has appeared!");
					Console.WriteLine();
					Console.ReadKey(true);

					Console.WriteLine("Player Attacked! Player dealt " + attack + " in damage to Enemy");
					Console.WriteLine();
					Console.ReadKey(true);

					points = 5.5f;
					AddScore(points, 1);
					Console.WriteLine("Player gained " + points + " Score");
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);
				}

				event1();

				void event2()
				{
					damage = 20; // me small brain
					takeDamage(damage); // DAMN IT YOU CAN FAAKING PUT VARIABLES IN THE BRACKETS OF METHODS W H A T?!
					Console.WriteLine("Enemy Attacked! Player has taken " + damage + " in damage From Enemy");
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);

					heal = 10;
					Heal(heal);
					Console.WriteLine("Player healed " + heal + " HP");
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);
				}

				event2();

				void event3()
				{
					damage = 90; //note to self. do range cheking for values and prevent overflow into the negative values.
					takeDamage(damage);
					Console.WriteLine("Enemy Attacked! Player has take " + damage + " in damage From Enemy, its a critical hit!");
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);

					Revive();
					Console.WriteLine("Player Revives! " + lives + " Lives Remain");
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);
				}

				event3();

				void event4()
				{
					powerUp = 100;
					PowerUp (powerUp);
					Console.WriteLine("Player gains a power up! Attack Power increased by " + powerUp);
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);

					Console.WriteLine("Player Attacked! Player dealt " + attack + " in damage to Enemy. Its a Critical hit!");
					Console.WriteLine();
					Console.ReadKey(true);

					Console.WriteLine("Enemy Dies");
					Console.WriteLine();
					Console.ReadKey(true);


					points = 50.5f;
					Console.WriteLine("Player gained " + points + " points");
					Console.WriteLine();
					Console.ReadKey(true);

					AddScore(points, 2);
					Console.WriteLine("Player points doubled! now is " + points);
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);
				}

				event4();

				Console.WriteLine("> Game End");
				Console.ReadKey(true);
			}
		}
		
	}
}

