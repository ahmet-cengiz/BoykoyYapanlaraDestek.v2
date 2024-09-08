using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoykoyYapanlaraDestek.v2.Mvc.Models
{
    public class SiteZiyaretcisi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "IP Adresi")]
        public string IPAdresi { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Tıklama Zamanı")]
        public DateTime GirisTarihi { get; set; } = DateTime.Now;

        [Required]
        [StringLength(50)]
        [Display(Name = "Tıklanan Sayfa")]
        public string GirdigiSayfa { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        [Display(Name = "User Agent")]
        public string ZiyaretciArayuzu { get; set; } = string.Empty;
    }
}
