using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using View.Base;
using View.ViewEventArgs;

namespace ServiceAccounting.View
{
    public partial class NewOrderForm : Form, INewOrderView
    {
        private BindingList<OrderItemDTO> _orderItems = new();

        public NewOrderForm()
        {
            InitializeComponent();
            bindingSource1.DataSource = _orderItems;
            OnViewLoaded(this, EventArgs.Empty);
        }

        public event EventHandler ViewLoaded;
        public event EventHandler<AddOrderEventArgs> BtnAddOrderClicked;

        public void LoadData(IEnumerable<CustomerDTO> customers, IEnumerable<ProductDTO> products)
        {
            var bindingSourceCustomers = new BindingSource { DataSource = customers };
            var bindingSourceProducts = new BindingSource { DataSource = products };

            _orderItems.Clear();

            gridControl1.DataSource = bindingSourceProducts;
            searchLookUpEdit1.Properties.DisplayMember = "Name";
            searchLookUpEdit1.Properties.ValueMember = "Id";
            searchLookUpEdit1.Properties.DataSource = bindingSourceCustomers;

            dateEdit1.EditValue = DateTime.Today;
        }

        public IEnumerable<OrderItemDTO> GetOrderItems() => _orderItems;

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
            if (gridView1.GetFocusedRow() is not ProductDTO productDTO) throw new InvalidCastException("Wrong data type.");

            _orderItems.Add(CreateOrderItemDTO());

            OrderItemDTO CreateOrderItemDTO() => new()
            {
                ProductId = productDTO.Id,
                Name = productDTO.Name,
                Description = productDTO.Description,
                Price = productDTO.Price,
                Count = 1
            };
        }

        private void BtnDeleteOrderItem_Click(object sender, EventArgs e)
        {
            if (gridView2.GetFocusedRow() is not OrderItemDTO orderItemDTO) return;

            _orderItems.Remove(orderItemDTO);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            if (searchLookUpEdit1View.GetFocusedRow() is null)
            {
                MessageBox.Show("Выберите покупателя!");
                return;
            }

            var selectedCustomer = GetSelectedCustomer();
            var selectedDate = dateEdit1.DateTime;

            OnBtnAddOrderClicked(this, new AddOrderEventArgs(_orderItems, selectedCustomer, selectedDate));
            Close();
        }

        private CustomerDTO GetSelectedCustomer() =>
            searchLookUpEdit1View.GetFocusedRow() is not CustomerDTO customer ?
            throw new InvalidCastException("Wrong data type.") : customer;

        void INewOrderView.Load()
        {
            OnViewLoaded(this, EventArgs.Empty);
        }
    }
}
