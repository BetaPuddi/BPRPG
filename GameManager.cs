using System;

namespace BPRPG
{
    public class GameManager
    {
        public static GameManager Instance { get; private set; }
        public Player PlayerEntity { get; private set; }
        public Location CurrentLocation { get; set; }

        public static void StartGame()
        {
            Instance = new GameManager();
            Instance.InitializePlayer();
            Instance.InitializeLocation();
        }

        private void InitializePlayer()
        {
            PlayerEntity = new Player
            {
                Name = "Player",
                MaxHealth = 100,
                CurrentHealth = 100,
                Attack = 10,
                Recovery = 10,
                Money = 0
            };
            Console.WriteLine("Choose a name for your character:");
            var input = Console.ReadLine();
            PlayerEntity.Name = input;
        }

        public void InitializeLocation()
        {
            Console.WriteLine("Choose a location:");
            Console.WriteLine("1. Cemetery");
            Console.WriteLine("2. Town");
            var input = Console.ReadLine();
            CurrentLocation = input switch
            {
                "1" => new Cemetery(),
                "2" => new Town(),
                _ => throw new Exception("Invalid location!")
            };
            CurrentLocation.EnterZone();
        }
    }
}