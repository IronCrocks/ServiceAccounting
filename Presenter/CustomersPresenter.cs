using Model.Services.Base;
using View.Base;
using View.ViewEventArgs;

namespace Presenter;

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

    private void CustomersView_btnAddCustomerClicked(object? sender, AddCustomerEventArgs e)
    {
        _customersService.AddCustomer(e.Name, e.Age);
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

