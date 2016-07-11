namespace TradeAndTravel
{
    public class Wood : Item
    {
        public const int InitialMoneyValue = 2;

        public Wood(string name, Location location = null) 
            : base(name, Wood.InitialMoneyValue, ItemType.Wood, location)
        {
        }

        public override void UpdateWithInteraction(string interaction)
        {
            if (interaction == "drop")
            {
                if (this.Value > 0)
                {
                    this.Value--;
                }               
            }
        }
    }
}
