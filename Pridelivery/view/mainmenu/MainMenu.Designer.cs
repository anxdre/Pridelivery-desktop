namespace Pridelivery.view.mainmenu
{
    partial class MainMenu
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
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageCourier = new MetroFramework.Controls.MetroTabPage();
            this.metroTileOrderTask = new MetroFramework.Controls.MetroTile();
            this.metroTileExitCourier = new MetroFramework.Controls.MetroTile();
            this.metroTileHistory = new MetroFramework.Controls.MetroTile();
            this.metroTileProfileCourier = new MetroFramework.Controls.MetroTile();
            this.metroTabPageUser = new MetroFramework.Controls.MetroTabPage();
            this.metroTileSendPacket = new MetroFramework.Controls.MetroTile();
            this.metroTileExitUser = new MetroFramework.Controls.MetroTile();
            this.metroTileHistoryUser = new MetroFramework.Controls.MetroTile();
            this.metroTileProfileUser = new MetroFramework.Controls.MetroTile();
            this.metroTabPageAdmin = new MetroFramework.Controls.MetroTabPage();
            this.metroTileHistoryAdmin = new MetroFramework.Controls.MetroTile();
            this.metroTileExitAdmin = new MetroFramework.Controls.MetroTile();
            this.metroTileUserMan = new MetroFramework.Controls.MetroTile();
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl.SuspendLayout();
            this.metroTabPageCourier.SuspendLayout();
            this.metroTabPageUser.SuspendLayout();
            this.metroTabPageAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.metroTabControl.Controls.Add(this.metroTabPageCourier);
            this.metroTabControl.Controls.Add(this.metroTabPageUser);
            this.metroTabControl.Controls.Add(this.metroTabPageAdmin);
            this.metroTabControl.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 1;
            this.metroTabControl.Size = new System.Drawing.Size(754, 364);
            this.metroTabControl.TabIndex = 0;
            this.metroTabControl.UseSelectable = true;
            // 
            // metroTabPageCourier
            // 
            this.metroTabPageCourier.Controls.Add(this.metroTileOrderTask);
            this.metroTabPageCourier.Controls.Add(this.metroTileExitCourier);
            this.metroTabPageCourier.Controls.Add(this.metroTileHistory);
            this.metroTabPageCourier.Controls.Add(this.metroTileProfileCourier);
            this.metroTabPageCourier.HorizontalScrollbarBarColor = true;
            this.metroTabPageCourier.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageCourier.HorizontalScrollbarSize = 10;
            this.metroTabPageCourier.Location = new System.Drawing.Point(4, 41);
            this.metroTabPageCourier.Name = "metroTabPageCourier";
            this.metroTabPageCourier.Size = new System.Drawing.Size(746, 319);
            this.metroTabPageCourier.TabIndex = 1;
            this.metroTabPageCourier.Text = "Courier";
            this.metroTabPageCourier.VerticalScrollbarBarColor = true;
            this.metroTabPageCourier.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageCourier.VerticalScrollbarSize = 10;
            // 
            // metroTileOrderTask
            // 
            this.metroTileOrderTask.ActiveControl = null;
            this.metroTileOrderTask.Location = new System.Drawing.Point(240, 28);
            this.metroTileOrderTask.Name = "metroTileOrderTask";
            this.metroTileOrderTask.Size = new System.Drawing.Size(267, 263);
            this.metroTileOrderTask.TabIndex = 3;
            this.metroTileOrderTask.Text = "Order Task";
            this.metroTileOrderTask.UseSelectable = true;
            // 
            // metroTileExitCourier
            // 
            this.metroTileExitCourier.ActiveControl = null;
            this.metroTileExitCourier.Location = new System.Drawing.Point(156, 137);
            this.metroTileExitCourier.Name = "metroTileExitCourier";
            this.metroTileExitCourier.Size = new System.Drawing.Size(78, 80);
            this.metroTileExitCourier.TabIndex = 4;
            this.metroTileExitCourier.Text = "Exit";
            this.metroTileExitCourier.UseSelectable = true;
            // 
            // metroTileHistory
            // 
            this.metroTileHistory.ActiveControl = null;
            this.metroTileHistory.Location = new System.Drawing.Point(513, 28);
            this.metroTileHistory.Name = "metroTileHistory";
            this.metroTileHistory.Size = new System.Drawing.Size(139, 103);
            this.metroTileHistory.TabIndex = 5;
            this.metroTileHistory.Text = "History";
            this.metroTileHistory.UseSelectable = true;
            // 
            // metroTileProfileCourier
            // 
            this.metroTileProfileCourier.ActiveControl = null;
            this.metroTileProfileCourier.Location = new System.Drawing.Point(95, 28);
            this.metroTileProfileCourier.Name = "metroTileProfileCourier";
            this.metroTileProfileCourier.Size = new System.Drawing.Size(139, 103);
            this.metroTileProfileCourier.TabIndex = 6;
            this.metroTileProfileCourier.Text = "Profile";
            this.metroTileProfileCourier.UseSelectable = true;
            this.metroTileProfileCourier.Click += new System.EventHandler(this.metroTileProfileCourier_Click);
            // 
            // metroTabPageUser
            // 
            this.metroTabPageUser.Controls.Add(this.metroTileSendPacket);
            this.metroTabPageUser.Controls.Add(this.metroTileExitUser);
            this.metroTabPageUser.Controls.Add(this.metroTileHistoryUser);
            this.metroTabPageUser.Controls.Add(this.metroTileProfileUser);
            this.metroTabPageUser.HorizontalScrollbarBarColor = true;
            this.metroTabPageUser.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageUser.HorizontalScrollbarSize = 10;
            this.metroTabPageUser.Location = new System.Drawing.Point(4, 41);
            this.metroTabPageUser.Name = "metroTabPageUser";
            this.metroTabPageUser.Size = new System.Drawing.Size(746, 319);
            this.metroTabPageUser.TabIndex = 0;
            this.metroTabPageUser.Text = "User";
            this.metroTabPageUser.VerticalScrollbarBarColor = true;
            this.metroTabPageUser.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageUser.VerticalScrollbarSize = 10;
            this.metroTabPageUser.Click += new System.EventHandler(this.metroTabPageUser_Click);
            // 
            // metroTileSendPacket
            // 
            this.metroTileSendPacket.ActiveControl = null;
            this.metroTileSendPacket.Location = new System.Drawing.Point(236, 31);
            this.metroTileSendPacket.Name = "metroTileSendPacket";
            this.metroTileSendPacket.Size = new System.Drawing.Size(267, 263);
            this.metroTileSendPacket.TabIndex = 2;
            this.metroTileSendPacket.Text = "Send Packet";
            this.metroTileSendPacket.UseSelectable = true;
            this.metroTileSendPacket.Click += new System.EventHandler(this.metroTileSendPacket_Click);
            // 
            // metroTileExitUser
            // 
            this.metroTileExitUser.ActiveControl = null;
            this.metroTileExitUser.Location = new System.Drawing.Point(152, 140);
            this.metroTileExitUser.Name = "metroTileExitUser";
            this.metroTileExitUser.Size = new System.Drawing.Size(78, 80);
            this.metroTileExitUser.TabIndex = 2;
            this.metroTileExitUser.Text = "Exit";
            this.metroTileExitUser.UseSelectable = true;
            // 
            // metroTileHistoryUser
            // 
            this.metroTileHistoryUser.ActiveControl = null;
            this.metroTileHistoryUser.Location = new System.Drawing.Point(509, 31);
            this.metroTileHistoryUser.Name = "metroTileHistoryUser";
            this.metroTileHistoryUser.Size = new System.Drawing.Size(139, 103);
            this.metroTileHistoryUser.TabIndex = 2;
            this.metroTileHistoryUser.Text = "History";
            this.metroTileHistoryUser.UseSelectable = true;
            // 
            // metroTileProfileUser
            // 
            this.metroTileProfileUser.ActiveControl = null;
            this.metroTileProfileUser.Location = new System.Drawing.Point(91, 31);
            this.metroTileProfileUser.Name = "metroTileProfileUser";
            this.metroTileProfileUser.Size = new System.Drawing.Size(139, 103);
            this.metroTileProfileUser.TabIndex = 2;
            this.metroTileProfileUser.Text = "Profile";
            this.metroTileProfileUser.UseSelectable = true;
            this.metroTileProfileUser.Click += new System.EventHandler(this.metroTileProfileUser_Click);
            // 
            // metroTabPageAdmin
            // 
            this.metroTabPageAdmin.Controls.Add(this.metroTileHistoryAdmin);
            this.metroTabPageAdmin.Controls.Add(this.metroTileExitAdmin);
            this.metroTabPageAdmin.Controls.Add(this.metroTileUserMan);
            this.metroTabPageAdmin.HorizontalScrollbarBarColor = true;
            this.metroTabPageAdmin.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageAdmin.HorizontalScrollbarSize = 10;
            this.metroTabPageAdmin.Location = new System.Drawing.Point(4, 41);
            this.metroTabPageAdmin.Name = "metroTabPageAdmin";
            this.metroTabPageAdmin.Size = new System.Drawing.Size(746, 319);
            this.metroTabPageAdmin.TabIndex = 2;
            this.metroTabPageAdmin.Text = "Admin";
            this.metroTabPageAdmin.VerticalScrollbarBarColor = true;
            this.metroTabPageAdmin.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageAdmin.VerticalScrollbarSize = 10;
            // 
            // metroTileHistoryAdmin
            // 
            this.metroTileHistoryAdmin.ActiveControl = null;
            this.metroTileHistoryAdmin.Location = new System.Drawing.Point(289, 48);
            this.metroTileHistoryAdmin.Name = "metroTileHistoryAdmin";
            this.metroTileHistoryAdmin.Size = new System.Drawing.Size(212, 217);
            this.metroTileHistoryAdmin.TabIndex = 3;
            this.metroTileHistoryAdmin.Text = "History Transaction";
            this.metroTileHistoryAdmin.UseSelectable = true;
            // 
            // metroTileExitAdmin
            // 
            this.metroTileExitAdmin.ActiveControl = null;
            this.metroTileExitAdmin.Location = new System.Drawing.Point(507, 48);
            this.metroTileExitAdmin.Name = "metroTileExitAdmin";
            this.metroTileExitAdmin.Size = new System.Drawing.Size(79, 76);
            this.metroTileExitAdmin.TabIndex = 4;
            this.metroTileExitAdmin.Text = "Exit";
            this.metroTileExitAdmin.UseSelectable = true;
            // 
            // metroTileUserMan
            // 
            this.metroTileUserMan.ActiveControl = null;
            this.metroTileUserMan.Location = new System.Drawing.Point(160, 48);
            this.metroTileUserMan.Name = "metroTileUserMan";
            this.metroTileUserMan.Size = new System.Drawing.Size(123, 107);
            this.metroTileUserMan.TabIndex = 6;
            this.metroTileUserMan.Text = "User Management";
            this.metroTileUserMan.TileImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroTileUserMan.UseSelectable = true;
            this.metroTileUserMan.UseTileImage = true;
            // 
            // metroLabelName
            // 
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelName.Location = new System.Drawing.Point(23, 440);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(65, 15);
            this.metroLabelName.TabIndex = 1;
            this.metroLabelName.Text = "Hello User";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.metroLabelName);
            this.Controls.Add(this.metroTabControl);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.metroTabControl.ResumeLayout(false);
            this.metroTabPageCourier.ResumeLayout(false);
            this.metroTabPageUser.ResumeLayout(false);
            this.metroTabPageAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPageUser;
        private MetroFramework.Controls.MetroTabPage metroTabPageCourier;
        private MetroFramework.Controls.MetroTabPage metroTabPageAdmin;
        private MetroFramework.Controls.MetroTile metroTileSendPacket;
        private MetroFramework.Controls.MetroTile metroTileExitUser;
        private MetroFramework.Controls.MetroTile metroTileHistoryUser;
        private MetroFramework.Controls.MetroTile metroTileProfileUser;
        private MetroFramework.Controls.MetroTile metroTileOrderTask;
        private MetroFramework.Controls.MetroTile metroTileExitCourier;
        private MetroFramework.Controls.MetroTile metroTileHistory;
        private MetroFramework.Controls.MetroTile metroTileProfileCourier;
        private MetroFramework.Controls.MetroTile metroTileHistoryAdmin;
        private MetroFramework.Controls.MetroTile metroTileExitAdmin;
        private MetroFramework.Controls.MetroTile metroTileUserMan;
        private MetroFramework.Controls.MetroLabel metroLabelName;
    }
}