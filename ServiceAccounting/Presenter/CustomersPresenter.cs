using System;
namespace ServiceAccounting.Presenter;

public class CustomersPresenter
{
    ICustomersView _customersView;
    ICustomersService _customersService;

    public CustomersPresenter(ICustomersView customersView, ICustomersService customersService)
    {
        _customersView = customersView;
        _customersService = customersService;
    }

}

