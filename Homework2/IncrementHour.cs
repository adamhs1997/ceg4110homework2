using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Homework2 {

    // Concrete command to implement hour increases

    class IncrementHour : ICommand {

        // Hold our singleton command list and controller
        private CommandList _commands = CommandList.Commands;
        private ClockController _controller = ClockController.Controller;

        public void Execute() {
            if (_controller.GetHour() != 23)
                _controller.SetHour(_controller.GetHour() + 1);
            else
                _controller.SetHour(0);
        }

        public void Revert() {
            if (_controller.GetHour() != 0)
                _controller.SetHour(_controller.GetHour() - 1);
            else
                _controller.SetHour(23);
        }

    }
}