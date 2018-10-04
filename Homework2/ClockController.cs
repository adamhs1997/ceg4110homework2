using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Homework2 {

    class ClockController {

        // Hold private references to model and view
        private ClockModel _clockModel;
        private List<IClockView> _views;

        // Use Singleton DP for clock controller
        private static ClockController _controller = new ClockController();

        private ClockController() {
            // Use our singleton clock model
            _clockModel = ClockModel.Model;

            // Instantiate our views
            _views = new List<IClockView>();

            // Run every second
            DelayedUpdate();
        }

        // Static getter for our singleton clock controller
        public static ClockController Controller { get => _controller; }

        // Register our model and avoid the chicken-egg scenario
        // of doing this in a constructor
        //public void RegisterModel(ClockModel model) {
        //    _clockModel = _clockModel.Model;
        //}

        // Register our model and avoid the chicken-egg scenario
        // of doing this in a constructor and give us flexibility
        // in adding more views
        public void RegisterView(IClockView view) {
            _views.Add(view);
        }

        // Update our views
        public void UpdateViews() {
            foreach (IClockView view in _views) {
                view.DisplayTime(_clockModel.Hour, _clockModel.Minute,
                    _clockModel.Second, _clockModel.Month, _clockModel.Day,
                    _clockModel.Year);
            }
        }

        // Asynchronous method call to update views on the second
        // Courtesy: https://forums.xamarin.com/discussion/37393/how-to-update-a-viewtext-every-0-1-sec
        public async Task DelayedUpdate() {
            while (true) {
                UpdateViews();
                await Task.Delay(1000, new CancellationToken());
            }
        }

        // Create all our public-facing getters and setters to change model
        // Note that the class.Var syntax is C# syntactic sugar, the actual
        // variable is the private _var as defined in the class. This is 
        // equivalent to calling Var.getVar / Var.setVar.

        public int GetSecond() { return _clockModel.Second; }
        public int GetMinute() { return _clockModel.Minute; }
        public int GetHour() { return _clockModel.Hour; }
        public int GetDay() { return _clockModel.Day; }
        public int GetMonth() { return _clockModel.Month; }
        public int GetYear() { return _clockModel.Year; }

        //public void SetSecond(int second) {
        //    _clockModel.Second = second;
        //}

        //public void SetMinute(int minute) {
        //    _clockModel.Minute = minute;
        //}

        //public void SetHour(int hour) {
        //    _clockModel.Hour = hour;
        //}

        //public void SetDay(int day) {
        //    _clockModel.Day = day;
        //}

        //public void SetMonth(int month) {
        //    _clockModel.Month = month;
        //}

        //public void SetYear(int year) {
        //    _clockModel.Year = year;
        //}

        public void IncreaseSecond() {
            _clockModel.CurrentTime = _clockModel.CurrentTime.AddSeconds(1);
        }

        public void IncreaseMinute() {
            _clockModel.CurrentTime = _clockModel.CurrentTime.AddMinutes(1);
        }

        public void IncreaseHour() {
            _clockModel.CurrentTime = _clockModel.CurrentTime.AddHours(1);
        }

        public void IncreaseDay() {
            _clockModel.CurrentTime = _clockModel.CurrentTime.AddDays(1);
        }

        public void IncreaseMonth() {
            _clockModel.CurrentTime = _clockModel.CurrentTime.AddMonths(1);
        }

        public void IncreaseYear() {
            _clockModel.CurrentTime = _clockModel.CurrentTime.AddYears(1);
        }

        public void DecreaseSecond() {
            _clockModel.CurrentTime = _clockModel.CurrentTime.AddSeconds(-1);
        }

        public void DecreaseMinute() {
            _clockModel.CurrentTime = _clockModel.CurrentTime.AddMinutes(-1);
        }

        public void DecreaseHour() {
            _clockModel.CurrentTime = _clockModel.CurrentTime.AddHours(-1);
        }

        public void DecreaseDay() {
            _clockModel.CurrentTime = _clockModel.CurrentTime.AddDays(-1);
        }

        public void DecreaseMonth() {
            _clockModel.CurrentTime = _clockModel.CurrentTime.AddMonths(-1);
        }

        public void DecreaseYear() {
            _clockModel.CurrentTime = _clockModel.CurrentTime.AddYears(-1);
        }

    }

}