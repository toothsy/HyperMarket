using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblCutomerDetail")]
    public class CustomerDetail
    {
        public string ReferalCode { get; set; }
        public int MyCredits { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Key]
        [ForeignKey("tblUser")]
        public int UserId { get; set; }
    }
}
