using System.ComponentModel;

namespace DTO;

public class OrderItemDTO
{
    [Browsable(false)]
    public int Id { get; set; }

    [Browsable(false)]
    public int ProductId { get; set; }

    [ReadOnly(true)]
    public string Name { get; set; } = string.Empty;

    [ReadOnly(true)]
    public string Description { get; set; } = string.Empty;

    [ReadOnly(true)]
    public int Price { get; set; }

    public int Count { get; set; }
}
