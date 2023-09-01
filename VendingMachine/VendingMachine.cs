using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine
    {
        public List<Product> DeliveryBin;
        private CoinContainer insertedCoins;

        public VendingMachine()
        {
            DeliveryBin = new List<Product>();
            DeliveryBin.Add(new Product("Mars", 45));
            DeliveryBin.Add(new Product("Cheetos", 55));
            DeliveryBin.Add(new Product("Sun Chips", 35));
            insertedCoins = new CoinContainer(1);
            insertedCoins.AttachContainer(new CoinContainer(5));
            insertedCoins.AttachContainer(new CoinContainer(10));
            insertedCoins.AttachContainer(new CoinContainer(25));
            insertedCoins.AttachContainer(new CoinContainer(50));
            insertedCoins.AttachContainer(new CoinContainer(100));
        }
        public void Insert(Coin coin)
        {
            Console.WriteLine("\n--- You inserted " + coin.Value + " ---\n");
            insertedCoins.Insert(coin);
            Console.WriteLine("Total inserted is " + insertedCoins.TotalValue);
        }

        public void EnterCode(String code)
        {
            Console.WriteLine("\n--- You entered the code " + code + " ---\n");
        }

        public void ShowInventory()
        {
            Console.WriteLine("\n--- The inventory would be here. ---\n");
        }
    }
}
