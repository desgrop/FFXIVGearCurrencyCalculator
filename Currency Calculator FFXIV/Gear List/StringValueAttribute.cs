using System;

namespace Currency_Calculator_FFXIV.Gear_List
{
    public class StringValueAttribute : Attribute
    {
        public string Value { get; }

        public StringValueAttribute(string value)
        {
            Value = value;
        }
    }
}