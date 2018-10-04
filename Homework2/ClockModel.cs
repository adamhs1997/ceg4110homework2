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

        // Private constructor implementing Singleton DP
        private ClockModel() {
            // Begin ticking the clock
            AdvanceClock();
        }

        // Public-facing getters and setters
        public static ClockModel Model { get => _model; }
        public DateTime CurrentTime { get => _current; set => _current = value; }

        public int Second {
            get => _current.Second;
            //set => _current = new DateTime(_current.Year, _current.Month,
            //    _current.Day, _current.Hour, _current.Minute, value);
        }

        public int Minute {
            get => _current.Minute;
            //set => _current = new DateTime(_current.Year, _current.Month,
            //    _current.Day, _current.Hour, value, _current.Second);
        }

        public int Hour {
            get => _current.Hour;
            //set => _current = new DateTime(_current.Year, _current.Month,
            //    _current.Day, value, _current.Minute, _current.Second);
        }

        public int Day {
            get => _current.Day;
            //set => _current = new DateTime(_current.Year, _current.Month,
            //    value, _current.Hour, _current.Minute, _current.Second);
        }

        public int Month {
            get => _current.Month;
            //set => _current = new DateTime(_current.Year, value,
            //    _current.Day, _current.Hour, _current.Minute, _current.Second);
        }

        public int Year {
            get => _current.Year;
            //set => _current = new DateTime(value, _current.Month,
            //    _current.Day, _current.Hour, _current.Minute, _current.Second);
        }

        // Asynchronous method call to update views on the second
        // Courtesy: https://forums.xamarin.com/discussion/37393/how-to-update-a-viewtext-every-0-1-sec
        public async void AdvanceClock() {
            while (true) {
                _current = _current.AddSeconds(1);
                await Task.Delay(1000, new CancellationToken());
            }
        }

    }

}