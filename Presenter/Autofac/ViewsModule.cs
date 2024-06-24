using Autofac;
using ServiceAccounting.View;
using ServiceAccounting;
using View.Base;

namespace Presenter.Autofac;

public class ViewsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<CustomersView>().As<ICustomersView>().SingleInstance();
        builder.RegisterType<ProductsView>().As<IProductsView>().SingleInstance();
        builder.RegisterType<OrdersView>().As<IOrdersView>().SingleInstance();
        builder.RegisterType<NewOrderForm>().As<INewOrderView>().SingleInstance();
        builder.RegisterType<MainForm>().As<IMainForm>().SingleInstance();
    }
}
