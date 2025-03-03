using AutoMapper;
using Buytopia.BLL.Model;
using Buytopia.BLL.Service.Interfaces;
using Buytopia.DAL.Entities;
using Buytopia.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buytopia.BLL.Service
{
    public class OrderService : GenericService<OrderModel, Order>, IOrderService
    {
        public OrderService(IMapper mapper, IGenericRepository<Order> genericRepository) : base(mapper, genericRepository)
        {
        }
    }
}
