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

using Com.Xenione.Digit;
   
namespace Homework2 {

    [Activity(Label = "Clock Master")]

    public class DigitalClockView : Activity, IClockView {

        ClockController clockController = ClockController.Controller;

        // Use this to show the proper month in the view
        string[] months = {"January", "February", "March", "April", "May",
                            "June", "July", "August", "September", "October",
                            "November", "December"};

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Set our view layout
            SetContentView(Resource.Layout.DigitalClockViewLayout);

            // Register this view with the controller
            clockController.RegisterView(this);

        }

        // Implementation of the IClockView interface, allowing updates from controller
        public void DisplayTime(int hour, int minute, int second, int month, int day, int year) {
            FindViewById<TabDigit>(Resource.Id.Hour1).SetChar(hour / 10);
            FindViewById<TabDigit>(Resource.Id.Hour2).SetChar(hour % 10);
            FindViewById<TabDigit>(Resource.Id.Minute1).SetChar(minute / 10);
            FindViewById<TabDigit>(Resource.Id.Minute2).SetChar(minute % 10);
            FindViewById<TabDigit>(Resource.Id.Second1).SetChar(second / 10);
            FindViewById<TabDigit>(Resource.Id.Second2).SetChar(second % 10);
            FindViewById<TextView>(Resource.Id.DigitalDate).Text =
                months[month - 1] + " " + day.ToString() + ", " + year.ToString();
        }

    }
}