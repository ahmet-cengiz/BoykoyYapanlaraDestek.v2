using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoykoyYapanlaraDestek.v2.Mvc.Models
{
    public class Duyuru
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Duyuru Metni")]
        public string DuyuruMetni { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Oluşturma Zamanı")]
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    }
}
