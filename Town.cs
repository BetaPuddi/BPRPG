using System;

namespace BPRPG;

public class Town : Location
{
    public static Item HealthPotion { get; set; }

    public override void EnterZone()
    {
        StartTown();
    }

    private static void StartTown()
    {
        while (true)
        {
            Console.WriteLine("Welcome to the town!");
            Console.WriteLine("1. Shop");
            Console.WriteLine("2. Exit");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    ShowShop();
                    break;
                case "2":
                    Exit();
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    continue;
            }

            break;
        }
    }

    private static void Exit()
    {
        GameManager.Instance.InitializeLocation();
    }

    private static void ShowShop()
    {
        while (true)
        {
            Console.WriteLine("Welcome to the shop!");
            Console.WriteLine("1. Buy");
            Console.WriteLine("2. Sell");
            Console.WriteLine("3. Exit");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Buy();
                    break;
                case "2":
                    Sell();
                    break;
                case "3":
                    Exit();
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    continue;
            }

            break;
        }
    }

    private static void Sell()
    {
        throw new NotImplementedException();
    }

    private static void Buy()
    {
        while (true)
        {
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine("1. Health Potion");
            Console.WriteLine("2. Exit");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    BuyItem(HealthPotion);
                    break;
                case "2":
                    ShowShop();
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    continue;
            }

            break;
        }
    }

    private static void BuyItem(Item item)
    {
        throw new NotImplementedException();
    }
}