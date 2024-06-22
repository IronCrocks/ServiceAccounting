using Autofac;
using Presenter;
using System.Windows.Forms;
using Presenter.Autofac;
using View.Base;

namespace ServiceAccounting;

internal static class Program
{
    private static IContainer _container;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        using var db = new ApplicationDBContext();
        //db.Database.EnsureDeleted();
        //db.Database.EnsureCreated();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var builder = new ContainerBuilder();
        builder.RegisterModule(new ServicesModule());
        builder.RegisterModule(new ViewsModule());
        _container = builder.Build();

        using var scope = _container.BeginLifetimeScope();

        //var newOrderForm = new NewOrderForm();

        //var customersView = new CustomersView();
        //var productsView = new ProductsView();
        //var ordersView = new OrdersView(newOrderForm);

        //var customersService = new CustomersService();
        //var productsService = new ProductsService();
        //var ordersService = new OrdersService();
        var mainForm = scope.Resolve<IMainForm>();
        Application.Run((Form)mainForm);
        //Application.Run(new MainFormPresenter(new MainForm(customersView, productsView, ordersView),
        //    new NewOrderPresenter(newOrderForm, ordersService, customersService, productsService),
        //    new OrdersPresenter(ordersView, ordersService),
        //    new ProductsPresenter(productsView, productsService),
        //    new CustomersPresenter(customersView, customersService)));
    }
}
