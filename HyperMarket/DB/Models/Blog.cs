using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HyperMarket.DB.Models
{
    [Table("tblBlog")]
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogAuthor { get; set; }

        [ForeignKey("tblUser")]
        public int UserId { get; set; }
        public User User { get; set; }
        public int CreatedById { get; set; }
        public int UpdatedById { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}

