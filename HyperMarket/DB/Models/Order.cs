using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblOrder")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("tblBusinessDetail")]
        public string BusinessName { get; set; }

        [ForeignKey("tblProduct")]
        public string ProductId { get; set; }
        public string MyOrderCredits { get; set; }

        [ForeignKey("tblPayment")]
        public string PaymentId { get; set; }

        [ForeignKey("tblUser")]
        public string UderId { get; set; }
    }
}
