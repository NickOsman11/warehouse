namespace WarehouseWorkshop
{
    public class Warehouse
    {
        public Dictionary<string, int> Stock { get; private set; }
        // private List<Transaction, DateTime> transactions = new List
        public Warehouse()
        {
            this.Stock = new Dictionary<string, int>();
        }
        
        public void BuyStock(List<(string, int)> newStock)
        {
            foreach ((string itemName, int number) newStockItem in newStock)
            {
                if (Stock.ContainsKey(newStockItem.itemName))
                {
                    Stock[newStockItem.itemName] += newStockItem.number;
                }
                else
                {
                    Stock.Add(newStockItem.itemName, newStockItem.number);
                }
            }
        }

    }


}