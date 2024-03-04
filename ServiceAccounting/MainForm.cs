using ServiceAccounting.Model.Services;
using ServiceAccounting.Presenter;
using ServiceAccounting.View;
using ServiceAccounting.View.Base;
using System;
using System.Windows.Forms;

namespace ServiceAccounting;

public partial class MainForm : DevExpress.XtraEditors.XtraForm
{
    private Control _customersView = new CustomersView();
    private Control _productsView = new ProductsView();
    private Control _ordersView = new OrdersView();
    private Control _view;

    public MainForm()
    {
        InitializeComponent();
    }

    // TODO: переделать через Container?
    private void btnCustomers_Click(object sender, EventArgs e)
    {
        panelControl2.Controls.Remove(_view);
        _view = _customersView;
        _view.Parent = panelControl2;
        _view.Dock = DockStyle.Fill;

        var _customersPresenter = new CustomersPresenter((ICustomersView)_customersView,new CustomersService());
    }

    private void btnProducts_Click(object sender, EventArgs e)
    {
        panelControl2.Controls.Remove(_view);
        _view = _productsView;
        _view.Parent = panelControl2;
        _view.Dock = DockStyle.Fill;
    }

    private void btnOrders_Click(object sender, EventArgs e)
    {
        panelControl2.Controls.Remove(_view);
        _view = _ordersView;
        _view.Parent = panelControl2;
        _view.Dock = DockStyle.Fill;
    }
}
