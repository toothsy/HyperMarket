using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblFaq")]
    public class Faq
    {
        [Key]
        public int FaqId { get; set; }
        public string FaqTitle { get; set; }
        public string FaqSolution { get; set; }

        [ForeignKey("tblUser")]
        public int UserId { get; set; }
        public User User { get; set; }
        public int CreatedById { get; set; }
        public int UpdatedById { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}