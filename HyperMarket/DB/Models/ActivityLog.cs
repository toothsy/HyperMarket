using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
