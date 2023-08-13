namespace BPRPG;

public static class EnemyFactory
{
    /*public static Enemy CreateEnemy(int zoneLevel, int enemyID)
    {
        return enemyID switch
        {
            1 => CreateUndeadEnemy(zoneLevel, enemyID),
            2 => CreateUndeadEnemy(zoneLevel, enemyID),
            _ => CreateUndeadEnemy(zoneLevel, enemyID)
        };
    }*/

    public static Enemy CreateUndeadEnemy(int zoneLevel, int enemyId)
    {
        Enemy enemy = enemyId switch
        {
            1 => new UndeadEnemies.Skeleton(),
            2 => new UndeadEnemies.Zombie(),
            _ => new UndeadEnemies.Skeleton()
        };

        enemy.CalculateLevel(zoneLevel);
        return enemy;
    }
}