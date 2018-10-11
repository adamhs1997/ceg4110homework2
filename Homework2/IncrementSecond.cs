namespace Homework2 {

    // Concrete command to implement second increases

    class IncrementSecond : ICommand {

        // Hold our singleton command list and controller
        private ClockController _controller = ClockController.Controller;

        public void Execute() {
            _controller.IncreaseSecond();
        }

        public void Revert() {
            _controller.DecreaseSecond();
        }

    }
}