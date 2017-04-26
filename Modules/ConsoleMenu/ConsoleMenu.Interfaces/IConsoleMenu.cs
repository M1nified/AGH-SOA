using ConsoleMenu.Models;

namespace ConsoleMenu.Interfaces
{
    public interface IConsoleMenu
    {
        void AddCommand(Command command);
        void DisplayMenu();
        void RemoveCommand(Command command);
        void RemoveCommand(System.ConsoleKey consoleKey);
        void UpdateCommnd(Command command);
        void WaitForCommand();
    }
}