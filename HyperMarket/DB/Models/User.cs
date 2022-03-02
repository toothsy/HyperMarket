﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblUser")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string ReferredBy { get; set; }
        public long UserName { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int RoleId { get; set; }
    }
}