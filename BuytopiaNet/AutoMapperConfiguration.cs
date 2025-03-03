using AutoMapper;
using Buytopia.DAL.Entities;
using Buytopia.DAL.entityes;

namespace Buytopia.PL
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Category, CategoryModel>.ReverseMap();
            CreateMap<Order, OrderModel>.ReverseMap();
            CreateMap<Product, ProductModel>.ReverseMap();
            CreateMap<User, UserModel>.ReverseMap();


        }
    }
}
