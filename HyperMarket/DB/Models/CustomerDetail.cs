using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblCutomerDetail")]
    public class CustomerDetail
    {
        [Key]
        public int CustomerId { get; set; }
        [ForeignKey("tblUser")]
        public int UserId { get; set; }
        public User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ReferralCode { get; set; }
        public int MyCredits { get; set; }
    }
}
