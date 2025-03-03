using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buytopia.BLL.Model
{
    public class OrderModel
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public int CommissionCost { get; set; }
        public int SpeditionCost { get; set; }
        public int TotalPrice { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
