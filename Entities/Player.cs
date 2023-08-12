using System;
using BPRPG.Locations.CombatZones;

namespace BPRPG.Entities
{
    public class Player : Entity
    {
        public Player()
        {
            Name = "Player";
            MaxHealth = 100;
            CurrentHealth = 100;
            Attack = 10;
        }
        public override void TakeTurn()
        {
            while (true)
            {
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
    }
}