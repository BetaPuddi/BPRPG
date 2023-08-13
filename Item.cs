using BPRPG.Interfaces;

namespace BPRPG;

public abstract class Item
{

}

public abstract class Consumable : Item, IUseable
{
    public abstract void Use();
}