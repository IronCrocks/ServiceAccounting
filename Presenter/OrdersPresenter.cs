using Model.Services.Base;
using View.Base;

namespace Presenter;

public class OrdersPresenter
{
    IOrdersView _ordersView;
    IOrdersService _ordersService;

    public OrdersPresenter(IOrdersView ordersView, IOrdersService ordersService)
    {
        _ordersView = ordersView ?? throw new ArgumentNullException(nameof(ordersView));
        _ordersService = ordersService ?? throw new ArgumentNullException(nameof(ordersService));

        _ordersView.ViewLoaded += OrdersView_ViewLoaded;
        _ordersView.btnAddCustomerClicked += OrdersView_btnAddCustomerClicked;
    }

    private void OrdersView_btnAddCustomerClicked(object? sender, EventArgs e)
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
        _ordersView.UpdateView(orders);
    }
}

