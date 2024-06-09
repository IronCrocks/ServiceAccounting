using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Base;
using View.ViewEventArgs;

namespace ServiceAccounting.View;

public partial class ProductsView : UserControl, IProductsView
{
    private BindingSource _bindingSource;
    public ProductsView()
    {
        InitializeComponent();

        OnViewLoaded(this, EventArgs.Empty);
    }

    public event EventHandler ViewLoaded;
    public event EventHandler<ProductEventArgs> ProductAdded;
    public event EventHandler<ProductEventArgs> ProductChanged;
    public event EventHandler<ProductEventArgs> ProductDeleted;

    public void LoadData(IEnumerable<ProductDTO> products)
    {
        _bindingSource = new BindingSource() { DataSource = products };
        _bindingSource.ListChanged += BindingSource_ListChanged;
        gridControl1.DataSource = _bindingSource;
        gridView1.RowDeleted += GridView1_RowDeleted;
    }

    protected virtual void OnProductAdded(ProductEventArgs e)
    {
        ProductAdded?.Invoke(this, e);
    }

    protected virtual void OnProductChanged(ProductEventArgs e)
    {
        ProductChanged?.Invoke(this, e);
    }

    protected virtual void OnProductDeleted(ProductEventArgs e)
    {
        ProductDeleted?.Invoke(this, e);
    }

    private void BindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
    {
        if (gridView1.GetRow(e.NewIndex) is not ProductDTO product) throw new InvalidCastException("Wrong data type");

        switch (e.ListChangedType)
        {
            case System.ComponentModel.ListChangedType.ItemAdded:
                OnProductAdded(new ProductEventArgs(product));
                break;
            case System.ComponentModel.ListChangedType.ItemChanged:
                OnProductChanged(new ProductEventArgs(product));
                break;
            default:
                break;
        }
    }

    private void GridView1_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
    {
        if (e.Row is not ProductDTO product) throw new InvalidCastException("Wrong data type");

        OnProductDeleted(new ProductEventArgs(product));
    }

    void IProductsView.Load()
    {
        OnViewLoaded(this, EventArgs.Empty);
    }

    public void UpdateView()
    {
        gridView1.RefreshData();
    }

    protected virtual void OnViewLoaded(object sender, EventArgs e)
    {
        ViewLoaded?.Invoke(sender, e);
    }
}
