using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblActivityType")]
    public class ActivityType
    {
        [Key]
        public int ActivityTypeId { get; set; }

        public string ActivityTypeName { get; set; }

        public string Description { get; set; }

    }
}
