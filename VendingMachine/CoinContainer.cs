using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class CoinContainer
    {
        private List<Coin> coins;
        private CoinContainer nextContainer;
        private int Value { get; }

        public CoinContainer(int value)
        {
            Value = value;
            coins = new List<Coin>();
            nextContainer = null;
        }  
        
        public Coin Insert(Coin coin)
        {
            if(coin.Value == Value)
            {
                coins.Add(coin);
                return null;
            }
            else
            {
                if(nextContainer != null)
                {
                    return nextContainer.Insert(coin);
                }
                else
                {
                    return coin;
                }
            }
        }

        public Coin Remove()
        {
            return null;
        }

        public int TotalValue
        {
            get
            {
                return coins.Count * Value;
            }
        }

        public void AttachContainer(CoinContainer cc)
        {
            if(nextContainer == null)
            {
                nextContainer = cc;
            }
            else
            {
                nextContainer.AttachContainer(cc);
            }
        }
    }
}
