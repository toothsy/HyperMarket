using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblActivityLog")]
    public class ActivityLog
    {
        [Key]
        public int ActivityId { get; set; }
        public string Description { get; set; }
        public string UrlOrModule { get; set; }
        public DateTime ActivityTimeStamp { get; set; }

        [ForeignKey("tblUser")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
