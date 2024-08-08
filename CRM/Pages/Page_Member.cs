//Code Generated by Jenga.NET
			using System;
			using System.Collections.Generic;
			using System.ComponentModel;
			using System.Data;
			using System.Drawing;
			using System.Linq;
			using System.Text;
			using System.Threading.Tasks;
			using System.Windows.Forms;
			using Kimtoo.BindingProvider;
			using ServiceStack.OrmLite;
			namespace CRM.Pages
			{
			public partial class Page_Member : UserControl
			{
           
	 		public bool AllowAdd { get; set; } = true;
			public bool AllowDelete { get; set; } = true;
			public bool AllowEdit { get; set; } = true;
			public bool AllowSearch { get; set; } = true; 
		    public int DataLimit { get; set; } = 0;
		    public Func<CRM.Models.Member, bool> BeforeDelete { get; set; } = null;
		    public Dictionary<string, object> FixedValues = new Dictionary<string, object>();
            public Dictionary<string, Action<CRM.Models.Member>> CustomContextMenu = new Dictionary<string, Action<CRM.Models.Member>>();
            private Func<IEnumerable< CRM.Models.Member>, IEnumerable<CRM.Models.Member>> _dataFilter = null;
		    public delegate void JengaEventHandler(CRM.Models.Member e);
            public event JengaEventHandler SelectionChanged = null;
            private Color _theme = Color.DodgerBlue;
            public Color ThemeColor { get => _theme; set { _theme = value;JengaInit(); } } 
			public Page_Member()
			{
			InitializeComponent();

			}

			private static bool IsInDesignMode()
			=> (Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1);

			public void LoadData()
			{
			Cursor.Current = Cursors.WaitCursor;
		
			var data = Kt.Db.Select<CRM.Models.Member>();
			//-filter Gender
if (cmbFilterGender.SelectedIndex > 0)
  data = data.Where(r => r.Gender == cmbFilterGender.SelectedItem.ToString()).ToList();
//filter
            if (_dataFilter != null)
                data = _dataFilter.Invoke(data).ToList();
			
			if (DataLimit > 0)
                data = data.Take(DataLimit).ToList();
			grid.Bind(data);
			Cursor.Current = Cursors.Default;
			}
			private void grid_SelectionChanged(object sender, EventArgs e)
			{
				SelectionChanged?.Invoke(grid.GetRecord<CRM.Models.Member>());
			}
			public CRM.Models.Member GetSelectedRecord()
				{
					return grid.GetRecord<CRM.Models.Member>();
				}
			public IEnumerable<CRM.Models.Member> GetCurrentRecords()
			{
				return grid.GetRecords<CRM.Models.Member>();
			}
		  
            public void SetDataFilter(Func<IEnumerable<CRM.Models.Member>, IEnumerable<CRM.Models.Member>> predicate)
            {
                _dataFilter = predicate;
                LoadData();
            }
		   
		    public void ClearDataFilter()
			{
				_dataFilter = null;
				LoadData();
			}

			private void LoadFilters()
			{
			Cursor.Current = Cursors.WaitCursor;
			txtSearch.Text = "";
			var db = Kt.Db;
			//fetch-filter
			Cursor.Current = Cursors.Default;
			}
			private void Page_Member_Load(object sender, EventArgs e)
			{
          
			ColEdit.Visible = this.AllowEdit;
			btnAdd.Visible = this.AllowAdd;
			txtSearch.Visible = btnSearch.Visible = this.AllowSearch;
			grid.AllowUserToDeleteRows = colDel.Visible = btnDelete.Visible = this.AllowDelete; 
			//disable rendering on design time
			if (IsInDesignMode()) return;
			LoadFilters();
            //load Custom ContextMenu 
             foreach (var menu in this.CustomContextMenu)
                contextMenuStrip.Items.Add(menu.Key, null, (s, ee) => menu.Value.Invoke(grid.GetRecord<CRM.Models.Member>()));

			//-Add code for deletion using Binding Provider 
if(this.AllowDelete) 
 grid.OnDelete<CRM.Models.Member>((r, i) => Kt.Db.Delete(r) > 0);
 //init
			LoadData();
            JengaInit();
			}

			private void btnAdd_Click(object sender, EventArgs e)
			 {
			     var frm  = new  CRM.Dialogs.Frm_Member(this.ThemeColor);
frm.FixedValues = this.FixedValues;
frm.ShowDialog();
LoadData(); 
			 }

			private void btnDelete_Click(object sender, EventArgs e)
			{ 
	        try
            {
                if (BeforeDelete != null)
                    if (!BeforeDelete.Invoke(GetSelectedRecord()))
                        return;
				 grid.DeleteRow<CRM.Models.Member>();
				  }
            catch (Exception)
            {
            }
			}

			private void txtSearch_KeyUp(object sender, KeyEventArgs e)
			{
			if (e.KeyCode == Keys.Enter)
			{
			if (txtSearch.Text.Trim().Length > 0)
			grid.SearchRows(txtSearch.Text);
			else
			LoadData();
			}
			}
			private void btnSearch_Click(object sender, EventArgs e)
			{
			if (txtSearch.Text.Trim().Length > 0)
			grid.SearchRows(txtSearch.Text);
			else
			LoadData();
			}
			private void filters_SelectionChangeCommitted(object sender, EventArgs e)
			{
			txtSearch.Reset();
			LoadData();
			}
			private void grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
			{
			
                                        if (e.ColumnIndex == column_Name.Index)
                                        {
                                           var db = Kt.Db;
                                           new CRM.Dialogs.Frm_Member(this.ThemeColor,grid.GetRecord<CRM.Models.Member>(), !this.AllowEdit).ShowDialog();
                                        }
                                     //frmLink
                                      
			}

			private void btnReload_Click(object sender, EventArgs e)
			{
			LoadFilters();
			LoadData();
			}
		    private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
            => e.Cancel = !(grid.SelectedRows.Count > 0 && CustomContextMenu.Count() > 0);
            private void dateRange_ValueChanged(object sender, EventArgs e)
            => this.LoadData();
			private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
			{
			if (e.ColumnIndex == ColEdit.Index)
			 { 
				  var frm = new CRM.Dialogs.Frm_Member(this.ThemeColor,grid.GetRecord<CRM.Models.Member>());
frm.FixedValues = this.FixedValues;
frm.ShowDialog();//edit
LoadData();
				 
			 } 
		    	if (e.ColumnIndex == colDel.Index)
			    grid.DeleteRow<CRM.Models.Member>();

	           /**cell-click**/

			}

			}
			}