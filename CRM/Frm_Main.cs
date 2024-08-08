using CRM.Models;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class Frm_Main : Form
    {
        private Company _company;

        public Frm_Main()
        {

            //auth 
            if (new Auth.Frm_Login().ShowDialog() != DialogResult.Yes)
                Environment.Exit(0);

            InitializeComponent();

            this._company = Kt.Db.Select<Models.Company>().FirstOrDefault();
            bunifuAppBar1.Title = "   " + _company.Name + " › Dashboard";
            page_Customer1.FixedValues.Add("AddedBy", GetMember().Id);

            ///add buttons on cutomers
            page_Lead2.FixedValues.Add("CustomerId", 1);
            page_Lead2.FixedValues.Add("AddedBy", GetMember().Id);
            page_Lead2.SetDataFilter(r => new List<Lead>());
            page_Customer1.grid.CellClick += (s, e) =>
            {
                var c = page_Customer1.GetSelectedRecord();
                if (c == null)
                {
                    page_Lead2.SetDataFilter(r => new List<Lead>());
                    return;
                }

                if (IsAdmin())
                    page_Lead2.SetDataFilter(r => r.Where(rr => rr.CustomerId == c.Id));
                else 
                    page_Lead2.SetDataFilter(r => r.Where(rr => rr.CustomerId == c.Id && rr.AssignedTo == GetMember().Id));


                page_Lead2.FixedValues["CustomerId"] = c.Id;
            };

            page_Member1.ActionButtons.Add("Change Password",
                (r) => new Auth.Frm_Reset(r).ShowDialog());

            page_Lead2.column_Date.DefaultCellStyle.Format = page_Lead1.column_Date.DefaultCellStyle.Format = "d";


            //limit leads if its for that employee 
            if (!IsAdmin())
            {
                page_Lead1.SetDataFilter(r => r.Where(rr => rr.AssignedTo == GetMember().Id));
                page_Lead2.FixedValues.Add("AssignedTo", GetMember().Id);
                page_Lead1.cmbFilterAssignedTo.Visible =
                page_Lead2.cmbFilterAssignedTo.Visible = false;
                page_Customer1.cmbFilterAddedBy.Visible = false;
            }

            //link interactions
            page_Lead2.FixedValues.Add("LeadId", 0); 
            page_Lead2.ActionButtons.Add("View Interactions",(r)=>    new Dialogs.Frm_Lead_Interactions(r).ShowDialog() );
          
        }

        bool IsAdmin()
         => (Jenga.Authentication.GetIdentity<Models.Member>().Role == "Admin");

        Member GetMember()
              => Jenga.Authentication.GetIdentity<Models.Member>();

        private void btnNav_Click(object sender, EventArgs e)
        {
            var btn = (Control)sender;

            if (btn.Tag == "Team" && Jenga.Authentication.GetIdentity<Models.Member>().Role == "Employee")
            {
                Alert.Show(this, "Access denied", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }


            pages.SetPage(btn.Tag.ToString());
            indicator.Top = btn.Top + (btn.Height / 2 - indicator.Height / 2);
            bunifuAppBar1.Title = "   " + _company.Name + " › " + btn.Tag.ToString();
        }

        private void bunifuIconButton5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            bunifuFormDock1.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;


        }
        private void bunifuIconButton3_Click(object sender, EventArgs e)
        {
            //open my profile here
            new Dialogs.Frm_Member(page_Customer1.ThemeColor, Jenga.Authentication.GetIdentity<Models.Member>()).ShowDialog();
        }

        private void bunifuIconButton7_Click(object sender, EventArgs e)
        {
            if (Jenga.Authentication.GetIdentity<Models.Member>().Role == "Employee")
            {
                Alert.Show(this, "Access denied", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            new Dialogs.Frm_Company(page_Customer1.ThemeColor, _company).ShowDialog();
            bunifuAppBar1.Title = "   " + _company.Name + " › " + pages.SelectedTab.Text;
        }
    }
}
