using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblRole")]
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        public string RoleName { get; set; }
    }
}
