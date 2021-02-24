using System.Threading.Tasks;
using CommandCLI.Inputs;
using Oakton;

namespace CommandCLI.Commands
{
    public class CheckoutCommand : OaktonAsyncCommand<CheckoutInput>
    {
        public override async Task<bool> Execute(CheckoutInput input)
        {
            await Task.CompletedTask;

            return true;
        }
    }
}