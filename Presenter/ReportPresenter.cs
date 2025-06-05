using AutoMapper;
using DevExpress.XtraReports.UI;
using DTO;
using Model.Entites;
using Model.Projections;
using Model.Services.Base;
using Presenter.Base;
using System.Drawing;
using View.Base;
using View.ViewEventArgs;

namespace Presenter
{
    public class ReportPresenter : IReportPresenter
    {
        private readonly IReportForm _view;
        private readonly IOrdersService _ordersService;
        private readonly ICustomersService _customersService;
        private readonly IMapper _mapper;

        public ReportPresenter(IReportForm view, IOrdersService ordersService, ICustomersService customersService, IMapper mapper)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _ordersService = ordersService ?? throw new ArgumentNullException(nameof(ordersService));
            _customersService = customersService ?? throw new ArgumentNullException(nameof(customersService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

            _view.ViewLoaded += OnViewLoaded;
            _view.btnReportClicked += OnBtnReportClicked;
        }
        private void OnViewLoaded(object sender, EventArgs e)
        {
            var customers = _customersService.GetCustomers();
            var customersDTO = customers.Select(_mapper.Map<CustomerDTO>).ToList();
            _view.LoadData(customersDTO);
        }
        private void OnBtnReportClicked(object sender, CustomerEventArgs e)
        {
            ArgumentNullException.ThrowIfNull(e);

            var customer = _mapper.Map<Customer>(e.Customer);
            var ordersData = _ordersService.GetOrders(customer);
            var report = CreateReport(ordersData.ToList());
            var printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }
        public static XtraReport CreateReport(List<CustomerOrderItem> data)
        {
            var report = new XtraReport();
            report.DataSource = data;

            float columnWidth = 100;
            float labelHeight = 25;

            var monthKey = new CalculatedField
            {
                Name = "MonthKey",
                FieldType = FieldType.String,
                Expression = "FormatString('{0:yyyy-MM}', [Date])"
            };

            report.CalculatedFields.Add(monthKey);
            // === ГРУППИРОВКА ПО МЕСЯЦУ ===
            var groupHeader = new GroupHeaderBand { HeightF = labelHeight };
            report.Bands.Add(groupHeader);

            // Группировка по дате (год + месяц)
            groupHeader.GroupFields.Add(new GroupField("MonthKey", XRColumnSortOrder.Ascending));

            // Метка с названием месяца
            var groupLabel = new XRLabel
            {
                BoundsF = new RectangleF(0, 0, 500, labelHeight),
                Font = new Font("Arial", 10, FontStyle.Bold),
                Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0),
                ExpressionBindings =
                {
                    new ExpressionBinding("BeforePrint", "Text", "FormatString('{0:MMMM yyyy}', [Date])")
                }
            };

            groupHeader.Controls.Add(groupLabel);

            // === ШАПКА СТРОК ===
            var pageHeader = new PageHeaderBand { HeightF = labelHeight };
            report.Bands.Add(pageHeader);

            float xHeader = 0;
            pageHeader.Controls.Add(CreateHeaderLabel("Дата", xHeader, columnWidth, labelHeight)); xHeader += columnWidth;
            pageHeader.Controls.Add(CreateHeaderLabel("Товар", xHeader, columnWidth, labelHeight)); xHeader += columnWidth;
            pageHeader.Controls.Add(CreateHeaderLabel("Кол-во", xHeader, columnWidth, labelHeight)); xHeader += columnWidth;
            pageHeader.Controls.Add(CreateHeaderLabel("Цена", xHeader, columnWidth, labelHeight)); xHeader += columnWidth;
            pageHeader.Controls.Add(CreateHeaderLabel("Итого", xHeader, columnWidth, labelHeight));

            var detail = new DetailBand { HeightF = labelHeight };
            report.Bands.Add(detail);

            float x = 0;
            detail.Controls.Add(CreateDateBoundLabel("Date", x, columnWidth, labelHeight)); x += columnWidth;
            detail.Controls.Add(CreateBoundLabel("Name", x, columnWidth, labelHeight)); x += columnWidth;
            detail.Controls.Add(CreateBoundLabel("Count", x, columnWidth, labelHeight)); x += columnWidth;
            detail.Controls.Add(CreateBoundLabel("Price", x, columnWidth, labelHeight)); x += columnWidth;
            detail.Controls.Add(CreateBoundLabel("Total", x, columnWidth, labelHeight)); x += columnWidth;

            return report;
        }

        private static XRLabel CreateBoundLabel(string fieldName, float x, float width, float height)
        {
            return new XRLabel
            {
                BoundsF = new RectangleF(x, 0, width, height),
                Borders = DevExpress.XtraPrinting.BorderSide.All,
                Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0),
                ExpressionBindings =
                {
                    new ExpressionBinding("BeforePrint", "Text", $"[{fieldName}]")
                }
            };
        }

        private static XRLabel CreateDateBoundLabel(string fieldName, float x, float width, float height)
        {
            return new XRLabel
            {
                BoundsF = new RectangleF(x, 0, width, height),
                Borders = DevExpress.XtraPrinting.BorderSide.All,
                Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0),
                ExpressionBindings =
                {
                    new ExpressionBinding("BeforePrint", "Text", "FormatString('{0:dd.MM.yyyy}', [Date])")
                }
            };
        }
        private static XRLabel CreateHeaderLabel(string text, float x, float width, float height)
        {
            return new XRLabel
            {
                BoundsF = new RectangleF(x, 0, width, height),
                Borders = DevExpress.XtraPrinting.BorderSide.All,
                Font = new Font("Arial", 9, FontStyle.Bold),
                BackColor = Color.LightGray,
                TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter,
                Text = text
            };
        }
    }
}
