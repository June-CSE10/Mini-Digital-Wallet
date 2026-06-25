namespace Mini_Digital_Wallet
{
    partial class UCdashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCdashboard));
            pictureBox3 = new PictureBox();
            LblMoney = new Label();
            LblAvailableBalance = new Label();
            LblWallet = new Label();
            imageList4 = new ImageList(components);
            LblWelcome = new Label();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            imageList3 = new ImageList(components);
            imageList5 = new ImageList(components);
            BtnSend = new Sunny.UI.UISymbolButton();
            BtnTransaction = new Sunny.UI.UISymbolButton();
            BtnAdd = new Sunny.UI.UISymbolButton();
            BtnProfile = new Sunny.UI.UISymbolButton();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            pictureBox1 = new PictureBox();
            LblDefault = new Sunny.UI.UISymbolLabel();
            LblDollar = new Label();
            uiPanel1 = new Sunny.UI.UIPanel();
            label1 = new Label();
            btnseeall = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.photo_2026_06_24_09_57_02_removebg_preview1;
            pictureBox3.Location = new Point(553, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(832, 474);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // LblMoney
            // 
            LblMoney.AutoSize = true;
            LblMoney.BackColor = Color.FromArgb(128, 128, 255);
            LblMoney.Font = new Font("Nirmala Text", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMoney.ForeColor = SystemColors.ButtonHighlight;
            LblMoney.Location = new Point(62, 132);
            LblMoney.Name = "LblMoney";
            LblMoney.Size = new Size(401, 72);
            LblMoney.TabIndex = 3;
            LblMoney.Text = "$12988,023.00";
            LblMoney.Click += label1_Click;
            // 
            // LblAvailableBalance
            // 
            LblAvailableBalance.AutoSize = true;
            LblAvailableBalance.BackColor = Color.FromArgb(128, 128, 255);
            LblAvailableBalance.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAvailableBalance.ForeColor = SystemColors.ButtonHighlight;
            LblAvailableBalance.Location = new Point(61, 73);
            LblAvailableBalance.Name = "LblAvailableBalance";
            LblAvailableBalance.Size = new Size(313, 49);
            LblAvailableBalance.TabIndex = 2;
            LblAvailableBalance.Text = "Available Balance";
            LblAvailableBalance.Click += LblAvailableBalance_Click;
            // 
            // LblWallet
            // 
            LblWallet.AutoSize = true;
            LblWallet.BackColor = Color.Transparent;
            LblWallet.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblWallet.ForeColor = Color.Black;
            LblWallet.ImageList = imageList4;
            LblWallet.Location = new Point(39, 164);
            LblWallet.Name = "LblWallet";
            LblWallet.Size = new Size(0, 62);
            LblWallet.TabIndex = 1;
            LblWallet.Click += LblWallet_Click;
            // 
            // imageList4
            // 
            imageList4.ColorDepth = ColorDepth.Depth32Bit;
            imageList4.ImageStream = (ImageListStreamer)resources.GetObject("imageList4.ImageStream");
            imageList4.TransparentColor = Color.Transparent;
            imageList4.Images.SetKeyName(0, "Notification.png");
            imageList4.Images.SetKeyName(1, "photo_2026-06-24_10-38-43.jpg");
            // 
            // LblWelcome
            // 
            LblWelcome.AutoSize = true;
            LblWelcome.BackColor = Color.Transparent;
            LblWelcome.Font = new Font("Segoe UI Variable Display", 8.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblWelcome.Location = new Point(217, 105);
            LblWelcome.Name = "LblWelcome";
            LblWelcome.Size = new Size(374, 37);
            LblWelcome.TabIndex = 7;
            LblWelcome.Text = "Welcome back to your wallet";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // imageList3
            // 
            imageList3.ColorDepth = ColorDepth.Depth16Bit;
            imageList3.ImageStream = (ImageListStreamer)resources.GetObject("imageList3.ImageStream");
            imageList3.TransparentColor = Color.Transparent;
            imageList3.Images.SetKeyName(0, "Notification.png");
            // 
            // imageList5
            // 
            imageList5.ColorDepth = ColorDepth.Depth32Bit;
            imageList5.ImageSize = new Size(16, 16);
            imageList5.TransparentColor = Color.Transparent;
            // 
            // BtnSend
            // 
            BtnSend.FillColor = Color.FromArgb(128, 128, 255);
            BtnSend.Font = new Font("Microsoft Sans Serif", 12F);
            BtnSend.Location = new Point(54, 673);
            BtnSend.MinimumSize = new Size(1, 1);
            BtnSend.Name = "BtnSend";
            BtnSend.Radius = 100;
            BtnSend.RectColor = Color.FromArgb(128, 128, 255);
            BtnSend.Size = new Size(396, 120);
            BtnSend.Symbol = 61732;
            BtnSend.SymbolSize = 60;
            BtnSend.TabIndex = 13;
            BtnSend.Text = "Send Money";
            BtnSend.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // BtnTransaction
            // 
            BtnTransaction.FillColor = Color.FromArgb(128, 128, 255);
            BtnTransaction.Font = new Font("Microsoft Sans Serif", 12F);
            BtnTransaction.Location = new Point(908, 673);
            BtnTransaction.MinimumSize = new Size(1, 1);
            BtnTransaction.Name = "BtnTransaction";
            BtnTransaction.Radius = 100;
            BtnTransaction.RectColor = Color.FromArgb(128, 128, 255);
            BtnTransaction.Size = new Size(391, 122);
            BtnTransaction.Symbol = 43;
            BtnTransaction.SymbolSize = 60;
            BtnTransaction.TabIndex = 16;
            BtnTransaction.Text = "Transaction";
            BtnTransaction.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // BtnAdd
            // 
            BtnAdd.FillColor = Color.FromArgb(128, 128, 255);
            BtnAdd.Font = new Font("Microsoft Sans Serif", 12F);
            BtnAdd.Location = new Point(478, 671);
            BtnAdd.MinimumSize = new Size(1, 1);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Radius = 100;
            BtnAdd.RectColor = Color.FromArgb(128, 128, 255);
            BtnAdd.Size = new Size(404, 122);
            BtnAdd.Symbol = 61694;
            BtnAdd.SymbolSize = 60;
            BtnAdd.TabIndex = 17;
            BtnAdd.Text = "Add Money";
            BtnAdd.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // BtnProfile
            // 
            BtnProfile.BackColor = Color.Transparent;
            BtnProfile.FillColor = Color.Transparent;
            BtnProfile.Font = new Font("Microsoft Sans Serif", 8.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnProfile.ForeColor = Color.Navy;
            BtnProfile.ForeHoverColor = Color.Gray;
            BtnProfile.ForePressColor = Color.LightGray;
            BtnProfile.ForeSelectedColor = Color.Silver;
            BtnProfile.Location = new Point(1058, 3);
            BtnProfile.MinimumSize = new Size(1, 1);
            BtnProfile.Name = "BtnProfile";
            BtnProfile.Radius = 63;
            BtnProfile.RectColor = Color.Transparent;
            BtnProfile.Size = new Size(261, 80);
            BtnProfile.Symbol = 62141;
            BtnProfile.SymbolColor = Color.FromArgb(128, 128, 255);
            BtnProfile.SymbolHoverColor = Color.FromArgb(128, 128, 255);
            BtnProfile.SymbolSelectedColor = Color.FromArgb(128, 128, 255);
            BtnProfile.SymbolSize = 60;
            BtnProfile.TabIndex = 18;
            BtnProfile.Text = "Leonel Messi";
            BtnProfile.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.BackColor = Color.Transparent;
            uiSymbolLabel1.Enabled = false;
            uiSymbolLabel1.Font = new Font("Arial Narrow", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiSymbolLabel1.ForeColor = Color.MidnightBlue;
            uiSymbolLabel1.Location = new Point(205, 4);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(461, 98);
            uiSymbolLabel1.Symbol = 62041;
            uiSymbolLabel1.SymbolColor = Color.Blue;
            uiSymbolLabel1.SymbolSize = 80;
            uiSymbolLabel1.TabIndex = 19;
            uiSymbolLabel1.Text = "Hello, Leonel Messi";
            uiSymbolLabel1.Click += uiSymbolLabel1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // LblDefault
            // 
            LblDefault.BackColor = Color.Yellow;
            LblDefault.Font = new Font("Microsoft Sans Serif", 8.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDefault.Location = new Point(76, 227);
            LblDefault.MinimumSize = new Size(1, 1);
            LblDefault.Name = "LblDefault";
            LblDefault.Size = new Size(132, 46);
            LblDefault.SymbolColor = Color.Transparent;
            LblDefault.TabIndex = 6;
            LblDefault.Text = "Default";
            // 
            // LblDollar
            // 
            LblDollar.AutoSize = true;
            LblDollar.BackColor = Color.FromArgb(128, 128, 255);
            LblDollar.Font = new Font("Calibri", 8.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDollar.ForeColor = SystemColors.ButtonHighlight;
            LblDollar.Location = new Point(214, 238);
            LblDollar.Name = "LblDollar";
            LblDollar.Size = new Size(91, 35);
            LblDollar.TabIndex = 7;
            LblDollar.Text = "Dollar.";
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(pictureBox3);
            uiPanel1.Controls.Add(LblDollar);
            uiPanel1.Controls.Add(LblMoney);
            uiPanel1.Controls.Add(LblAvailableBalance);
            uiPanel1.Controls.Add(LblDefault);
            uiPanel1.FillColor = Color.FromArgb(128, 128, 255);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(46, 206);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 90;
            uiPanel1.Size = new Size(1244, 449);
            uiPanel1.TabIndex = 21;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(76, 851);
            label1.Name = "label1";
            label1.Size = new Size(352, 49);
            label1.TabIndex = 8;
            label1.Text = "Recent Transactions";
            // 
            // btnseeall
            // 
            btnseeall.FillColor = Color.Transparent;
            btnseeall.FillDisableColor = Color.Black;
            btnseeall.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnseeall.ForeColor = Color.Navy;
            btnseeall.ForeHoverColor = Color.FromArgb(192, 192, 255);
            btnseeall.ForePressColor = Color.Navy;
            btnseeall.ForeSelectedColor = Color.FromArgb(128, 128, 255);
            btnseeall.LightColor = Color.FromArgb(0, 0, 192);
            btnseeall.Location = new Point(1114, 835);
            btnseeall.MinimumSize = new Size(1, 1);
            btnseeall.Name = "btnseeall";
            btnseeall.Radius = 65;
            btnseeall.RectColor = Color.Transparent;
            btnseeall.RectDisableColor = Color.FromArgb(192, 192, 255);
            btnseeall.Size = new Size(185, 65);
            btnseeall.SymbolDisableColor = Color.Black;
            btnseeall.SymbolHoverColor = Color.FromArgb(128, 128, 255);
            btnseeall.SymbolPressColor = Color.Black;
            btnseeall.SymbolSelectedColor = Color.FromArgb(128, 128, 255);
            btnseeall.TabIndex = 24;
            btnseeall.Text = "See All";
            btnseeall.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnseeall.TipsForeColor = Color.FromArgb(0, 0, 192);
            // 
            // UCdashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(btnseeall);
            Controls.Add(label1);
            Controls.Add(uiPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(uiSymbolLabel1);
            Controls.Add(BtnProfile);
            Controls.Add(BtnTransaction);
            Controls.Add(BtnAdd);
            Controls.Add(LblWelcome);
            Controls.Add(BtnSend);
            Controls.Add(LblWallet);
            Margin = new Padding(5);
            Name = "UCdashboard";
            Size = new Size(1330, 1653);
            Load += UCdashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblWallet;
        private Label LblAvailableBalance;
        private Label LblMoney;
        private Label LblWelcome;
        private PictureBox pictureBox3;
        private ImageList imageList1;
        private ImageList imageList2;
        private ImageList imageList4;
        private ImageList imageList3;
        private ImageList imageList5;
        private Sunny.UI.UISymbolButton BtnSend;
        private Sunny.UI.UISymbolButton BtnTransaction;
        private Sunny.UI.UISymbolButton BtnAdd;
        private Sunny.UI.UISymbolButton BtnProfile;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private PictureBox pictureBox1;
        private Sunny.UI.UISymbolLabel LblDefault;
        private Label LblDollar;
        private Sunny.UI.UIPanel uiPanel1;
        private Label label1;
        private Sunny.UI.UISymbolButton btnseeall;
    }
}
