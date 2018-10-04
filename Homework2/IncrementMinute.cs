namespace Homework2 {

    // Concrete command to implement hour increases

    class IncrementMinute : ICommand {

        // Hold our singleton command list and controller
        private CommandList _commands = CommandList.Commands;
        private ClockController _controller = ClockController.Controller;

        public void Execute() {
            if (_controller.GetMinute() != 59)
                _controller.SetMinute(_controller.GetMinute() + 1);
            else
                _controller.SetMinute(0);
        }

        public void Revert() {
            if (_controller.GetMinute() != 0)
                _controller.SetMinute(_controller.GetMinute() - 1);
            else
                _controller.SetMinute(59);
        }

    }
}