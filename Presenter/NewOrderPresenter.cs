using DTO;
using Model.Data;
using Model.Services.Base;
using Presenter.Base;
using View.Base;
using View.ViewEventArgs;

namespace Presenter;

public class NewOrderPresenter : INewOrderPresenter
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

    private void NewOrderView_BtnAddOrderClicked(object? sender, AddOrderEventArgs e)
    {
        List<OrderItem> orderItems = new();

        foreach (var item in _newOrderView.GetOrderItems())
        {
            var orderItem = CreateOrderItem(item);
            orderItems.Add(orderItem);
        }

        var customer = _customersService.GetCustomerById(e.Customer.Id);
        _ordersService.CreateOrder(customer, orderItems, e.Date);

        OrderItem CreateOrderItem(OrderItemDTO orderItemDTO) => new()
        {
            Count = orderItemDTO.Count,
            ProductId = orderItemDTO.ProductId
        };
    }

    private void NewOrderView_ViewLoaded(object? sender, EventArgs e)
    {
        var customers = _customersService.GetCustomers();
        var products = _productsService.GetProducts();

        var customersDTO = customers.Select(p => new CustomerDTO
        {
            Id = p.Id,
            Name = p.Name,
            Age = p.Age
        }).ToList();

        var productsDTO = products.Select(p => new ProductDTO
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Price = p.Price
        }).ToList();

        _newOrderView.LoadData(customersDTO, productsDTO);
    }
}
