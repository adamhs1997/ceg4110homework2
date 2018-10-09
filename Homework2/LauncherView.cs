using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Homework2 {

    [Activity(Label = "Clock Master", MainLauncher = true)]

    public class LauncherView : Activity {

        private ClockController controller = ClockController.Controller;

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Set our view
            SetContentView(Resource.Layout.LauncherLayout);

            // Add handlers to the buttons
            FindViewById(Resource.Id.AddAnalog).Click += AddAnalogHandler;
            FindViewById(Resource.Id.AddDigital).Click += AddDigitalHandler;
            FindViewById(Resource.Id.ViewOpen).Click += ViewOpenHandler;
            FindViewById(Resource.Id.ViewSettings).Click += ViewSettingsHandler;
        }

        private void AddAnalogHandler(object sender, EventArgs e) {
            controller.AddOpenClock(new AnalogClockView());
            string msg = "An analog clock has been added! Go to \"View Open Clocks\"" +
                " to see it!";
            Toast toast = Toast.MakeText(this, msg, ToastLength.Long);
            toast.Show();
        }

        private void AddDigitalHandler(object sender, EventArgs e) {
            controller.AddOpenClock(new DigitalClockView());
            string msg = "A digital clock has been added! Go to \"View Open Clocks\"" +
                " to see it!";
            Toast toast = Toast.MakeText(this, msg, ToastLength.Long);
            toast.Show();
        }

        private void ViewOpenHandler(object sender, EventArgs e) {
            StartActivity(typeof(ShowClocksView));
        }

        private void ViewSettingsHandler(object sender, EventArgs e) {
            StartActivity(typeof(SettingsView));
        }
    }
}