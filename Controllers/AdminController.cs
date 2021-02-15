using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesiMVc.Models.Sinflar;

namespace TatilSeyahatSitesiMVc.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            //Blog listeleme kodu
            var Listele = c.Blogs.ToList();
            return View(Listele);
        }

        [HttpGet] [Authorize]
        public ActionResult YeniBlog()
        {
            //boş deger dondurmeme kodu
            return View();
        }

        [HttpPost] [Authorize]
        public ActionResult YeniBlog(Blog p)
        {
            //Yeni Blog ekleme kodu
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            //Blog silme kodu
            var deger = c.Blogs.Find(id);
            c.Blogs.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            //id göre veri getirme kodu
            var deger = c.Blogs.Find(id);
            return View("BlogGetir", deger);
        }
        public ActionResult Guncelle(Blog p)
        {
            //Güncelleme kodu
            var deger = c.Blogs.Find(p.id);
            deger.Baslik = p.Baslik;
            deger.Tarih = p.Tarih;
            deger.Blokimg = p.Blokimg;
            deger.Aciklama = p.Aciklama;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult YorumListesi()
        {
            //Yorumları Listeleme kodu
            var deger = c.Yorumlars.ToList();
            return View(deger);
        }
        public ActionResult YorumSil(int id)
        {
            //Yorum silme kodu
            var deger = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("YorumListesi", deger);
        }
        public ActionResult YorumGetir(int id)
        {
            //id göre yorum getirme
            var deger = c.Yorumlars.Find(id);
            return View("YorumGetir", deger);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            //Yorum Güncelleme kodu
            var deger = c.Yorumlars.Find(y.id);
            deger.KullaniciAd = y.KullaniciAd;
            deger.Mail = y.Mail;
            deger.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult iletisimListe()
        {
            //iletişim listeleme kodu
            var deger = c.iletisims.ToList();
            return View(deger);
        }
        public ActionResult MesajSil(int id)
        {
            //iletisim silme kodu
            var deger = c.iletisims.Find(id);
            c.iletisims.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("iletisimListe", "Admin");
        }
        public ActionResult BlogDetay(int id)
        {
            //id göre detay getirme 
            var deger = c.Blogs.Find(id);
            return View("BlogDetay", deger);
        }
        public ActionResult AdminHakkimda()
        {
            var deger = c.Hakkimizdas.ToList();
            return View(deger);
        }
        public ActionResult HakkimdaGetir(int id)
        {
            var deger = c.Hakkimizdas.Find(id);
            return View("HakkimdaGetir", deger);
        }
        public ActionResult HakkimdaGuncelle(Hakkimizda p)
        {
            var deger = c.Hakkimizdas.Find(p.id);
            deger.Aciklama = p.Aciklama;
            deger.FotoUrl = p.FotoUrl;
            c.SaveChanges();
            return RedirectToAction("AdminHakkimda");
        }
    }
}