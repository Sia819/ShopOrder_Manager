namespace ShopOrder_Manager
{
    public class OrderedMenu
    {
        public string MenuName;
        public int Price;
        public int Amount;

        public OrderedMenu(string MenuName, int Price, int Count)
        {
            this.MenuName = MenuName;
            this.Price = Price;
            this.Amount = Count;
        }
    }
}
