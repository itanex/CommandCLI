using Oakton;

namespace CommandCLI.Inputs
{
    public class CleanInput
    {
        [Description("Do it now!")]
        public bool ForceFlag { get; set; }

        [FlagAlias('d')]
        [Description("Remove untracked directories in addition to untracked files")]
        public bool RemoveUntrackedDirectoriesFlag { get; set; }

        [FlagAlias('x')]
        [Description("Remove only files ignored by Git")]
        public bool DoNoUseStandardIgnoreRulesFlag { get; set; }
    }
}