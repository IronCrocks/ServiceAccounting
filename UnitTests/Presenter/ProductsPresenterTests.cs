using DTO;
using Model.Data;
using Model.Services.Base;
using Moq;
using Presenter;
using View.Base;
using View.ViewEventArgs;

namespace UnitTests.Presenter
{
    [TestFixture]
    public class ProductsPresenterTests
    {
        private Mock<IProductsView> _viewMock;
        private Mock<IProductsService> _serviceMock;
        private ProductsPresenter _presenter;

        [SetUp]
        public void Setup()
        {
            _viewMock = new Mock<IProductsView>();
            _serviceMock = new Mock<IProductsService>();
            _presenter = new ProductsPresenter(_viewMock.Object, _serviceMock.Object);
        }

        [Test]
        public void ViewLoaded_RaisesEvent_LoadProducts()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "P1", Description = "D1", Price = 10 }
            };

            _serviceMock.Setup(s => s.GetProducts()).Returns(products);

            _viewMock.Raise(v => v.ViewLoaded += null, EventArgs.Empty);

            _viewMock.Verify(v => v.LoadData(It.Is<List<ProductDTO>>(l => l.Count == 1 && l[0].Name == "P1")), Times.Once);
        }

        [Test]
        public void ProductAdded_RaiseEvent_AddProduct()
        {
            var productDTO = new ProductDTO { Name = "P1", Description = "D1", Price = 10 };
            _serviceMock.Setup(s => s.AddProduct(It.IsAny<Product>())).Returns(42);

            var args = new ProductEventArgs(productDTO);
            _viewMock.Raise(v => v.ProductAdded += null, args);

            Assert.That(productDTO.Id, Is.EqualTo(42));
        }

        [Test]
        public void ProductChanged_RaiseEvent_UpdateProduct()
        {
            var productDTO = new ProductDTO { Id = 1, Name = "Updated", Description = "Updated Desc", Price = 20 };
            var existingProduct = new Product { Id = 1, Name = "Old", Description = "Old Desc", Price = 10 };
            _serviceMock.Setup(s => s.GetProductById(1)).Returns(existingProduct);

            var args = new ProductEventArgs(productDTO);
            _viewMock.Raise(v => v.ProductChanged += null, args);

            _serviceMock.Verify(s => s.UpdateProduct(It.Is<Product>(p =>
                p.Name == "Updated" && p.Description == "Updated Desc" && p.Price == 20)), Times.Once);
        }

        [Test]
        public void ProductChanged_NullProduct_ThrowsException()
        {
            var productDTO = new ProductDTO { Id = 999 };
            _serviceMock.Setup(s => s.GetProductById(999)).Returns((Product)null);

            var args = new ProductEventArgs(productDTO);

            Assert.Throws<ArgumentNullException>(() => _viewMock.Raise(v => v.ProductChanged += null, args));
        }

        [Test]
        public void ProductDeleted_RaiseEvent_DeleteProduct()
        {
            var productDTO = new ProductDTO { Id = 1 };
            var existingProduct = new Product { Id = 1, Name = "P", Description = "D", Price = 10 };
            _serviceMock.Setup(s => s.GetProductById(1)).Returns(existingProduct);

            var args = new ProductEventArgs(productDTO);
            _viewMock.Raise(v => v.ProductDeleted += null, args);

            _serviceMock.Verify(s => s.RemoveProduct(existingProduct), Times.Once);
        }

        [Test]
        public void ProductDeleted_NullProduct_ThrowsException()
        {
            var productDTO = new ProductDTO { Id = 999 };
            _serviceMock.Setup(s => s.GetProductById(999)).Returns((Product)null);

            var args = new ProductEventArgs(productDTO);

            Assert.Throws<ArgumentNullException>(() => _viewMock.Raise(v => v.ProductDeleted += null, args));
        }
    }
}
