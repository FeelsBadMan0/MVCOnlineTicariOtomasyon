using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCOnlineTicariOtomasyon.Models.Sınıflar
{
    public class KargoDetay
    {
        [Key]
        public int KargoDetayID { get; set; }
        [Display(Name = "Açıklama")]
        [Column(TypeName = "Varchar")]
        [StringLength(300, ErrorMessage = "En fazla 300 karakter kullanabilirsiniz!")]
        public string Aciklama { get; set; }
        [Display(Name = "Takip Kodu")]
        [Column(TypeName = "Varchar")]
        [StringLength(10, ErrorMessage = "En fazla 10 karakter kullanabilirsiniz!")]
        public string TakipKodu { get; set; }
        [Display(Name = "Personel Adı")]
        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "En fazla 20 karakter kullanabilirsiniz!")]
        public string Personel { get; set; }
        [Display(Name = "Alıcı Adı")]
        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "En fazla 20 karakter kullanabilirsiniz!")]
        public string Alici { get; set; }
        public DateTime Tarih { get; set; }
    }
}