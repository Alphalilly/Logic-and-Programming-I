using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPI_Conditionals_HUDv1._2
{
	class Program
	{
		// use HUD From previous assignment, and demonstrate the use of Conditionals. in pretend gameplay.
		// Variables: health, Weapon.
		// Methods: ChangeWeapon, TakeDamage, Heal, SHowHUD
		// extra: use enums, error checking, switch statements.
		// https://theasciicode.com.ar/

		static int health;
		static int attack;
		static float score;

		static int lives;

		static float points;
		static int damage;
		static int heal;

		//static bool alive; // yeah, decided not to do this. 

		static string weapon;

		//public enum Weapon //eh, i gave up on this lol. enums are weird.
		//{
		//	NA,
		//	Pistol,
		//	ShotGun,
		//	Spreader,
		//	Laser,
		//	Sniper,
		//	BFG
		//}

		static void Main()
		{
			Game game = new Game(); // or just "new Game();" 
									// ^^ the differnce here is when I call on a function/method when using "Game." , the function has to be "static"
									// ^^ I have no idea how this works XD
			game.GameStart();
		}


		class Game
		{
			//static void PlayerDeath() // eh. nvm.
			//{
			//	alive = false;
			//	Console.WriteLine("Game Over.");
			//	Console.ReadKey(true);
			//}

			static void HealthStatus()
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
					Console.WriteLine("+ Dead");
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

			static void takeDamage(int damage)
			{
				health = health - damage;
				if (health < 0)
                {
					health = 0;
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("<!> Too much Damage Taken, Health value set to 0.");
					Console.ForegroundColor = ConsoleColor.Yellow;
				}
			} 

			static void AddScore(float mPoints, int scoreMulti)
			{
				mPoints = mPoints * scoreMulti;
				points = mPoints;
				// ^^^ I did it this way instead of just {score + mpoints * scoreMulti} so what I did on line 187 would work, and display the doubled points properly.
				score = score + points;
			}

			static void Heal(int heal)
			{
				health = health + heal;
				if (health > 100)
                {
					health = 100;
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("<!> Attepted to heal too much health, Health value set to 100.");
					Console.ForegroundColor = ConsoleColor.Yellow;
				}
			}

			static void Revive()
			{
				lives = lives - 1;
				health = 100;
				//if (lives == 0) 
				//{
				//	PlayerDeath(); // eh. nvm.
				//}
			}

			static void SwapWeapon(int swap)
			{
				if (swap == 0)
                {
					weapon = "NA";
					attack = 0;
				}
				else if (swap == 1)
				{
					weapon = "Pistol";
					attack = 10;
				}
				else if (swap == 2)
				{
					weapon = "ShotGun";
					attack = 30;
				}
				else if (swap == 3)
				{
					weapon = "Spreader";
					attack = 50;
				}
				else if (swap == 4)
				{
					weapon = "Laser";
					attack = 60;
				}
				else if (swap == 5)
				{
					weapon = "Sniper";
					attack = 90;
				}
				else if (swap == 6)
				{
					weapon = "BFG";
					attack = 9999;
				}
                else
                {
					Console.ForegroundColor = ConsoleColor.Red;
					weapon = "???";
					Console.WriteLine("<!> Player attepted to swap to " + weapon + " Invalid weapon number, outside of range. Please run this operation again.");
					Console.ForegroundColor = ConsoleColor.Yellow;
				}
			}

			static void ShowHUD()
			{
				Console.ForegroundColor = ConsoleColor.DarkCyan;

				Boarder(2.5f);

				Console.ForegroundColor = ConsoleColor.Magenta;

				Console.WriteLine($"§\tDumb Protagonist\t§");

				Console.ForegroundColor = ConsoleColor.DarkCyan;

				Console.WriteLine("---------------------------------");

				Console.WriteLine("» Health: " + health);
				Console.WriteLine("» Attack Power: " + attack);
				Console.WriteLine("» Weapon: " + weapon); 
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

			public void GameStart()
			{
				//starting values 
				health = 100;
				lives = 3;
				score = 0f;
				SwapWeapon(0);
				//alive = true; // eh. nvm.

				Console.WriteLine("> NSCC Game Dev");
				Console.WriteLine("> Totally not a Game");

				Console.WriteLine();
				Console.ReadKey(true);

				ShowHUD();
				Console.ReadKey(true);

				//while (alive == true) // eh. nvm. 
                //{
				void event1()
				{
					Console.WriteLine("! A Boss Has appeared!");
					Console.WriteLine();
					Console.ReadKey(true);

					
					SwapWeapon(69); //pretend error lol
					Console.WriteLine();
					Console.ReadKey(true);

					SwapWeapon(1);
					Console.WriteLine("> Player Swapped to " + weapon);
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);

					Console.WriteLine("> Player Attacked! Player dealt " + attack + " in damage to the Boss");
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
					damage = 30;
					takeDamage(damage);
					Console.WriteLine("! The Boss Attacked! Player has taken " + damage + " in damage From Boss");
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);

					heal = 40;
					Console.WriteLine("> Player healed " + heal + " HP");
					Console.WriteLine();
					Console.ReadKey(true);

					Heal(heal);
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);
				}

				event2();

				void event3()
                {
					SwapWeapon(2);
					Console.WriteLine("> Player Swapped to " + weapon);
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);

					Console.WriteLine("> Player Attacked! Player dealt " + attack + " in damage to the Boss");
					Console.WriteLine();
					Console.ReadKey(true);

					points = 15.5f;
					AddScore(points, 1);
					Console.WriteLine("> Player gained " + points + " Score");
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);

				}

				event3();

				void event4()
                {
					damage = 50;
					takeDamage(damage);
					Console.WriteLine("! The Boss Attacked! Player has taken " + damage + " in damage From Boss");
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);

					heal = 50;
					Console.WriteLine("> Player healed " + heal + " HP");
					Heal(heal);
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);

					Console.WriteLine("> The Boss is enraged. it charges up for a massive attack!");
					Console.WriteLine();
					Console.ReadKey(true);
				}

				event4();

				void event5()
				{
					damage = 110;
					Console.WriteLine("! The Boss Attacked! Player has take " + damage + " in damage From Enemy, its a critical hit!");
					Console.WriteLine();
					Console.ReadKey(true);

					takeDamage(damage);
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

				event5();

				void event6()
				{
					SwapWeapon(6);
					Console.WriteLine("> Player Swapped to " + weapon);
					Console.WriteLine();
					Console.ReadKey(true);

					ShowHUD();
					Console.ReadKey(true);

					Console.WriteLine("> Player Attacked! Player dealt " + attack + " in damage to The Boss. Its a Critical hit!");
					Console.WriteLine();
					Console.ReadKey(true);

					Console.WriteLine("! The Boss Dies");
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

				event6();
				//}

				Console.WriteLine("> Game End");
				Console.ReadKey(true);
			}
		}

	}
}
