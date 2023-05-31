using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCOnlineTicariOtomasyon.Models.Sınıflar
{
    public class FaturaKalem
    {
        [Key]
        [Display(Name = "Fatura Kalem ID")]
        public int FaturaKalemID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100, ErrorMessage = "En fazla 30 karakter kullanabilirsiniz!")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }
        public int Miktar { get; set; }
        [Display(Name = "Birim Fiyat")]
        public decimal BirimFiyat { get; set; }
        public decimal Tutar { get; set; }

        [Display(Name = "Fatura ID")]
        public int FaturaID { get; set; }
        public virtual Faturalar Faturalar { get; set; }
    }
}