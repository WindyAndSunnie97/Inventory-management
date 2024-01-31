using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKho1.Models
{
    internal class User
    {
        public User()
        {
            this.Documents = new HashSet<Document>();
        }
        public long UserID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string NameUser { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Email { get; set; }
        [Column(TypeName = "char(20)")]
        public string UserName { get; set; }
        [Column(TypeName = "char(50)")]
        public string Password { get; set; }
        public byte RoleID { get; set; }
        public ICollection<Document> Documents { get; set; }
    }
}
