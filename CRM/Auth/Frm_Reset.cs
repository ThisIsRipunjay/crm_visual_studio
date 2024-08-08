using Jenga;
using ServiceStack.OrmLite;
using System;
using System.Windows.Forms;

namespace CRM.Auth
{
    [JengaIgnore]
    public partial class Frm_Reset : Form 
    {
        private readonly CRM.Models.Member _identity;

        public string ErrorMessage { get; set; } = "Passwords do not match.";
        public string SuccessMessage { get; set; } = "Password successfully Changed.";

        public Frm_Reset(CRM.Models.Member identity = null)
        {
            InitializeComponent();
            this._identity = identity;
            if (_identity == null) _identity = Authentication.GetIdentity<CRM.Models.Member>();
            txtEmail.Text = _identity.Email;
            lblTitle.Text = _identity.Password?.Trim().Length == 0 ? "Set Password" : "Reset Password";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //validate for errors
            if (validationProvider.Validate().Length > 0) return;

            //check if passwords are same
            if (txtPassword.Text.Trim() != txtPassword2.Text.Trim())
            {
                Alert.Show(this, this.ErrorMessage, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            //check user on database 
            _identity.Password = txtPassword.Text.Trim().ToSHA512Hash();
            Kt.Db.Save(_identity);
            Alert.Show(this, this.SuccessMessage, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
            Cursor.Current = Cursors.Default;
        }
    }
}