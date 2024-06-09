using DTO;
using System;
using System.Collections.Generic;
using View.ViewEventArgs;

namespace View.Base;

public interface IProductsView : IView
{
    event EventHandler<ProductEventArgs> ProductAdded;
    event EventHandler<ProductEventArgs> ProductChanged;
    event EventHandler<ProductEventArgs> ProductDeleted;

    public void LoadData(IEnumerable<ProductDTO> products);
    public void Load();
}
