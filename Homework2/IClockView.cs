namespace Homework2 {

    // Interface for clock view core functionality

    interface IClockView {

        // A clock really only needs to display time
        void DisplayTime(int hour, int minute, int second, string month, int day, int year);

    }

}