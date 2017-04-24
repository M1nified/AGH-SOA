namespace ConsoleMenu
{
    public interface IConsoleMenu
    {
        void AddCommand(Command command);
        void DisplayMenu();
        void LoopMenu();
        void RemoveCommand(Command command);
        void RemoveCommand(System.ConsoleKey consoleKey);
        void WaitForCommand();
    }
}