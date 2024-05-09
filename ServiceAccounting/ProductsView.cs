using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using View.Base;
using View.ViewEventArgs;

namespace ServiceAccounting.View;

public partial class ProductsView : UserControl, IProductsView
{
    public ProductsView()
    {
        InitializeComponent();
    }

    public event EventHandler<ObjectUpdatedEventArgs> RowUpdated;
    public event EventHandler<RowRemovedEventArgs> RowRemoved;
    public event EventHandler ViewLoaded;
    public event EventHandler RowInserted;

    public void LoadData(IEnumerable<object> objects)
    {
        Products = objects.ToList();
        var bindingSource = new BindingSource() { DataSource = Products };
        gridControl1.DataSource = bindingSource;
    }

    /// TODO: сделать приватным с открытыми методами доступа. Либо взять неизменяемый список. 
    public List<object> Products { get; set; } = new List<object>();

    void IProductsView.Load()
    {
        OnViewLoaded(this, EventArgs.Empty);
    }

    public void UpdateView()
    {
        gridView1.RefreshData();
    }

    protected virtual void OnRowUpdated(object sender, ObjectUpdatedEventArgs e)
    {
        RowUpdated?.Invoke(sender, e);
    }

    protected virtual void OnRowRemoved(object sender, RowRemovedEventArgs e)
    {
        RowRemoved?.Invoke(sender, e);
    }

    protected virtual void OnRowInserted(object sender, EventArgs e)
    {
        RowInserted?.Invoke(sender, e);
    }

    protected virtual void OnViewLoaded(object sender, EventArgs e)
    {
        ViewLoaded?.Invoke(sender, e);
    }

    private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
        var updatedObject = gridView1.GetRow(e.RowHandle);
        OnRowUpdated(this, new ObjectUpdatedEventArgs(updatedObject));
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        OnRowInserted(this, EventArgs.Empty);
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        int removingObjectIndex = GetRemovingObjectIndex();
        OnRowRemoved(sender, new RowRemovedEventArgs(removingObjectIndex));
        UpdateView();
    }
    private int GetRemovingObjectIndex()
    {
        var selectedRowHandle = gridView1.FocusedRowHandle;
        var column = gridView1.Columns[0];
        var removingObjectIndex = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, column));

        return removingObjectIndex;
    }
}
