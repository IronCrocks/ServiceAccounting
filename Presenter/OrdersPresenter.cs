using AutoMapper;
using DTO;
using Model.Services.Base;
using Presenter.Base;
using View.Base;

namespace Presenter;

public class OrdersPresenter : IOrdersPresenter
{
    private readonly IOrdersView _ordersView;
    private readonly IOrdersService _ordersService;
    private readonly IMapper _mapper;

    public OrdersPresenter(IOrdersView ordersView, IOrdersService ordersService, IMapper mapper)
    {
        _ordersView = ordersView ?? throw new ArgumentNullException(nameof(ordersView));
        _ordersService = ordersService ?? throw new ArgumentNullException(nameof(ordersService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _ordersView.ViewLoaded += OrdersView_ViewLoaded;
        _ordersView.btnAddOrderClicked += OrdersView_btnAddOrderClicked;
    }

    private void OrdersView_btnAddOrderClicked(object? sender, EventArgs e)
    {
        UpdateViewData();
    }

    private void OrdersView_ViewLoaded(object? sender, EventArgs e)
    {
        UpdateViewData();
    }

    private void UpdateViewData()
    {
        var orders = _ordersService.GetOrders();
        var ordersDTO = orders.Select(_mapper.Map<OrderDTO>).ToList();
        _ordersView.UpdateView(ordersDTO);
    }
}
