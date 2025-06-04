using System.ComponentModel.DataAnnotations;

namespace Model.Entites;

public class Customer
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Age { get; set; }

    public List<Order> Orders { get; set; } = new();
}
