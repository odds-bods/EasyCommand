using EasyCommand.Examples.ConsoleApp.Commands;
using System;

namespace EasyCommand.Examples.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var executor = new CommandExecutor();
            
            executor.ExecuteCommand(new OutputPlatformCommand());

            Console.Read();
        }
    }
}
