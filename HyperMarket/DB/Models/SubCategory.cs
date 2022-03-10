using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblSubCategory")]
    public class SubCategory
    {
        [Key]
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }

        [ForeignKey("tblCategory")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
