using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PipiShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductID { set; get; }

        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string TagID { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tags { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }
    }
}