﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_currency_Analyze_Forecasting.Classes
{
    internal class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public ComboboxItem(string text, object value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
