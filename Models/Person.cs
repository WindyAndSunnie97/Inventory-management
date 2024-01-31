using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKho1.Models
{
    internal class Person
    {
        public Person()
        {
            this.Documents = new HashSet<Document>();
        }
        public long PersonID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public String NamePerson { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public String Address { get; set; }
        [Column(TypeName = "char(10)")]
        public String Phone { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public String? Email { get; set; }
        public ICollection<Document> Documents { get; set; }
    }
}
