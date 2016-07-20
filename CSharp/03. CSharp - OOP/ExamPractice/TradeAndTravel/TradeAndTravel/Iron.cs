namespace TradeAndTravel
{
    public class Iron : Item
    {
        private const int InitialMoneyValue = 3;

        public Iron(string name, Location location = null) 
            : base(name, Iron.InitialMoneyValue, ItemType.Iron , location)
        {
        }       
    }
}
