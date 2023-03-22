using Microsoft.AspNetCore.Mvc.Filters;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Sienna.Api.Filters.Auth
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class ApiKeyAttribute : Attribute, IAuthorizationFilter
    {
        private const string API_KEY_HEADER_NAME = "X-API-Key";

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var submittedApiKey = GetSubmittedApiKey(context.HttpContext);
            var apiKey = GetApiKey(context.HttpContext);

            if (submittedApiKey == null || !IsApiKeyValid(apiKey, submittedApiKey))
            {
                throw new UnauthorizedAccessException();
            }
        }

        private static string? GetSubmittedApiKey(HttpContext context) => 
            context.Request.Headers[API_KEY_HEADER_NAME];

        private static string GetApiKey(HttpContext context) => 
            context.RequestServices.GetRequiredService<IConfiguration>().GetValue<string>("ApiKey");

        /*
         * The reason we compare the below strings using spans and fixed time comparisons is to compare the two strings
         * without revealing the length or content of the two strings. This helps prevent timing attacks where hackers 
         * can guess the content of api tokens
         */
        private static bool IsApiKeyValid(string apiKey, string submittedApiKey)
        {
            var apiKeySpan = MemoryMarshal.Cast<char, byte>(apiKey.AsSpan());
            var submittedApiKeySpan = MemoryMarshal.Cast<char, byte>(submittedApiKey.AsSpan());

            return CryptographicOperations.FixedTimeEquals(apiKeySpan, submittedApiKeySpan);
        }
    }
}
