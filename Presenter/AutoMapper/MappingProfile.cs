using AutoMapper;
using DTO;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>();
            // CreateMap<Source, Destination>();
            // Example: CreateMap<OrderItem, OrderItemData>();
            // Example: CreateMap<Customer, CustomerData>();
            // Example: CreateMap<Product, ProductData>();
            // Example: CreateMap<Order, OrderData>();
        }
    }
    
}
