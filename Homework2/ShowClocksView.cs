using System.Collections.Generic;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Homework2 {

    [Activity(Label = "ShowClocksView")]

    public class ShowClocksView : Activity {

        // Use this to store our clock views
        ClockController clockController = ClockController.Controller;
        List<IClockView> currentClocks;

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Programmatically create our dynamic layout

            // Define basic layouts
            LinearLayout.LayoutParams matchParentLayout =
                new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);
            LinearLayout.LayoutParams wrapContentLayout =
                new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);

            // Create the main layout container
            ScrollView mainLayout = new ScrollView(this) {
                LayoutParameters = matchParentLayout,
            };

            // Grab our clocks list
            currentClocks = clockController.GetOpenClocks();

            // If we have no clocks, display appropriate message
            if (currentClocks.Count == 0) {
                TextView emptyText = new TextView(this) {
                    Gravity = GravityFlags.Center,
                    Text = "No clocks have been added yet! Go back to the main" +
                        " menu to add some."
                };
                mainLayout.AddView(emptyText);
                SetContentView(mainLayout, matchParentLayout);
                return;
            }

            // Otherwise, we create a list of buttons and appropriate
            //   launcher handlers to open existing clocks

            // Create layout to hold the buttons
            LinearLayout clocksList = new LinearLayout(this) {
                LayoutParameters = matchParentLayout,
                Orientation = Orientation.Vertical
            };
            mainLayout.AddView(clocksList);

            // Add button to open each clock
            foreach (IClockView clock in currentClocks) {
                Button current = new Button(this) {
                    LayoutParameters = wrapContentLayout,
                    Text = clock.GetType().ToString()
                };

                // Restart the clock we previously used on click
                current.Click += (s, e) => {
                    StartActivity(clock.GetType());
                };

                // Add this button to the list
                clocksList.AddView(current);
            }

            SetContentView(mainLayout, matchParentLayout);

        }
    }
}