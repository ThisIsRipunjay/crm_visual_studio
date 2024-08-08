using Jenga;
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

namespace CRM.Auth
{
    [JengaIgnore]
    public partial class Frm_Login : Form
    {
        public string ErrorMessage { get; set; } = "Incorrect Email or Password.";

        public Frm_Login()
        {
            InitializeComponent();

#if DEBUG
            txtEmail.Text = "admin@email.com";
            txtPassword.Text = "A00000";
#endif

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {


                //set up database on first connection
                if (Kt.Db.Count<Models.Company>() == 0)
                    Kt.Db.Save<Models.Company>(new Models.Company
                    {
                        Name = "Untitled"
                    }) ;

                //add first admin
                if (Kt.Db.Count<Models.Member>() == 0)
                    Kt.Db.Save<Models.Member>(new Models.Member
                    {
                        Name = "Default Admin",
                        Role="Admin",
                        Email = "admin@email.com",
                        Password = "A00000".ToSHA512Hash()
                    });


                //validate for errors
                if (validationProvider.Validate().Length > 0) return;
                Cursor.Current = Cursors.WaitCursor;
                //check user on database
                var account = Kt.Db.Select<CRM.Models.Member>(
                                  r => r.Email.ToString().ToLower() == txtEmail.Text.Trim().ToLower()
                                       && r.Password == txtPassword.Text.ToSHA512Hash()
                                ).FirstOrDefault();
                Cursor.Current = Cursors.Default;

                if (account == null)  //did  not match any user
                {
                    Alert.Show(this, this.ErrorMessage, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                    return;
                }

                //set identity authentication for easy access
                Authentication.SetIdentity(account);

                //give  feedback close the form
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            catch (Exception err)
            {
                Alert.Show(this, err.Message,Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kimtoo.DbManager.Connections.Show();
        }
    }
}