namespace Mini_Digital_Wallet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            uiPanel = new Sunny.UI.UIPanel();
            SymCNA = new Sunny.UI.UISymbolButton();
            SymLogin = new Sunny.UI.UISymbolButton();
            lblOr = new Sunny.UI.UILabel();
            lblForgotPassword = new Sunny.UI.UILinkLabel();
            chkRemember = new Sunny.UI.UICheckBox();
            txtPassword = new Sunny.UI.UITextBox();
            txtEmail = new Sunny.UI.UITextBox();
            lblPassword = new Sunny.UI.UILabel();
            lblEmail = new Sunny.UI.UILabel();
            uiPanel1 = new Sunny.UI.UIPanel();
            pictureBox1 = new PictureBox();
            lblSubTitle = new Sunny.UI.UILabel();
            lblTitle = new Sunny.UI.UILabel();
            uiPanel2 = new Sunny.UI.UIPanel();
            uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            uiLabel1 = new Sunny.UI.UILabel();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            uiTextBox2 = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            uiTextBox3 = new Sunny.UI.UITextBox();
            uiPanel.SuspendLayout();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            uiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel
            // 
            uiPanel.Controls.Add(SymCNA);
            uiPanel.Controls.Add(SymLogin);
            uiPanel.Controls.Add(lblOr);
            uiPanel.Controls.Add(lblForgotPassword);
            uiPanel.Controls.Add(chkRemember);
            uiPanel.Controls.Add(txtPassword);
            uiPanel.Controls.Add(txtEmail);
            uiPanel.Controls.Add(lblPassword);
            uiPanel.Controls.Add(lblEmail);
            uiPanel.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel.Location = new Point(515, 55);
            uiPanel.Margin = new Padding(4, 5, 4, 5);
            uiPanel.MinimumSize = new Size(1, 1);
            uiPanel.Name = "uiPanel";
            uiPanel.Size = new Size(561, 780);
            uiPanel.TabIndex = 0;
            uiPanel.Text = null;
            uiPanel.TextAlignment = ContentAlignment.MiddleCenter;
            uiPanel.Click += uiPanel_Click;
            // 
            // SymCNA
            // 
            SymCNA.BackColor = Color.White;
            SymCNA.FillColor = Color.Transparent;
            SymCNA.Font = new Font("Microsoft Sans Serif", 12F);
            SymCNA.ForeColor = Color.MediumBlue;
            SymCNA.Location = new Point(63, 564);
            SymCNA.MinimumSize = new Size(1, 1);
            SymCNA.Name = "SymCNA";
            SymCNA.RectColor = Color.White;
            SymCNA.RectDisableColor = Color.White;
            SymCNA.RectHoverColor = Color.Gray;
            SymCNA.RectPressColor = Color.White;
            SymCNA.RectSelectedColor = Color.White;
            SymCNA.Size = new Size(423, 62);
            SymCNA.Symbol = 61447;
            SymCNA.SymbolColor = Color.MediumBlue;
            SymCNA.SymbolDisableColor = Color.White;
            SymCNA.TabIndex = 10;
            SymCNA.Text = "Create New Account";
            SymCNA.TipsFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SymCNA.Click += SymCNA_Click;
            // 
            // SymLogin
            // 
            SymLogin.FillColor = Color.MediumBlue;
            SymLogin.Font = new Font("Microsoft Sans Serif", 12F);
            SymLogin.Location = new Point(63, 415);
            SymLogin.MinimumSize = new Size(1, 1);
            SymLogin.Name = "SymLogin";
            SymLogin.RectColor = Color.Blue;
            SymLogin.Size = new Size(423, 52);
            SymLogin.Symbol = 61537;
            SymLogin.TabIndex = 9;
            SymLogin.Text = "Login";
            SymLogin.TipsFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SymLogin.Click += SymLogin_Click;
            // 
            // lblOr
            // 
            lblOr.Font = new Font("Microsoft Sans Serif", 12F);
            lblOr.ForeColor = Color.FromArgb(48, 48, 48);
            lblOr.Location = new Point(245, 504);
            lblOr.Name = "lblOr";
            lblOr.Size = new Size(52, 34);
            lblOr.TabIndex = 7;
            lblOr.Text = "OR";
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.ActiveLinkColor = Color.FromArgb(80, 160, 255);
            lblForgotPassword.Font = new Font("Microsoft Sans Serif", 12F);
            lblForgotPassword.ForeColor = Color.White;
            lblForgotPassword.LinkBehavior = LinkBehavior.AlwaysUnderline;
            lblForgotPassword.LinkColor = Color.MediumBlue;
            lblForgotPassword.Location = new Point(274, 327);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(212, 37);
            lblForgotPassword.TabIndex = 5;
            lblForgotPassword.TabStop = true;
            lblForgotPassword.Text = "Forgot Password?";
            lblForgotPassword.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            lblForgotPassword.Click += lblForgotPassword_Click;
            // 
            // chkRemember
            // 
            chkRemember.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkRemember.ForeColor = Color.FromArgb(48, 48, 48);
            chkRemember.Location = new Point(63, 320);
            chkRemember.MinimumSize = new Size(1, 1);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(225, 44);
            chkRemember.TabIndex = 4;
            chkRemember.Text = "Remember Me";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtPassword.Location = new Point(63, 268);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(423, 44);
            txtPassword.Symbol = 61475;
            txtPassword.TabIndex = 3;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "Enter your password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(63, 152);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(423, 44);
            txtEmail.Symbol = 61443;
            txtEmail.TabIndex = 3;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "Enter your email";
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(48, 48, 48);
            lblPassword.Location = new Point(63, 229);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(150, 34);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(48, 48, 48);
            lblEmail.Location = new Point(63, 113);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(150, 34);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiPanel2);
            uiPanel1.Controls.Add(pictureBox1);
            uiPanel1.Controls.Add(lblSubTitle);
            uiPanel1.Controls.Add(lblTitle);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(4, 55);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(517, 780);
            uiPanel1.TabIndex = 1;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Wallet;
            pictureBox1.Location = new Point(74, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 301);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblSubTitle
            // 
            lblSubTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitle.ForeColor = Color.FromArgb(48, 48, 48);
            lblSubTitle.Location = new Point(74, 113);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(356, 34);
            lblSubTitle.TabIndex = 3;
            lblSubTitle.Text = "Login to access your Mini Digital Wallet";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(48, 48, 48);
            lblTitle.Location = new Point(90, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(327, 49);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Welcome Back!👋";
            // 
            // uiPanel2
            // 
            uiPanel2.BackColor = Color.White;
            uiPanel2.Controls.Add(uiTextBox3);
            uiPanel2.Controls.Add(uiLabel3);
            uiPanel2.Controls.Add(uiTextBox2);
            uiPanel2.Controls.Add(uiLabel2);
            uiPanel2.Controls.Add(uiTextBox1);
            uiPanel2.Controls.Add(uiLabel1);
            uiPanel2.Controls.Add(uiSymbolButton1);
            uiPanel2.Controls.Add(uiSymbolButton3);
            uiPanel2.Controls.Add(uiSymbolButton2);
            uiPanel2.FillColor = Color.Transparent;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(29, 475);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(461, 300);
            uiPanel2.TabIndex = 5;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiSymbolButton2
            // 
            uiSymbolButton2.BackColor = Color.White;
            uiSymbolButton2.FillColor = Color.FromArgb(128, 255, 128);
            uiSymbolButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolButton2.Location = new Point(19, 120);
            uiSymbolButton2.MinimumSize = new Size(1, 1);
            uiSymbolButton2.Name = "uiSymbolButton2";
            uiSymbolButton2.Size = new Size(57, 70);
            uiSymbolButton2.Symbol = 61671;
            uiSymbolButton2.TabIndex = 7;
            uiSymbolButton2.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiSymbolButton3
            // 
            uiSymbolButton3.FillColor = Color.RoyalBlue;
            uiSymbolButton3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolButton3.Location = new Point(19, 212);
            uiSymbolButton3.MinimumSize = new Size(1, 1);
            uiSymbolButton3.Name = "uiSymbolButton3";
            uiSymbolButton3.Size = new Size(57, 73);
            uiSymbolButton3.Symbol = 61568;
            uiSymbolButton3.TabIndex = 8;
            uiSymbolButton3.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiSymbolButton1
            // 
            uiSymbolButton1.BackColor = Color.White;
            uiSymbolButton1.FillColor = Color.DarkSlateBlue;
            uiSymbolButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiSymbolButton1.Location = new Point(18, 26);
            uiSymbolButton1.MinimumSize = new Size(1, 1);
            uiSymbolButton1.Name = "uiSymbolButton1";
            uiSymbolButton1.Size = new Size(57, 73);
            uiSymbolButton1.Symbol = 62124;
            uiSymbolButton1.TabIndex = 9;
            uiSymbolButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(82, 26);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(94, 34);
            uiLabel1.TabIndex = 10;
            uiLabel1.Text = "Secure";
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiTextBox1.Location = new Point(82, 60);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.RectColor = Color.White;
            uiTextBox1.ScrollBarStyleInherited = false;
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(267, 36);
            uiTextBox1.TabIndex = 11;
            uiTextBox1.Text = "Your transactiopn are 100% safe";
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(82, 120);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(94, 34);
            uiLabel2.TabIndex = 12;
            uiLabel2.Text = "Fast";
            // 
            // uiTextBox2
            // 
            uiTextBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiTextBox2.Location = new Point(82, 154);
            uiTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiTextBox2.MinimumSize = new Size(1, 16);
            uiTextBox2.Name = "uiTextBox2";
            uiTextBox2.Padding = new Padding(5);
            uiTextBox2.RectColor = Color.White;
            uiTextBox2.ShowText = false;
            uiTextBox2.Size = new Size(275, 36);
            uiTextBox2.TabIndex = 12;
            uiTextBox2.Text = "Send and receiw money instantly";
            uiTextBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox2.Watermark = "";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(82, 212);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(94, 34);
            uiLabel3.TabIndex = 13;
            uiLabel3.Text = "Easy";
            // 
            // uiTextBox3
            // 
            uiTextBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiTextBox3.Location = new Point(82, 249);
            uiTextBox3.Margin = new Padding(4, 5, 4, 5);
            uiTextBox3.MinimumSize = new Size(1, 16);
            uiTextBox3.Name = "uiTextBox3";
            uiTextBox3.Padding = new Padding(5);
            uiTextBox3.RectColor = Color.White;
            uiTextBox3.ScrollBarStyleInherited = false;
            uiTextBox3.ShowText = false;
            uiTextBox3.Size = new Size(267, 36);
            uiTextBox3.TabIndex = 13;
            uiTextBox3.Text = "Simple and user-friendly wallet";
            uiTextBox3.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox3.Watermark = "";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1088, 843);
            Controls.Add(uiPanel1);
            Controls.Add(uiPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Padding = new Padding(0, 50, 0, 0);
            SizeGripStyle = SizeGripStyle.Show;
            Text = "LOGIN";
            TitleHeight = 50;
            ZoomScaleRect = new Rectangle(22, 22, 800, 450);
            Load += Form1_Load;
            uiPanel.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            uiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UILabel lblPassword;
        private Sunny.UI.UILabel lblEmail;
        private Sunny.UI.UILinkLabel lblForgotPassword;
        private Sunny.UI.UICheckBox chkRemember;
        private Sunny.UI.UILabel lblOr;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel lblSubTitle;
        private Sunny.UI.UILabel lblTitle;
        private PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton SymLogin;
        private Sunny.UI.UISymbolButton SymCNA;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UILabel uiLabel3;
    }
}
