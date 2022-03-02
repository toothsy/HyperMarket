using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblCategory")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Commission { get; set; }

    }
}
