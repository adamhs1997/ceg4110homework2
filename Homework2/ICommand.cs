namespace Homework2 {

    // Interface for all generic command implementations

    interface ICommand {

        // "You can only do and undo a command..."
        void Execute();
        void Revert();

    }

}