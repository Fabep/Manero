using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Handlers.Services.Abstractions
{
    public interface ICookieService
    {
        void AddCookie(HttpResponse response, string cookieKey, object cookieValue);

        string GetCookie(HttpRequest req, string cookieKey);
    }
}
