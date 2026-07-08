using System.ComponentModel.DataAnnotations;

namespace CustomerOrderManagmentSystem.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        public string PaymentName { get; set; }
    }
}
