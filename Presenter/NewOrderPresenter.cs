using Model.Data;
using Model.Services.Base;
using View.Base;

namespace Presenter;

public class NewOrderPresenter
{
    private readonly INewOrderView _newOrderView;
    private readonly IOrdersService _ordersService;
    private readonly ICustomersService _customersService;
    private readonly IProductsService _productsService;

    public NewOrderPresenter(INewOrderView newOrderView, IOrdersService ordersService, ICustomersService customersService, IProductsService productsService)
    {
        _newOrderView = newOrderView ?? throw new ArgumentNullException(nameof(newOrderView));
        _ordersService = ordersService ?? throw new ArgumentNullException(nameof(ordersService));
        _customersService = customersService ?? throw new ArgumentNullException(nameof(customersService));
        _productsService = productsService ?? throw new ArgumentNullException(nameof(productsService));

        _newOrderView.ViewLoaded += NewOrderView_ViewLoaded;
        _newOrderView.BtnAddOrderClicked += NewOrderView_BtnAddOrderClicked;
    }

    private void NewOrderView_BtnAddOrderClicked(object? sender, View.ViewEventArgs.AddOrderEventArgs e)
    {
        var selectedCustomer = e.Customer as Customer;

        if (selectedCustomer is null) throw new ArgumentNullException(nameof(selectedCustomer));

        var customer = _customersService.GetCustomer(selectedCustomer.Id);
        _ordersService.CreateOrder(customer, e.Products.Cast<Product>().ToList(), e.Date);
    }

    private void NewOrderView_ViewLoaded(object? sender, EventArgs e)
    {
        var customers = _customersService.GetCustomers();
        var products = _productsService.GetProducts();

        _newOrderView.UpdateView(customers, products);
    }
}
