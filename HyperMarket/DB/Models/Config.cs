using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblConfig")]
    public class Config
    {
        [Key]
        public int ConfigId { get; set; }
        public string ConfigName { get; set; }
        public string Description { get; set; }
        public int ConfigValue { get; set; }

        [ForeignKey("tblUser")]
        public int UserId { get; set; }
        public User User { get; set; }
        public int CreatedById { get; set; }
        public int UpdatedById { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }

        public string InstaHandle { get; set; }
        public string FaceBookHandle { get; set; }
        public string TwitterHandle { get; set; }
        public string YouTubeHandle { get; set; }
        public string TelephoneId{ get; set; }
        public string EmailId{ get; set; }
    }
}
