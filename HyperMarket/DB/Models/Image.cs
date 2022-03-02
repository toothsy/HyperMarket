using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblImage")]
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        public string ImageLink { get; set; }

        [ForeignKey("tblProducts")]
        public int Product_Id { get; set; }
    }
}