using DTO;
using Model.Data;
using Model.Services.Base;
using Moq;
using Presenter;
using System.ComponentModel;
using View.Base;
using View.ViewEventArgs;

namespace UnitTests.Presenter
{
    [TestFixture]
    public class CustomerPresenterTests
    {
        private Mock<ICustomersView> _viewMock;
        private Mock<ICustomersService> _serviceMock;
        private CustomersPresenter _presenter;

        [SetUp]
        public void SetUp()
        {
            _viewMock = new Mock<ICustomersView>();
            _serviceMock = new Mock<ICustomersService>();
            _presenter = new CustomersPresenter(_viewMock.Object, _serviceMock.Object);
        }

        [Test]
        public void Constructor_NullView_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new CustomersPresenter(null, _serviceMock.Object));
        }

        [Test]
        public void Constructor_NullService_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new CustomersPresenter(_viewMock.Object, null));
        }

        [Test]
        public void ViewLoaded_RaisesEvent_LoadsCustomers()
        {
            var customers = new List<CustomerOrderSummary>
            {
                new() { Id = 1, Name = "John", Age = 30, TotalSum = 1000 }
            };

            _serviceMock.Setup(s => s.GetCustomers()).Returns(customers);

            _viewMock.Raise(v => v.ViewLoaded += null, EventArgs.Empty);

            _viewMock.Verify(v => v.LoadCustomers(It.Is<BindingList<CustomerDTO>>
                (list => list.Count == 1 && list[0].Name == "John")), Times.Once);
        }

        [Test]
        public void CustomerAdded_RaisesEvent_AddsCustomerAndSetsId()
        {
            var dto = new CustomerDTO { Name = "New", Age = 25 };
            var args = new CustomerEventArgs(dto);

            _serviceMock.Setup(s => s.AddCustomer(It.IsAny<Customer>())).Returns(42);

            _viewMock.Raise(v => v.CustomerAdded += null, null, args);

            _serviceMock.Verify(s => s.AddCustomer(It.Is<Customer>(c => c.Name == "New" && c.Age == 25)), Times.Once);
            Assert.That(dto.Id, Is.EqualTo(42));
        }

        [Test]
        public void CustomerDeleted_RaisesEvent_DeletesCustomer()
        {
            var dto = new CustomerDTO { Id = 10 };
            var args = new CustomerEventArgs(dto);
            var customer = new Customer { Id = 10 };

            _serviceMock.Setup(s => s.GetCustomerById(10)).Returns(customer);

            _viewMock.Raise(v => v.CustomerDeleted += null, null, args);

            _serviceMock.Verify(s => s.DeleteCustomer(customer), Times.Once);
        }

        [Test]
        public void CustomerChanged_RaisesEvent_UpdatesCustomer()
        {
            var dto = new CustomerDTO { Id = 5, Name = "Updated", Age = 35 };
            var args = new CustomerEventArgs(dto);
            var customer = new Customer { Id = 5 };

            _serviceMock.Setup(s => s.GetCustomerById(5)).Returns(customer);

            _viewMock.Raise(v => v.CustomerChanged += null, null, args);

            _serviceMock.Verify(s => s.UpdateCustomer(It.Is<Customer>(c => c.Id == 5 && c.Name == "Updated" && c.Age == 35)), Times.Once);
        }
    }
}