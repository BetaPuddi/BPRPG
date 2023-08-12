using System;
using System.Collections.Generic;
using BPRPG.Entities;

namespace BPRPG.Locations.CombatZones
{
    public class Cemetery : CombatZone
    {


        public Cemetery()
        {
            Name = "Cemetery";
            XCoordinate = 0;
            YCoordinate = 0;
            EnemyList = new List<Enemy>
            {
                new Skeleton(),
                new Skeleton(),
                new Zombie()
            };
        }

        public static void StartCombat()
        {
            while (true)
            {
                EnemyEntity = EnemyList[0];
                CurrentEnemy = EnemyEntity;
                Console.WriteLine("You are fighting a {0}!", EnemyEntity.Name);
                Console.WriteLine("You have {0} health!", GameManager.Instance.PlayerEntity.CurrentHealth);
                Console.WriteLine("{0} has {1} health!", EnemyEntity.Name, EnemyEntity.CurrentHealth);
                while (CurrentEnemy.CurrentHealth > 0 && GameManager.Instance.PlayerEntity.CurrentHealth > 0)
                {
                    GameManager.Instance.PlayerEntity.TakeTurn();
                }

                if (GameManager.Instance.PlayerEntity.CurrentHealth <= 0)
                {
                    Console.WriteLine("You have been defeated!");
                    Console.WriteLine("Game Over!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if (CurrentEnemy.CurrentHealth <= 0)
                {
                    Console.WriteLine("{0} has been defeated!", CurrentEnemy.Name);
                    EnemyList.RemoveAt(0);
                    if (EnemyList.Count > 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You have defeated all enemies!");
                        Console.WriteLine("You win!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }

                break;
            }
        }

        private static Enemy EnemyEntity { get; set; }
    }
}