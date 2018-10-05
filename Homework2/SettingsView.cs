using Android.App;
using Android.OS;
using Android.Widget;

namespace Homework2 {

    [Activity(Label = "SettingsView")]

    public class SettingsView : Activity {

        // Hold on to an instance of the command list
        CommandList _list = CommandList.Commands;

        // Use to update timing in the view
        ClockController _controller = ClockController.Controller;

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Call on the settings layout
            SetContentView(Resource.Layout.SettingsViewLayout);

            // "Pause" the clock while user is changing settings
            _controller.PauseUpdates();

            // Set current times in the settings window
            UpdateSettingTime();

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

            // Handle undo/redo
            FindViewById<Button>(Resource.Id.Undo).Click += HandleUndo;
            FindViewById<Button>(Resource.Id.Redo).Click += HandleRedo;
        }

        // Use to resume time updates after settings are chosen
        protected override void OnStop() {
            base.OnStop();

            _controller.ResumeUpdates();
        }

        // Use to update the times shown in the settings window
        private void UpdateSettingTime() {
            FindViewById<TextView>(Resource.Id.HourCur).Text = _controller.GetHour().ToString();
            FindViewById<TextView>(Resource.Id.MinuteCur).Text = _controller.GetMinute().ToString();
            FindViewById<TextView>(Resource.Id.SecondCur).Text = _controller.GetSecond().ToString();
            FindViewById<TextView>(Resource.Id.MonthCur).Text = _controller.GetMonth().ToString();
            FindViewById<TextView>(Resource.Id.DayCur).Text = _controller.GetDay().ToString();
            FindViewById<TextView>(Resource.Id.YearCur).Text = _controller.GetYear().ToString();
        }

        // Implement our handlers

        private void HandleHourDecrement(object sender, System.EventArgs e) {
            ICommand command = new DecrementHour();
            command.Execute();
            _list.AddCommand(command);
            UpdateSettingTime();
        }

        private void HandleHourIncrement(object sender, System.EventArgs e) {
            ICommand command = new IncrementHour();
            command.Execute();
            _list.AddCommand(command);
            UpdateSettingTime();
        }

        private void HandleMinuteIncrement(object sender, System.EventArgs e) {
            ICommand command = new IncrementMinute();
            command.Execute();
            _list.AddCommand(command);
            UpdateSettingTime();
        }

        private void HandleMinuteDecrement(object sender, System.EventArgs e) {
            ICommand command = new DecrementMinute();
            command.Execute();
            _list.AddCommand(command);
            UpdateSettingTime();
        }

        private void HandleSecondIncrement(object sender, System.EventArgs e) {
            ICommand command = new IncrementSecond();
            command.Execute();
            _list.AddCommand(command);
            UpdateSettingTime();
        }

        private void HandleSecondDecrement(object sender, System.EventArgs e) {
            ICommand command = new DecrementSecond();
            command.Execute();
            _list.AddCommand(command);
            UpdateSettingTime();
        }

        private void HandleMonthIncrement(object sender, System.EventArgs e) {
            ICommand command = new IncrementMonth();
            command.Execute();
            _list.AddCommand(command);
            UpdateSettingTime();
        }

        private void HandleMonthDecrement(object sender, System.EventArgs e) {
            ICommand command = new DecrementMonth();
            command.Execute();
            _list.AddCommand(command);
            UpdateSettingTime();
        }

        private void HandleDayIncrement(object sender, System.EventArgs e) {
            ICommand command = new IncrementDay();
            command.Execute();
            _list.AddCommand(command);
            UpdateSettingTime();
        }

        private void HandleDayDecrement(object sender, System.EventArgs e) {
            ICommand command = new DecrementDay();
            command.Execute();
            _list.AddCommand(command);
            UpdateSettingTime();
        }

        private void HandleYearIncrement(object sender, System.EventArgs e) {
            ICommand command = new IncrementYear();
            command.Execute();
            _list.AddCommand(command);
            UpdateSettingTime();
        }

        private void HandleYearDecrement(object sender, System.EventArgs e) {
            ICommand command = new DecrementYear();
            command.Execute();
            _list.AddCommand(command);
            UpdateSettingTime();
        }

        private void HandleUndo(object sender, System.EventArgs e) {
            _list.Undo();
            UpdateSettingTime();
        }

        private void HandleRedo(object sender, System.EventArgs e) {
            _list.Redo();
            UpdateSettingTime();
        }       

    }
}