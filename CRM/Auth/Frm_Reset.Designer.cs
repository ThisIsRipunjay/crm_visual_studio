namespace CRM.Auth
{
    partial class Frm_Reset
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Kimtoo.ValidationProvider.ValidationObject validationObject1 = new Kimtoo.ValidationProvider.ValidationObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reset));
            Kimtoo.ValidationProvider.ValidationObject validationObject3 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject4 = new Kimtoo.ValidationProvider.ValidationObject();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Kimtoo.ValidationProvider.ValidationObject validationObject5 = new Kimtoo.ValidationProvider.ValidationObject();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Kimtoo.ValidationProvider.ValidationObject validationObject6 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject7 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject8 = new Kimtoo.ValidationProvider.ValidationObject();
            Kimtoo.ValidationProvider.ValidationObject validationObject9 = new Kimtoo.ValidationProvider.ValidationObject();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Kimtoo.ValidationProvider.ValidationObject validationObject2 = new Kimtoo.ValidationProvider.ValidationObject();
            this.AppBar = new Bunifu.Utils.BunifuAppBar();
            this.Alert = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.validationProvider = new Kimtoo.ValidationProvider.ValidationProvider();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.txtEmail = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPassword2 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuFormDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AppBar
            // 
            this.AppBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AppBar.ControlBoxColor = System.Drawing.Color.DarkGray;
            this.AppBar.ControlBoxColorActive = System.Drawing.Color.RoyalBlue;
            this.AppBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.AppBar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AppBar.Icon = null;
            validationObject1.CustomErrorMessage = "";
            validationObject1.Optional = false;
            validationObject1.PropertyName = "Text";
            validationObject1.Regex = null;
            validationObject1.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.AppBar, validationObject1);
            this.AppBar.Location = new System.Drawing.Point(351, 0);
            this.AppBar.Name = "AppBar";
            this.AppBar.Size = new System.Drawing.Size(436, 46);
            this.AppBar.TabIndex = 7;
            this.AppBar.Title = "";
            this.AppBar.TitleMargin = new System.Windows.Forms.Padding(47, 12, 0, 0);
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
            this.Alert.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
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
            this.Alert.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
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
            this.Alert.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
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
            this.Alert.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.Alert.WarningOptions.IconLeftMargin = 12;
            this.Alert.ZoomCloseIcon = true;
            // 
            // validationProvider
            // 
            this.validationProvider.ErrorColor = System.Drawing.Color.Crimson;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            validationObject3.CustomErrorMessage = "";
            validationObject3.Optional = false;
            validationObject3.PropertyName = "Text";
            validationObject3.Regex = null;
            validationObject3.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.bunifuGradientPanel1, validationObject3);
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(351, 458);
            this.bunifuGradientPanel1.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = false;
            this.txtEmail.AcceptsTab = false;
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.AnimationSpeed = 200;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.AutoSizeHeight = true;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmail.BackgroundImage")));
            this.txtEmail.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtEmail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.Gainsboro;
            this.txtEmail.BorderRadius = 1;
            this.txtEmail.BorderThickness = 0;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtEmail.DefaultText = "";
            this.txtEmail.Enabled = false;
            this.txtEmail.FillColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HideSelection = true;
            this.txtEmail.IconLeft = null;
            this.txtEmail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.IconPadding = 10;
            this.txtEmail.IconRight = null;
            this.txtEmail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Lines = new string[0];
            validationObject4.CustomErrorMessage = "";
            validationObject4.Optional = false;
            validationObject4.PropertyName = "Text";
            validationObject4.Regex = resources.GetString("validationObject4.Regex");
            validationObject4.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.Email;
            this.validationProvider.SetLink(this.txtEmail, validationObject4);
            this.txtEmail.Location = new System.Drawing.Point(375, 139);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtEmail.Modified = false;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Gainsboro;
            stateProperties4.FillColor = System.Drawing.Color.Gainsboro;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnIdleState = stateProperties4;
            this.txtEmail.Padding = new System.Windows.Forms.Padding(3);
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "Enter Email";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(384, 31);
            this.txtEmail.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtEmail.TabIndex = 14;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextMarginBottom = 0;
            this.txtEmail.TextMarginLeft = 3;
            this.txtEmail.TextMarginTop = 1;
            this.txtEmail.TextPlaceholder = "Enter Email";
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.WordWrap = true;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.AutoSizeHeight = true;
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Gainsboro;
            this.txtPassword.BorderRadius = 1;
            this.txtPassword.BorderThickness = 0;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            validationObject5.CustomErrorMessage = "";
            validationObject5.Optional = false;
            validationObject5.PropertyName = "Text";
            validationObject5.Regex = "(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{6,}$";
            validationObject5.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.Password;
            this.validationProvider.SetLink(this.txtPassword, validationObject5);
            this.txtPassword.Location = new System.Drawing.Point(375, 213);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Gainsboro;
            stateProperties8.FillColor = System.Drawing.Color.Gainsboro;
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties8;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(384, 31);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 15;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 3;
            this.txtPassword.TextMarginTop = 1;
            this.txtPassword.TextPlaceholder = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WordWrap = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DodgerBlue;
            validationObject6.CustomErrorMessage = "";
            validationObject6.Optional = false;
            validationObject6.PropertyName = "Text";
            validationObject6.Regex = null;
            validationObject6.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.btnCancel, validationObject6);
            this.btnCancel.Location = new System.Drawing.Point(544, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 40);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "CLOSE";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            validationObject7.CustomErrorMessage = "";
            validationObject7.Optional = false;
            validationObject7.PropertyName = "Text";
            validationObject7.Regex = null;
            validationObject7.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.btnReset, validationObject7);
            this.btnReset.Location = new System.Drawing.Point(644, 366);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 40);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "RESET     ➲";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            validationObject8.CustomErrorMessage = "";
            validationObject8.Optional = false;
            validationObject8.PropertyName = "Text";
            validationObject8.Regex = null;
            validationObject8.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.lblTitle, validationObject8);
            this.lblTitle.Location = new System.Drawing.Point(375, 71);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 32);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Reset password";
            // 
            // txtPassword2
            // 
            this.txtPassword2.AcceptsReturn = false;
            this.txtPassword2.AcceptsTab = false;
            this.txtPassword2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword2.AnimationSpeed = 200;
            this.txtPassword2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword2.AutoSizeHeight = true;
            this.txtPassword2.BackColor = System.Drawing.Color.White;
            this.txtPassword2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword2.BackgroundImage")));
            this.txtPassword2.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPassword2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPassword2.BorderColorIdle = System.Drawing.Color.Gainsboro;
            this.txtPassword2.BorderRadius = 1;
            this.txtPassword2.BorderThickness = 0;
            this.txtPassword2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword2.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPassword2.DefaultText = "";
            this.txtPassword2.FillColor = System.Drawing.Color.Gainsboro;
            this.txtPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword2.HideSelection = true;
            this.txtPassword2.IconLeft = null;
            this.txtPassword2.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword2.IconPadding = 10;
            this.txtPassword2.IconRight = null;
            this.txtPassword2.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword2.Lines = new string[0];
            validationObject9.CustomErrorMessage = "";
            validationObject9.Optional = false;
            validationObject9.PropertyName = "Text";
            validationObject9.Regex = "(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{6,}$";
            validationObject9.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.Password;
            this.validationProvider.SetLink(this.txtPassword2, validationObject9);
            this.txtPassword2.Location = new System.Drawing.Point(375, 287);
            this.txtPassword2.MaxLength = 32767;
            this.txtPassword2.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword2.Modified = false;
            this.txtPassword2.Multiline = false;
            this.txtPassword2.Name = "txtPassword2";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword2.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword2.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword2.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Gainsboro;
            stateProperties12.FillColor = System.Drawing.Color.Gainsboro;
            stateProperties12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword2.OnIdleState = stateProperties12;
            this.txtPassword2.Padding = new System.Windows.Forms.Padding(3);
            this.txtPassword2.PasswordChar = '●';
            this.txtPassword2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword2.PlaceholderText = "Password";
            this.txtPassword2.ReadOnly = false;
            this.txtPassword2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword2.SelectedText = "";
            this.txtPassword2.SelectionLength = 0;
            this.txtPassword2.SelectionStart = 0;
            this.txtPassword2.ShortcutsEnabled = true;
            this.txtPassword2.Size = new System.Drawing.Size(384, 31);
            this.txtPassword2.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPassword2.TabIndex = 19;
            this.txtPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword2.TextMarginBottom = 0;
            this.txtPassword2.TextMarginLeft = 3;
            this.txtPassword2.TextMarginTop = 1;
            this.txtPassword2.TextPlaceholder = "Password";
            this.txtPassword2.UseSystemPasswordChar = true;
            this.txtPassword2.WordWrap = true;
            // 
            // bunifuFormDock
            // 
            this.bunifuFormDock.AllowFormDragging = true;
            this.bunifuFormDock.AllowFormDropShadow = true;
            this.bunifuFormDock.AllowFormResizing = false;
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
            this.bunifuFormDock.DockingOptions.DockAll = false;
            this.bunifuFormDock.DockingOptions.DockBottomLeft = false;
            this.bunifuFormDock.DockingOptions.DockBottomRight = false;
            this.bunifuFormDock.DockingOptions.DockFullScreen = false;
            this.bunifuFormDock.DockingOptions.DockLeft = false;
            this.bunifuFormDock.DockingOptions.DockRight = false;
            this.bunifuFormDock.DockingOptions.DockTopLeft = false;
            this.bunifuFormDock.DockingOptions.DockTopRight = false;
            this.bunifuFormDock.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock.ParentForm = this;
            this.bunifuFormDock.ShowCursorChanges = true;
            this.bunifuFormDock.ShowDockingIndicators = false;
            this.bunifuFormDock.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock.TitleBarOptions.BunifuFormDock = this.bunifuFormDock;
            this.bunifuFormDock.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.bunifuFormDock.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            validationObject2.CustomErrorMessage = "";
            validationObject2.Optional = false;
            validationObject2.PropertyName = "Text";
            validationObject2.Regex = null;
            validationObject2.ValidationType = Kimtoo.ValidationProvider.ValidationTypes.None;
            this.validationProvider.SetLink(this.pictureBox2, validationObject2);
            this.pictureBox2.Location = new System.Drawing.Point(60, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // Frm_Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(787, 458);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.AppBar);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Reset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Utils.BunifuAppBar AppBar;
        public Kimtoo.ValidationProvider.ValidationProvider validationProvider;
        public Bunifu.UI.WinForms.BunifuSnackbar Alert;
        public Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock;
        public Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        public System.Windows.Forms.Label lblTitle;
        public Bunifu.UI.WinForms.BunifuTextBox txtEmail;
        public Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnReset;
        public Bunifu.UI.WinForms.BunifuTextBox txtPassword2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}