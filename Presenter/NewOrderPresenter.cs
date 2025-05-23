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

    private List<OrderItemDTO> _items = new();

    public NewOrderPresenter(INewOrderView newOrderView, IOrdersService ordersService, ICustomersService customersService, IProductsService productsService)
    {
        _newOrderView = newOrderView ?? throw new ArgumentNullException(nameof(newOrderView));
        _ordersService = ordersService ?? throw new ArgumentNullException(nameof(ordersService));
        _customersService = customersService ?? throw new ArgumentNullException(nameof(customersService));
        _productsService = productsService ?? throw new ArgumentNullException(nameof(productsService));

        _newOrderView.ViewLoaded += NewOrderView_ViewLoaded;
        _newOrderView.OrderItemAdded += NewOrderView_OrderItemAdded;
        _newOrderView.OrderItemDeleted += NewOrderView_OrderItemDeleted;
        _newOrderView.BtnAddOrderClicked += NewOrderView_BtnAddOrderClicked;
    }

    private void NewOrderView_OrderItemAdded(object? sender, OrderItemEventArgs e)
    {

        //var orderItem = CreateOrderItem(e.OrderItemDTO);


        //var orderItem = 
        //var product = e.Product as Product ??
        //    throw new InvalidOperationException($"Невозможно привести {e.Product} к типу {nameof(Product)}");

        _newOrderView.AddOrderItem(e.OrderItemDTO);
        _items.Add(e.OrderItemDTO);
    }

    private void NewOrderView_OrderItemDeleted(object? sender, OrderItemEventArgs e)
    {
        _items.Remove(e.OrderItemDTO);
    }

    private void NewOrderView_BtnAddOrderClicked(object? sender, AddOrderEventArgs e)
    {
        List<OrderItem> createdItems = new();

        foreach (var item in _items)
        {
            var orderItem = CreateOrderItem(item);
            createdItems.Add(orderItem);
        }

        var customer = _customersService.GetCustomerById(e.Customer.Id);
        _ordersService.CreateOrder(customer, createdItems, e.Date);

        OrderItem CreateOrderItem(OrderItemDTO orderItemDTO) => new()
        {
            Id = orderItemDTO.Id,
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

    //private OrderItem CreateOrderItem(OrderItemDTO orderItemDTO) => new()
    //{
    //    OrderId = orderItemDTO.Id,
    //    ProductId = orderItemDTO.ProductId,
    //    Count = orderItemDTO.Count
    //};
}
