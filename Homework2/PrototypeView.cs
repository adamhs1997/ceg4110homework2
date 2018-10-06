using Android.App;
using Android.Widget;
using Android.OS;

using System.Timers;
using System.Threading;
using Android.Content;
using System;
using System.Threading.Tasks;

namespace Homework2 {

    [Activity(Label = "Homework2")]

    public class PrototypeView : Activity, IClockView {

        // Hold on to an instance of the controller
        private ClockController _controller = ClockController.Controller;

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.PrototypeViewLayout);

            // Register with the controller
            _controller.RegisterView(this);

            Button Do = FindViewById<Button>(Resource.Id.Do);
            Do.Click += HandleDo;

        }

        private void HandleDo(object sender, EventArgs e) {
            StartActivity(typeof(SettingsView));
        }

        public void DisplayTime(int hour, int minute, int second, int month, int day, int year) {
            FindViewById<TextView>(Resource.Id.Hour).Text = hour.ToString();
            FindViewById<TextView>(Resource.Id.Minute).Text = minute.ToString();
            FindViewById<TextView>(Resource.Id.Second).Text = second.ToString();
            FindViewById<TextView>(Resource.Id.Month).Text = month.ToString();
            FindViewById<TextView>(Resource.Id.Day).Text = day.ToString();
            FindViewById<TextView>(Resource.Id.Year).Text = year.ToString();
        }

    }

}

