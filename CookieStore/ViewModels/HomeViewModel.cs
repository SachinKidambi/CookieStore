using System;
using System.Collections.Generic;
using CookieStore.Models;

namespace CookieStore.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Cookie> Cookies { get; set; }
    }
}
