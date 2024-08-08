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

namespace CRM.Pages
{
    public partial class Page_Dashboard : UserControl
    {
        public Page_Dashboard()
        {
            if (IsInDesignMode()) return;
            InitializeComponent();
            LoadData();
        }

        private static bool IsInDesignMode()
              => (Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1);
        bool IsAdmin()
    => (Jenga.Authentication.GetIdentity<Models.Member>().Role == "Admin");

        Models.Member GetMember()
              => Jenga.Authentication.GetIdentity<Models.Member>();


        public void LoadData()
        {
            var allLeads = Kt.Db.Select<Models.Lead>();

            if (!IsAdmin())
                allLeads = allLeads.Where(r => r.AssignedTo == GetMember().Id).ToList() ;

            //chart 1
            dc1.Data.Clear();
            var data = allLeads.GroupBy(r => r.Stage);
            foreach (var stage in c1.Labels)
            {
                int val = 0;
                if (data.Where(r => r.Key == stage).Count() > 0)
                    val = data.FirstOrDefault(r => r.Key == stage).Count();

                dc1.Data.Add(val);
            }
            c1.Update(true);

            //chart 2

            d1c2.Data.Clear();
            d2c2.Data.Clear();
            d3c2.Data.Clear();

            var data2 = allLeads.GroupBy(r => r.AssignedTo).OrderByDescending(r => r.Count()).Take(10);
            var lbl = new List<string>();

            foreach (var memLeads in data2)
            {
                var member = Kt.Db.SingleById<Models.Member>(memLeads.Key);
                lbl.Add(member.Name);
                d1c2.Data.Add(memLeads.Where(r => !r.Stage.ToLower().Contains("closed")).Count());
                d2c2.Data.Add(memLeads.Where(r => r.Stage.ToLower() == ("closed lost")).Count());
                d3c2.Data.Add(memLeads.Where(r => r.Stage.ToLower() == ("closed won")).Count());
            }
            c2.Labels = lbl.ToArray();
            c2.Update(true);


            //chart 3

            d1c3.Data.Clear();
            d2c3.Data.Clear();
            d3c3.Data.Clear();
            lbl.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Today.Month); i++)
            {
                lbl.Add(i.ToString());
                var mleads = allLeads.Where(r => r.Date.Year == DateTime.Today.Year && r.Date.Month == DateTime.Now.Month && r.Date.Day == i);
                d1c3.Data.Add(mleads.Where(r => r.Stage.ToLower() == ("closed won")).Count());
                d2c3.Data.Add(mleads.Where(r => r.Stage.ToLower() == ("closed lost")).Count());
                d3c3.Data.Add(Math.Round(mleads.Where(r => r.Stage.ToLower() == ("closed won")).Sum(r => r.Amount) / 1000, 2));

            }

            c3.Labels = lbl.ToArray();
            c3.Update(true);

            //chart 4

            d1c4.Data.Clear();
            d2c4.Data.Clear();
            d3c4.Data.Clear();
            lbl.Clear();
            for (int i = 1; i <= 12; i++)
            {
                lbl.Add(i.ToString());
                var mleads = allLeads.Where(r => r.Date.Year == DateTime.Today.Year && r.Date.Month == i);
                d1c4.Data.Add(mleads.Where(r => r.Stage.ToLower() == ("closed won")).Count());
                d2c4.Data.Add(mleads.Where(r => r.Stage.ToLower() == ("closed lost")).Count());
                d3c4.Data.Add(Math.Round(mleads.Where(r => r.Stage.ToLower() == ("closed won")).Sum(r => r.Amount) / 1000, 2));

            }

            c4.Labels = lbl.ToArray();
            c4.Update(true);


            //open widgets
            l1.Text = allLeads.Count().ToString("N0");
            l2.Text = allLeads.Where(r => !r.Stage.ToLower().Contains("closed")).Count().ToString("N0");
            l3.Text = allLeads.Where(r => r.Stage.ToLower() == ("closed lost")).Count().ToString("N0");
            l4.Text = allLeads.Where(r => r.Stage.ToLower() == ("closed won")).Count().ToString("N0");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
