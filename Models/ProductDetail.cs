using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKho1.Models
{
    internal class ProductDetail
    {
        public ProductDetail ()
        {
            this.DcDetails = new HashSet<DcDetail> ();
        }
        public long ProductDetailID { get; set; }
        public int Quantity { get; set; }
        public long ProductID { get; set; }
        public long InventoryID { get; set; }
        public Product Product { get; set; }
        public Inventory Inventory { get; set; }
        public ICollection<DcDetail> DcDetails { get; set; }
        public object DocumentID { get; internal set; }
        public object Price { get; internal set; }
    }
}
