using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblSubCategory")]
    public class SubCategory
    {
        [Key]
        public string SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }

        [ForeignKey("tblCategory")]
        public string CategoryId { get; set; }
    }
}
