using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblBusinessDetail")]
    public class BusinessDetail
    {
        [Key]
        public int BusinessId { get; set; }
        [ForeignKey("tblUser")]
        public int UserId { get; set; }
        public User User { get; set; }
        public string BusinessName { get; set; }

        public string BusinessDescription { get; set; }
        public bool TopBrands { get; set; }
        public int ProductsSold { get; set; }

        [ForeignKey("tblLocation")]
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public string Logo { get; set; }
        
    }
}
