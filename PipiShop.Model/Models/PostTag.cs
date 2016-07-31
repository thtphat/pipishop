using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PipiShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Column(Order = 1)]
        public int PostID { set; get; }

        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar", Order = 2)]
        public string TagID { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tags { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Posts { set; get; }
    }
}