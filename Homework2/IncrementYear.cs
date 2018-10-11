namespace Homework2 {

    // Concrete command to implement year increases

    class IncrementYear : ICommand {

        // Hold our singleton command list and controller
        private ClockController _controller = ClockController.Controller;

        public void Execute() {
            _controller.IncreaseYear();
        }

        public void Revert() {
            _controller.DecreaseYear();
        }

    }
}