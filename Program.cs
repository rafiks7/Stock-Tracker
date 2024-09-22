using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Tracker
{
    public class Program
    {

        static void Main(string[] args)
        {
            Stock stock1 = new Stock("Technology", 160, 5, 15);
            Stock stock2 = new Stock("Retail", 30, 2, 6);
            Stock stock3 = new Stock("Banking", 90, 4, 10);
            Stock stock4 = new Stock("Commodity", 500, 20, 50);



            /*
            StockBroker b1 = new StockBroker("Broker 1");
            b1.AddStock(stock1);
            b1.AddStock(stock2);

            StockBroker b2 = new StockBroker("Broker 2");
            b2.AddStock(stock1);
            b2.AddStock(stock3);
            b2.AddStock(stock4);

            StockBroker b3 = new StockBroker("Broker 3");
            b3.AddStock(stock1);
            b3.AddStock(stock3);

            StockBroker b4 = new StockBroker("Broker 4");
            b4.AddStock(stock1);
            b4.AddStock(stock2);
            b4.AddStock(stock3);
            b4.AddStock(stock4);
            */

            /*
             
            The output sample (All the column must be left alignment):

            Broker Stock Value Changes Date and Time
            Broker 2 Banking 102 5 2/2/2022 1:23:25 PM
            Broker 3 Banking 102 5 2/2/2022 1:23:25 PM
            Broker 4 Banking 102 5 2/2/2022 1:23:25 PM
            Broker 2 Commodity 559 5 2/2/2022 1:23:25 PM
            Broker 4 Commodity 559 5 2/2/2022 1:23:25 PM
            Broker 1 Technology 176 6 2/2/2022 1:23:25 PM
            Broker 2 Technology 176 6 2/2/2022 1:23:25 PM
            Broker 3 Technology 176 6 2/2/2022 1:23:25 PM
            Broker 4 Technology 176 6 2/2/2022 1:23:25 PM
            Broker 2 Commodity 562 6 2/2/2022 1:23:25 PM
            Broker 4 Commodity 562 6 2/2/2022 1:23:25 PM
            Broker 2 Banking 104 6 2/2/2022 1:23:25 PM
            Broker 3 Banking 104 6 2/2/2022 1:23:25 PM

            */
        }


}
}
