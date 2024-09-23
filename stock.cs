//stock.cs
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
namespace Stock_Tracker
{
    public class Stock
    {
        // Event handler for the stock event.
        public event EventHandler<StockNotification> StockEvent;

        //PRIVATE FIELDS
        //Name of our stock.
        private string _name;
        //Starting value of the stock.
        private int _initialValue;
        //Max change of the stock that is possible.
        private int _maxChange;
        //Threshold value where we notify subscribers to the event.
        private int _threshold;
        //Amount of changes the stock goes through.
        private int _numChanges;
        //Current value of the stock.
        private int _currentValue;
        private readonly Thread _thread;

        //PUBLIC FIELDS
        public string StockName { get => _name; set => _name = value; }
        public int InitialValue { get => _initialValue; }
        public int CurrentValue { get => _currentValue; set => _currentValue = value; }
        public int MaxChange { get => _maxChange; }
        public int Threshold { get => _threshold; }
        public int NumChanges { get => _numChanges; set => _numChanges = value; }

        /// <summary>
        /// Stock class that contains all the information and changes of the stock
        /// </summary>
        /// <param name="name">Stock name</param>
        /// <param name="startingValue">Starting stock value</param>
        /// <param name="maxChange">The max value change of the stock</param>
        /// <param name="threshold">The range for the stock</param>
        public Stock(string name, int startingValue, int maxChange, int threshold)
        {
            _name = name;
            _initialValue = startingValue;
            _currentValue = InitialValue;
            _maxChange = maxChange;
            _threshold = threshold;
            _numChanges = 0;
            // Create a new thread for the stock when the constructor is called            
            this._thread = new Thread(new ThreadStart(Activate));
            _thread.Start();
            
        }

        /// <summary>
        /// Activates the threads synchronizations
        /// </summary>
        public void Activate()
        {
            //for loop to change the stock value every 1/2 second
            for (int i = 0; i < 25; i++)
            {
                Thread.Sleep(500); // thread sleeps for 1/2 second
                ChangeStockValue(); //changes the stock value
            }
        }

        /// <summary>
        /// Changes the stock value and also raising the event of stock value changes
        /// </summary>
        public void ChangeStockValue()
        {
            var rand = new Random();
            int sign = rand.Next(0, 2) == 0 ? 1 : -1;
            int change = rand.Next(1, MaxChange + 1);
            CurrentValue += sign * change;
            NumChanges++;
            // Raise an event if the stock passes threshold
            if ((CurrentValue - InitialValue) >= Threshold)
            {
                StockEvent?.Invoke(this, new StockNotification(StockName, CurrentValue, NumChanges));
            }            
        }

    }
}

