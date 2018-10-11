namespace Homework2 {

    // Concrete command to implement hour decreases

    class DecrementHour : ICommand {

        // Hold our singleton command list and controller
        private ClockController _controller = ClockController.Controller;

        public void Execute() {
            _controller.DecreaseHour();
        }

        public void Revert() {
            _controller.IncreaseHour();
        }

    }
}