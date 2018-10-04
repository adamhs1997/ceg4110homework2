using Android.App;
using Android.OS;
using Android.Widget;

namespace Homework2 {

    [Activity(Label = "SettingsView")]

    public class SettingsView : Activity {

        // Hold on to an instance of the command list
        CommandList _list = CommandList.Commands;

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Call on the settings layout
            SetContentView(Resource.Layout.SettingsViewLayout);

            // Add our handlers
            FindViewById<Button>(Resource.Id.HourDec).Click += HandleHourDecrement;
            FindViewById<Button>(Resource.Id.HourInc).Click += HandleHourIncrement;
            FindViewById<Button>(Resource.Id.MinuteInc).Click += HandleMinuteIncrement;
            FindViewById<Button>(Resource.Id.MinuteDec).Click += HandleMinuteDecrement;
            FindViewById<Button>(Resource.Id.SecondInc).Click += HandleSecondIncrement;
            FindViewById<Button>(Resource.Id.SecondDec).Click += HandleSecondDecrement;
            FindViewById<Button>(Resource.Id.MonthInc).Click += HandleMonthIncrement;
            FindViewById<Button>(Resource.Id.MonthDec).Click += HandleMonthDecrement;
            FindViewById<Button>(Resource.Id.DayInc).Click += HandleDayIncrement;
            FindViewById<Button>(Resource.Id.DayDec).Click += HandleDayDecrement;
            FindViewById<Button>(Resource.Id.YearInc).Click += HandleYearIncrement;
            FindViewById<Button>(Resource.Id.YearDec).Click += HandleYearDecrement;
        }

        private void HandleHourDecrement(object sender, System.EventArgs e) {
            ICommand command = new DecrementHour();
            command.Execute();
            _list.AddCommand(command);
        }

        private void HandleHourIncrement(object sender, System.EventArgs e) {
            ICommand command = new IncrementHour();
            command.Execute();
            _list.AddCommand(command);
        }

        private void HandleMinuteIncrement(object sender, System.EventArgs e) {
            ICommand command = new IncrementMinute();
            command.Execute();
            _list.AddCommand(command);
        }

        private void HandleMinuteDecrement(object sender, System.EventArgs e) {
            ICommand command = new DecrementMinute();
            command.Execute();
            _list.AddCommand(command);
        }

        private void HandleSecondIncrement(object sender, System.EventArgs e) {
            ICommand command = new IncrementSecond();
            command.Execute();
            _list.AddCommand(command);
        }

        private void HandleSecondDecrement(object sender, System.EventArgs e) {
            ICommand command = new DecrementSecond();
            command.Execute();
            _list.AddCommand(command);
        }

        private void HandleMonthIncrement(object sender, System.EventArgs e) {
            ICommand command = new IncrementMonth();
            command.Execute();
            _list.AddCommand(command);
        }

        private void HandleMonthDecrement(object sender, System.EventArgs e) {
            ICommand command = new DecrementMonth();
            command.Execute();
            _list.AddCommand(command);
        }

        private void HandleDayIncrement(object sender, System.EventArgs e) {
            ICommand command = new IncrementDay();
            command.Execute();
            _list.AddCommand(command);
        }

        private void HandleDayDecrement(object sender, System.EventArgs e) {
            ICommand command = new DecrementDay();
            command.Execute();
            _list.AddCommand(command);
        }

        private void HandleYearIncrement(object sender, System.EventArgs e) {
            ICommand command = new IncrementYear();
            command.Execute();
            _list.AddCommand(command);
        }

        private void HandleYearDecrement(object sender, System.EventArgs e) {
            ICommand command = new DecrementYear();
            command.Execute();
            _list.AddCommand(command);
        }

    }
}