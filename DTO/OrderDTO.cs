using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO;

public class OrderDTO
{
    public string CustomerName { get; set; } = string.Empty;
    public string productName { get; set; } = string.Empty;
    public int Count { get; set; }
    public int Price { get; set; }
    public DateTime Date { get; set; }
}
