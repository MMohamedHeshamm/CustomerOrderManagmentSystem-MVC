
using System.ComponentModel.DataAnnotations;

namespace CustomerOrderManagmentSystem.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(100)]
        public string CustomerEmail { get; set; }


        public string? CustomerPhone { get; set; }

        [Required]
        public string CustomerPassword { get; set; }


        public List<Order> Orders { get; set; }

    }
}
