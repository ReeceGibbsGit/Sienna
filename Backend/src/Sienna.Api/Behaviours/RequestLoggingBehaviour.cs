namespace Sienna.Api.Behaviours
{
    public class RequestLoggingBehaviour
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public RequestLoggingBehaviour(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<RequestLoggingBehaviour>();
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            finally
            {
                _logger.LogInformation("Request {method} {url} => {statusCode}",
                    context.Request?.Method,
                    context.Request?.Path.Value,
                    context.Response?.StatusCode);
            }
        }
    }
}
