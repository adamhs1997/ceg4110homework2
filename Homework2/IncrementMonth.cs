namespace Homework2 {

    // Concrete command to implement month increases

    class IncrementMonth : ICommand {

        // Hold our singleton command list and controller
        private ClockController _controller = ClockController.Controller;

        public void Execute() {
            _controller.IncreaseMonth();
        }

        public void Revert() {
            _controller.DecreaseMonth();
        }

    }
}