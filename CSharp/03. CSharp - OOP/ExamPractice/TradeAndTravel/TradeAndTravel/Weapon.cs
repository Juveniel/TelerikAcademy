using System.Collections.Generic;

namespace TradeAndTravel
{
    public class Weapon : Item
    {
        private const int InitialValue = 10;

        public Weapon(string name, Location location = null) 
            : base(name, Weapon.InitialValue, ItemType.Weapon, location)
        {
        }

        static List<ItemType> GetComposingItems()
        {
            return new List<ItemType>()
            {
                ItemType.Iron,
                ItemType.Wood
            };
        }
    }
}
