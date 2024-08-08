
namespace CRM.Dialogs
{
    partial class Frm_Lead_Interactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Lead_Interactions));
            this.bunifuFormDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.AppBar = new Bunifu.Utils.BunifuAppBar();
            this.page_Interaction1 = new CRM.Pages.Page_Interaction();
            this.SuspendLayout();
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
            this.bunifuFormDock.ShowDockingIndicators = false;
            this.bunifuFormDock.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock.TitleBarOptions.BunifuFormDock = this.bunifuFormDock;
            this.bunifuFormDock.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.bunifuFormDock.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // AppBar
            // 
            this.AppBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.AppBar.ControlBoxColor = System.Drawing.Color.WhiteSmoke;
            this.AppBar.ControlBoxColorActive = System.Drawing.Color.White;
            this.AppBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.AppBar.ForeColor = System.Drawing.Color.White;
            this.AppBar.Icon = ((System.Drawing.Image)(resources.GetObject("AppBar.Icon")));
            this.AppBar.Location = new System.Drawing.Point(0, 0);
            this.AppBar.Name = "AppBar";
            this.AppBar.Size = new System.Drawing.Size(1177, 46);
            this.AppBar.TabIndex = 7;
            this.AppBar.Title = "Lead Interactions";
            this.AppBar.TitleMargin = new System.Windows.Forms.Padding(47, 12, 0, 0);
            // 
            // page_Interaction1
            // 
            this.page_Interaction1.AllowAdd = true;
            this.page_Interaction1.AllowDelete = true;
            this.page_Interaction1.AllowEdit = true;
            this.page_Interaction1.AllowSearch = true;
            this.page_Interaction1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.page_Interaction1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.page_Interaction1.BeforeDelete = null;
            this.page_Interaction1.DataLimit = 0;
            this.page_Interaction1.Location = new System.Drawing.Point(8, 53);
            this.page_Interaction1.Name = "page_Interaction1";
            this.page_Interaction1.Size = new System.Drawing.Size(1162, 692);
            this.page_Interaction1.TabIndex = 8;
            this.page_Interaction1.ThemeColor = System.Drawing.Color.DodgerBlue;
            // 
            // Frm_Lead_Interactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1177, 755);
            this.Controls.Add(this.page_Interaction1);
            this.Controls.Add(this.AppBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Lead_Interactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Interactions";
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock;
        public Bunifu.Utils.BunifuAppBar AppBar;
        private Pages.Page_Interaction page_Interaction1;
    }
}