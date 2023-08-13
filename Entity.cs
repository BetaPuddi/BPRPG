using BPRPG.Interfaces;

namespace BPRPG
{
    public abstract class Entity : IDamageable, IHealable
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int Attack { get; set; }
        public int Recovery { get; set; }

        public abstract void TakeDamage(int amount);

        public abstract void Heal(int amount);

        public abstract void AttackEntity(Player player);

        public abstract void TakeTurn();
    }
}