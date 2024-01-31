using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKho1.Models
{
    internal class Document
    {
        internal readonly object Inventory;

        public Document()
        {
            this.DcDetails = new HashSet<DcDetail>();
        }
        public long DocumentID { get; set; }
        public long PersonID { get; set; }
        public long UserID { get; set; }
        [Column(TypeName = "Date")]
        public DateTime CreateDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public byte Classify { get; set; }
        public ICollection<DcDetail> DcDetails { get; set; }
        public Person Person { get; set; }
        public User User { get; set; }
    }
}
