using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblErrorLog")]
    public class ErrorLog
    {
        [Key]
        public int ErrorId { get; set; }
        public string Description { get; set; }
        public string UrlOrModule { get; set; }
        public DateTime ErrorTimeStamp { get; set; }

        [ForeignKey("tblUser")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("tblErrorType")]
        public int ErrorTypeId { get; set; }

        public bool IsResolved { get; set; }

    }
}
