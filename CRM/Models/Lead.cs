using Kimtoo.BindingProvider;
using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    [AutoGenerateTable(2)]
    [JengaEntity]
    [Alias("Leads")]
    public class Lead
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [JengaIdentifier]
        public string LeadName { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        [ForeignKey(typeof(Customer), OnDelete = "CASCADE")]
        [JengaLink("Customer", "GetCustomerName()")]
        public int CustomerId { get; set; }

        [JengaOptions("Prospecting,Appointment,Presentation,Bought-In,Contract,Closed Won,Closed Lost")]
        [JengaLink("Stage", "GetStage()")]
        public string Stage { get; set; }
        public double Amount { get; set; }

        [JengaTextArea]
        public string Notes { get; set; }

        [ForeignKey(typeof(Member), OnDelete = "CASCADE")]
        public int AddedBy { get; set; }

        [ForeignKey(typeof(Member), OnDelete = "CASCADE")]
        [JengaLink("Assigned To", "GetMemberName()")]
        public int AssignedTo { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Customer GetCustomer()
        {
            return Kt.Db.SingleById<Models.Customer>(this.CustomerId);
        }
        public string GetCustomerName()
        {
            return GetCustomer().Name;
        }
        public Member GetMember()
        {
            return Kt.Db.SingleById<Models.Member>(this.AssignedTo);
        }

        public string GetMemberName()
        {
            return GetMember().Name;
        }
        public Color GetStageColor()
        {
            if (this.Stage == "Prospecting")
                return Color.Black;

            if (this.Stage == "Appointment")
                return Color.DodgerBlue;

            if (this.Stage == "Presentation")
                return Color.Turquoise;

            if (this.Stage == "Bought-In")
                return Color.Teal;

            if (this.Stage == "Contract")
                return Color.Teal;

            if (this.Stage == "Closed Won")
                return Color.LimeGreen;

            return Color.Crimson;
        }
        public int GetProgressPass()
        {
            if (this.Stage == "Prospecting")
                return 10;

            if (this.Stage == "Appointment")
                return 35;

            if (this.Stage == "Presentation")
                return 50;

            if (this.Stage == "Bought-In")
                return 70;

            if (this.Stage == "Contract")
                return 85;

            if (this.Stage == "Closed Won")
                return 100;

            return 100;
        }

        public DataGridViewBadge GetStage()
        {
            return new DataGridViewBadge
            {
                BackColor = GetStageColor(),
                Value = this.Stage,
                ForeColor = Color.White,
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold)

            };
             
        }

        [JengaVirtualColumn("Interactions", "", 11)]
        public double GetInteractions()
        {
            return Kt.Db.Count<Models.Interaction>(r => r.LeadId == this.Id);
        }


        [JengaVirtualColumn("", "", 12)]
        public DatagridViewProgressBar GetProgresssBar()
        {
            return new DatagridViewProgressBar
            {
                BackColor = Color.DarkGray,
                FillColor = GetStageColor(),
                Maximum = 100,
                Value = GetProgressPass()
            };
        }

    }
}
