using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Base;
using View.ViewEventArgs;

namespace ServiceAccounting.View
{
    public partial class CustomersView : UserControl, ICustomersView
    {
        public CustomersView()
        {
            InitializeComponent();

            OnViewLoaded(EventArgs.Empty);
        }

        public event EventHandler ViewLoaded;
        public event EventHandler<AddCustomerEventArgs> btnAddCustomerClicked;

        public void UpdateView(IEnumerable<object> data)
        {
            var bindingSource = new BindingSource { DataSource = data };
            gridControl1.DataSource = bindingSource;
        }

        protected virtual void OnViewLoaded(EventArgs e)
        {
            ViewLoaded?.Invoke(this, e);
        }

        protected virtual void OnBtnAddCustomerClicked(AddCustomerEventArgs e)
        {
            btnAddCustomerClicked?.Invoke(this, e);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            OnBtnAddCustomerClicked(new AddCustomerEventArgs
            {
                Name = textEdit1.Text,
                Age = Convert.ToInt32(textEdit2.Text)
            });
        }
    }
}
