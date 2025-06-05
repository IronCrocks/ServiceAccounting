using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using View;
using View.Base;

namespace ServiceAccounting.View;

public partial class OrdersView : UserControl, IOrdersView
{
    private readonly INewOrderView _newOrderForm;
    private readonly IReportForm _reportForm;
    private IEnumerable<OrderDTO> _orders;

    public OrdersView(INewOrderView newOrderForm, IReportForm reportForm)
    {
        InitializeComponent();
        _newOrderForm = newOrderForm ?? throw new ArgumentNullException(nameof(newOrderForm));
        _reportForm = reportForm ?? throw new ArgumentNullException(nameof(reportForm));
    }

    public event EventHandler ViewLoaded;
    public event EventHandler btnAddOrderClicked;

    public void UpdateView(IEnumerable<OrderDTO> orders)
    {
        _orders = orders ?? throw new ArgumentNullException(nameof(orders));
        orderDTOBindingSource.DataSource = _orders;
        pivotGridControl1.DataSource = orderDTOBindingSource;
        pivotGridControl1.RefreshData();
    }

    protected virtual void OnViewLoaded(object sender, EventArgs e)
    {
        ViewLoaded?.Invoke(sender, e);
    }

    protected virtual void OnBtnAddOrderClicked(object sender, EventArgs e)
    {
        btnAddOrderClicked?.Invoke(sender, e);
    }

    // По хорошему здесь конечно нужно создавать форму, а не перезагружать. Возможно при помощи фабрики.
    private void BtnAddOrder_Click(object sender, EventArgs e)
    {
        _newOrderForm.Load();
        if (_newOrderForm is not NewOrderForm form) throw new InvalidOperationException();
        form.ShowDialog();
        OnBtnAddOrderClicked(this, EventArgs.Empty);
    }

    // По хорошему здесь конечно нужно создавать форму, а не перезагружать. Возможно при помощи фабрики.
    private void BtnReport_Click(object sender, EventArgs e)
    {
        _reportForm.Load();
        if (_reportForm is not ReportForm form) throw new InvalidOperationException();
        form.ShowDialog();
    }

    void IOrdersView.Load()
    {
        OnViewLoaded(this, EventArgs.Empty);
    }
}
