using Microsoft.AspNetCore.Http;

namespace DataAccess.Handlers.Services.Abstractions
{
    public interface ICookieService
    {
        void AddCookie(HttpResponse response, string cookieKey, object cookieValue, CookieOptions cookieOptions = null!);

        string GetCookie(HttpRequest req, string cookieKey);
    }
}
