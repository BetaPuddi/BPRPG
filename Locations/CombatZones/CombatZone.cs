using System.Collections.Generic;
using BPRPG.Entities;

namespace BPRPG.Locations.CombatZones
{
    public class CombatZone : Location
    {
        public static Entity CurrentEnemy { get; protected set; }
        protected static List<Enemy> EnemyList { get; set; }
    }
}