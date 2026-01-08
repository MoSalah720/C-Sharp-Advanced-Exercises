using System;
using System.Collections.Generic;
using System.Text;

namespace Stock_Price_Monitoring__System
{
    internal class StockMarket
    {
        public event EventHandler <StockEventArgs>StockMarketChanged;
        private double CurrentPrice { get; set; }

        public void ChangePrice(double NewPrice)
        {
            CurrentPrice = NewPrice;
            Console.WriteLine($"Stock price changed to {NewPrice}");


            StockMarketChanged?.Invoke(this, new StockEventArgs(NewPrice,DateTime.Now));
        }

    }
}
