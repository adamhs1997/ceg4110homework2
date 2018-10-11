namespace Homework2 {

    // Concrete command to implement minute increases

    class IncrementMinute : ICommand {

        // Hold our singleton command list and controller
        private ClockController _controller = ClockController.Controller;

        public void Execute() {
            _controller.IncreaseMinute();
        }

        public void Revert() {
            _controller.DecreaseMinute();
        }

    }
}