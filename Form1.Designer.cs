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
            uiPanel1 = new Sunny.UI.UIPanel();
            lblEmail = new Sunny.UI.UILabel();
            lblPassword = new Sunny.UI.UILabel();
            txtEmail = new Sunny.UI.UITextBox();
            chkRemember = new Sunny.UI.UICheckBox();
            lblForgotPassword = new Sunny.UI.UILinkLabel();
            txtPassword = new Sunny.UI.UITextBox();
            btnLogin = new Sunny.UI.UISymbolButton();
            uiLine1 = new Sunny.UI.UILine();
            btnCNA = new Sunny.UI.UISymbolButton();
            uiPanel2 = new Sunny.UI.UIPanel();
            lblTitle = new Sunny.UI.UILabel();
            lblSubTitle = new Sunny.UI.UILabel();
            pictureBox1 = new PictureBox();
            uiPanel3 = new Sunny.UI.UIPanel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            uiLabel5 = new Sunny.UI.UILabel();
            uiLabel6 = new Sunny.UI.UILabel();
            uiPanel4 = new Sunny.UI.UIPanel();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            uiPanel3.SuspendLayout();
            uiPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(btnCNA);
            uiPanel1.Controls.Add(uiLine1);
            uiPanel1.Controls.Add(btnLogin);
            uiPanel1.Controls.Add(txtPassword);
            uiPanel1.Controls.Add(lblForgotPassword);
            uiPanel1.Controls.Add(chkRemember);
            uiPanel1.Controls.Add(txtEmail);
            uiPanel1.Controls.Add(lblPassword);
            uiPanel1.Controls.Add(lblEmail);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(540, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RectColor = Color.Transparent;
            uiPanel1.Size = new Size(528, 780);
            uiPanel1.TabIndex = 0;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(48, 48, 48);
            lblEmail.Location = new Point(55, 112);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(79, 34);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(48, 48, 48);
            lblPassword.Location = new Point(55, 243);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(129, 34);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(55, 151);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(404, 44);
            txtEmail.Symbol = 61443;
            txtEmail.SymbolSize = 32;
            txtEmail.TabIndex = 2;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "Enter your email";
            // 
            // chkRemember
            // 
            chkRemember.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkRemember.ForeColor = Color.FromArgb(48, 48, 48);
            chkRemember.Location = new Point(55, 344);
            chkRemember.MinimumSize = new Size(1, 1);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(200, 44);
            chkRemember.TabIndex = 4;
            chkRemember.Text = "Remember Me";
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.ActiveLinkColor = Color.FromArgb(80, 160, 255);
            lblForgotPassword.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForgotPassword.ForeColor = Color.FromArgb(48, 48, 48);
            lblForgotPassword.LinkBehavior = LinkBehavior.AlwaysUnderline;
            lblForgotPassword.LinkColor = Color.MediumBlue;
            lblForgotPassword.Location = new Point(284, 354);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(175, 34);
            lblForgotPassword.TabIndex = 5;
            lblForgotPassword.TabStop = true;
            lblForgotPassword.Text = "Forgot Password?";
            lblForgotPassword.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(55, 282);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(404, 44);
            txtPassword.Symbol = 61475;
            txtPassword.SymbolSize = 32;
            txtPassword.TabIndex = 3;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "Enter your password";
            // 
            // btnLogin
            // 
            btnLogin.FillColor = Color.MediumBlue;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(55, 451);
            btnLogin.MinimumSize = new Size(1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Radius = 20;
            btnLogin.Size = new Size(404, 65);
            btnLogin.Symbol = 61537;
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiLine1
            // 
            uiLine1.BackColor = Color.Transparent;
            uiLine1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLine1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine1.Location = new Point(55, 539);
            uiLine1.MinimumSize = new Size(1, 1);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new Size(404, 44);
            uiLine1.TabIndex = 7;
            uiLine1.Text = "OR";
            // 
            // btnCNA
            // 
            btnCNA.FillColor = Color.White;
            btnCNA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCNA.ForeColor = Color.MediumBlue;
            btnCNA.Location = new Point(55, 613);
            btnCNA.MinimumSize = new Size(1, 1);
            btnCNA.Name = "btnCNA";
            btnCNA.Radius = 20;
            btnCNA.Size = new Size(404, 65);
            btnCNA.Symbol = 61447;
            btnCNA.SymbolColor = Color.MediumBlue;
            btnCNA.TabIndex = 8;
            btnCNA.Text = "Create New Account";
            btnCNA.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(uiPanel3);
            uiPanel2.Controls.Add(pictureBox1);
            uiPanel2.Controls.Add(lblSubTitle);
            uiPanel2.Controls.Add(lblTitle);
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(4, 0);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.RectColor = Color.Transparent;
            uiPanel2.Size = new Size(544, 780);
            uiPanel2.TabIndex = 1;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(48, 48, 48);
            lblTitle.Location = new Point(125, 56);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(301, 49);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome Back!👋";
            // 
            // lblSubTitle
            // 
            lblSubTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitle.ForeColor = Color.FromArgb(48, 48, 48);
            lblSubTitle.Location = new Point(88, 115);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(357, 34);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Login to access your Mini Digital Wallet";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Wallet;
            pictureBox1.Location = new Point(64, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // uiPanel3
            // 
            uiPanel3.Controls.Add(uiLabel6);
            uiPanel3.Controls.Add(uiLabel5);
            uiPanel3.Controls.Add(uiSymbolButton3);
            uiPanel3.Controls.Add(uiLabel4);
            uiPanel3.Controls.Add(uiLabel3);
            uiPanel3.Controls.Add(uiSymbolButton2);
            uiPanel3.Controls.Add(uiSymbolButton1);
            uiPanel3.Controls.Add(uiLabel2);
            uiPanel3.Controls.Add(uiLabel1);
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.Location = new Point(39, 464);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.RectColor = Color.Transparent;
            uiPanel3.Size = new Size(437, 296);
            uiPanel3.TabIndex = 3;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(92, 30);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(90, 34);
            uiLabel1.TabIndex = 1;
            uiLabel1.Text = "Secure";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(92, 64);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(320, 34);
            uiLabel2.TabIndex = 2;
            uiLabel2.Text = "Your transaction are 100% safe";
            // 
            // uiSymbolButton1
            // 
            uiSymbolButton1.BackColor = Color.White;
            uiSymbolButton1.FillColor = Color.Navy;
            uiSymbolButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolButton1.Location = new Point(25, 30);
            uiSymbolButton1.MinimumSize = new Size(1, 1);
            uiSymbolButton1.Name = "uiSymbolButton1";
            uiSymbolButton1.Radius = 20;
            uiSymbolButton1.Size = new Size(61, 68);
            uiSymbolButton1.Symbol = 62124;
            uiSymbolButton1.SymbolSize = 32;
            uiSymbolButton1.TabIndex = 3;
            uiSymbolButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiSymbolButton2
            // 
            uiSymbolButton2.BackColor = Color.White;
            uiSymbolButton2.FillColor = Color.FromArgb(128, 255, 128);
            uiSymbolButton2.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolButton2.Location = new Point(25, 115);
            uiSymbolButton2.MinimumSize = new Size(1, 1);
            uiSymbolButton2.Name = "uiSymbolButton2";
            uiSymbolButton2.Radius = 20;
            uiSymbolButton2.Size = new Size(61, 68);
            uiSymbolButton2.Symbol = 61671;
            uiSymbolButton2.SymbolSize = 32;
            uiSymbolButton2.TabIndex = 4;
            uiSymbolButton2.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiSymbolButton2.Click += uiSymbolButton2_Click;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(92, 115);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(90, 34);
            uiLabel3.TabIndex = 5;
            uiLabel3.Text = "Fast";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(92, 149);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(320, 34);
            uiLabel4.TabIndex = 6;
            uiLabel4.Text = "Send and reciew money instantly";
            // 
            // uiSymbolButton3
            // 
            uiSymbolButton3.BackColor = Color.White;
            uiSymbolButton3.FillColor = Color.RoyalBlue;
            uiSymbolButton3.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolButton3.Location = new Point(25, 201);
            uiSymbolButton3.MinimumSize = new Size(1, 1);
            uiSymbolButton3.Name = "uiSymbolButton3";
            uiSymbolButton3.Radius = 20;
            uiSymbolButton3.Size = new Size(61, 68);
            uiSymbolButton3.Symbol = 61568;
            uiSymbolButton3.SymbolSize = 32;
            uiSymbolButton3.TabIndex = 7;
            uiSymbolButton3.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(92, 201);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(90, 34);
            uiLabel5.TabIndex = 8;
            uiLabel5.Text = "Easy";
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Location = new Point(92, 235);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(320, 34);
            uiLabel6.TabIndex = 9;
            uiLabel6.Text = "Simple and user-friendly wallet";
            // 
            // uiPanel4
            // 
            uiPanel4.Controls.Add(uiPanel1);
            uiPanel4.Controls.Add(uiPanel2);
            uiPanel4.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel4.Location = new Point(4, 55);
            uiPanel4.Margin = new Padding(4, 5, 4, 5);
            uiPanel4.MinimumSize = new Size(1, 1);
            uiPanel4.Name = "uiPanel4";
            uiPanel4.RectColor = Color.Transparent;
            uiPanel4.Size = new Size(1072, 780);
            uiPanel4.TabIndex = 4;
            uiPanel4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1080, 840);
            Controls.Add(uiPanel4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Padding = new Padding(0, 50, 0, 0);
            SizeGripStyle = SizeGripStyle.Show;
            Text = "LOGIN";
            TitleHeight = 50;
            ZoomScaleRect = new Rectangle(22, 22, 800, 450);
            uiPanel1.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            uiPanel3.ResumeLayout(false);
            uiPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel lblEmail;
        private Sunny.UI.UILinkLabel lblForgotPassword;
        private Sunny.UI.UICheckBox chkRemember;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UILabel lblPassword;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolButton btnLogin;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UISymbolButton btnCNA;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel lblSubTitle;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private PictureBox pictureBox1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UIPanel uiPanel4;
    }
}
