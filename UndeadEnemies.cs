using System;

namespace BPRPG;

public abstract class UndeadEnemies : Enemy
{
    public class Skeleton : UndeadEnemies
    {
        public Skeleton()
        {
            EnemyID = 1;
            Name = "Skeleton";
            Level = 1;
            MaxHealth = 50;
            CurrentHealth = MaxHealth;
            Attack = 5;
            Recovery = 5;
            ExperienceToGrant = 5;
            Money = 1;

            //CalculateLevel(GameManager.Instance.CurrentLocation.ZoneLevel);
        }
        public override void TakeTurn()
        {
            switch (CurrentHealth)
            {
                case < 15 and > 0:
                    Heal(Recovery);
                    break;
                case > 0:
                    AttackEntity(GameManager.Instance.PlayerEntity);
                    break;
            }
        }

        public override void TakeDamage(int amount)
        {
            CurrentHealth -= amount;
            Console.WriteLine("{0} took {1} damage!", Name, amount);
            if (CurrentHealth > 0)
            {
                Console.WriteLine("{0} has {1} health remaining!", Name, CurrentHealth);
            }
        }

        public override void Heal(int amount)
        {
            CurrentHealth += amount;
            if (CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
            Console.WriteLine("{0} healed {1} health!", Name, amount);
            Console.WriteLine("{0} has {1} health remaining!", Name, CurrentHealth);
        }

        public sealed override void CalculateLevel(int zoneLevel)
        {
            Level = zoneLevel;
            MaxHealth += (Level * 5);
            CurrentHealth = MaxHealth;
            Attack += (Level * 2);
            Recovery += (Level * 2);
            ExperienceToGrant = 5 + (Level * 2);
            Money += (Level * 2);
        }
    }

    public class Zombie : UndeadEnemies
    {
        public Zombie()
        {
            EnemyID = 2;
            Name = "Zombie";
            MaxHealth = 100;
            CurrentHealth = MaxHealth;
            Attack = 8;
            Recovery = 5;
            ExperienceToGrant = 15;
            Money = 5;

            //CalculateLevel(GameManager.Instance.CurrentLocation.ZoneLevel);
        }

        public override void TakeTurn()
        {
            switch (CurrentHealth)
            {
                case < 25 and > 0:
                    Heal(Recovery);
                    AttackEntity(GameManager.Instance.PlayerEntity);
                    break;
                case > 0:
                    AttackEntity(GameManager.Instance.PlayerEntity);
                    break;
            }
        }

        public override void TakeDamage(int amount)
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

        public override void Heal(int amount)
        {
            CurrentHealth += amount;
            if (CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
            Console.WriteLine("{0} healed {1} health!", Name, amount);
            Console.WriteLine("{0} has {1} health remaining!", Name, CurrentHealth);
        }

        public sealed override void CalculateLevel(int zoneLevel)
        {
            Level = zoneLevel + 1;
            MaxHealth += (Level * 5);
            CurrentHealth = MaxHealth;
            Attack += (Level * 2);
            Recovery += (Level * 2);
            ExperienceToGrant += (Level * 2);
            Money += (Level * 2);
        }

    }
}