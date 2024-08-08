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
    [AutoGenerateTable(3)]
    [JengaEntity]
    [Alias("Interactions")]
    public class Interaction
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [JengaIdentifier]
        public string Subject { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        [JengaOptions("Call,Email,Physical-Meeting,Video-Confrence")]
        public string Type { get; set; }

        [JengaTextArea]
        public string Notes { get; set; }

        [JengaFile("All FIles|*.*")]
        public byte[] Attachment { get; set; }

        [ForeignKey(typeof(Lead), OnDelete = "CASCADE")]
        [JengaLink("Lead", "GetLeadName()")]
        public int LeadId { get; set; }

        [ForeignKey(typeof(Member), OnDelete = "CASCADE")]
        [JengaLink("Added By", "GetMemberName()")]
        public int AddedBy { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;


        public Lead GetLead()
        {
            return Kt.Db.Single<Models.Lead>(this.LeadId);
        }

        public string GetLeadName()
        {
            return GetLead().LeadName;
        }

        public Member GetMember()
        {
            return Kt.Db.Single<Models.Member>(this.AddedBy);
        }

        public string GetMemberName()
        {
            return GetMember().Name;
        }

    }
}
