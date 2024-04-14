using Model.Services.Base;
using View.Base;

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
        _productsView.RowDeleted += ProductsView_RowDeleted;
    }

    private void ProductsView_ViewLoaded(object? sender, EventArgs e)
    {
        var data = _productsService.Load();
        _productsView.UpdateView(data);
    }

    private void ProductsView_RowDeleted(object? sender, EventArgs e)
    {
        _productsService.SaveChanges();
    }

    private void ProductsView_RowUpdated(object? sender, EventArgs e)
    {
        _productsService.SaveChanges();
    }
}

