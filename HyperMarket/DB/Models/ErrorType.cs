using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperMarket.DB.Models
{
    [Table("tblErrorType")]
    public class ErrorType
    {
        [Key]
        public int ErrorTypeId { get; set; }

        public string ErrorTypeName { get; set; }

        public string Description { get; set; }
    }
}
