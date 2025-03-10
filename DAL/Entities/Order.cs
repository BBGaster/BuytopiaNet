﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buytopia.DAL.Entities
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public int CommissionCost { get; set; }
        public int SpeditionCost { get; set; }
        public int TotalPrice { get; set; }

        public int UserId { get; set; }
        public virtual User? User { get; set; }


        public ICollection<Product> Products;


        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
