namespace Homework2 {

    // Concrete command to implement month decreases

    class DecrementMonth : ICommand {

        // Hold our singleton command list and controller
        private ClockController _controller = ClockController.Controller;

        public void Execute() {
            _controller.DecreaseMonth();
        }

        public void Revert() {
            _controller.IncreaseMonth();
        }

    }
}