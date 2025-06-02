using DTO;
using System;
using System.Collections.Generic;
using View.ViewEventArgs;

namespace View.Base
{
    public interface IReportForm : IView
    {
        event EventHandler<CustomerEventArgs> btnReportClicked;

        void LoadData(IEnumerable<CustomerDTO> customers);
        void Load();
    }
}
