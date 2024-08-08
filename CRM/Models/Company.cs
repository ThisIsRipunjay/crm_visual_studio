using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    [AutoGenerateTable(0)]
    [JengaEntity] 
    public class Company  
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [JengaImage(200, 200)]
        public byte[] Logo { get; set; } 

        [JengaIdentifier]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }  
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
