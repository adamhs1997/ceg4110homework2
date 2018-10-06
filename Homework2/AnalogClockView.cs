using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Java.Util;

namespace Homework2 {
    [Activity(Label = "AnalogClockView", MainLauncher = true)]
    public class AnalogClockView : Activity, IClockView {

        CustomAnalogClock clock;
        ClockController clockController = ClockController.Controller;

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Programmatically create main layout
            LinearLayout mainLayout = new LinearLayout(this);
            LinearLayout.LayoutParams relParentParam = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent, RelativeLayout.LayoutParams.MatchParent);
            mainLayout.LayoutParameters = relParentParam;

            LinearLayout.LayoutParams clockParam = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WrapContent, RelativeLayout.LayoutParams.WrapContent);

            // Add (temp) settings button
            Button settings = new Button(this) {
                LayoutParameters = clockParam,
                Text = "Settings"
            };
            mainLayout.AddView(settings);
            settings.Click += Settings_Click;

            // Add clock to layout
            clock = new CustomAnalogClock(this);
            clock.SetColor(Color.White);
            clock.LayoutParameters = clockParam;
            mainLayout.AddView(clock);

            clockController.RegisterView(this);

            SetContentView(mainLayout, relParentParam);
        }

        private void Settings_Click(object sender, EventArgs e) {
            StartActivity(typeof(SettingsView));
        }

        public void DisplayTime(int hour, int minute, int second, int month, int day, int year) {
            Calendar temp = Calendar.GetInstance(new Locale("en", "US"));
            temp.Set(year, month, day, hour, minute, second);
            clock.SetCalendar(temp);
        }
    }
}