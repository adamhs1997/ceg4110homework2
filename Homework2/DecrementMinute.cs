namespace Homework2 {

    // Concrete command to implement minute decreases

    class DecrementMinute : ICommand {

        // Hold our singleton command list and controller
        private CommandList _commands = CommandList.Commands;
        private ClockController _controller = ClockController.Controller;

        public void Execute() {
            _controller.DecreaseMinute();
        }

        public void Revert() {
            _controller.IncreaseMinute();
        }

    }
}