using System;

namespace BPRPG.Entities
{
    public class Entity
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int Attack { get; set; }

        public void TakeDamage(int amount)
        {
            CurrentHealth -= amount;
            Console.WriteLine("{0} took {1} damage!", Name, amount);
        }
    }
}