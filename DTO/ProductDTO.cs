using System.ComponentModel;

namespace DTO;

public class ProductDTO
{
    [Browsable(false)]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Price { get; set; }
}
