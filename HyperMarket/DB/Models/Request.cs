using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblRequest")]
    public class Request
    {
        [Key]
        public int RequestId { get; set; }

        [ForeignKey("tblProducts")]
        public int ProductsId { get; set; }

        [ForeignKey("tblUser")]
        public int UserId { get; set; }
    }
}