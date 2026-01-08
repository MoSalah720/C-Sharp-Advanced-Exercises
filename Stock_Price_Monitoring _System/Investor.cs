using System;
using System.Collections.Generic;
using System.Text;

namespace Stock_Price_Monitoring__System
{
    internal class Investor
    {
        private double minPrice {  get; set; }
        public Investor(double Price)
        {
            minPrice = Price;
        }

        public void CheckPrice(object? obj ,StockEventArgs stockEventArgs)
        {
            if (stockEventArgs.Price<minPrice)
            {
                Console.WriteLine($"Investor Alert: Stock dropped! Current price: {stockEventArgs.Price}");
            }
        }
    }
}
