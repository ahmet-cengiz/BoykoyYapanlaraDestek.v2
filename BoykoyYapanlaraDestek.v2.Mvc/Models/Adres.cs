using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoykoyYapanlaraDestek.v2.Mvc.Models
{
    public class Adres
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "İşletme Adı")]
        public string Adi { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        [Display(Name = "İşletme Türü")]
        public string Turu { get; set; } = string.Empty;

        [Required]
        [StringLength(300)]
        [Display(Name = "İşletme Adresi")]
        public string Adresi { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        [Display(Name = "İl")]
        public string Il { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        [Display(Name = "İlçe")]
        public string Ilce { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        [Display(Name = "Telefon Numarası")]
        public string TelefonNumarasi { get; set; } = string.Empty;

        [Required]
        [Display(Name = "CocaCola Yok")]
        public bool CocaColaYok { get; set; } = true;

        [Required]
        [Display(Name = "Algida Yok")]
        public bool AlgidaYok { get; set; } = true;

        [Required]
        [Display(Name = "Map Src")]
        public string MapSrc { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Enlem")]
        public string Enlem { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Boylam")]
        public string Boylam { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Oluşturma Zamanı")]
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    }
}
