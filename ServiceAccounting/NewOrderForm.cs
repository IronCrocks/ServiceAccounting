using DTO;
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
        List<OrderItemDTO> _products = new List<OrderItemDTO>();
        public NewOrderForm()
        {
            InitializeComponent();
            OnViewLoaded(this, EventArgs.Empty);
        }

        public event EventHandler<OrderItemEventArgs> OrderItemAdded;
        public event EventHandler<AddOrderEventArgs> BtnAddOrderClicked;
        public event EventHandler ViewLoaded;

        public void LoadData(IEnumerable<CustomerDTO> customers, IEnumerable<ProductDTO> products)
        {
            var bindingSourceCustomers = new BindingSource { DataSource = customers };
            var bindingSourceProducts = new BindingSource { DataSource = products };

            gridControl1.DataSource = bindingSourceProducts;
            gridLookUpEdit1.Properties.DataSource = bindingSourceCustomers;
        }

        // TODO: переписать так, чтобы при добавлении одинакового товара, не создавались новые ордер итемы с уже
        // добавленным товаром, вместо этого увеличивался счетчик данного товара в соответствующем ордер итеме.
        public void AddOrderItem(OrderItemDTO item)
        {
            _products.Add(item);
            gridControl2.BeginUpdate();
            gridControl2.EndUpdate();
        }

        protected virtual void OnOrderItemAdded(object sender, OrderItemEventArgs e)
        {
            OrderItemAdded?.Invoke(this, e);
        }

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
            if (gridView1.GetFocusedRow() is not OrderItemDTO orderItemDTO) throw new InvalidCastException("Wrong data type.");
            OnOrderItemAdded(this, new OrderItemEventArgs(orderItemDTO));
        }

        private void BtnRemoveOrderItem_Click(object sender, EventArgs e)
        {
            if (gridView2.GetFocusedRow() is not OrderItemDTO orderItemDTO) throw new InvalidCastException("Wrong data type.");

            _products.Remove(orderItemDTO);
            gridControl2.BeginUpdate();
            gridControl2.EndUpdate();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            var selectedCustomer = GetSelectedCustomer1();
            var selectedDate = dateEdit1.DateTime;

            if (selectedCustomer is null) return;

            OnBtnAddOrderClicked(this, new AddOrderEventArgs(_products, selectedCustomer, selectedDate));

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

        void INewOrderView.Load()
        {
            OnViewLoaded(this, EventArgs.Empty);
        }
    }
}
