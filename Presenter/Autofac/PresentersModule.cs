using Autofac;
using Presenter.Base;

namespace Presenter.Autofac;

public class PresentersModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<CustomersPresenter>().As<ICustomersPresenter>();
        builder.RegisterType<ProductsPresenter>().As<IProductsPresenter>();
        builder.RegisterType<OrdersPresenter>().As<IOrdersPresenter>();
        builder.RegisterType<NewOrderPresenter>().As<INewOrderPresenter>();
        builder.RegisterType<MainFormPresenter>().As<IMainFormPresenter>();
    }
}
