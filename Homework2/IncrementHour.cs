namespace Homework2 {

    // Concrete command to implement hour increases

    class IncrementHour : ICommand {

        // Hold our singleton command list and controller
        private CommandList _commands = CommandList.Commands;
        private ClockController _controller = ClockController.Controller;

        public void Execute() {
            _controller.IncreaseHour();
        }

        public void Revert() {
            _controller.DecreaseHour();
        }

    }
}