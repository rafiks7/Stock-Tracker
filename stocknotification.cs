//Stocknotification.cs

// This is a class that holds attributes of the stock that passed a threshold to be notified

namespace StockTracker
{
    public class StockNotification : EventArgs
    {
        public string StockName { get; set; }
        public int CurrentValue { get; set; }
        public int NumChanges { get; set; }
        /// <summary>
        /// Stock notification attributes that are set and changed
        /// </summary>
        /// <param name="stockName">Name of stock</param>
        /// <param name="currentValue">Current value of the stock</param>
        /// <param name="numChanges">Number of changes the stock goes through</param>
        public StockNotification(string stockName, int currentValue, int numChanges)
        {
            // !NOTE!: Fill in below of what the notification will do using the comments above
            /*!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!TODO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/
            // I'm not sure what is he expecting us to do here
            this.StockName = stockName;
            this.CurrentValue = currentValue;
            this.NumChanges = numChanges;
        }
    }
}
