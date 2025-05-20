

namespace TimerFunction.Middleware
{
    public class GlobalExceptionMiddleware : IFunctionsWorkerMiddleware
    {
        public async Task Invoke(FunctionContext context, FunctionExecutionDelegate next)
        {
			try
			{
				await next(context);
			}
			catch (Exception ex)
			{

				throw;
			}
        }
    }
}
