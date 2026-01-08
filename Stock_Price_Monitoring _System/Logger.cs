using System;
using System.Collections.Generic;
using System.Text;

namespace Stock_Price_Monitoring__System
{
    internal class Logger
    {
        public void Logs(object? obj, StockEventArgs e)
        {
            Console.WriteLine($"Log: Price = {e.Price} at time {e.TimesTamp}");
        }
    }
}
