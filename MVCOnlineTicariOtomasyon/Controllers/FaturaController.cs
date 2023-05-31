using MVCOnlineTicariOtomasyon.Models.Sınıflar;
using System.Linq;
using System.Web.Mvc;
namespace MVCOnlineTicariOtomasyon.Controllers
{
    public class FaturaController : Controller
    {
        Context c = new Context();
        // GET: Fatura
        public ActionResult Index()
        {
            var liste = c.Faturalars.ToList();
            return View(liste);
        }

        [HttpGet]
        public ActionResult YeniFatura()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniFatura(Faturalar f)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniFatura");
            }
            c.Faturalars.Add(f);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult FaturaGetir(int id)
        {
            var fatura = c.Faturalars.Find(id);
            return View("FaturaGetir", fatura);
        }

        public ActionResult FaturaGuncelle(Faturalar f)
        {
            if (!ModelState.IsValid)
            {
                return View("Faturagetir");
            }
            var fatura = c.Faturalars.Find(f.FaturaID);
            fatura.FaturaSeriNo = f.FaturaSeriNo;
            fatura.FaturaSiraNo = f.FaturaSiraNo;
            fatura.VergiDairesi = f.VergiDairesi;
            fatura.TeslimEden = f.TeslimEden;
            fatura.TeslimAlan = f.TeslimAlan;
            fatura.Tarih = f.Tarih;
            fatura.Saat = f.Saat;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult FaturaDetay(int id)
        {
            var degerler = c.FaturaKalems.Where(x => x.FaturaID == id).ToList();
            var ftr = c.Faturalars.Where(x => x.FaturaID == id).Select(y => y.FaturaID).FirstOrDefault();
            ViewBag.ftr = ftr;
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniKalem(int id)
        {

            return View();
        }

        [HttpPost]
        public ActionResult YeniKalem(FaturaKalem fk)
        {
            c.FaturaKalems.Add(fk);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Dinamik()
        {
            Class3 cs = new Class3();
            cs.deger1 = c.Faturalars.ToList();
            cs.deger2 = c.FaturaKalems.ToList();
            return View(cs);
        }

    }
}