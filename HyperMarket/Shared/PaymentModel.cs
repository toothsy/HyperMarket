using System.ComponentModel.DataAnnotations;


namespace HyperMarket.ViewModels
{
    public class PaymentModel
    {
        [Required]
        public string PaymentType { get; set; }
        public int CreditsUsed { get; set; }
        public int Price { get; set; }
    }
}
