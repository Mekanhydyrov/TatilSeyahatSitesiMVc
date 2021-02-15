using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesiMVc.Models.Sinflar;

namespace TatilSeyahatSitesiMVc.Migrations
{
    public class AboutController : Controller
    {
        // GET: About
        Context db = new Context();
        public ActionResult Index()
        {
            var Listele = db.Hakkimizdas.ToList();
            return View(Listele);
        }
    }
}