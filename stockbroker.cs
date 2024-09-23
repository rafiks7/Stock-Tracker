﻿//stockbroker.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Collections;
using System.Reflection;
using Stock_Tracker;

namespace Stock_Tracker
{
    //!NOTE!: Class StockBroker has fields broker name and a list of Stock named stocks.
    // addStock method registers the Notify listener with the stock(in addition to adding it to the lsit of stocks held by the broker).
    // This notify method outputs to the console the name, value, and the number of changes of the stock whose value is out of the range given the stock's notification threshold.
    public class StockBroker
    {
        //PUBLIC FIELDS
        public string BrokerName { get; set; }
        public List<Stock> stocks = new List<Stock>();

        // destination path for the log file
        readonly static string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lab1_output.txt");
        // Titles for the log file
        public static string titles = "Broker".PadRight(10) + "Stock".PadRight(15) + "Value".PadRight(10) + "Changes".PadRight(10) + "Date and Time";

        /// <summary>
        /// The stockbroker object
        /// </summary>
        /// <param name="brokerName">The stockbroker's name</param>
        public StockBroker(string brokerName)
        {
            BrokerName = brokerName;
        }

        // Static constructor that writes the titles to the log file
        static StockBroker()
        {
            Console.WriteLine(titles);

            // write the tites (first line) in the logging file
            using (StreamWriter outputFile = new StreamWriter(destPath, true))
            {
                outputFile.WriteLine(titles);
            }
        }

        /// <summary>
        /// Adds stock objects to the stock list
        /// </summary>
        /// <param name="stock">Stock object</param>
        // Add a new stock to the list of stocks for the Broker
        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
            stock.StockEvent += EventHandler;
        }

        /// <summary>
        /// The eventhandler that raises the event of a change
        /// </summary>
        /// <param name="sender">The sender that indicated a change</param>
        /// <param name="e">Event arguments</param>

        // Event handler for when the stock passes threshold
        async void EventHandler(Object sender, StockNotification e)
        {
            await Helper(sender, e);
        }


        // Helper function that writes the message to the log file and outputs the message to the console
        public async Task Helper(Object Sender, StockNotification e)
        {
            Stock newStock = (Stock)Sender;

            // Create the message to be written to the log file
            string message = $"{BrokerName.PadRight(16)}{e.StockName.PadRight(15)}" +
            $"{e.CurrentValue.ToString().PadRight(10)}" +
            $"{e.NumChanges.ToString().PadRight(10)}" +
            $"{DateTime.Now}";

            try
            {
                // Write the message to the log file
                using (StreamWriter outputFile = new StreamWriter(destPath, true))
                {
                    await outputFile.WriteLineAsync(message);
                }
                // Output the message to the console
                Console.WriteLine(message);
            }
            //Handle exceptions
            catch (IOException O)
            {
                Console.WriteLine($"Error writing to file: {O.Message}");
            }
        }
    }
}