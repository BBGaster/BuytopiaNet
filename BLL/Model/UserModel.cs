using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buytopia.BLL.Model
{
    public class UserModel
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string BillingAddress { get; set; }
        public bool IsVendor { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
