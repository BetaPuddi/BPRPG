using System;

namespace BPRPG;

public class HealthPotion : Consumable
{
    public override void Use()
    {
        GameManager.Instance.PlayerEntity.Heal(20);
    }
}