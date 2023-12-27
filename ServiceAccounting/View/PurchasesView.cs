using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Microsoft.EntityFrameworkCore;

namespace ServiceAccounting.View
{
    public partial class PurchasesView : UserControl
    {
        public PurchasesView()
        {
            InitializeComponent();


            ServiceAccounting.ApplicationContext db = new ServiceAccounting.ApplicationContext();
            //using ApplicationContext db = new();

            var result = from customer in db.Customers
                         join purchase in db.Purchases on customer.Id equals purchase.CustomerId
                         join product in db.Products on purchase.ProductId equals product.Id
                         select new
                         {
                             customer.Name,
                             productName = product.Name,
                             purchase.Count,
                             product.Price,
                             purchase.Date
                         };
            //var result = from customer in db.Customers
            //             join purchase in db.Purchases on customer.Id equals purchase.CustomerId into cs
            //             from subcustomer in cs
            //             join product in db.Products on subcustomer.ProductId equals product.Id into cp
            //             from value in cp
            //             select new
            //             {
            //                 customerName = cp.,
            //                 productName = product.Name,
            //                 productPrice = product.Price,
            //                 count = purchase.Count,
            //             };

            var result1 = result.ToList();
            var bs = new BindingSource
            {
                DataSource = result.ToList()
            };

            pivotGridControl1.DataSource = bs;
            UpdatePivotGrid();

            ServiceAccounting.ApplicationContext dbContext = new ServiceAccounting.ApplicationContext();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Customers.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridLookUpEdit1.Properties.DataSource = dbContext.Customers.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
           
        }

        private void UpdatePivotGrid()
        {
            //fields[0].na
            pivotGridControl1.RetrieveFields();
            var fields = pivotGridControl1.Fields;
            fields[0].Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            fields[1].Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            fields[2].Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            fields[3].Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            fields[4].Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            //var y = pivotGridControl1.Fields;
            pivotGridControl1.BeginUpdate();
            pivotGridControl1.EndUpdate();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var form = new NewPurchaseForm();
            form.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //var report = ReportGenerator.GenerateReport(gridView1);
            //string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "report.docx");
            //var report = new Report2();
            //report.ExportToDocx(path);


            using ApplicationContext db = new ApplicationContext();

            //var result = from customer in db.Customers
            //             join purchase in db.Purchases on customer.Id equals purchase.CustomerId
            //             join product in db.Products on purchase.ProductId equals product.Id
            //             select new
            //             {
            //                 customer.Name,
            //                 productName = product.Name,
            //                 purchase.Count,
            //                 product.Price,
            //                 purchase.Date
            //             };

            var report1 = new Report2();
            report1.Parameters["parameter1"].Value = 1;
            //var tt = report1.DataSource as SqlDataSource;
            //var y = tt.Queries;
            var printTool = new ReportPrintTool(report1);
            printTool.ShowPreview();

            //string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "report.docx");
            //report4.ExportToDocx(path);
        }

    }
}
