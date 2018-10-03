using Android.App;
using Android.Widget;
using Android.OS;

using System.Timers;
using System.Threading;
using Android.Content;
using System;
using System.Threading.Tasks;

namespace Homework2 {

    [Activity(Label = "Homework2", MainLauncher = true)]

    public class AnalogClockView : Activity, IClockView {

        // Hold on to an instance of the controller
        private ClockController _controller;
        private CancellationTokenSource cts = new CancellationTokenSource();

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.AnalogClockViewLayout);

            // Note that this would usually only be in main activity driver
            //ClockModel model = new ClockModel(); // unused for now
            _controller = new ClockController();

            // Register with the controller
            _controller.RegisterView(this);
        }

        public void DisplayTime(int hour, int minute, int second, string month, int day, int year) {
            FindViewById<TextView>(Resource.Id.Hour).Text += hour;
            FindViewById<TextView>(Resource.Id.Minute).Text += minute;
            FindViewById<TextView>(Resource.Id.Second).Text += second;
            FindViewById<TextView>(Resource.Id.Month).Text += month;
            FindViewById<TextView>(Resource.Id.Day).Text += day;
            FindViewById<TextView>(Resource.Id.Year).Text += year;
        }

    }

}

