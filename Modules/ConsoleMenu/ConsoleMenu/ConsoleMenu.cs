using ConsoleMenu.Interfaces;
using ConsoleMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleMenu
{
    public class ConsoleMenu : IConsoleMenu
    {
        public string WrongCommandInfo = "Invalid key.";

        private List<Command> _commands;

        public List<Command> Commands { get => _commands.ToList(); private set => _commands = value; }

        public ConsoleMenu()
        {
            _commands = new List<Command>();
        }

        public void AddCommand(Command command)
        {
            if(0 != _commands.Where(x => x.Key == command.Key).Count())
            {
                throw new System.Exception("Command with this key has already been assigned. Use UpdateCommand or RemoveCommand.");
            }
            _commands.Add(command);
        }

        public void DisplayMenu()
        {
            _commands.ForEach(command =>
            {
                Console.WriteLine("{0}\t{1}", command.Key, command.Description);
            });
        }

        public void RemoveCommand(Command command)
        {
            _commands.Remove(command);
        }

        public void RemoveCommand(ConsoleKey consoleKey)
        {
            _commands.RemoveAll(x => x.Key == consoleKey);
        }

        public void UpdateCommnd(Command command)
        {
            RemoveCommand(command.Key);
            AddCommand(command);
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
