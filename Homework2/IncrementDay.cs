namespace Homework2 {

    // Concrete command to implement day increases

    class IncrementDay : ICommand {

        // Hold our singleton command list and controller
        private ClockController _controller = ClockController.Controller;

        public void Execute() {
            _controller.IncreaseDay();
        }

        public void Revert() {
            _controller.DecreaseDay();
        }

    }
}