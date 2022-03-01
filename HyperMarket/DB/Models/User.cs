using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket.DB.Models
{
    [Table("tblUser")]
    public class User
    {
        [Key]
        public Int32 UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Int64 MobileNumber { get; set; }
        public string Address { get; set; }
    }
}
