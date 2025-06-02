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
        var bindingSource = new BindingSource { DataSource = orders };
        pivotGridControl1.DataSource = bindingSource;
        UpdatePivotGrid();
    }

    protected virtual void OnViewLoaded(object sender, EventArgs e)
    {
        ViewLoaded?.Invoke(sender, e);
    }

    protected virtual void OnBtnAddOrderClicked(object sender, EventArgs e)
    {
        btnAddOrderClicked?.Invoke(sender, e);
    }

    private void UpdatePivotGrid()
    {
        pivotGridControl1.RetrieveFields();
        var fields = pivotGridControl1.Fields;
        fields[0].Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
        fields[1].Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
        fields[2].Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
        fields[3].Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
        fields[4].Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
        pivotGridControl1.BeginUpdate();
        pivotGridControl1.EndUpdate();
    }

    private void BtnAddOrder_Click(object sender, EventArgs e)
    {
        _newOrderForm.Load();
        if (_newOrderForm is not NewOrderForm form) throw new InvalidOperationException();
        form.ShowDialog();
        OnBtnAddOrderClicked(this, EventArgs.Empty);
    }

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
