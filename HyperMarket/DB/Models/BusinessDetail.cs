﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblBusinessDetail")]
    public class BusinessDetail
    {
        [Key]
        [ForeignKey("tblUser")]
        public string UserId { get; set; }
        public string BusinessName { get; set; }

        [ForeignKey("tblCategory")]
        public string CategoryId { get; set; }

        public string BusinessDescription { get; set; }
        public bool TopBrands { get; set; }
        public int ProductsSold { get; set; }

        [ForeignKey("tblLocation")]
        public string LocationId { get; set; }
        
    }
}
