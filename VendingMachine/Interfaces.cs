using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public enum COIN { PENNY, NICKEL, DIME, QUARTER, HALF_DOLLAR, DOLLAR }
    public interface IProduct
    {
        String Name { get; }
        int Value { get; }
        String Description { get; }
    }
}
