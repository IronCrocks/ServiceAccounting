using AutoMapper;
using DTO;
using Model.Entites;
using Model.Projections;

namespace Presenter.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerOrderSummary, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();

            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();

            CreateMap<OrderSummary, OrderDTO>();
            CreateMap<OrderItemDTO, OrderItem>();
        }
    }
}
