using System.ComponentModel.DataAnnotations;

namespace Model.Data;

public class Order
{
    public int Id { get; set; }
    [Required]
    public string Number { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;

    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public Customer? Customer { get; set; }
    public int CustomerId { get; set; }
}
