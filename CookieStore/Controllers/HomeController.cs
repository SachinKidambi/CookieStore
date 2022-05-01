using System;
using System.Linq;
using CookieStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace CookieStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;
        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Insomnia Cookies";
            var cookies = _repository.GetAllCookies().OrderByDescending(x => x.Price);
            return View(cookies);
        }
    }
}
