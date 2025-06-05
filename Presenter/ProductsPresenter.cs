using AutoMapper;
using DTO;
using Model.Entites;
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
    private readonly IMapper _mapper;

    public ProductsPresenter(IProductsView productsView, IProductsService productsService, IMapper mapper)
    {
        _productsView = productsView ?? throw new ArgumentNullException(nameof(productsView));
        _productsService = productsService ?? throw new ArgumentNullException(nameof(productsService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        _productsView.ViewLoaded += ProductsView_ViewLoaded;
        _productsView.ProductAdded += ProductsView_ProductAdded;
        _productsView.ProductChanged += ProductsView_ProductChanged;
        _productsView.ProductDeleted += ProductsView_ProductDeleted;
    }

    private void ProductsView_ProductAdded(object? sender, ProductEventArgs e)
    {
        var product = _mapper.Map<Product>(e.ProductDTO);
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
        LoadViewData();
    }

    private void LoadViewData()
    {
        var products = _productsService.GetProducts();
        var productsDTO = products.Select(_mapper.Map<ProductDTO>).ToList();
        var bindingList = new BindingList<ProductDTO>(productsDTO);
        _productsView.LoadData(productsDTO);
    }
}

