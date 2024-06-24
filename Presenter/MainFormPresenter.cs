using Presenter.Base;
using System.Windows.Forms;
using View.Base;

namespace Presenter;

public class MainFormPresenter : ApplicationContext, IMainFormPresenter
{
    private readonly IMainForm _mainForm;
    private readonly INewOrderPresenter _newOrderPresenter;
    private readonly IOrdersPresenter _ordersPresenter;
    private readonly IProductsPresenter _productsPresenter;
    private readonly ICustomersPresenter _customersPresenter;

    public MainFormPresenter(IMainForm mainForm,
        INewOrderPresenter newOrderPresenter,
        IOrdersPresenter ordersPresenter,
        IProductsPresenter productsPresenter,
        ICustomersPresenter customersPresenter)
    {
        _mainForm = mainForm;
        _newOrderPresenter = newOrderPresenter;
        _ordersPresenter = ordersPresenter;
        _productsPresenter = productsPresenter;
        _customersPresenter = customersPresenter;

        if (_mainForm is not Form form) throw new InvalidOperationException();

        form.Show();
    }
}
