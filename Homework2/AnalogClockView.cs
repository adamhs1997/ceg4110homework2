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
        private ClockController _controller = ClockController.Controller;

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.AnalogClockViewLayout);

            // Register with the controller
            _controller.RegisterView(this);

            Button Do = FindViewById<Button>(Resource.Id.Do);
            Do.Click += HandleDo;

            Button Undo = FindViewById<Button>(Resource.Id.Undo);
            Undo.Click += HandleUndo;
        }

        private void HandleUndo(object sender, EventArgs e) {
            ICommand command = new IncrementHour();
            command.Revert();
        }

        private void HandleDo(object sender, EventArgs e) {
            ICommand command = new IncrementHour();
            command.Execute();
        }

        public void DisplayTime(int hour, int minute, int second, int month, int day, int year) {
            FindViewById<TextView>(Resource.Id.Hour).Text += hour;
            FindViewById<TextView>(Resource.Id.Minute).Text += minute;
            FindViewById<TextView>(Resource.Id.Second).Text += second;
            FindViewById<TextView>(Resource.Id.Month).Text += month;
            FindViewById<TextView>(Resource.Id.Day).Text += day;
            FindViewById<TextView>(Resource.Id.Year).Text += year;
        }

    }

}

