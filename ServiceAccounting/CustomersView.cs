using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using View.Base;
using View.ViewEventArgs;

namespace ServiceAccounting.View;

public partial class CustomersView : UserControl, ICustomersView
{
    BindingSource _bindingSource;
    public CustomersView()
    {
        InitializeComponent();

        OnViewLoaded(this, EventArgs.Empty);
    }

    public event EventHandler ViewLoaded;
    public event EventHandler<CustomerEventArgs> CustomerAdded;
    public event EventHandler<CustomerEventArgs> CustomerDeleted;
    public event EventHandler<CustomerEventArgs> CustomerChanged;

    public void LoadCustomers(IEnumerable<CustomerDTO> customers)
    {
        _bindingSource = new BindingSource { DataSource = customers };
        _bindingSource.ListChanged += BindingSource_ListChanged;
        gridControl1.DataSource = _bindingSource;
        gridView1.RowDeleted += GridView1_RowDeleted;
    }

    // TODO: реализовать распознавание какое именно поле объекта было изменено использую PropertyDescriptor.
    // (если это возможно)
    private void BindingSource_ListChanged(object sender, ListChangedEventArgs e)
    {
        if (_bindingSource[e.NewIndex] is not CustomerDTO customer) throw new InvalidCastException("Wrong data type");

        switch (e.ListChangedType)
        {
            case ListChangedType.ItemAdded:
                OnCustomerAdded(this, new CustomerEventArgs(customer));
                break;
            case ListChangedType.ItemChanged:
                OnCustomerChanged(this, new CustomerEventArgs(customer));
                break;
        }
    }

    private void GridView1_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
    {
        if (e.Row is not CustomerDTO customer) throw new InvalidCastException("Wrong data type");
        OnCustomerDeleted(this, new CustomerEventArgs(customer));
    }

    protected virtual void OnViewLoaded(object sender, EventArgs e)
    {
        ViewLoaded?.Invoke(sender, e);
    }

    protected virtual void OnCustomerAdded(object sender, CustomerEventArgs e)
    {
        CustomerAdded?.Invoke(sender, e);
    }

    protected virtual void OnCustomerDeleted(object sender, CustomerEventArgs e)
    {
        CustomerDeleted?.Invoke(sender, e);
    }

    protected virtual void OnCustomerChanged(object sender, CustomerEventArgs e)
    {
        CustomerChanged?.Invoke(sender, e);
    }

    void ICustomersView.Load()
    {
        OnViewLoaded(this, EventArgs.Empty);
    }
}
