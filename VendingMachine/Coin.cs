using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Coin
    {
        public int Value { get; }

        public Coin(COIN coinType)
        {
            Value = 1;
            switch(coinType)
            {
                case COIN.PENNY:
                    break;
                case COIN.NICKEL:
                    Value = 5;
                    break;
                case COIN.DIME:
                    Value = 10;
                    break;
                case COIN.QUARTER:
                    Value = 25;
                    break;
                case COIN.HALF_DOLLAR:
                    Value = 50;
                    break;
                case COIN.DOLLAR:
                    Value = 100;
                    break;
                    default:
                    break;
            }
        }
    }
}
