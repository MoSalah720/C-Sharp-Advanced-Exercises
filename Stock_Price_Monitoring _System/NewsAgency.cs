using System;
using System.Collections.Generic;
using System.Text;

namespace Stock_Price_Monitoring__System
{
    internal class NewsAgency
    {

        public void PublishNews(object? obj , StockEventArgs stockEventArgs)
        {
            Console.WriteLine($"News: Stock price updated to {stockEventArgs.Price}");
        }
    }
}
