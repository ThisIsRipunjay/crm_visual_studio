using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Dialogs
{
    public partial class Frm_Lead_Interactions : Form
    {
        public Frm_Lead_Interactions(Models.Lead lead)
        {
            InitializeComponent(); 

            page_Interaction1.SetDataFilter(r=>r.Where(rr=>rr.LeadId==lead.Id));
            page_Interaction1.FixedValues.Add("AddedBy",Jenga.Authentication.GetIdentity<Models.Member>().Id);
            page_Interaction1.FixedValues["LeadId"] = lead.Id;
        }
    }
}
