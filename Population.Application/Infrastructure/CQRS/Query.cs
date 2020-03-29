using Population.Application.Infrastructure.CQExecutionResult;
using System;

namespace Population.Application.Infrastructure.QueryInfrastructure
{
    public abstract class Query<TQueryResult>
    {
        public abstract QueryExecutionResult<TQueryResult> Execute();

        protected QueryExecutionResult<TQueryResult> Ok(TQueryResult data)
        {
            return new QueryExecutionResult<TQueryResult>
            {
                Success = true,
                Data = data,
                Exception = null
            };
        }

        protected QueryExecutionResult<TQueryResult> Fail(Exception exception)
        {
            return new QueryExecutionResult<TQueryResult>
            {
                Success = false,
                Exception = exception
            };
        }
    }
}
