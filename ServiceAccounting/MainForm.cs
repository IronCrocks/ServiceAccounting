using System;
using System.Windows.Forms;
using View.Base;

namespace ServiceAccounting;

public partial class MainForm : DevExpress.XtraEditors.XtraForm, IMainForm
{
    private Control _view;
    private readonly ICustomersView _customersView;
    private readonly IProductsView _productsView;
    private readonly IOrdersView _ordersView;

    public MainForm(ICustomersView customersView,
        IProductsView productsView,
        IOrdersView ordersView)
    {
        _customersView = customersView ?? throw new ArgumentNullException(nameof(customersView));
        _productsView = productsView ?? throw new ArgumentNullException(nameof(productsView));
        _ordersView = ordersView ?? throw new ArgumentNullException(nameof(ordersView));

        InitializeComponent();
    }

    // TODO: переделать через Container?
    private void btnCustomers_Click(object sender, EventArgs e)
    {
        panelControl2.Controls.Remove(_view);
        _view = _customersView as Control;
        _view.Parent = panelControl2;
        _view.Dock = DockStyle.Fill;
        _customersView.Load();
    }

    private void btnProducts_Click(object sender, EventArgs e)
    {
        panelControl2.Controls.Remove(_view);
        _view = _productsView as Control;
        _view.Parent = panelControl2;
        _view.Dock = DockStyle.Fill;
        _productsView.Load();
    }

    private void btnOrders_Click(object sender, EventArgs e)
    {
        panelControl2.Controls.Remove(_view);
        _view = _ordersView as Control;
        _view.Parent = panelControl2;
        _view.Dock = DockStyle.Fill;
        _ordersView.Load();
    }
}
