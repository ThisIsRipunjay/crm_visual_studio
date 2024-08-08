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
    [AutoGenerateTable(1)]
    [JengaEntity]
    [Alias("Contacts")]
    public class Customer 
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [JengaIdentifier]
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; } 
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        [JengaOptions("Person,Company,Government,Partner,Organization,Other")]
        public string Type { get; set; }

        [ForeignKey(typeof(Member), OnDelete = "CASCADE")]
        [JengaLink("Added By", "GetMemberName()")]
        public int AddedBy { get; set; }

        [JengaTextArea]
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

       
        public Member GetMember()
        {
            return Kt.Db.Single<Models.Member>(this.AddedBy);
        }

        public string GetMemberName()
        {
            return GetMember().Name;
        }
        public List<Lead> GetLeads()
        {
            return Kt.Db.Select<Models.Lead>(r=>r.CustomerId==this.Id);
        }

        [JengaVirtualColumn("Leads", "", 10)]
        public double GetLeadCount()
        {
            return Kt.Db.Count<Models.Lead>(r => r.CustomerId == this.Id);
        }


        [JengaVirtualColumn("Open Leads","",11)]
        public double GetOpenLeadCount()
        {
            return Kt.Db.Count<Models.Lead>(r => r.CustomerId == this.Id && !r.Stage.Contains("Closed"));
        }

        [JengaVirtualColumn("Lost Leads", "", 12)]
        public double GetlostLeadCount()
        {
            return Kt.Db.Count<Models.Lead>(r => r.CustomerId == this.Id && r.Stage.Contains("Closed Lost"));
        }
        [JengaVirtualColumn("Won Leads", "", 12)]
        public double GetWonLeadCount()
        {
            return Kt.Db.Count<Models.Lead>(r => r.CustomerId == this.Id && r.Stage.Contains("Closed Won"));
        }
    }
}
