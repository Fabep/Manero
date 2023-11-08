using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace DataAccess.Handlers.Services
{
    public class CookieService : ICookieService
    {
        private readonly CookieOptions _cookieOptions;
        public CookieService()
        {
            _cookieOptions = new CookieOptions()
            {
                Expires = DateTimeOffset.UtcNow.AddDays(1),
                Path = "/"
            };
        }
        public void AddCookie(HttpResponse response, string cookieKey, object cookieValue)
        {
            response.Cookies.Append(cookieKey, JsonConvert.SerializeObject(cookieValue), _cookieOptions);
        }

        public string GetCookie(HttpRequest req, string cookieKey)
        {
            try
            {
                return req.Cookies[cookieKey];
            }
            catch
            {
                return null!;
            }
        }
    }
}
