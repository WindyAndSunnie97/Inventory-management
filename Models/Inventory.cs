using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKho1.Models
{
    internal class Inventory
    {
        public Inventory()
        {
            this.ProductDetails = new HashSet<ProductDetail>();
        }
        public long InventoryID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string NameInventory { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
