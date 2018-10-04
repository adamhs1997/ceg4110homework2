namespace Homework2 {

    // Concrete command to implement hour increases

    class IncrementSecond : ICommand {

        // Hold our singleton command list and controller
        private CommandList _commands = CommandList.Commands;
        private ClockController _controller = ClockController.Controller;

        public void Execute() {
            if (_controller.GetSecond() != 59)
                _controller.SetSecond(_controller.GetSecond() + 1);
            else
                _controller.SetSecond(0);
        }

        public void Revert() {
            if (_controller.GetSecond() != 0)
                _controller.SetSecond(_controller.GetSecond() - 1);
            else
                _controller.SetSecond(59);
        }

    }
}