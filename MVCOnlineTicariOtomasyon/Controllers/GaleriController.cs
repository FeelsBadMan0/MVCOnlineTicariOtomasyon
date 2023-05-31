using MVCOnlineTicariOtomasyon.Models.Sınıflar;
using System.Linq;
using System.Web.Mvc;
namespace MVCOnlineTicariOtomasyon.Controllers
{
    public class GaleriController : Controller
    {
        Context c = new Context();
        // GET: Galeri
        public ActionResult Index()
        {
            var degerler = c.Uruns.ToList();
            return View(degerler);
        }
    }
}