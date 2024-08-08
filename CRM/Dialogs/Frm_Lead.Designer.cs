//Code Generated by Jenga.NET 
            using System.Drawing;
            using System.Windows.Forms;

			namespace CRM.Dialogs
			{
			partial class Frm_Lead
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

			#region Windows Form Designer generated code

			private void InitializeComponent()
			{
			this.components = new System.ComponentModel.Container();
			this.Alert = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
			this.validationProvider = new Kimtoo.ValidationProvider.ValidationProvider();
			this.bindingProvider = new Kimtoo.BindingProvider.BindingProvider();
            this.themeProvider = new Kimtoo.ThemeProvider.ThemeProvider();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.AppBar = new Bunifu.Utils.BunifuAppBar();
			this.pnlContent = new System.Windows.Forms.Panel();
			this.bunifuFormDock = new Bunifu.UI.WinForms.BunifuFormDock();
		    this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.lblLeadName = new System.Windows.Forms.Label();
 Kimtoo.ValidationProvider.ValidationObject LeadNamevalidationObject = new Kimtoo.ValidationProvider.ValidationObject();
Kimtoo.BindingProvider.BindingProvider.BindingObject LeadNameBindingObject = new Kimtoo.BindingProvider.BindingProvider.BindingObject();
 this.txtLeadName = new Bunifu.UI.WinForms.BunifuTextBox();
this.lblDate = new System.Windows.Forms.Label();
 Kimtoo.ValidationProvider.ValidationObject DatevalidationObject = new Kimtoo.ValidationProvider.ValidationObject();
Kimtoo.BindingProvider.BindingProvider.BindingObject DateBindingObject = new Kimtoo.BindingProvider.BindingProvider.BindingObject();
 this.dtDate = new Bunifu.UI.WinForms.BunifuDatePicker();
this.lblStage = new System.Windows.Forms.Label();
 Kimtoo.ValidationProvider.ValidationObject StagevalidationObject = new Kimtoo.ValidationProvider.ValidationObject();
Kimtoo.BindingProvider.BindingProvider.BindingObject StageBindingObject = new Kimtoo.BindingProvider.BindingProvider.BindingObject();
 this.cmbStage = new Bunifu.UI.WinForms.BunifuDropdown();
this.lblAmount = new System.Windows.Forms.Label();
 Kimtoo.ValidationProvider.ValidationObject AmountvalidationObject = new Kimtoo.ValidationProvider.ValidationObject();
Kimtoo.BindingProvider.BindingProvider.BindingObject AmountBindingObject = new Kimtoo.BindingProvider.BindingProvider.BindingObject();
 this.txtAmount = new Bunifu.UI.WinForms.BunifuTextBox();
this.lblNotes = new System.Windows.Forms.Label();
 Kimtoo.ValidationProvider.ValidationObject NotesvalidationObject = new Kimtoo.ValidationProvider.ValidationObject();
Kimtoo.BindingProvider.BindingProvider.BindingObject NotesBindingObject = new Kimtoo.BindingProvider.BindingProvider.BindingObject();
 this.txtNotes = new Bunifu.UI.WinForms.BunifuTextBox();
this.lblAssignedTo = new System.Windows.Forms.Label();
 Kimtoo.ValidationProvider.ValidationObject AssignedTovalidationObject = new Kimtoo.ValidationProvider.ValidationObject();
Kimtoo.BindingProvider.BindingProvider.BindingObject AssignedToBindingObject = new Kimtoo.BindingProvider.BindingProvider.BindingObject();
 this.cmbAssignedTo = new Bunifu.UI.WinForms.BunifuDropdown();
this.lblCreatedAt = new System.Windows.Forms.Label();
 Kimtoo.ValidationProvider.ValidationObject CreatedAtvalidationObject = new Kimtoo.ValidationProvider.ValidationObject();
Kimtoo.BindingProvider.BindingProvider.BindingObject CreatedAtBindingObject = new Kimtoo.BindingProvider.BindingProvider.BindingObject();
 this.dtCreatedAt = new Bunifu.UI.WinForms.BunifuDatePicker();
this.lblBottom = new System.Windows.Forms.Label();
//init

			this.SuspendLayout();
			//
			// AppBar
			//
			this.AppBar.BackColor = System.Drawing.Color.DodgerBlue;
			this.AppBar.ControlBoxColor = System.Drawing.Color.WhiteSmoke;
			this.AppBar.ControlBoxColorActive = System.Drawing.Color.White;
			this.AppBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.AppBar.ForeColor = System.Drawing.Color.White;
			this.AppBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.validationProvider.SetLink(this.AppBar, null);
			this.bindingProvider.SetLink(this.AppBar, null);
			this.AppBar.Location = new System.Drawing.Point(3, 5);
			this.AppBar.Name = "Lead";
			this.AppBar.Size = new System.Drawing.Size(574, 46);
			this.AppBar.TabIndex = 6;
			this.AppBar.Title = "Lead";
			this.AppBar.TitleMargin = new System.Windows.Forms.Padding(47, 12, 0, 0);
			//
			// pnlContent
			//
			this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.validationProvider.SetLink(this.pnlContent, null);
			this.bindingProvider.SetLink(this.pnlContent, null);
			this.pnlContent.Location = new System.Drawing.Point(3, 51);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(590, 515);
			this.pnlContent.TabIndex = 7;
			this.pnlContent.AutoScroll = true;
			//
			// btnAdd
			//
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnAdd.FlatAppearance.BorderSize = 2;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.validationProvider.SetLink(this.btnAdd, null);
			this.bindingProvider.SetLink(this.btnAdd, null);
			this.btnAdd.Location = new System.Drawing.Point(435, 620);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(115, 40);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.Text = "SAVE";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			//
			// btnCancel
			//
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnCancel.FlatAppearance.BorderSize = 2;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.DodgerBlue;
			this.validationProvider.SetLink(this.btnCancel, null);
			this.bindingProvider.SetLink(this.btnCancel, null);
			this.btnCancel.Location = new System.Drawing.Point(335,  620);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(94, 40);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "CANCEL";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			//
			// bunifuFormDock
			//
			this.bunifuFormDock.AllowFormDragging = true;
			this.bunifuFormDock.AllowFormDropShadow = true;
			this.bunifuFormDock.AllowFormResizing = true;
			this.bunifuFormDock.AllowHidingBottomRegion = true;
			this.bunifuFormDock.AllowOpacityChangesWhileDragging = false;
			this.bunifuFormDock.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
			this.bunifuFormDock.BorderOptions.BottomBorder.BorderThickness = 1;
			this.bunifuFormDock.BorderOptions.BottomBorder.ShowBorder = true;
			this.bunifuFormDock.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
			this.bunifuFormDock.BorderOptions.LeftBorder.BorderThickness = 1;
			this.bunifuFormDock.BorderOptions.LeftBorder.ShowBorder = true;
			this.bunifuFormDock.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
			this.bunifuFormDock.BorderOptions.RightBorder.BorderThickness = 1;
			this.bunifuFormDock.BorderOptions.RightBorder.ShowBorder = true;
			this.bunifuFormDock.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
			this.bunifuFormDock.BorderOptions.TopBorder.BorderThickness = 1;
			this.bunifuFormDock.BorderOptions.TopBorder.ShowBorder = true;
			this.bunifuFormDock.ContainerControl = this;
			this.bunifuFormDock.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
			this.bunifuFormDock.DockingIndicatorsOpacity = 0.5D;
			this.bunifuFormDock.DockingOptions.DockAll = true;
			this.bunifuFormDock.DockingOptions.DockBottomLeft = true;
			this.bunifuFormDock.DockingOptions.DockBottomRight = true;
			this.bunifuFormDock.DockingOptions.DockFullScreen = true;
			this.bunifuFormDock.DockingOptions.DockLeft = true;
			this.bunifuFormDock.DockingOptions.DockRight = true;
			this.bunifuFormDock.DockingOptions.DockTopLeft = true;
			this.bunifuFormDock.DockingOptions.DockTopRight = true;
			this.bunifuFormDock.FormDraggingOpacity = 0.9D;
			this.bunifuFormDock.ParentForm = this;
			this.bunifuFormDock.ShowCursorChanges = true;
			this.bunifuFormDock.ShowDockingIndicators = true;
		    this.bunifuFormDock.ShowCursorChanges = true;
            this.bunifuFormDock.ShowDockingIndicators = false;
            this.bunifuFormDock.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock.TitleBarOptions.BunifuFormDock = this.bunifuFormDock;
            this.bunifuFormDock.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.bunifuFormDock.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock.TitleBarOptions.UseBackColorOnDockingIndicators = false; 
			//
			// Alert
			//
			this.Alert.AllowDragging = false;
			this.Alert.AllowMultipleViews = true;
			this.Alert.ClickToClose = true;
			this.Alert.DoubleClickToClose = true;
			this.Alert.DurationAfterIdle = 3000;
			this.Alert.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Alert.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Alert.ErrorOptions.ActionBorderRadius = 1;
			this.Alert.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.Alert.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
			this.Alert.ErrorOptions.BackColor = System.Drawing.Color.White;
			this.Alert.ErrorOptions.BorderColor = System.Drawing.Color.White;
			this.Alert.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
			this.Alert.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.Alert.ErrorOptions.ForeColor = System.Drawing.Color.Black;
			this.Alert.ErrorOptions.IconLeftMargin = 12;
			this.Alert.FadeCloseIcon = false;
			this.Alert.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
			this.Alert.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Alert.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Alert.InformationOptions.ActionBorderRadius = 1;
			this.Alert.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.Alert.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
			this.Alert.InformationOptions.BackColor = System.Drawing.Color.White;
			this.Alert.InformationOptions.BorderColor = System.Drawing.Color.White;
			this.Alert.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
			this.Alert.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.Alert.InformationOptions.ForeColor = System.Drawing.Color.Black;
			this.Alert.InformationOptions.IconLeftMargin = 12;
			this.Alert.Margin = 10;
			this.Alert.MaximumSize = new System.Drawing.Size(0, 0);
			this.Alert.MaximumViews = 7;
			this.Alert.MessageRightMargin = 15;
			this.Alert.MinimumSize = new System.Drawing.Size(0, 0);
			this.Alert.ShowBorders = false;
			this.Alert.ShowCloseIcon = false;
			this.Alert.ShowIcon = true;
			this.Alert.ShowShadows = true;
			this.Alert.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Alert.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Alert.SuccessOptions.ActionBorderRadius = 1;
			this.Alert.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.Alert.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
			this.Alert.SuccessOptions.BackColor = System.Drawing.Color.White;
			this.Alert.SuccessOptions.BorderColor = System.Drawing.Color.White;
			this.Alert.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
			this.Alert.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.Alert.SuccessOptions.ForeColor = System.Drawing.Color.Black;
			this.Alert.SuccessOptions.IconLeftMargin = 12;
			this.Alert.ViewsMargin = 7;
			this.Alert.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Alert.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Alert.WarningOptions.ActionBorderRadius = 1;
			this.Alert.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.Alert.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
			this.Alert.WarningOptions.BackColor = System.Drawing.Color.White;
			this.Alert.WarningOptions.BorderColor = System.Drawing.Color.White;
			this.Alert.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
			this.Alert.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.Alert.WarningOptions.ForeColor = System.Drawing.Color.Black;
			this.Alert.WarningOptions.IconLeftMargin = 12;
			this.Alert.ZoomCloseIcon = true;

			
                    //
                    // lblLeadName
                    //
                    this.lblLeadName.AutoSize = true;
                    this.lblLeadName.Location = new System.Drawing.Point(25, 30);
                    this.lblLeadName.Name = "lblLeadName";
                    this.lblLeadName.Text = "Lead Name*";
                    this.themeProvider.SetLink(this.lblLeadName, null);
                    this.pnlContent.Controls.Add(this.lblLeadName);

                    

                LeadNamevalidationObject.Optional = false;
                LeadNamevalidationObject.Regex = "";
                LeadNamevalidationObject.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.CustomRegex;

                
            LeadNameBindingObject.Data = "LeadName";
            LeadNameBindingObject.TwoWay = true;

            
                      this.txtLeadName.Location = new System.Drawing.Point(150, 20);
                     
                    this.txtLeadName.Size = new System.Drawing.Size(400, 39);
                     
                this.txtLeadName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
                this.txtLeadName.PlaceholderText = "Enter LeadName";
                this.txtLeadName.ReadOnly = false;
                this.txtLeadName.BackColor = System.Drawing.Color.White;
                 LeadNamevalidationObject.PropertyName = "Text";
                 LeadNameBindingObject.Property = "Text";
                this.validationProvider.SetLink(this.txtLeadName, LeadNamevalidationObject);
                this.bindingProvider.SetLink(this.txtLeadName, LeadNameBindingObject);
                this.themeProvider.SetLink(this.txtLeadName, null);
                this.pnlContent.Controls.Add(this.txtLeadName);

                
                    //
                    // lblDate
                    //
                    this.lblDate.AutoSize = true;
                    this.lblDate.Location = new System.Drawing.Point(25, 100);
                    this.lblDate.Name = "lblDate";
                    this.lblDate.Text = "Date*";
                    this.themeProvider.SetLink(this.lblDate, null);
                    this.pnlContent.Controls.Add(this.lblDate);

                    

                DatevalidationObject.Optional = false;
                DatevalidationObject.Regex = "";
                DatevalidationObject.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.CustomRegex;

                
            DateBindingObject.Data = "Date";
            DateBindingObject.TwoWay = true;

            

                this.dtDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
                this.dtDate.BackColor = System.Drawing.Color.White;
                this.dtDate.BorderColor = System.Drawing.Color.Silver;
                this.dtDate.CalendarMonthBackground = System.Drawing.Color.White;
                this.dtDate.CalendarTitleBackColor = System.Drawing.Color.LightSteelBlue;
                this.dtDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.dtDate.CalendarTrailingForeColor = System.Drawing.Color.Gray;
                this.dtDate.Color = System.Drawing.Color.Silver;
                this.dtDate.ForeColor = System.Drawing.Color.Black;
                this.dtDate.IconColor = System.Drawing.Color.Gray;
                this.dtDate.Location = new System.Drawing.Point(150, 90);
                this.dtDate.Name = "dtDate";
                this.dtDate.Size = new System.Drawing.Size(400, 32);
                this.dtDate.TabIndex = 14;

                 DatevalidationObject.PropertyName = "Value";
                 DateBindingObject.Property = "Value";
                this.validationProvider.SetLink(this.dtDate, DatevalidationObject);
                this.bindingProvider.SetLink(this.dtDate, DateBindingObject);
                this.pnlContent.Controls.Add(this.dtDate);
                this.themeProvider.SetLink(this.dtDate, null);
                
                    //
                    // lblStage
                    //
                    this.lblStage.AutoSize = true;
                    this.lblStage.Location = new System.Drawing.Point(25, 170);
                    this.lblStage.Name = "lblStage";
                    this.lblStage.Text = "Stage*";
                    this.themeProvider.SetLink(this.lblStage, null);
                    this.pnlContent.Controls.Add(this.lblStage);

                    

                StagevalidationObject.Optional = false;
                StagevalidationObject.Regex = "";
                StagevalidationObject.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.CustomRegex;

                
            StageBindingObject.Data = "Stage";
            StageBindingObject.TwoWay = true;

            

                this.cmbStage.Name = "cmbStage";
                this.cmbStage.Size = new System.Drawing.Size(400, 39);
                this.cmbStage.Location = new System.Drawing.Point(150, 160);
	            this.cmbStage.BackColor = System.Drawing.Color.White;
                this.cmbStage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
                this.cmbStage.Items.AddRange(new object[] {"Prospecting","Appointment","Presentation","Bought-In","Contract","Closed Won","Closed Lost"});
                this.validationProvider.SetLink(this.cmbStage, StagevalidationObject);
                 StageBindingObject.Property = "Text";
                 this.bindingProvider.SetLink(this.cmbStage, StageBindingObject);
                this.themeProvider.SetLink(this.cmbStage, null);
                this.pnlContent.Controls.Add(this.cmbStage);
                 
                    //
                    // lblAmount
                    //
                    this.lblAmount.AutoSize = true;
                    this.lblAmount.Location = new System.Drawing.Point(25, 240);
                    this.lblAmount.Name = "lblAmount";
                    this.lblAmount.Text = "Amount*";
                    this.themeProvider.SetLink(this.lblAmount, null);
                    this.pnlContent.Controls.Add(this.lblAmount);

                    

                AmountvalidationObject.Optional = false;
                AmountvalidationObject.Regex = "^[0-9]*(\\.[0-9]{1,4})?$";
                AmountvalidationObject.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.CustomRegex;

                
            AmountBindingObject.Data = "Amount";
            AmountBindingObject.TwoWay = true;

            
                      this.txtAmount.Location = new System.Drawing.Point(150, 230);
                     
                    this.txtAmount.Size = new System.Drawing.Size(400, 39);
                     
                this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
                this.txtAmount.PlaceholderText = "Enter Amount";
                this.txtAmount.ReadOnly = false;
                this.txtAmount.BackColor = System.Drawing.Color.White;
                 AmountvalidationObject.PropertyName = "Text";
                 AmountBindingObject.Property = "Text";
                this.validationProvider.SetLink(this.txtAmount, AmountvalidationObject);
                this.bindingProvider.SetLink(this.txtAmount, AmountBindingObject);
                this.themeProvider.SetLink(this.txtAmount, null);
                this.pnlContent.Controls.Add(this.txtAmount);

                
                    //
                    // lblNotes
                    //
                    this.lblNotes.AutoSize = true;
                    this.lblNotes.Location = new System.Drawing.Point(25, 310);
                    this.lblNotes.Name = "lblNotes";
                    this.lblNotes.Text = "Notes";
                    this.themeProvider.SetLink(this.lblNotes, null);
                    this.pnlContent.Controls.Add(this.lblNotes);

                    

                NotesvalidationObject.Optional = true;
                NotesvalidationObject.Regex = "";
                NotesvalidationObject.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.CustomRegex;

                
            NotesBindingObject.Data = "Notes";
            NotesBindingObject.TwoWay = true;

            
                      this.txtNotes.Location = new System.Drawing.Point(150, 300);
                     
                    this.txtNotes.Multiline=true;
                    this.txtNotes.Size = new System.Drawing.Size(400, 130);
                     
                this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
                this.txtNotes.PlaceholderText = "Enter Notes";
                this.txtNotes.ReadOnly = false;
                this.txtNotes.BackColor = System.Drawing.Color.White;
                 NotesvalidationObject.PropertyName = "Text";
                 NotesBindingObject.Property = "Text";
                this.validationProvider.SetLink(this.txtNotes, NotesvalidationObject);
                this.bindingProvider.SetLink(this.txtNotes, NotesBindingObject);
                this.themeProvider.SetLink(this.txtNotes, null);
                this.pnlContent.Controls.Add(this.txtNotes);

                
                    //
                    // lblAssignedTo
                    //
                    this.lblAssignedTo.AutoSize = true;
                    this.lblAssignedTo.Location = new System.Drawing.Point(25, 480);
                    this.lblAssignedTo.Name = "lblAssignedTo";
                    this.lblAssignedTo.Text = "Assigned To*";
                    this.themeProvider.SetLink(this.lblAssignedTo, null);
                    this.pnlContent.Controls.Add(this.lblAssignedTo);

                    

                AssignedTovalidationObject.Optional = false;
                AssignedTovalidationObject.Regex = "";
                AssignedTovalidationObject.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.CustomRegex;

                
            AssignedToBindingObject.Data = "AssignedTo";
            AssignedToBindingObject.TwoWay = true;

            

                this.cmbAssignedTo.ValueMember = "Id";
                this.cmbAssignedTo.DisplayMember = "Name";

                this.cmbAssignedTo.Name = "cmbAssignedTo";
                this.cmbAssignedTo.Size = new System.Drawing.Size(400, 39);
                this.cmbAssignedTo.Location = new System.Drawing.Point(150, 470);
	            this.cmbAssignedTo.BackColor = System.Drawing.Color.White;
                this.cmbAssignedTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
                this.validationProvider.SetLink(this.cmbAssignedTo, AssignedTovalidationObject);
                 AssignedToBindingObject.Property = "SelectedValue";
                 this.bindingProvider.SetLink(this.cmbAssignedTo, AssignedToBindingObject);
                 this.themeProvider.SetLink(this.cmbAssignedTo, null);
                 this.pnlContent.Controls.Add(this.cmbAssignedTo);

                 
                    //
                    // lblCreatedAt
                    //
                    this.lblCreatedAt.AutoSize = true;
                    this.lblCreatedAt.Location = new System.Drawing.Point(25, 550);
                    this.lblCreatedAt.Name = "lblCreatedAt";
                    this.lblCreatedAt.Text = "Created At*";
                    this.themeProvider.SetLink(this.lblCreatedAt, null);
                    this.pnlContent.Controls.Add(this.lblCreatedAt);

                    

                CreatedAtvalidationObject.Optional = false;
                CreatedAtvalidationObject.Regex = "";
                CreatedAtvalidationObject.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.CustomRegex;

                
            CreatedAtBindingObject.Data = "CreatedAt";
            CreatedAtBindingObject.TwoWay = true;

            

                this.dtCreatedAt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
                this.dtCreatedAt.BackColor = System.Drawing.Color.White;
                this.dtCreatedAt.BorderColor = System.Drawing.Color.Silver;
                this.dtCreatedAt.CalendarMonthBackground = System.Drawing.Color.White;
                this.dtCreatedAt.CalendarTitleBackColor = System.Drawing.Color.LightSteelBlue;
                this.dtCreatedAt.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.dtCreatedAt.CalendarTrailingForeColor = System.Drawing.Color.Gray;
                this.dtCreatedAt.Color = System.Drawing.Color.Silver;
                this.dtCreatedAt.ForeColor = System.Drawing.Color.Black;
                this.dtCreatedAt.IconColor = System.Drawing.Color.Gray;
                this.dtCreatedAt.Location = new System.Drawing.Point(150, 540);
                this.dtCreatedAt.Name = "dtCreatedAt";
                this.dtCreatedAt.Size = new System.Drawing.Size(400, 32);
                this.dtCreatedAt.TabIndex = 14;

                 CreatedAtvalidationObject.PropertyName = "Value";
                 CreatedAtBindingObject.Property = "Value";
                this.validationProvider.SetLink(this.dtCreatedAt, CreatedAtvalidationObject);
                this.bindingProvider.SetLink(this.dtCreatedAt, CreatedAtBindingObject);
                this.pnlContent.Controls.Add(this.dtCreatedAt);
                this.themeProvider.SetLink(this.dtCreatedAt, null);
                
                     this.dtCreatedAt.Enabled=false;
                   
                    //
                    //lblBottom
                    //
                    this.lblBottom.AutoSize = true;
                    this.lblBottom.Location = new System.Drawing.Point(25, 670);
                    this.lblBottom.Name = "lblBottom";
                    this.lblBottom.Text = "";
                    this.themeProvider.SetLink(this.lblBottom, null);
                    this.pnlContent.Controls.Add(this.lblBottom);

                    //code

			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(599, 573);
			this.MaximizeBox = false;
			this.Name = "Frm_Lead";
			this.Text = "Frm_Lead";
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Load += new System.EventHandler(this.Frm_Load);
			this.Controls.Add(this.pnlContent);
			this.Controls.Add(this.AppBar);
			this.pnlContent.Controls.Add(this.btnCancel);
			this.pnlContent.Controls.Add(this.btnAdd); 
			this.ResumeLayout(false);
			}

        #region  Jenga Generated Code
        public void JengaInit(Color themeColor)
        {
            AppBar.BackColor = themeColor; 
            foreach (Control ctrl in pnlContent.Controls)
            {
                if (ctrl.GetType() == typeof(Bunifu.UI.WinForms.BunifuTextBox))
                {
                    var ctr = (Bunifu.UI.WinForms.BunifuTextBox)ctrl;
                    ctr.OnHoverState.BorderColor
                        = ctr.OnActiveState.BorderColor
                        = themeColor;

                }
                else if (ctrl.GetType() == typeof(Bunifu.UI.WinForms.BunifuDropdown))
                {
                    var ctr = (Bunifu.UI.WinForms.BunifuDropdown)ctrl;
                    ctr.ItemHighLightColor = themeColor;
                    ctr.ItemHighLightForeColor = Color.White;
                }
                else if (ctrl.GetType() == typeof(LinkLabel))
                {
                    var ctr = (LinkLabel)ctrl;
                    ctr.LinkColor
                        = ctr.VisitedLinkColor
                        = themeColor;
                }
                else if (ctrl.GetType() == typeof(Button))
                {
                    var ctr = (Button)ctrl;
                    ctr.FlatAppearance.BorderColor = themeColor;

                    if (ctr.Name == "btnAdd")
                        ctr.BackColor = themeColor;
                    else
                        ctr.ForeColor = themeColor;
                }
                else if (ctrl.GetType() == typeof(Bunifu.UI.WinForms.BunifuCheckBox))
                {
                    var ctr = (Bunifu.UI.WinForms.BunifuCheckBox)ctrl;
                    ctr.OnCheck.BorderColor = themeColor;
                    ctr.OnCheck.CheckBoxColor = themeColor;

                    ctr.OnUncheck.BorderColor = themeColor;
                    ctr.OnUncheck.CheckBoxColor = Color.WhiteSmoke;

                }

            }
        } 
        #endregion

			#endregion
			public Kimtoo.ValidationProvider.ValidationProvider validationProvider;
			public Kimtoo.BindingProvider.BindingProvider bindingProvider;
		    public Kimtoo.ThemeProvider.ThemeProvider themeProvider;
			public System.Windows.Forms.Button btnAdd;
			public System.Windows.Forms.Button btnCancel;
			public Bunifu.Utils.BunifuAppBar AppBar;
			public System.Windows.Forms.Panel pnlContent;
			public Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock;
			public Bunifu.UI.WinForms.BunifuSnackbar Alert;
		    public System.Windows.Forms.OpenFileDialog openFileDialog;
			public System.Windows.Forms.SaveFileDialog saveFileDialog;
			public System.Windows.Forms.Label lblLeadName;
public Bunifu.UI.WinForms.BunifuTextBox txtLeadName;
public System.Windows.Forms.Label lblDate;
public Bunifu.UI.WinForms.BunifuDatePicker dtDate;
public System.Windows.Forms.Label lblStage;
  public Bunifu.UI.WinForms.BunifuDropdown cmbStage;
public System.Windows.Forms.Label lblAmount;
public Bunifu.UI.WinForms.BunifuTextBox txtAmount;
public System.Windows.Forms.Label lblNotes;
public Bunifu.UI.WinForms.BunifuTextBox txtNotes;
public System.Windows.Forms.Label lblAssignedTo;
  public Bunifu.UI.WinForms.BunifuDropdown cmbAssignedTo;
public System.Windows.Forms.Label lblCreatedAt;
public Bunifu.UI.WinForms.BunifuDatePicker dtCreatedAt;
public System.Windows.Forms.Label lblBottom;
//declare
			}
			}