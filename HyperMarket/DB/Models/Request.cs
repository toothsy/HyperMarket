using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblRequest")]
    public class Request
    {
        [Key]
        public int RequestId { get; set; }

        [ForeignKey("tblProduct")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("tblUser")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}