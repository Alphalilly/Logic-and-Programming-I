using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPI_Conditionals_HUDv1._2
{
	class Program
	{
		// use HUD From previous assignment, and demonstrate the use of Conditionals (if, else, else if, etc)
		// Variables: 
		// Methods:  
		// operators: 
		// extra: 
		// https://theasciicode.com.ar/

		static int health;
		static int attack;
		static float score;

		static int lives;

		static float points;
		static int damage;
		static int heal;
		static int powerUp;

		public enum Weapon //putting this in a test class breaks it. Am I botherd to figure out why? no. so in class program it will stay. :)
		{
			Pistol,
			ShotGun,
			Spreader,
			Laser,
			Sniper,
			BFG
		}

		static void Main()
		{
			Game game = new Game(); // or just "new Game();" 
									// ^^ the differnce here is when I call on a function/method when using "Game." , the function has to be "static"
									// ^^ I have no idea how this works XD
			game.GameStart();
		}


		class Game
		{

			public static void HealthStatus()
			{
				if (health == 100)
				{
					Console.WriteLine("+ Prefect Health");
				}
				else if (health >= 75)
				{
					Console.WriteLine("+ Healthy");
				}
				else if (health >= 50)
				{
					Console.WriteLine("+ Hurt");
				}
				else if (health >= 10)
				{
					Console.WriteLine("+ Badly hurt");
				}
				else if (health > 0)
				{
					Console.WriteLine("+ Imminent Danger");
				}
				else if (health <= 0)
				{
					health = 0;
					Console.WriteLine("+ Player dead");
				}
				else
				{

				}
			}

			static void Boarder(float increment)
			{
				if (increment == 1)
				{
					Console.WriteLine("»══════¤══════«");
				}
				else if (increment == 1.5f)
				{
					Console.WriteLine("»═════════¤═════════«");
				}
				else if (increment == 2)
				{
					Console.WriteLine("»════════════¤════════════«");
				}
				else if (increment == 2.5f)
				{
					Console.WriteLine("»═══════════════¤═══════════════«");
				}
				else if (increment == 3)
				{
					Console.WriteLine("»══════════════════¤══════════════════«");
				}
				else
				{

				}
			}

			static void takeDamage(int damage) //needs testing
			{
				health = health - damage;
				if (health < 0)
                {
					health = 0;
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("<!> Too much Damage Taken, Health value set to 0");
				}
			} 

			static void AddScore(float mPoints, int scoreMulti)
			{
				mPoints = mPoints * scoreMulti;
				points = mPoints;
				// ^^^ I did it this way instead of just {score + mpoints * scoreMulti} so what I did on line 187 would work, and display the doubled points properly.
				score = score + points;
			}

			static void PowerUp(int powerUp)
			{
				attack = attack + powerUp;
			}

			static void Heal(int heal) //needs testing
			{
				health = health + heal;
				if (health > 100)
                {
					health = 100;
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("<!> Attepted to heal too much health, Health value set to 100");
				}
			}

			static void Revive() //needs testing
			{
				lives = lives - 1;
				health = 100;
				if (lives == 0)
                {
					Console.WriteLine("Game Over.");
                }
			}

			static void SwapWeapon(int swap) //needs testing
			{
				if (swap == 1)
				{
					Console.WriteLine(Weapon.Pistol);
				}
				else if (swap == 2)
				{
					Console.WriteLine(Weapon.ShotGun);
				}
				else if (swap == 3)
				{
					Console.WriteLine(Weapon.Spreader);
				}
				else if (swap == 4)
				{
					Console.WriteLine(Weapon.Laser);
				}
				else if (swap == 5)
				{
					Console.WriteLine(Weapon.Sniper);
				}
				else if (swap == 6)
				{
					Console.WriteLine(Weapon.BFG);
				}
                else
                {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("<!> Invalid weapon number, weapon range from 1-6");
				}
			}

			public void ShowHUD()
			{
				Console.ForegroundColor = ConsoleColor.DarkCyan;

				Boarder(2.5f);

				Console.ForegroundColor = ConsoleColor.Magenta;

				Console.WriteLine($"§\tDumb Protagonist\t§");

				Console.ForegroundColor = ConsoleColor.DarkCyan;

				Console.WriteLine("---------------------------------");

				Console.WriteLine("» Health: " + health);
				Console.WriteLine("» Attack Power: " + attack); //replace this with weapon and the attack power is replaced with what weapon your holding
				Console.WriteLine("» Weapon: " + Weapon.Pistol); //have this change with whatever weapon is in hand
				Console.WriteLine("» Lives: " + lives);
				Console.WriteLine("» Score: " + score);

				Console.WriteLine("---------------------------------");

				Console.ForegroundColor = ConsoleColor.Magenta;

				HealthStatus();

				Console.ForegroundColor = ConsoleColor.DarkCyan;

				Boarder(2.5f);

				Console.ForegroundColor = ConsoleColor.Yellow;

				Console.WriteLine();
			}

			public void GameStart() //needs updating with new gameplay 
			{
				//starting values 
				health = 100;
				attack = 50;
				lives = 3;
				score = 200.7f;

				//output
				Console.WriteLine("> NSCC Game Dev");
				Console.WriteLine("> Totally not a Game");
				Console.WriteLine("<!> GamePlay has not been updated yet to display the new changes <!>");

				Console.WriteLine();
				Console.ReadKey(true);

				ShowHUD();
				Console.ReadKey(true);

				void event1()
				{
					Console.WriteLine("! An Enemey Has appeared!");
					Console.WriteLine();
					Console.ReadKey(true);

					Console.WriteLine("> Player Attacked! Player dealt " + attack + " in damage to Enemy");
					Console.WriteLine();
					Console.ReadKey(true);

					points = 5.5f;
					AddScore(points, 1);
					Console.WriteLine("> Player gained " + points + " Score");
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
					Console.WriteLine("! Enemy Attacked! Player has taken " + damage + " in damage From Enemy");
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);

					heal = 10;
					Heal(heal);
					Console.WriteLine("> Player healed " + heal + " HP");
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
					Console.WriteLine("! Enemy Attacked! Player has take " + damage + " in damage From Enemy, its a critical hit!");
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);

					Revive();
					Console.WriteLine("> Player Revives! " + lives + " Lives Remain");
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);
				}

				event3();

				void event4()
				{
					powerUp = 100;
					PowerUp(powerUp);
					Console.WriteLine("> Player gains a power up! Attack Power increased by " + powerUp);
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);

					Console.WriteLine("> Player Attacked! Player dealt " + attack + " in damage to Enemy. Its a Critical hit!");
					Console.WriteLine();
					Console.ReadKey(true);

					Console.WriteLine("! Enemy Dies");
					Console.WriteLine();
					Console.ReadKey(true);


					points = 50.5f;
					Console.WriteLine("> Player gained " + points + " points");
					Console.WriteLine();
					Console.ReadKey(true);

					AddScore(points, 2);
					Console.WriteLine("> Player points doubled! now is " + points);
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
