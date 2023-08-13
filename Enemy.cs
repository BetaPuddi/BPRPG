namespace BPRPG
{
    public abstract class Enemy : Entity
    {
        protected int Level { get; set; }
        protected int ExperienceToGrant { get; set; }
        protected int EnemyID { get; set; }

        public abstract void CalculateLevel(int zoneLevel);

        public override void AttackEntity(Player player)
        {
            player.TakeDamage(Attack);
        }
    }
}