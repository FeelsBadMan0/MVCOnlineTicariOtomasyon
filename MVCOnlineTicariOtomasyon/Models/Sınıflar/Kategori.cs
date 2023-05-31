using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCOnlineTicariOtomasyon.Models.Sınıflar
{
    public class Kategori
    {
        [Key]
        [Display(Name = "Kategori ID")]
        public int KategoriID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter kullanabilirsiniz!")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        [Display(Name = "Kategori Adı")]
        public string KategoriAd { get; set; }
        public bool Durum { get; set; }
        public ICollection<Urun> Uruns { get; set; }
    }
}