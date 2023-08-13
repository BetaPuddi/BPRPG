using System.Collections.Generic;

namespace BPRPG
{
    public class Cemetery : CombatZone
    {
        public Cemetery()
        {
            Name = "Cemetery";
            XCoordinate = 0;
            YCoordinate = 0;
            ZoneLevel = 1;
            EnemyList = new List<Enemy>
            {
                EnemyFactory.CreateUndeadEnemy(ZoneLevel, 1),
                EnemyFactory.CreateUndeadEnemy(ZoneLevel, 1),
                EnemyFactory.CreateUndeadEnemy(ZoneLevel, 2)
            };
        }

        public override void EnterZone()
        {
            StartCombat();
        }
    }
}