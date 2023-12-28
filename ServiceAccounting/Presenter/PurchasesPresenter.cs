using System;
using ServiceAccounting.View.Base;

namespace ServiceAccounting.Presenter;

public class PurchasesPresenter
{
    IPurchasesView _purchasesView;
    IPurchasesService _purchasesService;

    public PurchasesPresenter(IPurchasesView purchasesView, IPurchasesService purchasesService)
    {
        _purchasesView = purchasesView;
        _purchasesService = purchasesService;
    }
}

