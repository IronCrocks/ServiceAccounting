using ServiceAccounting.Model.Services.Base;
using ServiceAccounting.View.Base;

namespace ServiceAccounting.Presenter;

public class OrdersPresenter
{
    IOrdersView _ordersView;
    IOrdersService _ordersService;

    public OrdersPresenter(IOrdersView ordersView, IOrdersService ordersService)
    {
        _ordersView = ordersView ?? throw new System.ArgumentNullException(nameof(ordersView));
        _ordersService = ordersService ?? throw new System.ArgumentNullException(nameof(ordersService));

        _ordersView.ViewLoaded += OrdersView_ViewLoaded;
        _ordersView.btnAddCustomerClicked += OrdersView_btnAddCustomerClicked;
    }

    private void OrdersView_btnAddCustomerClicked(object? sender, System.EventArgs e)
    {
        UpdateViewData();
    }

    private void OrdersView_ViewLoaded(object? sender, System.EventArgs e)
    {
        UpdateViewData();
    }

    private void UpdateViewData()
    {
        var orders = _ordersService.GetOrders();
        _ordersView.UpdateView(orders);
    }
}

