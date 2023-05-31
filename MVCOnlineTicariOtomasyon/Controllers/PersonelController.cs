using MVCOnlineTicariOtomasyon.Models.Sınıflar;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCOnlineTicariOtomasyon.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();
        // GET: Personel
        public ActionResult Index()
        {
            var degerler = c.Personels.Where(z => z.PersonelDurum == true).ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniPersonel()
        {
            List<SelectListItem> dprt = (from x in c.Depatmans.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.DepartmanAd,
                                             Value = x.DepartmanID.ToString()


                                         }).ToList();
            ViewBag.dprt = dprt;
            return View();
        }

        [HttpPost]
        public ActionResult YeniPersonel(Personel p)
        {
            List<SelectListItem> dprt = (from x in c.Depatmans.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.DepartmanAd,
                                             Value = x.DepartmanID.ToString()


                                         }).ToList();
            ViewBag.dprt = dprt;
            if (!ModelState.IsValid)
            {
                return View("YeniPersonel");
            }
            p.PersonelDurum = true;
            c.Personels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PersonelSil(int id)
        {
            var pers = c.Personels.Find(id);
            pers.PersonelDurum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PersonelGetir(int id)
        {
            List<SelectListItem> dprt = (from x in c.Depatmans.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.DepartmanAd,
                                             Value = x.DepartmanID.ToString()


                                         }).ToList();
            ViewBag.dprt = dprt;
            var personel = c.Personels.Find(id);
            return View("PersonelGetir", personel);
        }

        public ActionResult PersonelGuncelle(Personel p)
        {
            List<SelectListItem> dprt = (from x in c.Depatmans.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.DepartmanAd,
                                             Value = x.DepartmanID.ToString()


                                         }).ToList();
            ViewBag.dprt = dprt;

            if (!ModelState.IsValid)
            {
                return View("PersonelGetir");
            }
            var pers = c.Personels.Find(p.PersonelID);
            pers.PersonelAd = p.PersonelAd;
            pers.PersonelSoyad = p.PersonelSoyad;
            pers.PersonelDurum = true;
            pers.PersonelGorsel = p.PersonelGorsel;
            pers.DepartmanID = p.DepartmanID;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PersonelListe()
        {
            var sorgu = c.Personels.ToList();
            return View(sorgu);
        }
    }
}