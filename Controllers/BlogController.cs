using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesiMVc.Models.Sinflar;

namespace TatilSeyahatSitesiMVc.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context db = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            // var Listele = db.Blogs.ToList();

            //Blog Listeleme ve Son Yazlan Blokları getirme kodu
            by.degerB = db.Blogs.ToList();
            by.degerS = db.Blogs.OrderByDescending(x=>x.id).Take(3).ToList();
            return View(by);
        }
        public ActionResult BlogDetay(int id)
        {
            //var deger = db.Blogs.Where(x => x.id == id).ToList();

            //Bir Bloga birden fazla yorum getire bilmek için kod
            by.degerB = db.Blogs.Where(x => x.id == id).ToList();
            by.degerY = db.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);
        }
    }
}