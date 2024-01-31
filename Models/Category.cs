using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKho1.Models
{
    internal class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
        public long CategoryID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string NameCategory { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
