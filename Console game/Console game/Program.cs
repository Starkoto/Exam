using System;

namespace Console_game
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            Console.WriteLine("What is your name?");
            Player player = new Player()
            {
               Name = Console.ReadLine()
            };

            Console.WriteLine("Lets start your adventure, " + player.Name + ".");

            //First enemy_________________________________________________________________________________________________________________________________________________________________________________

            Enemy firstEnemy = new Enemy("Goblin");
            GameLoop(firstEnemy, random, player, 10);

            //BOSS________________________________________________________________________________________________________________________________________________________________________________________

            if (!player.isDead)
            {
                Boss boss = new Boss();
                GameLoop(boss, random, player, 20);

            }
            else
            {
                GameOver();
            }
            if (!player.isDead)
            {
                Console.WriteLine("Congrats " + player.Name + " you won the game!!!");
            }
            else
            {
                GameOver();
            }
        }
        private static void GameOver()
        {
            Console.WriteLine("Game over.");
        }
        private static void GameLoop(Enemy enemy, Random random, Player player, int max_attack_power)
        {
            Console.WriteLine(player.Name + " you have encountered a " + enemy.Name + "!");
            while (!enemy.isDead && !player.isDead)
            {
                Console.WriteLine("What would you like to do:\n(1) Multiple attack\n(2) Strong attack\n(3) Block\n(4) Heal");
                string playersAction = Console.ReadLine();
                if (playersAction == "1")
                {
                    Console.WriteLine("You choose to do a multiple attack the " + enemy.Name + "!");
                    for (int i = 0; i < 3; i++)
                    {
                        enemy.GetsHit(random.Next(1, 10));
                    }
                }
                else if (playersAction == "2")
                {
                    Console.WriteLine("You choose to do a strong attack " + enemy.Name + "!");
                    enemy.GetsHit(random.Next(15, 30));
                }
                else if (playersAction == "3")
                {
                    Console.WriteLine("You choose to block!");
                    player.isBlocking = true;
                }
                else if (playersAction == "4")
                {
                    Console.WriteLine("You choose to heal!");
                    player.Heal(random.Next(1, 20));
                }
                else
                {
                    Console.WriteLine("You choose something else.");
                }
                if (!enemy.isDead)
                {
                    player.GetsHit(random.Next(1, max_attack_power));
                }

            }
        }
    }
}
