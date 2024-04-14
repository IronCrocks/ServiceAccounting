using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using View.Base;
using View.ViewEventArgs;

namespace ServiceAccounting.View
{
    public partial class NewOrderForm : Form, INewOrderView
    {
        private readonly List<object> _products = new();

        public NewOrderForm()
        {
            InitializeComponent();
            gridControl2.DataSource = _products;
            OnViewLoaded(this, EventArgs.Empty);
        }

        public event EventHandler<AddOrderEventArgs> BtnAddOrderClicked;
        public event EventHandler ViewLoaded;

        protected virtual void OnViewLoaded(object sender, EventArgs e)
        {
            ViewLoaded?.Invoke(this, e);
        }

        protected virtual void OnBtnAddOrderClicked(object sender, AddOrderEventArgs e)
        {
            BtnAddOrderClicked?.Invoke(this, e);
        }

        private void BtnAddOrderItem_Click(object sender, EventArgs e)
        {
            var selectedRow = gridView1.GetFocusedRow();

            _products.Add(selectedRow);
            gridControl2.BeginUpdate();
            gridControl2.EndUpdate();
        }

        private void BtnRemoveOrderItem_Click(object sender, EventArgs e)
        {
            var selectedRow = gridView2.GetFocusedRow();

            _products.Remove(selectedRow);
            gridControl2.BeginUpdate();
            gridControl2.EndUpdate();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            var selectedProducts = GetProductRows();
            var selectedCustomer = GetSelectedCustomer1();
            var selectedDate = dateEdit1.DateTime;

            if (selectedCustomer is null) return;

            OnBtnAddOrderClicked(this, new AddOrderEventArgs(selectedProducts, selectedCustomer, selectedDate));

            //var order = CreateOrder();
            //selectedCustomer.Orders.Add(order);

            //foreach (var product in selectedProducts)
            //{
            //    var selectedProduct = db.Products.FirstOrDefault(p => p.Id == product.Id);

            //    var orderItem = new OrderItem
            //    {
            //        Count = 1,
            //        Product = selectedProduct,
            //    };

            //    order.OrderItems.Add(orderItem);
            //}

            //db.SaveChanges();

            Close();
        }

        private IEnumerable<object> GetProductRows()
        {
            int rowIndex = 0;
            var selectedProducts = new List<object>();

            while (gridView2.IsValidRowHandle(rowIndex))
            {
                selectedProducts.Add(gridView2.GetRow(rowIndex));
                rowIndex++;
            }

            return selectedProducts;
        }

        private object GetSelectedCustomer1() => gridLookUpEdit1View.GetFocusedRow();

        //private Customer GetSelectedCustomer()
        //{
        //    if (gridLookUpEdit1View.GetFocusedRow() is not Customer selectedCustomerRow) return null;

        //    using ApplicationContext db = new();
        //    return db.Customers.FirstOrDefault(p => p.Id == selectedCustomerRow.Id);
        //}

        //private Order CreateOrder() => new()
        //{
        //    Number = "",
        //    Date = dateEdit1.DateTime,
        //};

        public void UpdateView(IEnumerable<object> products, IEnumerable<object> customers)
        {
            gridControl1.DataSource = products.ToList();
            gridLookUpEdit1.Properties.DataSource = customers.ToList();
        }
    }
}
