//Code Generated by Jenga.NET
			using System;
			using System.Collections.Generic;
			using System.ComponentModel;
			using System.Data;
			using System.Drawing;
			using System.Linq;
			using System.Text;
			using System.Threading.Tasks;
			using ServiceStack.OrmLite;
			using System.Windows.Forms; 
            using Newtonsoft.Json.Linq;
			using Jenga;
			//import;

			namespace CRM.Dialogs
			{

			public partial class Frm_Customer: Form
			{
			private CRM.Models.Customer _record;
			private CRM.Models.Customer _oldRecord;
            public Dictionary<string, object> FixedValues = new Dictionary<string, object>();

            public Func<CRM.Models.Customer, CRM.Models.Customer, bool> BeforeSave { get; set; } = null;
            public Action<CRM.Models.Customer> AfterSave { get; set; } = null;

			public Frm_Customer(Color themeColor,CRM.Models.Customer record = null, bool readOnly = false)
			{
			Cursor.Current = Cursors.WaitCursor;
			InitializeComponent();
			 //enable double buffer
            pnlContent.GetType()
               .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
               .SetValue(pnlContent, true, null);
			 
			if(record==null)
			_record = new CRM.Models.Customer(); //create new recoded
			else
			_record = record; //assign existing record

			//bind data to dropdowns
			var db = Kt.Db;
			//reference
 
			//disable controls if read-only mode
			if (readOnly)
			{
			foreach (Control ctrl in pnlContent.Controls)
			{
			if (ctrl.GetType() != typeof(Label))
			ctrl.Enabled = false;
			btnCancel.Enabled = true;
			}
			}
             JengaInit(themeColor);
			Cursor.Current = Cursors.Default;
			}
			private void btnCancel_Click(object sender, EventArgs e)
			{
			this.Close();
			}
			private void btnAdd_Click(object sender, EventArgs e)
			{
		    try
            {
			
			//check validation
			if (validationProvider.Validate().Length > 0)
			{
			Alert.Show(this, "Vaidation Error", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
			return;  //Return when validation fails
			}
			if (BeforeSave != null)
                 if (!BeforeSave.Invoke(_oldRecord, _record))
                        return;
			Kt.Db.Save(_record) ; //save changes to database
			 if (AfterSave != null)
                    AfterSave.Invoke(_record);
			Alert.Show(this, "Successfull", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
			 }
            catch (Exception err)
            {
                Alert.Show(this, err.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
			}
			  private void Frm_Load(object sender, EventArgs e) 
			  {
				    //check fixed Values
					if (this.FixedValues.Count() > 0)
					{
						//disable mentioned controls
						foreach (Control ctrl in pnlContent.Controls)
							   if (bindingProvider.GetLink(ctrl) != null && FixedValues.ContainsKey(bindingProvider.GetLink(ctrl).Data))
								ctrl.Enabled = false;

						//merge the pased values
						var tmp = JObject.FromObject(_record);
						foreach (var prop in this.FixedValues)
							tmp[prop.Key] = JToken.Parse(prop.Value.ToString());

						_record = tmp.ToObject<CRM.Models.Customer>();
					}

            //bind record to controls
            bindingProvider.Bind(_record);
				  /**load**/
			  }
			/**global**/
			}
			}