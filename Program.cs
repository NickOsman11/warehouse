using System;

namespace WarehouseWorkshop
{
    class program
    {
        public static void Main(string[] args){

            Console.WriteLine("hi mum");
            Warehouse warehouse = new Warehouse();

            warehouse.BuyStock(new List<(string, int)>{("orange", 3)});
        }
    }
}