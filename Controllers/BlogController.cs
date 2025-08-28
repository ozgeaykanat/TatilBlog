using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Sınıflar;

namespace TravelTrip.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();

        public ActionResult Index()
        {
            // var bloglar=c.Blogs.ToList();
            BlogYorum by = new BlogYorum();
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.Take(18).ToList();
            return View(by);
        }
        BlogYorum by = new BlogYorum();
        public ActionResult BlogDetay(int id)
        {
            BlogYorum by = new BlogYorum();
            //var blogbul=c.Blogs.Where(x => x.ID == id).ToList();           
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(y => y.BLOGID == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }

    }
}