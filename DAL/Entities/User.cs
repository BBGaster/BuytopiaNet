using Buytopia.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buytopia.DAL.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string BillingAddress { get; set; }
        public bool IsVendor { get; set; }



        public ICollection<Order>? Orders;

        //Prodotti messi in vendita dall'utente
        public ICollection<Product>? Products;

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }




    }
}
