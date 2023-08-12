namespace BPRPG.Entities
{
    public abstract class Enemy : Entity
    {

    }

    public class Skeleton : Enemy
    {
        public Skeleton()
        {
            Name = "Skeleton";
            MaxHealth = 50;
            CurrentHealth = 50;
            Attack = 5;
            Recovery = 5;
        }
        public override void TakeTurn()
        {
            if (CurrentHealth < 15 && CurrentHealth > 0)
            {
                Heal(Recovery);
            }
            else if (CurrentHealth > 0)
            {
                AttackEntity(GameManager.Instance.PlayerEntity);
            }
        }
    }

    public class Zombie : Enemy
    {
        public Zombie()
        {
            Name = "Zombie";
            MaxHealth = 100;
            CurrentHealth = 100;
            Attack = 8;
            Recovery = 5;
        }

        public override void TakeTurn()
        {
            if (CurrentHealth < 25 && CurrentHealth > 0)
            {
                Heal(Recovery);
                AttackEntity(GameManager.Instance.PlayerEntity);
            }
            else if (CurrentHealth > 0)
            {
                AttackEntity(GameManager.Instance.PlayerEntity);
            }
        }
    }
}