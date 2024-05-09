using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using View.Base;

namespace ServiceAccounting.View;

public partial class OrdersView : UserControl, IOrdersView
{
    private readonly INewOrderView _newOrderForm;

    public OrdersView(INewOrderView newOrderForm)
    {
        InitializeComponent();
        _newOrderForm = newOrderForm ?? throw new ArgumentNullException(nameof(newOrderForm));
    }

    public event EventHandler ViewLoaded;
    public event EventHandler btnAddOrderClicked;

    public void UpdateView(IEnumerable<object> orders)
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
        var form = _newOrderForm as NewOrderForm;
        form.ShowDialog();
        //form.Show();
        OnBtnAddOrderClicked(this, EventArgs.Empty);
    }

    private void BtnReport_Click(object sender, EventArgs e)
    {
        //var report = ReportGenerator.GenerateReport(gridView1);
        //string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "report.docx");
        //var report = new Report2();
        //report.ExportToDocx(path);


        using ApplicationContext db = new ApplicationContext();

        //var result = from customer in db.Customers
        //             join purchase in db.Purchases on customer.Id equals purchase.CustomerId
        //             join product in db.Products on purchase.ProductId equals product.Id
        //             select new
        //             {
        //                 customer.Name,
        //                 productName = product.Name,
        //                 purchase.Count,
        //                 product.Price,
        //                 purchase.Date
        //             };

        var report1 = new Report2();
        report1.Parameters["parameter1"].Value = 1;
        //var tt = report1.DataSource as SqlDataSource;
        //var y = tt.Queries;
        var printTool = new ReportPrintTool(report1);
        printTool.ShowPreview();

        //string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "report.docx");
        //report4.ExportToDocx(path);
    }

    void IOrdersView.Load()
    {
        OnViewLoaded(this, EventArgs.Empty);
    }
}
