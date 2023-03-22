using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Sienna.Domain.Exceptions;
using System.Net;

namespace Sienna.Api.Behaviours
{
    public class ExceptionHandlingBehaviour
    {
        private readonly RequestDelegate _next;
        private readonly JsonSerializerSettings _serializerSettings;
        private readonly IDictionary<Type, Func<HttpContext, Exception, Task>> _exceptionHandlers;

        public ExceptionHandlingBehaviour(RequestDelegate next)
        {
            _next = next;
            _exceptionHandlers = new Dictionary<Type, Func<HttpContext, Exception, Task>>
            {
                { typeof(NotFoundException), HandleNotFoundException },
                { typeof(ValidationException), HandleValidationException },
                { typeof(UnauthorizedAccessException), HandleUnauthorizedAccessException }
            };

            _serializerSettings = new JsonSerializerSettings();
            _serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                HandleException(context, exception);
            }
        }

        private void HandleException(HttpContext context, Exception exception) 
        {
            Type type = exception.GetType();
            if (_exceptionHandlers.ContainsKey(type))
            {
                context.Response.ContentType = "application/json";
                _exceptionHandlers[type].Invoke(context, exception);
                return;
            }
        }

        private async Task HandleNotFoundException(HttpContext context, Exception exception)
        {
            var notFoundException = (NotFoundException)exception;

            var details = new ProblemDetails
            {
                Status = (int)HttpStatusCode.NotFound,
                Title = "The specified resource was not found",
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.4",
                Detail = notFoundException.Message,
            };

            var result = JsonConvert.SerializeObject(details, _serializerSettings);
            await context.Response.WriteAsync(result);
        }

        private async Task HandleValidationException(HttpContext context, Exception exception)
        {
            var validationException = (ValidationException)exception;

            var details = new ValidationProblemDetails(validationException.Errors)
            {
                Status = (int)HttpStatusCode.BadRequest,
                Title = "Validation exception",
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1"
            };

            var result = JsonConvert.SerializeObject(details, _serializerSettings);
            await context.Response.WriteAsync(result);
        }
        private async Task HandleUnauthorizedAccessException(HttpContext context, Exception exception)
        {
            var details = new ProblemDetails
            {
                Status = (int)HttpStatusCode.Unauthorized,
                Title = "Unauthorized",
                Type = "https://tools.ietf.org/html/rfc7235#section-3.1"
            };

            var result = JsonConvert.SerializeObject(details, _serializerSettings);
            await context.Response.WriteAsync(result);
        }
    }
}
