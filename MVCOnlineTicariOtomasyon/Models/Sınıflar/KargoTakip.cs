using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCOnlineTicariOtomasyon.Models.Sınıflar
{
    public class KargoTakip
    {
        [Key]
        public int KargoTakipID { get; set; }
        [Display(Name = "Takip Kodu")]
        [Column(TypeName = "Varchar")]
        [StringLength(10, ErrorMessage = "En fazla 10 karakter kullanabilirsiniz!")]
        public string TakipKodu { get; set; }
        [Display(Name = "Açıklama")]
        [Column(TypeName = "Varchar")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter kullanabilirsiniz!")]
        public string Aciklama { get; set; }
        public DateTime TarihZaman { get; set; }
    }
}