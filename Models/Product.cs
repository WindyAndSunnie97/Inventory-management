using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKho1.Models
{
    internal class Product
    {
        public Product()
        {
            this.Details = new HashSet<ProductDetail>();
        }

        public long ProductID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string NameProduct { get; set; }
        public int Price { get; set; }
        public long CategoryID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Origin { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductDetail> Details { get; set; }
    }
}
