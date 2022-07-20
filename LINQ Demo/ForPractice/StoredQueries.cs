using System;
using System.Collections.Generic;
using System.Text;

namespace ForPractice
{
    internal class StoredQueries
    {
//        Console.WriteLine("SELECT");
//            //Shows All Company names Dublicate too.
//            var ShowAllShares = sharesList.Select(s => s.CompanyName);               //from s in sharesList select s.CompanyName;
//            foreach (var share in ShowAllShares)
//            {
//                Console.Write("  " + share);
//            }
//    Console.WriteLine();
//            Console.WriteLine();


//            Console.WriteLine("DISTINCT");
//            //Shows All Company names distinct.
//            var ShowAllSharesDistinct = sharesList.Select(s => s.CompanyName).Distinct();    
//            foreach (var share in ShowAllSharesDistinct)
//            {
//                Console.Write(" " + share);
//            }
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine("WHERE And DISTINCT");
////Shows All Stockes whose price is greter than 3000 Rs
//var StockPriceHigherThan3000 = sharesList.Where(s => s.StockPrice > 3000).Select(s => s.CompanyName).Distinct();
//foreach (var share in StockPriceHigherThan3000)
//{
//    Console.Write("  " + share);
//}
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine("COUNT");
////Shows All Stockes whose price is greter than 3000 Rs
//var TotalStocks = sharesList.Count();

//Console.Write("  " + TotalStocks);

//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine("ORDERBY And DISTINCT");
////Shows All Stockes whose price is greter than 3000 Rs
//var StockNameInOrder = sharesList.OrderBy(s => s.CompanyName).Select(s => s.CompanyName).Distinct();
//foreach (var share in StockNameInOrder)
//{
//    Console.Write("  " + share);
//}
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine("GROUPBY  ");
////Shows All Stockes With price 
//var StockNameAndPrice = sharesList.GroupBy(s => s.CompanyName);

//foreach (var share in StockNameAndPrice)
//{

//    Console.Write("Name:  " + share.Key + "      Max Sahre price: " + share.Max(s => s.StockPrice) + "       total order:" + share.Count());

//    foreach (var s in share)
//    {
//        Console.Write("         " + s.OrderQuntity);
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.WriteLine();




//Console.WriteLine("INNER JOIN");
//var JoinSharesToMarket = sharesList.Join(stockExchangesList, s => s.MarketID, e => e.ExchangeID, (Shares, StockExchange) => new
//{
//    companyName = Shares.CompanyName,
//    stockMarket = StockExchange.ExchangeName
//});


//foreach (var s in JoinSharesToMarket)
//{
//    Console.Write("" + s.companyName + "     " + s.stockMarket);
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.WriteLine();

    }
}
