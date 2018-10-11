namespace Homework2 {

    // Concrete command to implement day decreases

    class DecrementDay : ICommand {

        // Hold our singleton command list and controller
        private ClockController _controller = ClockController.Controller;

        public void Execute() {
            _controller.DecreaseDay();
        }

        public void Revert() {
            _controller.IncreaseDay();
        }

    }
}