using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCOnlineTicariOtomasyon.Models.Sınıflar
{
    public class Urun
    {
        [Key]
        [Display(Name = "Urun ID")]
        public int UrunID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter kullanabilirsiniz!")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        [Display(Name = "Ürün Adı")]
        public string UrunAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter kullanabilirsiniz!")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string Marka { get; set; }
        public short Stok { get; set; }
        [Display(Name = "Alış Fiyat")]
        public decimal AlisFiyat { get; set; }
        [Display(Name = "Satış Fiyat")]
        public decimal SatisFiyat { get; set; }
        public bool Durum { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250, ErrorMessage = "En fazla 250 karakter kullanabilirsiniz!")]
        [Display(Name = "Ürün Görsel")]
        public string UrunGorsel { get; set; }
        public int KategoriID { get; set; }
        public virtual Kategori Kategori { get; set; }

        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}