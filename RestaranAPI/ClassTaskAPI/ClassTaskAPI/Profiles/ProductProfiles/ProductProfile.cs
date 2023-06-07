using AutoMapper;
using ClassTaskAPI.Models;
using ClassTaskAPI.Models.Dtos.Product;

namespace ClassTaskAPI.Profiles.ProductProfiles
{
    public class ProductProfile : Profile
    {
         public ProductProfile()
         {
             CreateMap<Product, GetProductDto>();
             CreateMap<Product, UpdateProductDto>();
             CreateMap<Product, CreateProductDto>();
         }
    }
}
