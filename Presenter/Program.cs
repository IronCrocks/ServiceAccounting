using Autofac;
using System.Windows.Forms;
using Presenter.Autofac;
using Presenter.Base;

namespace ServiceAccounting;

internal static class Program
{
    private static IContainer? _container;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        using var db = new ApplicationDBContext();
        //db.Database.EnsureDeleted();
        db.Database.EnsureCreated();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var builder = new ContainerBuilder();
        builder.RegisterModule(new ServicesModule());
        builder.RegisterModule(new ViewsModule());
        builder.RegisterModule(new PresentersModule());
        builder.RegisterModule(new AutoMapperModule());
        _container = builder.Build();

        using var scope = _container.BeginLifetimeScope();

        if (scope.Resolve<IMainFormPresenter>() is not ApplicationContext mainFormPresenter)
        {
            throw new InvalidOperationException();
        }

        Application.Run(mainFormPresenter);
    }
}
