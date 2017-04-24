using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleMenu
{
    public class ConsoleMenu : IConsoleMenu
    {
        public string WrongCommandInfo = "Bledna komenda";

        private List<Command> _commands;
        private bool shallStop = false;

        public void AddCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public void DisplayMenu()
        {
            _commands.ForEach(command =>
            {
                Console.WriteLine("{0}\t{1}", command.Key, command.Description);
            });
        }

        public void LoopMenu()
        {
            while (shallStop == false)
            {
                DisplayMenu();
                WaitForCommand();
            }
        }

        public void RemoveCommand(Command command)
        {
            _commands.Remove(command);
        }

        public void RemoveCommand(ConsoleKey consoleKey)
        {
            _commands.RemoveAll(x => x.Key == consoleKey);
        }

        public void WaitForCommand()
        {
            var key = Console.ReadKey();
            var command = _commands.Where(x => x.Key == key.Key).FirstOrDefault();
            if(command == null)
            {
                Console.WriteLine(WrongCommandInfo);
            }
            else
            {
                command.Action();
            }
        }
    }
}
