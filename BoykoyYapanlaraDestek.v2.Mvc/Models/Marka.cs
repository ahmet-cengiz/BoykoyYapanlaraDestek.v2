using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoykoyYapanlaraDestek.v2.Mvc.Models
{
    public class Marka
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Adı")]
        public string Adi { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        [Display(Name = "Fotoğraf Path")]
        public string ResimYolu { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Oluşturma Zamanı")]
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    }
}
