using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerOrderManagmentSystem.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        [MaxLength(150)]
        public string OrderTitle { get; set; }
        [MaxLength(500)]
        public string? OrderDescription { get; set; }


        public string OrderStatus { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }



    }
}
