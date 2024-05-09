using Model.Services;
using Presenter;
using ServiceAccounting.View;
using System.Windows.Forms;

namespace ServiceAccounting;

internal static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        using var db = new ApplicationDBContext();
        //db.Database.EnsureDeleted();
        //db.Database.EnsureCreated();

        //using (ApplicationContext db = new ApplicationContext())
        //{
        //    //db.Database.ExecuteSqlRaw(@"CREATE VIEW CustomersTotalSumView AS 
        //    //                                SELECT Customers.Name, Customers.Age, COALESCE(SUM(Products.Price*Purchases.Count),0)
        //    //                                FROM Customers LEFT JOIN Purchases ON Customers.Id=Purchases.CustomerId
        //    //                                Left JOIN Products ON Purchases.ProductId=Products.Id
        //    //                                GROUP BY Customers.Name, Customers.Age");
        //    db.Database.ExecuteSqlRaw(@"CREATE VIEW CustomersTotalSumView AS 
        //                                    SELECT Customers.Name, Products.Name, Purchases.Date, Purchases.Count, Products.Price
        //                                    FROM Customers JOIN Purchases ON Customers.Id=Purchases.CustomerId
        //                                    JOIN Products ON Purchases.ProductId=Products.Id");
        //    db.SaveChanges();
        //}
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        //Application.Run(new MainForm());
        var newOrderForm = new NewOrderForm();

        var customersView = new CustomersView();
        var productsView = new ProductsView();
        var ordersView = new OrdersView(newOrderForm);

        var customersService = new CustomersService();
        var productsService = new ProductsService();
        var ordersService = new OrdersService();


        Application.Run(new MainFormPresenter(new MainForm(customersView, productsView, ordersView),
            new NewOrderPresenter(newOrderForm, ordersService, customersService, productsService),
            new OrdersPresenter(ordersView, ordersService),
            new ProductsPresenter(productsView, productsService),
            new CustomersPresenter(customersView, customersService)));
        //presenter.Run();
    }
}
