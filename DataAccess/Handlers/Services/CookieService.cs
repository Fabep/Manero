using DataAccess.Handlers.Services.Abstractions;
using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace DataAccess.Handlers.Services
{
    public class CookieService : ICookieService
    {
        public CookieService()
        {
        }
        public void AddCookie(HttpResponse response, string cookieKey, object cookieValue, CookieOptions cookieOptions = null!)
        {
            if (cookieOptions != null)
            {
                response.Cookies.Append(cookieKey, JsonConvert.SerializeObject(cookieValue), cookieOptions);
            }
            else
            {
                response.Cookies.Append(cookieKey, JsonConvert.SerializeObject(cookieValue));
            }
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
