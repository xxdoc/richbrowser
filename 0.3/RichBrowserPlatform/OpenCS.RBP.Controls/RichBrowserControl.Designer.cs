﻿namespace OpenCS.RBP.Controls
{
    partial class RichBrowserControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainerMain = new System.Windows.Forms.ToolStripContainer();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.dockPanelMain = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStripWeb = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelWeb = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripPlugins = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelPlugins = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonShowPlugins = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripAddress = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelAddress = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxUrl = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonGo = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            this.toolStripContainerMain.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainerMain.ContentPanel.SuspendLayout();
            this.toolStripContainerMain.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.toolStripWeb.SuspendLayout();
            this.toolStripPlugins.SuspendLayout();
            this.toolStripAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(824, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // toolbarsToolStripMenuItem
            // 
            this.toolbarsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webBarToolStripMenuItem,
            this.addressBarToolStripMenuItem,
            this.pluginsToolStripMenuItem});
            this.toolbarsToolStripMenuItem.Name = "toolbarsToolStripMenuItem";
            this.toolbarsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.toolbarsToolStripMenuItem.Text = "Toolbars";
            // 
            // webBarToolStripMenuItem
            // 
            this.webBarToolStripMenuItem.CheckOnClick = true;
            this.webBarToolStripMenuItem.Name = "webBarToolStripMenuItem";
            this.webBarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.webBarToolStripMenuItem.Text = "Web";
            this.webBarToolStripMenuItem.Click += new System.EventHandler(this.OnMenuItemCheckedChanged);
            // 
            // addressBarToolStripMenuItem
            // 
            this.addressBarToolStripMenuItem.CheckOnClick = true;
            this.addressBarToolStripMenuItem.Name = "addressBarToolStripMenuItem";
            this.addressBarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.addressBarToolStripMenuItem.Text = "Address";
            this.addressBarToolStripMenuItem.Click += new System.EventHandler(this.OnMenuItemCheckedChanged);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.CheckOnClick = true;
            this.pluginsToolStripMenuItem.Image = global::OpenCS.RBP.Controls.Properties.Resources.plugin;
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pluginsToolStripMenuItem.Text = "Plugins";
            this.pluginsToolStripMenuItem.Click += new System.EventHandler(this.OnMenuItemCheckedChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.statusBarToolStripMenuItem.Text = "StatusBar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.OnMenuItemCheckedChanged);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // toolStripContainerMain
            // 
            // 
            // toolStripContainerMain.BottomToolStripPanel
            // 
            this.toolStripContainerMain.BottomToolStripPanel.Controls.Add(this.statusStripMain);
            // 
            // toolStripContainerMain.ContentPanel
            // 
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.dockPanelMain);
            this.toolStripContainerMain.ContentPanel.Size = new System.Drawing.Size(824, 302);
            this.toolStripContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainerMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainerMain.Name = "toolStripContainerMain";
            this.toolStripContainerMain.Size = new System.Drawing.Size(824, 374);
            this.toolStripContainerMain.TabIndex = 2;
            this.toolStripContainerMain.Text = "toolStripContainer1";
            // 
            // toolStripContainerMain.TopToolStripPanel
            // 
            this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripWeb);
            this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripPlugins);
            this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripAddress);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage});
            this.statusStripMain.Location = new System.Drawing.Point(0, 0);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(824, 22);
            this.statusStripMain.TabIndex = 0;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // dockPanelMain
            // 
            this.dockPanelMain.ActiveAutoHideContent = null;
            this.dockPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelMain.Location = new System.Drawing.Point(0, 0);
            this.dockPanelMain.Name = "dockPanelMain";
            this.dockPanelMain.ShowDocumentIcon = true;
            this.dockPanelMain.Size = new System.Drawing.Size(824, 302);
            this.dockPanelMain.TabIndex = 0;
            // 
            // toolStripWeb
            // 
            this.toolStripWeb.CanOverflow = false;
            this.toolStripWeb.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripWeb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelWeb,
            this.toolStripButtonNew,
            this.toolStripSeparator2,
            this.toolStripButtonBack,
            this.toolStripButtonForward,
            this.toolStripSeparator1,
            this.toolStripButtonStop,
            this.toolStripButtonRefresh,
            this.toolStripButtonHome});
            this.toolStripWeb.Location = new System.Drawing.Point(0, 0);
            this.toolStripWeb.Name = "toolStripWeb";
            this.toolStripWeb.Size = new System.Drawing.Size(824, 25);
            this.toolStripWeb.Stretch = true;
            this.toolStripWeb.TabIndex = 3;
            // 
            // toolStripLabelWeb
            // 
            this.toolStripLabelWeb.Name = "toolStripLabelWeb";
            this.toolStripLabelWeb.Size = new System.Drawing.Size(34, 22);
            this.toolStripLabelWeb.Text = "Web:";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.Image = global::OpenCS.RBP.Controls.Properties.Resources.page_white_world;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonNew.Text = "New";
            this.toolStripButtonNew.Click += new System.EventHandler(this.OnWebButtonClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.Image = global::OpenCS.RBP.Controls.Properties.Resources.arrow_left;
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonBack.Text = "Back";
            this.toolStripButtonBack.Click += new System.EventHandler(this.OnWebButtonClick);
            // 
            // toolStripButtonForward
            // 
            this.toolStripButtonForward.Image = global::OpenCS.RBP.Controls.Properties.Resources.arrow_right;
            this.toolStripButtonForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonForward.Name = "toolStripButtonForward";
            this.toolStripButtonForward.Size = new System.Drawing.Size(70, 22);
            this.toolStripButtonForward.Text = "Forward";
            this.toolStripButtonForward.Click += new System.EventHandler(this.OnWebButtonClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.Image = global::OpenCS.RBP.Controls.Properties.Resources.stop;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonStop.Text = "Stop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.OnWebButtonClick);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.Image = global::OpenCS.RBP.Controls.Properties.Resources.arrow_refresh;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonRefresh.Text = "Refresh";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.OnWebButtonClick);
            // 
            // toolStripButtonHome
            // 
            this.toolStripButtonHome.Image = global::OpenCS.RBP.Controls.Properties.Resources.house;
            this.toolStripButtonHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHome.Name = "toolStripButtonHome";
            this.toolStripButtonHome.Size = new System.Drawing.Size(60, 22);
            this.toolStripButtonHome.Text = "Home";
            this.toolStripButtonHome.Click += new System.EventHandler(this.OnWebButtonClick);
            // 
            // toolStripPlugins
            // 
            this.toolStripPlugins.CanOverflow = false;
            this.toolStripPlugins.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripPlugins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelPlugins,
            this.toolStripButtonShowPlugins,
            this.toolStripSeparator3,
            this.toolStripButtonLoad});
            this.toolStripPlugins.Location = new System.Drawing.Point(3, 0);
            this.toolStripPlugins.Name = "toolStripPlugins";
            this.toolStripPlugins.Size = new System.Drawing.Size(190, 25);
            this.toolStripPlugins.TabIndex = 1;
            this.toolStripPlugins.Visible = false;
            // 
            // toolStripLabelPlugins
            // 
            this.toolStripLabelPlugins.Name = "toolStripLabelPlugins";
            this.toolStripLabelPlugins.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabelPlugins.Text = "Plugins:";
            // 
            // toolStripButtonShowPlugins
            // 
            this.toolStripButtonShowPlugins.Image = global::OpenCS.RBP.Controls.Properties.Resources.plugin;
            this.toolStripButtonShowPlugins.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowPlugins.Name = "toolStripButtonShowPlugins";
            this.toolStripButtonShowPlugins.Size = new System.Drawing.Size(100, 22);
            this.toolStripButtonShowPlugins.Text = "Show Plugins";
            this.toolStripButtonShowPlugins.Click += new System.EventHandler(this.toolStripButtonShowPlugins_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonLoad
            // 
            this.toolStripButtonLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLoad.Image = global::OpenCS.RBP.Controls.Properties.Resources.plugin_go;
            this.toolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoad.Name = "toolStripButtonLoad";
            this.toolStripButtonLoad.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLoad.Text = "LoadPlugins";
            this.toolStripButtonLoad.Click += new System.EventHandler(this.toolStripButtonLoad_Click);
            // 
            // toolStripAddress
            // 
            this.toolStripAddress.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripAddress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelAddress,
            this.toolStripTextBoxUrl,
            this.toolStripButtonGo});
            this.toolStripAddress.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripAddress.Location = new System.Drawing.Point(0, 25);
            this.toolStripAddress.Name = "toolStripAddress";
            this.toolStripAddress.Size = new System.Drawing.Size(824, 25);
            this.toolStripAddress.Stretch = true;
            this.toolStripAddress.TabIndex = 2;
            // 
            // toolStripLabelAddress
            // 
            this.toolStripLabelAddress.Name = "toolStripLabelAddress";
            this.toolStripLabelAddress.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabelAddress.Text = "A&ddress:";
            // 
            // toolStripTextBoxUrl
            // 
            this.toolStripTextBoxUrl.Name = "toolStripTextBoxUrl";
            this.toolStripTextBoxUrl.Size = new System.Drawing.Size(400, 25);
            this.toolStripTextBoxUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxUrl_KeyDown);
            // 
            // toolStripButtonGo
            // 
            this.toolStripButtonGo.Image = global::OpenCS.RBP.Controls.Properties.Resources.resultset_next;
            this.toolStripButtonGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGo.Name = "toolStripButtonGo";
            this.toolStripButtonGo.Size = new System.Drawing.Size(42, 22);
            this.toolStripButtonGo.Text = "Go";
            this.toolStripButtonGo.Click += new System.EventHandler(this.toolStripButtonGo_Click);
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabelMessage.Text = "Ready.";
            // 
            // RichBrowserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainerMain);
            this.Controls.Add(this.menuStripMain);
            this.Name = "RichBrowserControl";
            this.Size = new System.Drawing.Size(824, 398);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripContainerMain.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainerMain.BottomToolStripPanel.PerformLayout();
            this.toolStripContainerMain.ContentPanel.ResumeLayout(false);
            this.toolStripContainerMain.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerMain.TopToolStripPanel.PerformLayout();
            this.toolStripContainerMain.ResumeLayout(false);
            this.toolStripContainerMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.toolStripWeb.ResumeLayout(false);
            this.toolStripWeb.PerformLayout();
            this.toolStripPlugins.ResumeLayout(false);
            this.toolStripPlugins.PerformLayout();
            this.toolStripAddress.ResumeLayout(false);
            this.toolStripAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolbarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainerMain;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanelMain;
        private System.Windows.Forms.ToolStrip toolStripWeb;
        private System.Windows.Forms.ToolStripLabel toolStripLabelWeb;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStripButton toolStripButtonForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripButton toolStripButtonHome;
        private System.Windows.Forms.ToolStrip toolStripPlugins;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPlugins;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoad;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowPlugins;
        private System.Windows.Forms.ToolStrip toolStripAddress;
        private System.Windows.Forms.ToolStripLabel toolStripLabelAddress;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxUrl;
        private System.Windows.Forms.ToolStripButton toolStripButtonGo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
    }
}
