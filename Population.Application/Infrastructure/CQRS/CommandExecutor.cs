using Population.Application.Infrastructure.CQExecutionResult;

namespace Population.Application.Infrastructure.CommandInfrastructure
{
    public class CommandExecutor
    {
        public CommandExecutionResult Execute(Command command)
        {
            return command.Execute();
        }
    }
}
