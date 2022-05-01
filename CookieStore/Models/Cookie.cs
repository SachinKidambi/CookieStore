using System;
namespace CookieStore.Models
{
    public class Cookie
    {
        public int Id { get; set; }
        public String Name{ get; set; }
        public String TinyDescription { get; set; }
        public string FullDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsCookieOfTheDay { get; set; }
        public Cookie()
        {
        }

    }
}
