using System;
using System.Collections.Generic;

namespace BPRPG
{
    public abstract class CombatZone : Location
    {
        public static Entity CurrentEnemy { get; set; }
        private static Enemy EnemyEntity { get; set; }
        protected static List<Enemy> EnemyList { get; set; }
        //public int ZoneLevel { get; set; }


        protected static void StartCombat()
        {
            while (EnemyList.Count > 0)
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
                    Console.WriteLine("Game Over!");
                    //Console.ReadLine();
                    Environment.Exit(0);
                }
                else if (CurrentEnemy.CurrentHealth <= 0)
                {
                    Console.WriteLine("{0} has been defeated!", CurrentEnemy.Name);
                    GameManager.Instance.PlayerEntity.AddMoney(CurrentEnemy.Money);
                    EnemyList.RemoveAt(0);
                    if (EnemyList.Count > 0)
                    {
                        continue;
                    }

                    Console.WriteLine("You have defeated all enemies!");
                    Console.WriteLine("You win!");
                    //Console.ReadLine();
                    GameManager.StartGame();
                }

                break;
            }
        }
    }
}