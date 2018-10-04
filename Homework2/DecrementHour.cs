namespace Homework2 {

    // Concrete command to implement hour decreases

    class DecrementHour : ICommand {

        // Hold our singleton command list and controller
        private CommandList _commands = CommandList.Commands;
        private ClockController _controller = ClockController.Controller;

        public void Execute() {
            if (_controller.GetHour() != 0)
                _controller.SetHour(_controller.GetHour() - 1);
            else
                _controller.SetHour(23);
        }

        public void Revert() {
            if (_controller.GetHour() != 23)
                _controller.SetHour(_controller.GetHour() + 1);
            else
                _controller.SetHour(0);
        }

    }
}