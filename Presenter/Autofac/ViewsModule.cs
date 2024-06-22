using Autofac;
using ServiceAccounting.View;
using ServiceAccounting;
using View.Base;

namespace Presenter.Autofac;

public class ViewsModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<MainForm>().As<IMainForm>();
        builder.RegisterType<CustomersView>().As<ICustomersView>();
        builder.RegisterType<ProductsView>().As<IProductsView>();
        builder.RegisterType<OrdersView>().As<IOrdersView>();
        builder.RegisterType<NewOrderForm>().As<INewOrderView>();
    }
}
