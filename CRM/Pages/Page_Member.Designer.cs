//Code Generated by Jenga.NET
            using System;
            using System.Collections.Generic;
            using System.Drawing;
            using System.Windows.Forms;

			namespace CRM.Pages
			{
			partial class Page_Member
			{

			private System.ComponentModel.IContainer components = null;

			protected override void Dispose(bool disposing)
			{
			if (disposing && (components != null))
			{
			components.Dispose();
			}
			base.Dispose(disposing);
			}

			#region Component Designer generated code

			private void InitializeComponent()
			{
			 this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		    System.Windows.Forms.DataGridViewCellStyle colProgressStyle = new System.Windows.Forms.DataGridViewCellStyle(); 
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
			this.grid = new Bunifu.UI.WinForms.BunifuDataGridView();
			this.colAvatar = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColEdit = new System.Windows.Forms.DataGridViewLinkColumn();
			this.colDel = new System.Windows.Forms.DataGridViewLinkColumn();
			this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.pnlActions = new System.Windows.Forms.Panel();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
              this.Alert = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
			 this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.pnlActions.SuspendLayout();
			this.column_Name = new System.Windows.Forms.DataGridViewLinkColumn();
this.cmbFilterGender = new Bunifu.UI.WinForms.BunifuDropdown();this.column_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
this.column_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
this.column_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
this.column_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
this.column_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
this.column_Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
this.column_GetLeadCount7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
this.column_GetOpenLeadCount8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
this.column_GetlostLeadCount9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
this.column_GetWonLeadCount10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//init
			this.SuspendLayout();

			//
			// colProgressStyle
			// 
            colProgressStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colProgressStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			//
			// grid
			//
			this.grid.AllowCustomTheming = true;
			this.grid.AllowUserToAddRows = false;
		    this.grid.AllowUserToResizeRows = false;
			this.grid.MultiSelect = false;
			this.grid.ReadOnly=true;
			this.grid.ContextMenuStrip = this.contextMenuStrip;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.grid.ColumnHeadersHeight = 40;
			this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colAvatar,
			column_Name,column_Gender,column_Email,column_Title,column_Department,column_Role,column_Active,column_GetLeadCount7,column_GetOpenLeadCount8,column_GetlostLeadCount9,column_GetWonLeadCount10,
			this.ColEdit,
			this.colDel});
			this.grid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
			this.grid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.grid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
			this.grid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
			this.grid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.grid.CurrentTheme.BackColor = System.Drawing.Color.White;
			this.grid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
			this.grid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
			this.grid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
			this.grid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.grid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
			this.grid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.grid.CurrentTheme.Name = null;
			this.grid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
			this.grid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.grid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.grid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
			this.grid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grid.DefaultCellStyle = dataGridViewCellStyle3;
			this.grid.EnableHeadersVisualStyles = false;
			this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
			this.grid.HeaderBackColor = System.Drawing.Color.DodgerBlue;
			this.grid.HeaderBgColor = System.Drawing.Color.Empty;
			this.grid.HeaderForeColor = System.Drawing.Color.White;
			this.grid.Location = new System.Drawing.Point(10, 59);
			this.grid.Name = "grid";
			this.grid.RowHeadersVisible = false;
			this.grid.RowTemplate.Height = 40;
			this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid.Size = new System.Drawing.Size(859, 627);
			this.grid.TabIndex = 0;
			this.grid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
			this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
			this.grid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentDoubleClick);
			this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            //
			// colAvatar
			//
			this.colAvatar.DataPropertyName = "Avatar(@Name)";
			this.colAvatar.HeaderText = "";
			this.colAvatar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.colAvatar.Name = "colAvatar";
            this.colAvatar.FillWeight = 30F;
			
                                    //
                                    //column_Name
                                    //
                                    this.column_Name.HeaderText = "Name";
                                    this.column_Name.FillWeight = 200F;
                                    this.column_Name.DataPropertyName = "Name";
                                    this.column_Name.Name = "column_Name";
                                    
                                    //
                                    // cmbFilterGender
                                    //
                                    
                                    this.cmbFilterGender.BorderRadius = 0;
                                    this.cmbFilterGender.Color = System.Drawing.SystemColors.Control;
                                    this.cmbFilterGender.Dock = System.Windows.Forms.DockStyle.Left;
                                    this.cmbFilterGender.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
                                    this.cmbFilterGender.IndicatorThickness = 2;
                                    this.cmbFilterGender.Name = "cmbFilterGender ";
                                    this.cmbFilterGender.Size = new System.Drawing.Size(150, 32);
                                    this.cmbFilterGender.Text = "Gender (All)";
                                    this.cmbFilterGender.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);  
                                    this.cmbFilterGender.IndicatorColor =  System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                                    this.cmbFilterGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                                    this.cmbFilterGender.BackgroundColor = System.Drawing.Color.Gainsboro;
                                    this.cmbFilterGender.BorderColor = System.Drawing.Color.Gainsboro;  
                                    this.cmbFilterGender.Items.AddRange(new object[] { "Gender (All)","Male","Female","Non-Binary"   });
                                    this.pnlActions.Controls.Add(this.cmbFilterGender );
                                    this.cmbFilterGender.SelectionChangeCommitted += new System.EventHandler(this.filters_SelectionChangeCommitted);
                                    
                                    //
                                    // column_Gender
                                    //
                                    this.column_Gender.HeaderText = "Gender";
                                    this.column_Gender.Name = "column_Gender";
                                    this.column_Gender.DataPropertyName = "Gender";
                                    this.column_Gender.ReadOnly = false;
                                    
                                    //
                                    // column_Email
                                    //
                                    this.column_Email.HeaderText = "Email";
                                    this.column_Email.Name = "column_Email";
                                    this.column_Email.DataPropertyName = "Email";
                                    this.column_Email.ReadOnly = false;
                                    
                                    //
                                    // column_Title
                                    //
                                    this.column_Title.HeaderText = "Title";
                                    this.column_Title.Name = "column_Title";
                                    this.column_Title.DataPropertyName = "Title";
                                    this.column_Title.ReadOnly = false;
                                    
                                    //
                                    // column_Department
                                    //
                                    this.column_Department.HeaderText = "Department";
                                    this.column_Department.Name = "column_Department";
                                    this.column_Department.DataPropertyName = "Department";
                                    this.column_Department.ReadOnly = false;
                                    
                                    //
                                    // column_Role
                                    //
                                    this.column_Role.HeaderText = "Role";
                                    this.column_Role.Name = "column_Role";
                                    this.column_Role.DataPropertyName = "Role";
                                    this.column_Role.ReadOnly = false;
                                    
                                    //
                                    // column_Active
                                    //
                                    this.column_Active.HeaderText = "Active";
                                    this.column_Active.Name = "column_Active";
                                    this.column_Active.DataPropertyName = "Active";
                                    this.column_Active.ReadOnly = false;
                                    
                            //
                            // column_GetLeadCount
                            //
                            this.column_GetLeadCount7.HeaderText = "Leads";
                            this.column_GetLeadCount7.Name = "column_GetLeadCount7";
                            this.column_GetLeadCount7.DataPropertyName = "{GetLeadCount()}";
                            this.column_GetLeadCount7.ReadOnly =true;
                            
                            //
                            // column_GetOpenLeadCount
                            //
                            this.column_GetOpenLeadCount8.HeaderText = "Open Leads";
                            this.column_GetOpenLeadCount8.Name = "column_GetOpenLeadCount8";
                            this.column_GetOpenLeadCount8.DataPropertyName = "{GetOpenLeadCount()}";
                            this.column_GetOpenLeadCount8.ReadOnly =true;
                            
                            //
                            // column_GetlostLeadCount
                            //
                            this.column_GetlostLeadCount9.HeaderText = "Lost Leads";
                            this.column_GetlostLeadCount9.Name = "column_GetlostLeadCount9";
                            this.column_GetlostLeadCount9.DataPropertyName = "{GetlostLeadCount()}";
                            this.column_GetlostLeadCount9.ReadOnly =true;
                            
                            //
                            // column_GetWonLeadCount
                            //
                            this.column_GetWonLeadCount10.HeaderText = "Won Leads";
                            this.column_GetWonLeadCount10.Name = "column_GetWonLeadCount10";
                            this.column_GetWonLeadCount10.DataPropertyName = "{GetWonLeadCount()}";
                            this.column_GetWonLeadCount10.ReadOnly =true;
                            //code
                                 

			//
			// ColEdit
			//
			this.ColEdit.DataPropertyName = "✏";
			this.ColEdit.FillWeight = 30F;
			this.ColEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.ColEdit.HeaderText = "";
			this.ColEdit.Name = "ColEdit";

			//
			// colDel
			//
			this.colDel.ActiveLinkColor = System.Drawing.Color.Crimson;
			this.colDel.DataPropertyName = "❌";
			this.colDel.FillWeight = 30F;
			this.colDel.HeaderText = "";
			this.colDel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.colDel.LinkColor = System.Drawing.Color.Crimson;
			this.colDel.Name = "colDel";
			this.colDel.TrackVisitedState = false;
			this.colDel.VisitedLinkColor = System.Drawing.Color.Crimson;

			//
			// txtSearch
			//
			this.txtSearch.AcceptsReturn = false;
			this.txtSearch.AcceptsTab = false;
			this.txtSearch.AnimationSpeed = 200;
			this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
			this.txtSearch.AutoSizeHeight = true;
			this.txtSearch.BackColor = System.Drawing.Color.Transparent;
			this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
			this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
			this.txtSearch.BorderRadius = 1;
			this.txtSearch.BorderThickness = 1;
			this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
			this.txtSearch.DefaultText = "";
			this.txtSearch.FillColor = System.Drawing.Color.White;
			this.txtSearch.HideSelection = true;
			this.txtSearch.IconLeft = null;
			this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSearch.IconPadding = 10;
			this.txtSearch.IconRight = null;
			this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSearch.Lines = new string[0];
			this.txtSearch.Location = new System.Drawing.Point(10, 12);
			this.txtSearch.MaxLength = 32767;
			this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
			this.txtSearch.Modified = false;
			this.txtSearch.Multiline = false;
			this.txtSearch.Name = "txtSearch";
			stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
			stateProperties1.FillColor = System.Drawing.Color.Empty;
			stateProperties1.ForeColor = System.Drawing.Color.Empty;
			stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txtSearch.OnActiveState = stateProperties1;
			stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txtSearch.OnDisabledState = stateProperties2;
			stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			stateProperties3.FillColor = System.Drawing.Color.Empty;
			stateProperties3.ForeColor = System.Drawing.Color.Empty;
			stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txtSearch.OnHoverState = stateProperties3;
			stateProperties4.BorderColor = System.Drawing.Color.Silver;
			stateProperties4.FillColor = System.Drawing.Color.White;
			stateProperties4.ForeColor = System.Drawing.Color.Empty;
			stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
			this.txtSearch.OnIdleState = stateProperties4;
			this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
			this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.txtSearch.PlaceholderText = "Search...";
			this.txtSearch.ReadOnly = false;
			this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtSearch.SelectedText = "";
			this.txtSearch.SelectionLength = 0;
			this.txtSearch.SelectionStart = 0;
			this.txtSearch.ShortcutsEnabled = true;
			this.txtSearch.Size = new System.Drawing.Size(269, 30);
			this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
			this.txtSearch.TabIndex = 2;
			this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSearch.TextMarginBottom = 0;
			this.txtSearch.TextMarginLeft = 3;
			this.txtSearch.TextMarginTop = 1;
			this.txtSearch.TextPlaceholder = "Search...";
			this.txtSearch.UseSystemPasswordChar = false;
			this.txtSearch.WordWrap = true;
			this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
			//
			// btnDelete
			//
			 this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(516, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 30);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "🗑";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			//
			// btnAdd
			//
			this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(486, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 30);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "✚";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			//
			// btnReload
			//
			this.btnReload.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnReload.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnReload.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReload.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnReload.ForeColor = System.Drawing.Color.White;
			this.btnReload.Location = new System.Drawing.Point(0, 0);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(40, 30);
			this.btnReload.TabIndex = 19;
			this.btnReload.Text = "🗘";
			this.btnReload.UseVisualStyleBackColor = false;
			this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
			//
			// pnlActions
			//
			this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlActions.Location = new System.Drawing.Point(321, 12);
			this.pnlActions.Name = "pnlActions";
			this.pnlActions.Size = new System.Drawing.Size(548, 30);
			this.pnlActions.TabIndex = 17; 
			this.pnlActions.Controls.Add(this.btnAdd);
			this.pnlActions.Controls.Add(this.btnDelete);
			this.pnlActions.Controls.Add(this.btnReload);
			//addFilter
			//
			// btnSearch
			//
			this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.7F, System.Drawing.FontStyle.Bold);
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(279, 12);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(42, 30);
			this.btnSearch.TabIndex = 18;
			this.btnSearch.Text = "🔎";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
		    // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
			//
			// UserControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.DoubleBuffered = true;
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.pnlActions);
			this.Name = "Page_Member";
			this.Size = new System.Drawing.Size(885, 703);
			this.Load += new System.EventHandler(this.Page_Member_Load);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.pnlActions.ResumeLayout(false);
			this.ResumeLayout(false);

			}
          #region  Jenga Generated Code
          public Dictionary<string, Action<CRM.Models.Member>> ActionButtons = new Dictionary<string, Action<CRM.Models.Member>>();
          public Dictionary<string, Func<CRM.Models.Member , bool>> ActionButtonsFilter = new Dictionary<string, Func<CRM.Models.Member , bool>>();

                public void JengaInit()
                {
                    grid.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor;
                    grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = ThemeColor;
                    grid.DefaultCellStyle.SelectionBackColor =System.Drawing.Color.Gainsboro;

                    btnAdd.BackColor
                        = btnReload.BackColor
                        = btnSearch.BackColor = ThemeColor;

                    ColEdit.LinkColor =
                        ColEdit.VisitedLinkColor = ThemeColor;

                    foreach (System.Windows.Forms.DataGridViewColumn col in grid.Columns)
                    {
                        if (col.GetType() != typeof(System.Windows.Forms.DataGridViewLinkColumn))
                            continue;
                        if (col == ColEdit || col == colDel)
                            continue;

                        ((System.Windows.Forms.DataGridViewLinkColumn)col).LinkColor =
                        ((System.Windows.Forms.DataGridViewLinkColumn)col).VisitedLinkColor =System.Drawing. Color.Black;
                        ((System.Windows.Forms.DataGridViewLinkColumn)col).ActiveLinkColor = this.ThemeColor;
                    }
                        int i = 0;
            foreach (var item in this.ActionButtons)
            {
                Button btnAction = new Button();
                btnAction.AutoSize = true;
                btnAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                btnAction.BackColor = System.Drawing.Color.Gainsboro;
                btnAction.Dock = System.Windows.Forms.DockStyle.Right;
                btnAction.FlatAppearance.BorderSize = 0;
                btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnAction.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
                btnAction.Location = new System.Drawing.Point(386, 0);
                btnAction.Name = "btnAction" + i;
                btnAction.Size = new System.Drawing.Size(82, 30);
                btnAction.TabIndex = 20; 
                btnAction.Text = "  " + item.Key + "  ";
                btnAction.UseVisualStyleBackColor = false;
                btnAction.Tag = item.Key;
                btnAction.Visible = false;
                btnAction.Click += new System.EventHandler(this.btnAction_Click);
                this.pnlActions.Controls.Add(btnAction);
                btnAction.BringToFront();

                grid.CellClick += (s, e) =>
                  {
                      var record = GetSelectedRecord();


                      if (!ActionButtonsFilter.ContainsKey(btnAction.Tag.ToString()))
                      {
                          btnAction.Visible = true;
                          return;
                      }

                    
                      var filter =  ActionButtonsFilter[btnAction.Tag.ToString()];

                      if (record == null)
                      {
                          btnAction.Visible = false;
                          return;
                      }
                      btnAction.Visible = filter.Invoke(record);
                  };

                i++;
            }

            /**JengaInit**/
           }
                 private void btnAction_Click(object sender, EventArgs e)
                {
                    var record = GetSelectedRecord();
                    if (record == null) return;

                    var _func = ActionButtons[((Button)sender).Tag.ToString()]; 
                    _func.Invoke(record); 
                }

              /**JengaGlobal**/

                #endregion
			#endregion

			public Bunifu.UI.WinForms.BunifuDataGridView grid;
		    public System.Windows.Forms.ContextMenuStrip contextMenuStrip;
			public Bunifu.UI.WinForms.BunifuTextBox txtSearch;
			public System.Windows.Forms.Button btnDelete;
			public System.Windows.Forms.Button btnAdd;
			public System.Windows.Forms.Panel pnlActions; 
			public System.Windows.Forms.DataGridViewImageColumn colAvatar;
			public System.Windows.Forms.DataGridViewLinkColumn ColEdit;
			public System.Windows.Forms.DataGridViewLinkColumn colDel;
			public System.Windows.Forms.Button btnSearch;
			public System.Windows.Forms.Button btnReload; 
            public Bunifu.UI.WinForms.BunifuSnackbar Alert;
			 public System.Windows.Forms.DataGridViewLinkColumn column_Name;
 public Bunifu.UI.WinForms.BunifuDropdown cmbFilterGender;public System.Windows.Forms.DataGridViewTextBoxColumn column_Gender;
public System.Windows.Forms.DataGridViewTextBoxColumn column_Email;
public System.Windows.Forms.DataGridViewTextBoxColumn column_Title;
public System.Windows.Forms.DataGridViewTextBoxColumn column_Department;
public System.Windows.Forms.DataGridViewTextBoxColumn column_Role;
public System.Windows.Forms.DataGridViewCheckBoxColumn column_Active;
public System.Windows.Forms.DataGridViewTextBoxColumn column_GetLeadCount7;
public System.Windows.Forms.DataGridViewTextBoxColumn column_GetOpenLeadCount8;
public System.Windows.Forms.DataGridViewTextBoxColumn column_GetlostLeadCount9;
public System.Windows.Forms.DataGridViewTextBoxColumn column_GetWonLeadCount10;
//declare


          

			}
			}