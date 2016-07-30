using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PipiShop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [MaxLength(250)]
        public string Description { set; get; }

        [Required]
        [MaxLength(500)]
        public string Image { set; get; }

        [Required]
        [MaxLength(500)]
        public string URL { set; get; }

        public int? DisplayOrer { set; get; }

        public bool Status { set; get; }
    }
}