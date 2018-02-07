using System;

namespace Currency_Calculator_FFXIV.Gear_List
{
    public class PriceAttribute : Attribute
    {
        public string Price { get; }

        public PriceAttribute(string price)
        {
            Price = price;
        }
    }
}