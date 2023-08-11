using BPRPG.Entities;

namespace BPRPG
{
    public class GameManager
    {
        public static GameManager Instance { get; private set; }

        public GameManager()
        {
            Instance = this;
        }

        public static void StartGame()
        {
            var player = new Player
            {
                Name = "Player",
                MaxHealth = 100,
                CurrentHealth = 100,
                Attack = 10
            };

            var enemy = new Enemy
            {
                Name = "Enemy",
                MaxHealth = 50,
                CurrentHealth = 50,
                Attack = 5
            };

            while (player.CurrentHealth > 0 && enemy.CurrentHealth > 0)
            {
                player.TakeDamage(enemy.Attack);
                enemy.TakeDamage(player.Attack);
            }
        }
    }
}