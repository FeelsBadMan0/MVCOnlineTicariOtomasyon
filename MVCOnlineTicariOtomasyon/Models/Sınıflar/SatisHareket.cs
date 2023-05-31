using System;
using System.ComponentModel.DataAnnotations;

namespace MVCOnlineTicariOtomasyon.Models.Sınıflar
{
    public class SatisHareket
    {
        [Key]
        [Display(Name = "Satış ID")]
        public int SatisID { get; set; }
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        [Display(Name = "Toplam Tutar")]
        public decimal ToplamTutar { get; set; }
        [Display(Name = "Ürün")]
        public int UrunID { get; set; }
        [Display(Name = "Cari")]
        public int CariID { get; set; }
        [Display(Name = "Personel")]
        public int PersonelID { get; set; }
        public virtual Urun Urun { get; set; }
        public virtual Cariler Cariler { get; set; }
        public virtual Personel Personel { get; set; }

    }
}