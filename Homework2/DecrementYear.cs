namespace Homework2 {

    // Concrete command to implement year decreases

    class DecrementYear : ICommand {

        // Hold our singleton command list and controller
        private CommandList _commands = CommandList.Commands;
        private ClockController _controller = ClockController.Controller;

        public void Execute() {
            _controller.DecreaseYear();
        }

        public void Revert() {
            _controller.IncreaseYear();
        }

    }
}