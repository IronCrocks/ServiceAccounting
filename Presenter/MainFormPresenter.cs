﻿using ServiceAccounting;
using System.Windows.Forms;
using View.Base;

namespace Presenter;

public class MainFormPresenter : ApplicationContext
{
    private readonly IMainForm form;
    private readonly NewOrderPresenter newOrderPresenter;
    private readonly OrdersPresenter ordersPresenter;
    private readonly ProductsPresenter productsPresenter;
    private readonly CustomersPresenter customersPresenter;

    public MainFormPresenter(IMainForm form,
        NewOrderPresenter newOrderPresenter,
        OrdersPresenter ordersPresenter,
        ProductsPresenter productsPresenter,
        CustomersPresenter customersPresenter)
    {
        this.form = form;
        this.newOrderPresenter = newOrderPresenter;
        this.ordersPresenter = ordersPresenter;
        this.productsPresenter = productsPresenter;
        this.customersPresenter = customersPresenter;

        //form.Show();
    }

    public void Run()
    {
    }
}
