using AutoMapper;
using DTO;
using Model.Entites;
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
    private readonly IMapper _mapper;

    public CustomersPresenter(ICustomersView customersView, ICustomersService customersService, IMapper mapper)
    {
        _customersView = customersView ?? throw new ArgumentNullException(nameof(customersView));
        _customersService = customersService ?? throw new ArgumentNullException(nameof(customersService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        _customersView.ViewLoaded += CustomersView_ViewLoaded;
        _customersView.CustomerAdded += CustomersView_CustomerAdded;
        _customersView.CustomerDeleted += CustomersView_CustomerDeleted;
        _customersView.CustomerChanged += CustomersView_CustomerChanged;
    }

    private void CustomersView_CustomerAdded(object? sender, CustomerEventArgs e)
    {
        var customer = _mapper.Map<Customer>(e.Customer);
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
        var customersDTO = customers.Select(_mapper.Map<CustomerDTO>).ToList();
        var bindingList = new BindingList<CustomerDTO>(customersDTO);
        _customersView.LoadCustomers(bindingList);
    }
}
