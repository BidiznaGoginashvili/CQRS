using System;
using Population.Application.Infrastructure.CQExecutionResult;

namespace Population.Application.Infrastructure.CommandInfrastructure
{
    public abstract class Command
    {
        public abstract CommandExecutionResult Execute();

        protected CommandExecutionResult Fail(Exception exception) 
        {
            return new CommandExecutionResult
            {
                Success = false,
                Data = null,
                Exception = exception
            };
        }

        protected CommandExecutionResult Ok(object data) 
        {
            return new CommandExecutionResult
            {
                Success = true,
                Data = data,
                Exception = null
            };
        }
    }
}
