using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForPractice
{
    internal class ShareMarket
    {
        public static void Main(string[] args)
        {
            List<Shares> sharesList = new List<Shares>() {
            new Shares() {CompanyName ="TCS",    StockPrice =3318.5,    UnitCount=2,     MarketID=1},
            new Shares() {CompanyName ="Cipla",  StockPrice =945.10,    UnitCount=12,    MarketID=1},
            new Shares() {CompanyName ="HDFC",   StockPrice =2180.85,   UnitCount=5,     MarketID=2},
            new Shares() {CompanyName ="L&TFH",  StockPrice =3350.5,    UnitCount=2,     MarketID=1},
            new Shares() {CompanyName ="ACC",    StockPrice =2128,      UnitCount=4,     MarketID=1},
            new Shares() {CompanyName ="TCS",    StockPrice =3319.5,    UnitCount=1,     MarketID=2},
            new Shares() {CompanyName ="Cipla",  StockPrice =946.15,    UnitCount=8,     MarketID=2},
            new Shares() {CompanyName ="HDFC",   StockPrice =2180.85,   UnitCount=2,     MarketID=1},
            new Shares() {CompanyName ="TCS",    StockPrice =3319.5,    UnitCount=7,     MarketID=2},
            new Shares() {CompanyName ="HDFC",   StockPrice =2181.05,   UnitCount=6,     MarketID=1},
            new Shares() {CompanyName ="TCS",    StockPrice =3318.5,    UnitCount=3,     MarketID=2}

            };

            List<StockExchange> stockExchangesList = new List<StockExchange>()
            {
                new StockExchange() {ExchangeID =1, ExchangeName ="BSE"},
                new StockExchange() {ExchangeID =2, ExchangeName ="NSE"}
            };

            Console.WriteLine("SELECT");
           //sharesList.ForEach(s=>someFunc(s));

             sharesList.ForEach(s=> {
                 Console.WriteLine(s.CompanyName);
             } );
        

           // Console.WriteLine(allCompanyNames.ToList());
            //foreach(var name in allCompanyNames)
            //    {
            //    Console.WriteLine(name);
            //}

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("DISTINCT");
            var allDistinctCompanyNames = sharesList.Select(s => s.CompanyName).Distinct();
            foreach (var name in allDistinctCompanyNames)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("WHERE And DISTINCT");
            var stockPriceHigherThanLimit = sharesList.Where(s => s.StockPrice > 3000);
            foreach (var stock in stockPriceHigherThanLimit)
            {
                Console.WriteLine($"Company Name:{stock.CompanyName}  Current Price:{stock.StockPrice} ");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("COUNT");
            var totalNumberOfStocks = sharesList.Count();
            Console.WriteLine($"Total Number Of Order OF Different Stocks: {totalNumberOfStocks}");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SUM");
            var totalUnitsCount = sharesList.Sum(s => s.UnitCount);
            Console.WriteLine($"Total Number Of UnitCount: {totalUnitsCount}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ORDERBY");
            var stockPriceFromHighToLow = sharesList.OrderByDescending(s => s.StockPrice);
            foreach (var stock in stockPriceFromHighToLow)
            {
                Console.WriteLine($"Company Name:{stock.CompanyName} Price:{stock.StockPrice} ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("GROUPBY  ");
            var companiesInMarket = sharesList.GroupBy(s => s.MarketID);
            foreach (var stock in companiesInMarket)
            {
                Console.WriteLine($"Market Id :{stock.Key}   ,Total Price:{stock.Sum(s => s.StockPrice)} ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("INNER JOIN");

            var companiesInSpecificMarket = sharesList.Join(stockExchangesList, s => s.MarketID, se => se.ExchangeID, (Shares, StockExchange) => new
            {
                companyName = Shares.CompanyName,
                marketName = StockExchange.ExchangeName
            });

            foreach (var stock in companiesInSpecificMarket)
            {
                Console.WriteLine($"Market Name:{stock.marketName}      Company Name:{stock.companyName}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("'n'th Highest StockPrice");
            Console.WriteLine("Enter value of 'n':");
            int nThSalary = Convert.ToInt32(Console.ReadLine());
            var nThHighestStock = sharesList.OrderByDescending(s => s.StockPrice)
                .Skip(nThSalary - 1).FirstOrDefault();
          
            Console.WriteLine($"{nThSalary} th highest stock price is :{nThHighestStock.StockPrice}  & Company Name is: {nThHighestStock.CompanyName}");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("For each Exchange for Each company total price:");
            //var totalPriceOfEachComapnyForeachExchange=sharesList.GroupBy(st=>st.CompanyName).Sum(s=>s.StockPrice)
            var totalPriceOfEachComapnyForeachExchange = sharesList.Join(stockExchangesList, s => s.MarketID, se => se.ExchangeID, (Shares, StockExchange) => new
            {
                TotalInvestment = Shares.UnitCount * Shares.StockPrice,
                companyName = Shares.CompanyName, 
                marketName = StockExchange.ExchangeName
            }).GroupBy(s => new { s.marketName, s.companyName }).Select(g => new { companyName= g.Key.companyName, marketName = g.Key.marketName, TotalInvestment= g.Sum(s=>s.TotalInvestment)});

            foreach (var s in totalPriceOfEachComapnyForeachExchange)
            {
                Console.WriteLine($"Market Name :{s.marketName}   Company Name: {s.companyName}  Total Price: {s.TotalInvestment}");
            }
        }

        private static void someFunc(Shares s)
        {
            Console.WriteLine(s.CompanyName);
           // return 1;
        }
    }
}
