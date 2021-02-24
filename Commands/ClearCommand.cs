using CommandCLI.Inputs;
using Oakton;

namespace CommandCLI.Commands
{
    [Description("Switch branches or restore working tree files")]
    public class CleanCommand : OaktonCommand<CleanInput>
    {
        public override bool Execute(CleanInput input)
        {
            return true;
        }
    }
}
