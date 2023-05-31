using MVCOnlineTicariOtomasyon.Models.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
namespace MVCOnlineTicariOtomasyon.Controllers
{
    public class SatisController : Controller
    {
        Context c = new Context();
        // GET: Satis
        public ActionResult Index()
        {
            var satislar = c.SatisHarekets.ToList();
            return View(satislar);
        }

        [HttpGet]
        public ActionResult YeniSatis()
        {
            List<SelectListItem> personel = (from x in c.Personels.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.PersonelAd + " " + x.PersonelSoyad,
                                                 Value = x.PersonelID.ToString()
                                             }).ToList();

            List<SelectListItem> urun = (from y in c.Uruns.ToList()
                                         select new SelectListItem
                                         {
                                             Text = y.UrunAd,
                                             Value = y.UrunID.ToString()
                                         }).ToList();

            List<SelectListItem> cari = (from z in c.Carilers.ToList()
                                         select new SelectListItem
                                         {
                                             Text = z.CariAd + " " + z.CariSoyad,
                                             Value = z.CariID.ToString()
                                         }).ToList();

            ViewBag.pers = personel;
            ViewBag.urun = urun;
            ViewBag.cari = cari;


            return View();
        }

        [HttpPost]
        public ActionResult YeniSatis(SatisHareket s)
        {
            s.Tarih = DateTime.Now;
            c.SatisHarekets.Add(s);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SatisGetir(int id)
        {
            List<SelectListItem> personel = (from x in c.Personels.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.PersonelAd + " " + x.PersonelSoyad,
                                                 Value = x.PersonelID.ToString()
                                             }).ToList();

            List<SelectListItem> urun = (from y in c.Uruns.ToList()
                                         select new SelectListItem
                                         {
                                             Text = y.UrunAd,
                                             Value = y.UrunID.ToString()
                                         }).ToList();

            List<SelectListItem> cari = (from z in c.Carilers.ToList()
                                         select new SelectListItem
                                         {
                                             Text = z.CariAd + " " + z.CariSoyad,
                                             Value = z.CariID.ToString()
                                         }).ToList();

            ViewBag.pers = personel;
            ViewBag.urun = urun;
            ViewBag.cari = cari;

            var satis = c.SatisHarekets.Find(id);
            return View("Satisgetir", satis);
        }

        public ActionResult SatisGuncelle(SatisHareket s)
        {
            var satis = c.SatisHarekets.Find(s.SatisID);
            satis.UrunID = s.UrunID;
            satis.CariID = s.CariID;
            satis.PersonelID = s.PersonelID;
            satis.Adet = s.Adet;
            satis.Fiyat = s.Fiyat;
            satis.ToplamTutar = s.ToplamTutar;
            satis.Tarih = s.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult SatisDetay(int id)
        {
            var degerler = c.SatisHarekets.Where(x => x.SatisID == id).ToList();
            return View(degerler);
        }

        public ActionResult SatisYazdir()
        {
            var degerler = c.SatisHarekets.ToList();
            return View(degerler);
        }
    }
}