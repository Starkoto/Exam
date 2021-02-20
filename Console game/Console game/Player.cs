using System;
using System.Collections.Generic;
using System.Text;

namespace Console_game
{
    public class Player
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public bool isDead { get; set; }
        public bool isBlocking { get; set; }
        public Player()
        {
            Health = 100;
        }
        public void GetsHit(int hit_value)
        {
            if(isBlocking)
            {
                Console.WriteLine(Name + " blocked the attack and was unharmed");
                isBlocking = false;
            }
            else
            {
                Health = Health - hit_value;

                Console.WriteLine(Name + " was hit for " + hit_value + " damage! You now have " + Health + " health remaining.");
            }
            if (Health <= 0)
            {
                Die();
            }
        }
        public void Heal(int amount_to_heal)
        {
            Health = Health + amount_to_heal;
            if (Health > 100)
            {
                Health = 100;
            }
            Console.WriteLine(Name + " has healed " + amount_to_heal + " health. You now have " + Health + " health remaining");
        }

        private void Die()
        {
            Console.WriteLine(Name + " has died!");
            isDead = true;
        }
    }
}
