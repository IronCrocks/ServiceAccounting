using Autofac;
using Model.Services.Base;
using Model.Services;

namespace Presenter.Autofac;

public class ServicesModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<CustomersService>().As<ICustomersService>().SingleInstance();
        builder.RegisterType<ProductsService>().As<IProductsService>().SingleInstance();
        builder.RegisterType<OrdersService>().As<IOrdersService>().SingleInstance();
    }
}
