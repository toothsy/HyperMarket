using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblUserRole")]
    public class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }

        [ForeignKey("tblUser")]
        public int UserId { get; set; }

        [ForeignKey("tblRoles")]
        public int RoleId { get; set; }

    }
}
