using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblProduct")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string CategoryId { get; set; }
        public string SubCategoryId { get; set; }
        public bool Image { get; set; }
        public int Discount { get; set; }
        public int Price { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public int Pin { get; set; }
        [ForeignKey("tblUser")]
        public int UserId { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
