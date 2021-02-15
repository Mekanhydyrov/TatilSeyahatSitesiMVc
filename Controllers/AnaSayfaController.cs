using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesiMVc.Models.Sinflar;

namespace TatilSeyahatSitesiMVc.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        Context c = new Context();
        public ActionResult Index()
        {
            //Listeleme Kodu
            var Listele = c.Blogs.ToList();
            return View(Listele);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            //son eklenen iki blogu alma kodu
            var deger = c.Blogs.OrderByDescending(x => x.id).Take(2).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(x => x.id == 1).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            //Son eklenen 10 blog listeleme
            var deger = c.Blogs.OrderByDescending(x => x.id).Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            //son eklenen 3 blog listeleme anasayfada 
            var deger = c.Blogs.OrderBy(x => x.id).Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            //son eklenen blog getirme Ana Sayfada 
            var deger = c.Blogs.OrderByDescending(x => x.id).Take(3).ToList();
            return PartialView(deger);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            //blogun id göre yorum yaptırma kodu
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            //yorum ekleme
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
        public ActionResult Adres()
        {
            var deger = c.AdresBlogs.ToList();
            return View(deger);
        }

        [HttpGet]
        public PartialViewResult iletisim()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult iletisim(İletisim p)
        {
            c.iletisims.Add(p);
            c.SaveChanges();
            return PartialView();
        }
        
    }
}