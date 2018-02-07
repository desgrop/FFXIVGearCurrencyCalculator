using System;

namespace Currency_Calculator_FFXIV.Gear_List
{
    public class CurrencyAttribute : Attribute
    {
        public string Currency { get; }

        public CurrencyAttribute(string currency)
        {
            Currency = currency;
        }
    }
}