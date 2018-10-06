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
    [Activity(Label = "AnalogClockView", MainLauncher = true)]
    public class AnalogClockView : Activity {
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            LinearLayout mainLayout = new LinearLayout(this);
            LinearLayout.LayoutParams relParentParam = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent, RelativeLayout.LayoutParams.MatchParent);
            mainLayout.LayoutParameters = relParentParam;

            CustomAnalogClock clock = new CustomAnalogClock(this);
            LinearLayout.LayoutParams clockParam = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WrapContent, RelativeLayout.LayoutParams.WrapContent);
            clock.LayoutParameters = clockParam;

            mainLayout.AddView(clock);

            SetContentView(mainLayout, relParentParam);
        }
    }
}