using System;

namespace Currency_Calculator_FFXIV
{
    public class StringValueAttribute : Attribute
    {
        private readonly string _value;

        public string Value { get { return _value; } }

        public StringValueAttribute(string value)
        {
            _value = value;
        }
    }
}