using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buytopia.DAL.Entities
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }


        public ICollection<Product>? Products;


        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
