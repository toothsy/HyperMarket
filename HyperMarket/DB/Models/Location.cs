using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblLocation")]
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public bool IsLocationActive { get; set; }

    }
}