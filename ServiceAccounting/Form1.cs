using ServiceAccounting.View;
using System;
using System.Windows.Forms;

namespace ServiceAccounting;

public partial class Form1 : DevExpress.XtraEditors.XtraForm
{
    private Control _view;
    public Form1()
    {
        InitializeComponent();
    }

    // TODO: переделать через Container?
    private void simpleButton1_Click(object sender, EventArgs e)
    {
        panelControl2.Controls.Remove(_view);
        _view = new CustomersView();
        _view.Parent = panelControl2;
        _view.Dock = DockStyle.Fill;
    }

    private void simpleButton2_Click(object sender, EventArgs e)
    {
        panelControl2.Controls.Remove(_view);
        _view = new ProductsView();
        _view.Parent = panelControl2;
        _view.Dock = DockStyle.Fill;
    }

    private void simpleButton3_Click(object sender, EventArgs e)
    {
        panelControl2.Controls.Remove(_view);
        _view = new PurchasesView();
        _view.Parent = panelControl2;
        _view.Dock = DockStyle.Fill;
    }
}
