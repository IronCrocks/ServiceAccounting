using DTO;
using Model.Data;
using Model.Services.Base;
using Presenter.Base;
using System.ComponentModel;
using View.Base;
using View.ViewEventArgs;

namespace Presenter;

public class ProductsPresenter : IProductsPresenter
{
    private readonly IProductsView _productsView;
    private readonly IProductsService _productsService;

    public ProductsPresenter(IProductsView productsView, IProductsService productsService)
    {
        _productsView = productsView ?? throw new ArgumentNullException(nameof(productsView));
        _productsService = productsService ?? throw new ArgumentNullException(nameof(productsService));

        _productsView.ViewLoaded += ProductsView_ViewLoaded;
        _productsView.ProductAdded += ProductsView_ProductAdded;
        _productsView.ProductChanged += ProductsView_ProductChanged;
        _productsView.ProductDeleted += ProductsView_ProductDeleted;
    }

    private void ProductsView_ProductAdded(object? sender, ProductEventArgs e)
    {
        var product = CreateProduct(e.ProductDTO);
        int productId = _productsService.AddProduct(product);
        e.ProductDTO.Id = productId;
    }

    private void ProductsView_ProductChanged(object? sender, ProductEventArgs e)
    {
        var product = _productsService.GetProductById(e.ProductDTO.Id);
        if (product is null) throw new ArgumentNullException(nameof(product));

        product.Name = e.ProductDTO.Name;
        product.Description = e.ProductDTO.Description;
        product.Price = e.ProductDTO.Price;
        _productsService.UpdateProduct(product);
    }

    private void ProductsView_ProductDeleted(object? sender, ProductEventArgs e)
    {
        var product = _productsService.GetProductById(e.ProductDTO.Id);
        if (product is null) throw new ArgumentNullException(nameof(product));
        _productsService.RemoveProduct(product);
    }

    private void ProductsView_ViewLoaded(object? sender, EventArgs e)
    {
        var products = _productsService.GetProducts();
        var productsDTO = products.Select(p => new ProductDTO
        {
            Id = p.Id,
            Description = p.Description,
            Name = p.Name,
            Price = p.Price
        }).ToList();

        var bindingList = new BindingList<ProductDTO>(productsDTO);
        _productsView.LoadData(productsDTO);
    }

    private Product CreateProduct(ProductDTO productDTO) => new()
    {
        Id = productDTO.Id,
        Name = productDTO.Name,
        Description = productDTO.Description,
        Price = productDTO.Price
    };
}

