using System.Collections.Generic;

namespace Homework2 {

    // Singleton class that will hold all our commands to undo/redo

    class CommandList {

        // Create our instance of the list
        private List<ICommand> _list = new List<ICommand>();

        // Hold on to the singleton command list
        private static CommandList _commandList = new CommandList();

        // Hold on to current and max indices in list
        private int _currentPos = -1, _maxPos = -1;

        // Privatize our constructor
        private CommandList() { }

        // Make possible to get back our list
        public static CommandList Commands { get => _commandList; }

        // Add a new item to the end of the list
        public void AddCommand(ICommand command) {
            _list.Add(command);
            _currentPos++;
            _maxPos = _currentPos;
        }

        // Undo the last item in the list
        public void Undo() {
            if (_currentPos != -1)
                _list[_currentPos--].Revert();
        }

        // Redo the next command
        public void Redo() {
            if (_currentPos < _maxPos)
                _list[++_currentPos].Execute();
        }

    }

}