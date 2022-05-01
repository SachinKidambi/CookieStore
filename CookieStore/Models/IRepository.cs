using System;
using System.Collections.Generic;

namespace CookieStore.Models
{
    public interface IRepository
    {
        IEnumerable<Cookie> GetAllCookies();
        Cookie GetCookieById(int id);
    }
}
