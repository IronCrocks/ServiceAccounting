using DevExpress.Xpo;
using Model.Data;
using Model.Services.Base;
using View.Base;
using View.ViewEventArgs;

namespace Presenter;

public class ProductsPresenter : IPresenter
{
    private readonly IProductsView _productsView;
    private readonly IProductsService _productsService;

    public ProductsPresenter(IProductsView productsView, IProductsService productsService)
    {
        _productsView = productsView ?? throw new ArgumentNullException(nameof(productsView));
        _productsService = productsService ?? throw new ArgumentNullException(nameof(productsService));

        _productsView.ViewLoaded += ProductsView_ViewLoaded;
        _productsView.RowUpdated += ProductsView_RowUpdated;
        _productsView.RowRemoved += ProductsView_RowRemoved;
        _productsView.RowInserted += ProductsView_RowInserted;
    }

    private void ProductsView_RowInserted(object? sender, EventArgs e)
    {
        var product = _productsService.AddDefaultProduct();
        _productsView.Products.Add(product);
        _productsView.UpdateView();
    }

    private void ProductsView_ViewLoaded(object? sender, EventArgs e)
    {
        var data = _productsService.GetProducts();
        _productsView.LoadData(data);
    }

    private void ProductsView_RowRemoved(object? sender, RowRemovedEventArgs e)
    {
        _productsService.RemoveProduct(e.Index);
    }

    private void ProductsView_RowUpdated(object? sender, ObjectUpdatedEventArgs e)
    {
        var changedProduct = e.UpdatedObject as Product;
        _productsService.ChangeProduct(changedProduct);
    }
}

