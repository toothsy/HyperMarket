using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblOrder")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey("tblUser")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("tblBusinessDetail")]
        public int BusinessDetailId { get; set; }
        public BusinessDetail BusinessDetail { get; set; }
        [ForeignKey("tblProduct")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int MyOrderCredits { get; set; }

        [ForeignKey("tblPayment")]
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
