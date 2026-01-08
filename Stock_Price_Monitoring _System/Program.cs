namespace Stock_Price_Monitoring__System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockMarket stockMarket = new StockMarket();
            Investor investor = new Investor(100);
            NewsAgency newsAgency = new NewsAgency();
            Logger logger = new Logger();

            stockMarket.StockMarketChanged += newsAgency.PublishNews;
            stockMarket.StockMarketChanged += investor.CheckPrice;
            stockMarket.StockMarketChanged += logger.Logs;



            Console.WriteLine("Welcome to Stock Price Monitoring System");

            while (true)
            {
                Console.WriteLine("Please Enter new stock price");
                var stockprice = Console.ReadLine();
                if (stockprice == "done")
                {
                    return;
                }
                if (double.TryParse(stockprice, out double Price))
                {
                    stockMarket.ChangePrice(Price);
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
                stockMarket.ChangePrice(Price);

               
            }
        }
    }
}
