using EasyCommand.Examples.ConsoleApp.Commands;
using System;
using System.Threading.Tasks;

namespace EasyCommand.Examples.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var executor = new CommandExecutor();
            
            executor.ExecuteCommand(new OutputPlatformCommand());

            Console.ReadLine();

            MainAsync(args).Wait();
        }

        static async Task MainAsync(string[] args)
        {
            var executor = new CommandExecutor();

            await executor.ExecuteCommandAsync(new AsyncOutputPlatformCommand());

            Console.ReadLine();
        }
    }
}
