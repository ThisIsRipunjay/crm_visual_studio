using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    [AutoGenerateTable(0)]
    [JengaEntity]
    [Alias("Team")]
    public class Member: IJengaAuth
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [JengaImage(200,200)]
        public byte[] Pic { get; set; }

        [JengaIdentifier]
        public string Name { get; set; }

        [JengaOptions("Male,Female,Non-Binary")]
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Title { get; set; }
        public string Department { get; set; } 

        [JengaOptions("Admin,Employee")]
        public string Role { get; set; } 
        public bool Active { get; set; } = true;

        [JengaTextArea]
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;


        public List<Lead> GetLeads()
        {
            return Kt.Db.Select<Models.Lead>(r => r.AssignedTo == this.Id);
        }

        [JengaVirtualColumn("Leads", "", 10)]
        public double GetLeadCount()
        {
            return Kt.Db.Count<Models.Lead>(r => r.AssignedTo == this.Id);
        }


        [JengaVirtualColumn("Open Leads", "", 11)]
        public double GetOpenLeadCount()
        {
            return Kt.Db.Count<Models.Lead>(r => r.AssignedTo == this.Id && !r.Stage.Contains("Closed"));
        }

        [JengaVirtualColumn("Lost Leads", "", 12)]
        public double GetlostLeadCount()
        {
            return Kt.Db.Count<Models.Lead>(r => r.AssignedTo == this.Id && r.Stage.Contains("Closed Lost"));
        }
        [JengaVirtualColumn("Won Leads", "", 12)]
        public double GetWonLeadCount()
        {
            return Kt.Db.Count<Models.Lead>(r => r.AssignedTo == this.Id && r.Stage.Contains("Closed Won"));
        }

    }
}
