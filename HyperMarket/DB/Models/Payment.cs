using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblPayment")]
   public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public int CreditsUsed { get; set; }
        public int Price { get; set; }
    }
}
