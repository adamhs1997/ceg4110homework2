using System;

namespace Homework2 {

    // This class defines the model for our system clock.
     
    class ClockModel {

        // Private class variables, inaccessible beyond this class
        private ClockModel _model;
        private ClockController _controller;
        private int _second;
        private int _minute;
        private int _hour;
        private int _day;
        private string _month;
        private int _year;

        // Private constructor impolementing Singleton DP
        private ClockModel() {
            // Instantiate our one instance
            if (_model == null)
                _model = new ClockModel();

            // Initialize to current times
            DateTime current = new DateTime();
            _second = current.Second;
            _minute = current.Minute;
            _hour = current.Hour;
            _day = current.Day;
            _month = current.ToString("MMMM");
            _year = current.Year;
        }

        // Public-facing getters and setters
        // If you aren't familiar with this C# syntax, read more about this here:
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
        public ClockModel Model { get => _model; }
        public int Second { get => _second; set => _second = value; }
        public int Minute { get => _minute; set => _minute = value; }
        public int Hour { get => _hour; set => _hour = value; }
        public int Day { get => _day; set => _day = value; }
        public string Month { get => _month; set => _month = value; }
        public int Year { get => _year; set => _year = value; }

    }

}