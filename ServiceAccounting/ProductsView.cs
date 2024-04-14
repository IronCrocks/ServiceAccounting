using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using View.Base;

namespace ServiceAccounting.View
{
    public partial class ProductsView : UserControl, IProductsView
    {
        public ProductsView()
        {
            InitializeComponent();
            OnViewLoaded(this, EventArgs.Empty);
        }

        public event EventHandler RowUpdated;
        public event EventHandler RowDeleted;
        public event EventHandler ViewLoaded;

        public void UpdateView(IEnumerable<object> objects)
        {
            gridControl1.DataSource = objects.ToList();
        }

        protected virtual void OnRowUpdated(object sender, EventArgs e)
        {
            RowUpdated?.Invoke(sender, e);
        }

        protected virtual void OnRowDeleted(object sender, EventArgs e)
        {
            RowDeleted?.Invoke(sender, e);
        }

        protected virtual void OnViewLoaded(object sender, EventArgs e)
        {
            ViewLoaded?.Invoke(sender, e);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            OnRowUpdated(this, EventArgs.Empty);
        }

        private void gridView1_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            OnRowDeleted(this, EventArgs.Empty);
        }
    }
}
