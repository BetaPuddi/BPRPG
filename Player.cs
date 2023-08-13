using System;
using BPRPG.Interfaces;

namespace BPRPG
{
    public class Player : IDamageable, IHealable
    {
        public string Name { get; set; } = "Player";
        public int Level { get; set; } = 1;
        public int Experience { get; set; }
        public int ExperienceToNextLevel { get; set; } = 100;
        public int Money { get; set; }
        public int MaxHealth { get; set; } = 100;
        public int CurrentHealth { get; set; } = 100;
        public int Attack { get; set; } = 10;
        public int Recovery { get; set; } = 10;

        public void TakeTurn()
        {
            while (true)
            {
                Console.WriteLine("What would you like to do?");

                var actionToTake = Console.ReadLine()?.ToLower();
                switch (actionToTake)
                {
                    case "attack":
                        AttackEntity(CombatZone.CurrentEnemy);
                        CombatZone.CurrentEnemy.TakeTurn();
                        break;
                    case "heal":
                        Heal(Recovery);
                        CombatZone.CurrentEnemy.TakeTurn();
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid action!");
                        continue;
                }

                break;
            }
        }

        public void TakeDamage(int amount)
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

        private void AttackEntity(IDamageable entity)
        {
            entity.TakeDamage(Attack);
        }

        public void Heal(int amount)
        {
            CurrentHealth += amount;
            if (CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
            Console.WriteLine("{0} healed {1} health!", Name, amount);
            Console.WriteLine("{0} has {1} health remaining!", Name, CurrentHealth);
        }
        public void AddMoney(int amount)
        {
            if (amount <= 0) return;
            Money += amount;
            Console.WriteLine("You gained {0} money!", amount);
            Console.WriteLine("You now have {0} money!", Money);
        }
    }
}