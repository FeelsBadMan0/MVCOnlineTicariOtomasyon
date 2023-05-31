using MVCOnlineTicariOtomasyon.Models.Sınıflar;
using System.Linq;
using System.Web.Mvc;
namespace MVCOnlineTicariOtomasyon.Controllers
{
    [Authorize]
    public class DepartmanController : Controller
    {
        Context c = new Context();
        // GET: Departman
        public ActionResult Index()
        {
            var degerler = c.Depatmans.Where(x => x.Durum == true).ToList();
            return View(degerler);
        }
        [Authorize(Roles = "A")]
        [HttpGet]
        public ActionResult DepartmanEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DepartmanEkle(Departman d)
        {
            if (!ModelState.IsValid)
            {
                return View("DepartmanEkle");
            }
            d.Durum = true;
            c.Depatmans.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DepartmanSil(int id)
        {
            var dprt = c.Depatmans.Find(id);
            dprt.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DepartmanGetir(int id)
        {
            var dgr = c.Depatmans.Find(id);
            return View("DepartmanGetir", dgr);
        }

        public ActionResult DepartmanGuncelle(Departman d)
        {
            if (!ModelState.IsValid)
            {
                return View("DepartmanGetir");
            }
            var dept = c.Depatmans.Find(d.DepartmanID);
            dept.DepartmanAd = d.DepartmanAd;
            dept.Durum = true;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DepartmanDetay(int id)
        {
            var degerler = c.Personels.Where(x => x.DepartmanID == id).ToList();
            var dpt = c.Depatmans.Where(x => x.DepartmanID == id).Select(y => y.DepartmanAd).FirstOrDefault();
            ViewBag.dpt = dpt;
            return View(degerler);
        }

        public ActionResult DepartmanPersonelSatis(int id)
        {
            var degerler = c.SatisHarekets.Where(x => x.PersonelID == id).ToList();
            var pers = c.Personels.Where(x => x.PersonelID == id).Select(y => y.PersonelAd + " " + y.PersonelSoyad).FirstOrDefault();
            ViewBag.Pers = pers;
            return View(degerler);
        }
    }
}