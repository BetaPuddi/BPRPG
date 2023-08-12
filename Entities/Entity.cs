using System;

namespace BPRPG.Entities
{
    public abstract class Entity
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int Attack { get; set; }
        public int Recovery { get; set; }

        private void TakeDamage(int amount)
        {
            CurrentHealth -= amount;
            Console.WriteLine("{0} took {1} damage!", Name, amount);
            if (CurrentHealth > 0)
            {
                Console.WriteLine("{0} has {1} health remaining!", Name, CurrentHealth);
            } else
            {
                Console.WriteLine("{0} has been defeated!", Name);
            }
        }

        protected void Heal(int amount)
        {
            CurrentHealth += amount;
            if (CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
            Console.WriteLine("{0} healed {1} health!", Name, amount);
            Console.WriteLine("{0} has {1} health remaining!", Name, CurrentHealth);
        }

        protected void AttackEntity(Entity entity)
        {
            entity.TakeDamage(Attack);
        }

        public abstract void TakeTurn();
    }
}