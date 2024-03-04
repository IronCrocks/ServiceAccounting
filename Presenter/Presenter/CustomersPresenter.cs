using ServiceAccounting.Model.Services.Base;
using ServiceAccounting.View.Base;
using ServiceAccounting.View.ViewEventArgs;
using System;

namespace ServiceAccounting.Presenter;

public class CustomersPresenter
{
    ICustomersView _customersView;
    ICustomersService _customersService;

    public CustomersPresenter(ICustomersView customersView, ICustomersService customersService)
    {
        _customersView = customersView ?? throw new ArgumentNullException(nameof(customersView));
        _customersService = customersService ?? throw new ArgumentNullException(nameof(customersService));

        _customersView.ViewLoaded += CustomersView_ViewLoaded;
        _customersView.btnAddCustomerClicked += CustomersView_btnAddCustomerClicked;
    }

    private void CustomersView_btnAddCustomerClicked(object? sender, BtnAddCustomerClickedEventArgs e)
    {
        _customersService.AddCustomer(e);
        UpdateViewData();
    }


    private void CustomersView_ViewLoaded(object sender, EventArgs e)
    {
        UpdateViewData();
    }

    private void UpdateViewData()
    {
        var data = _customersService.GetCustomers();
        _customersView.UpdateView(data);
    }
}

