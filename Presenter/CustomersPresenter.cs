using DTO;
using Model.Data;
using Model.Services.Base;
using Presenter.Base;
using System.ComponentModel;
using View.Base;
using View.ViewEventArgs;

namespace Presenter;

public class CustomersPresenter : ICustomersPresenter
{
    private readonly ICustomersView _customersView;
    private readonly ICustomersService _customersService;

    public CustomersPresenter(ICustomersView customersView, ICustomersService customersService)
    {
        _customersView = customersView ?? throw new ArgumentNullException(nameof(customersView));
        _customersService = customersService ?? throw new ArgumentNullException(nameof(customersService));

        _customersView.ViewLoaded += CustomersView_ViewLoaded;
        _customersView.CustomerAdded += CustomersView_CustomerAdded;
        _customersView.CustomerDeleted += CustomersView_CustomerDeleted;
        _customersView.CustomerChanged += CustomersView_CustomerChanged;
    }

    private void CustomersView_CustomerAdded(object? sender, CustomerEventArgs e)
    {
        var customer = CreateCustomer(e.Customer);
        int customerId = _customersService.AddCustomer(customer);
        e.Customer.Id = customerId;
    }

    private void CustomersView_CustomerDeleted(object? sender, CustomerEventArgs e)
    {
        var customer = _customersService.GetCustomerById(e.Customer.Id);
        _customersService.DeleteCustomer(customer);
    }

    private void CustomersView_CustomerChanged(object? sender, CustomerEventArgs e)
    {
        var customer = _customersService.GetCustomerById(e.Customer.Id);
        customer.Name = e.Customer.Name;
        customer.Age = e.Customer.Age;
        _customersService.UpdateCustomer(customer);
    }

    private void CustomersView_ViewLoaded(object sender, EventArgs e)
    {
        LoadViewData();
    }

    private void LoadViewData()
    {
        var customers = _customersService.GetCustomers();
        var customersDTO = customers.Select(x => new CustomerDTO { Id = x.Id, Name = x.Name, Age = x.Age, TotalSum = x.TotalSum }).ToList();
        var bindingList = new BindingList<CustomerDTO>(customersDTO);
        _customersView.LoadCustomers(bindingList);
    }

    private Customer CreateCustomer(CustomerDTO customerDTO) => new()
    {
        Id = customerDTO.Id,
        Name = customerDTO.Name,
        Age = customerDTO.Age
    };
}

