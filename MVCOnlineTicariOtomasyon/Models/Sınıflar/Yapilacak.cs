using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCOnlineTicariOtomasyon.Models.Sınıflar
{
    public class Yapilacak
    {
        [Key]
        public int YapilacakID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(150)]
        [Display(Name = "Başlık")]
        public string Baslik { get; set; }
        [Column(TypeName = "bit")]
        public bool Durum { get; set; }

    }
}