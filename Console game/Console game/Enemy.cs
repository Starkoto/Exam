using System;
using System.Collections.Generic;
using System.Text;

namespace Console_game
{
    class Enemy
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public bool isDead { get; set; }
        public Enemy(string name)
        {
            Health = 100;
            Name = name;
        }
     
        public void GetsHit (int hit_value)
        {
            Health = Health - hit_value;

            Console.WriteLine(Name + " was hit for " + hit_value + " damage! He now has " + Health + " health remaining.");

            if (Health <=0)
            {
                Die();
            }
        }

        private void Die()
        {
            Console.WriteLine(Name + " has died!");
            isDead = true;
        }
    }
}
