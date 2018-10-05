using System;
using System.Threading;
using System.Threading.Tasks;

namespace Homework2 {

    // This class defines the model for our system clock.
     
    class ClockModel {

        // Private class variables, inaccessible beyond this class
        private static ClockModel _model = new ClockModel();
        DateTime _current = DateTime.Now;

        // Make note if model will actually update (pauses if user updating clock)
        bool _update;

        // Private constructor implementing Singleton DP
        private ClockModel() {
            // Allow clock updates
            _update = true;

            // Begin ticking the clock
            AdvanceClock();
        }

        // Public-facing getters and setters
        public static ClockModel Model { get => _model; }
        public DateTime CurrentTime { get => _current; set => _current = value; }

        public int Second { get => _current.Second; }
        public int Minute { get => _current.Minute; }
        public int Hour { get => _current.Hour; }
        public int Day { get => _current.Day; }
        public int Month { get => _current.Month; }
        public int Year { get => _current.Year; }

        // Asynchronous method call to update views on the second
        // Courtesy: https://forums.xamarin.com/discussion/37393/how-to-update-a-viewtext-every-0-1-sec
        private async void AdvanceClock() {
            while (_update) {
                _current = _current.AddSeconds(1);
                await Task.Delay(1000, new CancellationToken());
            }
        }

        // Allow suspension of clock updates
        public void SuspendClock() {
            _update = false;
        }

        // Allow clock ticks to resume
        public void ResumeClock() {
            // Allow future updates
            _update = true;

            // Restart advancment
            AdvanceClock();
        }

    }

}