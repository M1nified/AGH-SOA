using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleMenu.Models;

namespace ConsoleMenu.Test
{
    [TestClass]
    public class ConsoleMenuTest
    {
        private ConsoleMenu _consoleMenu;
        [TestInitialize]
        public void InitMenu()
        {
            _consoleMenu = new ConsoleMenu();
        }
        [TestMethod]
        public void AddCommandTest()
        {
            _consoleMenu.AddCommand(new Command
            {
                Key = ConsoleKey.A,
                Description = "Go to point A.",
                Action = () =>
                {
                    // there might be some action
                }
            });
            Assert.AreEqual(1, _consoleMenu.Commands.Count);
        }
    }
}
