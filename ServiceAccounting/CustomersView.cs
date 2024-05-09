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

            OnViewLoaded(this, EventArgs.Empty);
        }

        public event EventHandler ViewLoaded;
        public event EventHandler<AddCustomerEventArgs> btnAddCustomerClicked;

        public void UpdateView(IEnumerable<object> data)
        {
            var bindingSource = new BindingSource { DataSource = data };
            gridControl1.DataSource = bindingSource;
        }

        protected virtual void OnViewLoaded(object sender, EventArgs e)
        {
            ViewLoaded?.Invoke(sender, e);
        }

        protected virtual void OnBtnAddCustomerClicked(object sender, AddCustomerEventArgs e)
        {
            btnAddCustomerClicked?.Invoke(sender, e);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            OnBtnAddCustomerClicked(this, new AddCustomerEventArgs
            {
                Name = textEdit1.Text,
                Age = Convert.ToInt32(textEdit2.Text)
            });
        }

        void ICustomersView.Load()
        {
            OnViewLoaded(this, EventArgs.Empty);
        }
    }
}
