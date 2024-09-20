//stockbroker.cs
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Collections;
using System.Reflection;

namespace StockTracker
{ 
    //!NOTE!: Class StockBroker has fields broker name and a list of Stock named stocks.
    // addStock method registers the Notify listener with the stock(in addition to adding it to the lsit of stocks held by the broker).
    // This notify method outputs to the console the name, value, and the number of changes of the stock whose value is out of the range given the stock's notification threshold.
    public class StockBroker
    {
        //PUBLIC FIELDS
        public string BrokerName { get; set; }
        public List<Stock> stocks = new List<Stock>();

        // ********* define path accordingly
        //readonly string docPath = @"C:\Users\Documents\CECS 475\Lab3_output.txt";
        readonly string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Lab1_output.txt");
        public string titles = "Broker".PadRight(10) + "Stock".PadRight(15) + "Value".PadRight(10) + "Changes".PadRight(10) + "Date and Time";

        /*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!TODO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/
        // output the titles to the console
        //Console.WriteLine(___________________);

        /*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!TODO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/
        // write the tites (first line) in the logging file
        /*
        using (StreamWriter outputFile = new StreamWriter(________, _____________))
        {
            outputFile.WriteLine(titles);
        } 
        */

        /// <summary>
        /// The stockbroker object
        /// </summary>
        /// <param name="brokerName">The stockbroker's name</param>
        public StockBroker(string brokerName)
        {
            BrokerName = brokerName;
        }

        /// <summary>
        /// Adds stock objects to the stock list
        /// </summary>
        /// <param name="stock">Stock object</param>
        /*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!TODO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/
        // Add a new stock to the list of stocks for the Broker
        /*
        public void AddStock(Stock stock)
        {
            stocks._____________________________
            stock.____________________________________
        }
        */

        /// <summary>
        /// The eventhandler that raises the event of a change
        /// </summary>
        /// <param name="sender">The sender that indicated a change</param>
        /// <param name="e">Event arguments</param>
        
        /*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!TODO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/
        // Event handler for when the stock passes threshold
        void EventHandler(Object sender, EventArgs e)
        {
            /*
            _______________ Helper(Sender, e);
            */
        }



        /*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!TODO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/
        // Helper function that writes the message to the log file and outputs the message to the console
        /*
        public _______________ Helper(Object Sender, StockNotification e)
        {
            Stock newStock = (Stock)Sender;
            
            /*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!TODO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//
            // Fill in the message. missing: numChanges, Date and Time
            string message = $"{BrokerName.PadRight(16)}{e.StockName.PadRight(15)}" +
            $"{e.CurrentValue.ToString().PadRight(10)}" +
            ________________
        _________________________________;

            /*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!TODO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//
            // Write the message to the log file
            // Output the message to the console
            try
            {
                using (StreamWriter outputFile = new StreamWriter(________,
                ________________))
                {
                    ______ outputFile.________________________(____________);
                }
                Console.__________________________________;
            }
            /*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!TODO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//
            //Handle exceptions
            catch (IOException O)
            {

            }
        }
        */
    }
}