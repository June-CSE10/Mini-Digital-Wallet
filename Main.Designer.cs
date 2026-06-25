namespace Mini_Digital_Wallet
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            TbpDashboard = new TabPage();
            uCdashboard1 = new UCdashboard();
            TbpSendMoney = new TabPage();
            uCsendmoney1 = new UCsendmoney();
            TbpAddMoney = new TabPage();
            uCaddmoney1 = new UCaddmoney();
            TbpTransactions = new TabPage();
            uCtransactions1 = new UCtransactions();
            TbpContacs = new TabPage();
            uCcontacs1 = new UCcontacs();
            TbpProfile = new TabPage();
            uCprofile1 = new UCprofile();
            TbpSetting = new TabPage();
            uCsetting1 = new UCsetting();
            TbpLogOut = new TabPage();
            uClogOut1 = new UClogOut();
            imageList1 = new ImageList(components);
            uiTabControlMenu1.SuspendLayout();
            TbpDashboard.SuspendLayout();
            TbpSendMoney.SuspendLayout();
            TbpAddMoney.SuspendLayout();
            TbpTransactions.SuspendLayout();
            TbpContacs.SuspendLayout();
            TbpProfile.SuspendLayout();
            TbpSetting.SuspendLayout();
            TbpLogOut.SuspendLayout();
            SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            uiTabControlMenu1.Alignment = TabAlignment.Left;
            uiTabControlMenu1.Controls.Add(TbpDashboard);
            uiTabControlMenu1.Controls.Add(TbpSendMoney);
            uiTabControlMenu1.Controls.Add(TbpAddMoney);
            uiTabControlMenu1.Controls.Add(TbpTransactions);
            uiTabControlMenu1.Controls.Add(TbpContacs);
            uiTabControlMenu1.Controls.Add(TbpProfile);
            uiTabControlMenu1.Controls.Add(TbpSetting);
            uiTabControlMenu1.Controls.Add(TbpLogOut);
            uiTabControlMenu1.Dock = DockStyle.Fill;
            uiTabControlMenu1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControlMenu1.Font = new Font("Microsoft Sans Serif", 12F);
            uiTabControlMenu1.ImageList = imageList1;
            uiTabControlMenu1.Location = new Point(0, 50);
            uiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiTabControlMenu1.Multiline = true;
            uiTabControlMenu1.Name = "uiTabControlMenu1";
            uiTabControlMenu1.SelectedIndex = 0;
            uiTabControlMenu1.Size = new Size(1356, 790);
            uiTabControlMenu1.SizeMode = TabSizeMode.Fixed;
            uiTabControlMenu1.TabIndex = 1;
            uiTabControlMenu1.TextAlignment = HorizontalAlignment.Left;
            // 
            // TbpDashboard
            // 
            TbpDashboard.Controls.Add(uCdashboard1);
            TbpDashboard.ImageIndex = 0;
            TbpDashboard.Location = new Point(201, 0);
            TbpDashboard.Name = "TbpDashboard";
            TbpDashboard.Size = new Size(1155, 790);
            TbpDashboard.TabIndex = 0;
            TbpDashboard.Text = "Dashboard";
            TbpDashboard.UseVisualStyleBackColor = true;
            // 
            // uCdashboard1
            // 
            uCdashboard1.BackColor = Color.FromArgb(192, 192, 255);
            uCdashboard1.Dock = DockStyle.Fill;
            uCdashboard1.Location = new Point(0, 0);
            uCdashboard1.Margin = new Padding(5);
            uCdashboard1.Name = "uCdashboard1";
            uCdashboard1.Size = new Size(1155, 790);
            uCdashboard1.TabIndex = 0;
            // 
            // TbpSendMoney
            // 
            TbpSendMoney.Controls.Add(uCsendmoney1);
            TbpSendMoney.ImageIndex = 2;
            TbpSendMoney.Location = new Point(201, 0);
            TbpSendMoney.Name = "TbpSendMoney";
            TbpSendMoney.Size = new Size(879, 790);
            TbpSendMoney.TabIndex = 1;
            TbpSendMoney.Text = "Send Money";
            TbpSendMoney.UseVisualStyleBackColor = true;
            // 
            // uCsendmoney1
            // 
            uCsendmoney1.Dock = DockStyle.Fill;
            uCsendmoney1.Location = new Point(0, 0);
            uCsendmoney1.Margin = new Padding(5, 5, 5, 5);
            uCsendmoney1.Name = "uCsendmoney1";
            uCsendmoney1.Size = new Size(879, 790);
            uCsendmoney1.TabIndex = 0;
            // 
            // TbpAddMoney
            // 
            TbpAddMoney.Controls.Add(uCaddmoney1);
            TbpAddMoney.ImageIndex = 5;
            TbpAddMoney.Location = new Point(201, 0);
            TbpAddMoney.Name = "TbpAddMoney";
            TbpAddMoney.Size = new Size(879, 790);
            TbpAddMoney.TabIndex = 2;
            TbpAddMoney.Text = "Add Money";
            TbpAddMoney.UseVisualStyleBackColor = true;
            // 
            // uCaddmoney1
            // 
            uCaddmoney1.Dock = DockStyle.Fill;
            uCaddmoney1.Location = new Point(0, 0);
            uCaddmoney1.Margin = new Padding(5, 5, 5, 5);
            uCaddmoney1.Name = "uCaddmoney1";
            uCaddmoney1.Size = new Size(879, 790);
            uCaddmoney1.TabIndex = 0;
            // 
            // TbpTransactions
            // 
            TbpTransactions.Controls.Add(uCtransactions1);
            TbpTransactions.ImageIndex = 6;
            TbpTransactions.Location = new Point(201, 0);
            TbpTransactions.Name = "TbpTransactions";
            TbpTransactions.Size = new Size(879, 790);
            TbpTransactions.TabIndex = 3;
            TbpTransactions.Text = "Transactions";
            TbpTransactions.UseVisualStyleBackColor = true;
            // 
            // uCtransactions1
            // 
            uCtransactions1.Dock = DockStyle.Fill;
            uCtransactions1.Location = new Point(0, 0);
            uCtransactions1.Margin = new Padding(5, 5, 5, 5);
            uCtransactions1.Name = "uCtransactions1";
            uCtransactions1.Size = new Size(879, 790);
            uCtransactions1.TabIndex = 0;
            // 
            // TbpContacs
            // 
            TbpContacs.Controls.Add(uCcontacs1);
            TbpContacs.ImageIndex = 3;
            TbpContacs.Location = new Point(201, 0);
            TbpContacs.Name = "TbpContacs";
            TbpContacs.Size = new Size(879, 790);
            TbpContacs.TabIndex = 4;
            TbpContacs.Text = "Contacs";
            TbpContacs.UseVisualStyleBackColor = true;
            // 
            // uCcontacs1
            // 
            uCcontacs1.Dock = DockStyle.Fill;
            uCcontacs1.Location = new Point(0, 0);
            uCcontacs1.Margin = new Padding(5, 5, 5, 5);
            uCcontacs1.Name = "uCcontacs1";
            uCcontacs1.Size = new Size(879, 790);
            uCcontacs1.TabIndex = 0;
            // 
            // TbpProfile
            // 
            TbpProfile.Controls.Add(uCprofile1);
            TbpProfile.ImageIndex = 4;
            TbpProfile.Location = new Point(201, 0);
            TbpProfile.Name = "TbpProfile";
            TbpProfile.Size = new Size(879, 790);
            TbpProfile.TabIndex = 5;
            TbpProfile.Text = "Profile";
            TbpProfile.UseVisualStyleBackColor = true;
            // 
            // uCprofile1
            // 
            uCprofile1.Dock = DockStyle.Fill;
            uCprofile1.Location = new Point(0, 0);
            uCprofile1.Margin = new Padding(4, 4, 4, 4);
            uCprofile1.Name = "uCprofile1";
            uCprofile1.Size = new Size(879, 790);
            uCprofile1.TabIndex = 0;
            // 
            // TbpSetting
            // 
            TbpSetting.Controls.Add(uCsetting1);
            TbpSetting.ImageIndex = 7;
            TbpSetting.Location = new Point(201, 0);
            TbpSetting.Name = "TbpSetting";
            TbpSetting.Size = new Size(879, 790);
            TbpSetting.TabIndex = 6;
            TbpSetting.Text = "Setting";
            TbpSetting.UseVisualStyleBackColor = true;
            // 
            // uCsetting1
            // 
            uCsetting1.Dock = DockStyle.Fill;
            uCsetting1.Location = new Point(0, 0);
            uCsetting1.Margin = new Padding(4, 4, 4, 4);
            uCsetting1.Name = "uCsetting1";
            uCsetting1.Size = new Size(879, 790);
            uCsetting1.TabIndex = 0;
            // 
            // TbpLogOut
            // 
            TbpLogOut.Controls.Add(uClogOut1);
            TbpLogOut.ImageIndex = 1;
            TbpLogOut.Location = new Point(201, 0);
            TbpLogOut.Name = "TbpLogOut";
            TbpLogOut.Size = new Size(879, 790);
            TbpLogOut.TabIndex = 7;
            TbpLogOut.Text = "Log Out";
            TbpLogOut.UseVisualStyleBackColor = true;
            // 
            // uClogOut1
            // 
            uClogOut1.Dock = DockStyle.Fill;
            uClogOut1.Location = new Point(0, 0);
            uClogOut1.Margin = new Padding(5, 5, 5, 5);
            uClogOut1.Name = "uClogOut1";
            uClogOut1.Size = new Size(879, 790);
            uClogOut1.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Home.png");
            imageList1.Images.SetKeyName(1, "Logout11.png");
            imageList1.Images.SetKeyName(2, "Paper Plane.png");
            imageList1.Images.SetKeyName(3, "People.png");
            imageList1.Images.SetKeyName(4, "Profile.png");
            imageList1.Images.SetKeyName(5, "Sum.png");
            imageList1.Images.SetKeyName(6, "Transaction.png");
            imageList1.Images.SetKeyName(7, "Settings.png");
            imageList1.Images.SetKeyName(8, "Wallet.png");
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1356, 840);
            Controls.Add(uiTabControlMenu1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Padding = new Padding(0, 50, 0, 0);
            Text = "MINI DIGITAL WALLET";
            TitleHeight = 50;
            ZoomScaleRect = new Rectangle(22, 22, 800, 450);
            Load += Main_Load;
            uiTabControlMenu1.ResumeLayout(false);
            TbpDashboard.ResumeLayout(false);
            TbpSendMoney.ResumeLayout(false);
            TbpAddMoney.ResumeLayout(false);
            TbpTransactions.ResumeLayout(false);
            TbpContacs.ResumeLayout(false);
            TbpProfile.ResumeLayout(false);
            TbpSetting.ResumeLayout(false);
            TbpLogOut.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private TabPage TbpDashboard;
        private TabPage TbpSendMoney;
        private TabPage TbpAddMoney;
        private TabPage TbpTransactions;
        private TabPage TbpContacs;
        private TabPage TbpProfile;
        private TabPage TbpSetting;
        private TabPage TbpLogOut;
        private ImageList imageList1;
        private UCdashboard uCdashboard1;
        private UCsendmoney uCsendmoney1;
        private UCaddmoney uCaddmoney1;
        private UCtransactions uCtransactions1;
        private UCcontacs uCcontacs1;
        private UCprofile uCprofile1;
        private UCsetting uCsetting1;
        private UClogOut uClogOut1;
    }
}