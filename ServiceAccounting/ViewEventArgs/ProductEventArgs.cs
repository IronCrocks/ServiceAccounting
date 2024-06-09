using DTO;
using System;

namespace View.ViewEventArgs;

public class ProductEventArgs : EventArgs
{
    public ProductEventArgs(ProductDTO productDTO)
    {
        ProductDTO = productDTO ?? throw new ArgumentNullException(nameof(productDTO));
    }

    public ProductDTO ProductDTO { get; }
}
