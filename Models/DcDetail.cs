using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKho1.Models
{
    internal class DcDetail
    {
        public DcDetail()
        {
        }
        public long DcDetailID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public long DocumentID { get; set; }
        public long ProductDetailID {  get; set; }
        public ProductDetail ProductDetail {  get; set; }
        public Document Document { get; set; }
    }
}
