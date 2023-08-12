using System;
using BPRPG.Entities;
using BPRPG.Locations;
using BPRPG.Locations.CombatZones;

namespace BPRPG
{
    public class GameManager
    {
        public static GameManager Instance { get; private set; }
        public Player PlayerEntity { get; private set; }
        public CombatZone CurrentLocation { get; private set; }

        public static void StartGame()
        {
            Instance = new GameManager();
            Instance.InitializePlayer();
            Instance.InitializeLocation();
            Cemetery.StartCombat();
        }

        private void InitializePlayer()
        {
            PlayerEntity = new Player
            {
                Name = "Player",
                MaxHealth = 100,
                CurrentHealth = 100,
                Attack = 10,
                Recovery = 10
            };
        }

        private void InitializeLocation()
        {
            CurrentLocation = new Cemetery();
        }
    }
}