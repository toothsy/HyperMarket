using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperMarket.ViewModels
{
    public class AddProductModel
    {
        [Required,StringLength(30, ErrorMessage = "Product name must be atleast 2 characters long.", MinimumLength = 2)]
        public string ProductName{ get; set; }
        public string ProductDescription{ get; set; }
        [Required]
        public int CategoryId{ get; set; }
        [Required]
        public int SubCategoryId { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Discount { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        [Required]
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        [Required]
        public int Pin { get; set; }
    }
}
