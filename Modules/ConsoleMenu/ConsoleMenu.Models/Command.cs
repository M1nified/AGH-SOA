using System;

namespace ConsoleMenu.Models
{
    public class Command
    {
        public ConsoleKey Key;
        public string Description;
        public Action Action;
    }
}
