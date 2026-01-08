using System;
using System.Collections.Generic;
using System.Text;

namespace Stock_Price_Monitoring__System
{
    internal class StockEventArgs: EventArgs
    {
        public double Price {  get; set; }

        public DateTime TimesTamp { get; set; }

        public StockEventArgs(double price , DateTime dateTime)
        {
            Price = price;
            TimesTamp = dateTime;
        }
    }
}
