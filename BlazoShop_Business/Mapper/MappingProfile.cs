using AutoMapper;
using BlazorShop_DataAccess;
using BlazorShop_DataAccess.ViewModel;
using BlazorShop_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazoShop_Business.Mapper
{
    public class MappingProfile: Profile
    {

        public MappingProfile() 
        {
            CreateMap<Category,CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<ProductPrice, ProductPriceDTO>().ReverseMap();
            CreateMap<OrderHeader, OrderHeaderDTO>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailDTO>().ReverseMap();
            CreateMap<OrderDTO, Order>().ReverseMap();
            //CreateMap<CategoryDTO, Category>();
        }
    }
}
