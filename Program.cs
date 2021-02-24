using System;
using CommandCLI.Commands;
using Oakton;

namespace CommandCLI
{
    class Program
    {
        static int Main(string[] args)
        {
            var executor = CommandExecutor.For(ce =>
            {
                ce.RegisterCommand<CheckoutCommand>();
                ce.RegisterCommand<CleanCommand>();
            });

            return executor.Execute(args);
        }
    }
}
