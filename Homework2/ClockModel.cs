using System;
using System.Threading;
using System.Threading.Tasks;

namespace Homework2 {

    // This class defines the model for our system clock.
     
    class ClockModel {

        // Private class variables, inaccessible beyond this class
        private static ClockModel _model = new ClockModel();
        DateTime _current = DateTime.Now;
        private ClockController _controller;
        private int _second;
        private int _minute;
        private int _hour;
        private int _day;
        private string _month;
        private int _year;

        // Private constructor implementing Singleton DP
        private ClockModel() {
            // Initialize to current times
            _second = _current.Second;
            _minute = _current.Minute;
            _hour = _current.Hour;
            _day = _current.Day;
            _month = _current.ToString("MMMM");
            _year = _current.Year;

            // Begin ticking the clock
            AdvanceClock();
        }

        // Public-facing getters and setters
        // If you aren't familiar with this C# syntax, read more about this here:
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
        public static ClockModel Model { get => _model; }
        public int Second { get => _second; set => _second = value; }
        public int Minute { get => _minute; set => _minute = value; }
        public int Hour { get => _hour; set => _hour = value; }
        public int Day { get => _day; set => _day = value; }
        public string Month { get => _month; set => _month = value; }
        public int Year { get => _year; set => _year = value; }

        // Asynchronous method call to update views on the second
        // Courtesy: https://forums.xamarin.com/discussion/37393/how-to-update-a-viewtext-every-0-1-sec
        public async Task AdvanceClock() {
            while (true) {
                _current = _current.AddSeconds(1);
                _second = _current.Second;
                _minute = _current.Minute;
                _hour = _current.Hour;
                _day = _current.Day;
                _month = _current.ToString("MMMM");
                _year = _current.Year;
                await Task.Delay(1000, new CancellationToken());
            }
        }

    }

}