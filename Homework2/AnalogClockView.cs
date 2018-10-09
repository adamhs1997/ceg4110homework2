using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Util;
using Android.Widget;

using Java.Util;

namespace Homework2 {

    [Activity(Label = "Clock Master")]

    public class AnalogClockView : Activity, IClockView {

        // Define what we will need on a class level
        private CustomAnalogClock clock;
        private TextView analogDate;
        private ClockController clockController = ClockController.Controller;

        // Use this to show the proper month in the view
        string[] months = {"January", "February", "March", "April", "May",
                            "June", "July", "August", "September", "October",
                            "November", "December"};

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Programmatically create main layout
            // -->For some reason, the clock won't appear in the XML

            // Define basic layouts
            LinearLayout.LayoutParams matchParentLayout =
                new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);
            LinearLayout.LayoutParams wrapContentLayout =
                new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);

            // Create the main layout container
            LinearLayout mainLayout = new LinearLayout(this) {
                LayoutParameters = matchParentLayout,
                Orientation = Orientation.Vertical
            };

            // Add the calendar to the view
            analogDate = new TextView(this) {
                Gravity = GravityFlags.Center,
            };
            analogDate.SetTextColor(Color.White);
            analogDate.SetTextSize(ComplexUnitType.Sp, 24);
            mainLayout.AddView(analogDate);

            // Add clock to layout
            clock = new CustomAnalogClock(this);
            clock.SetColor(Color.White);
            clock.LayoutParameters = wrapContentLayout;
            mainLayout.AddView(clock);

            // Register this view
            clockController.RegisterView(this);

            // Set our view in the activity
            SetContentView(mainLayout, matchParentLayout);
        }

        // Implementation of the IClockView interface, allowing updates from controller
        public void DisplayTime(int hour, int minute, int second, int month, int day, int year) {
            Calendar temp = Calendar.GetInstance(new Locale("en", "US"));
            temp.Set(year, month, day, hour, minute, second);
            clock.SetCalendar(temp);
            analogDate.Text =
                months[month - 1] + " " + day.ToString() + ", " + year.ToString();
        }
    }
}