using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Sınıflar;

namespace TravelTrip.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {

            var degerler = c.Blogs.Take(5).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {

            return View();

        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4() 
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(deger);
        }
        //public PartialViewResult Partial2()
        //{
        //    var deger = c.Blogs.OrderByDescending(x => x.ID == 1).ToList();
        //    return PartialView(deger);
        //}
       
    }
}