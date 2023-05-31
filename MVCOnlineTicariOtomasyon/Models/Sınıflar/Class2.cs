using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCOnlineTicariOtomasyon.Models.Sınıflar
{
    public class Class2
    {
        public IEnumerable<SelectListItem> Kategoriler { get; set; }
        public IEnumerable<SelectListItem> Urunler { get; set; }
    }
}