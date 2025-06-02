using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Base;
using View.ViewEventArgs;

namespace View;

public partial class ReportForm : Form, IReportForm
{
    public ReportForm()
    {
        InitializeComponent();
        OnViewLoaded(this, EventArgs.Empty);
    }

    public event EventHandler ViewLoaded;
    public event EventHandler<CustomerEventArgs> btnReportClicked;

    public void LoadData(IEnumerable<CustomerDTO> customers)
    {
        searchLookUpEdit1.Properties.DisplayMember = "Name";
        searchLookUpEdit1.Properties.ValueMember = "Id";
        searchLookUpEdit1.Properties.DataSource = customers;

        dateEdit1.EditValue = DateTime.Today;
        dateEdit2.EditValue = DateTime.Today;
    }

    protected virtual void OnbtnReportClicked(object sender, CustomerEventArgs e)
    {
        btnReportClicked?.Invoke(sender, e);
    }

    protected virtual void OnViewLoaded(object sender, EventArgs e)
    {
        ViewLoaded?.Invoke(sender, e);
    }

    private void btnShowReport_Click(object sender, EventArgs e)
    {
        if (searchLookUpEdit1View.GetFocusedRow() is null)
        {
            MessageBox.Show("Выберите покупателя!");
            return;
        }
        if (dateEdit1.DateTime >= dateEdit2.DateTime)
        {
            MessageBox.Show("Выберите корректные даты для отчета!");
            return;
        }

        var selectedCustomer = GetSelectedCustomer();
        OnbtnReportClicked(this, new CustomerEventArgs(selectedCustomer));
    }

    private CustomerDTO GetSelectedCustomer() =>
        searchLookUpEdit1View.GetFocusedRow() is not CustomerDTO customer ?
        throw new InvalidCastException("Wrong data type.") : customer;

    void IReportForm.Load()
    {
        OnViewLoaded(this, EventArgs.Empty);
    }
}
