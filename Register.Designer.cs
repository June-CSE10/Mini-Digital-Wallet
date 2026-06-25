namespace Mini_Digital_Wallet
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            LblAcc = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            LblName = new Sunny.UI.UILabel();
            LblEmail = new Sunny.UI.UILabel();
            LblPassword = new Sunny.UI.UILabel();
            LblCfPassword = new Sunny.UI.UILabel();
            LblPhoneNumber = new Sunny.UI.UILabel();
            TxtName = new Sunny.UI.UITextBox();
            TxtEmail = new Sunny.UI.UITextBox();
            TxtPassword = new Sunny.UI.UITextBox();
            TxtCfPassword = new Sunny.UI.UITextBox();
            TxtPhoneNumber = new Sunny.UI.UITextBox();
            CheckBox1 = new Sunny.UI.UICheckBox();
            BtnRegister = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            uiLabel2 = new Sunny.UI.UILabel();
            uiImageListBox1 = new Sunny.UI.UIImageListBox();
            SuspendLayout();
            // 
            // LblAcc
            // 
            LblAcc.Font = new Font("Microsoft Sans Serif", 12F);
            LblAcc.ForeColor = Color.FromArgb(48, 48, 48);
            LblAcc.Location = new Point(401, 61);
            LblAcc.Name = "LblAcc";
            LblAcc.Size = new Size(245, 38);
            LblAcc.TabIndex = 0;
            LblAcc.Text = "Create Your Account";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(401, 99);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(223, 29);
            uiLabel1.TabIndex = 1;
            uiLabel1.Text = "Fill in the details to get started";
            uiLabel1.Click += uiLabel1_Click;
            // 
            // LblName
            // 
            LblName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblName.ForeColor = Color.FromArgb(48, 48, 48);
            LblName.Location = new Point(401, 128);
            LblName.Name = "LblName";
            LblName.Size = new Size(114, 37);
            LblName.TabIndex = 2;
            LblName.Text = "Full Name";
            // 
            // LblEmail
            // 
            LblEmail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblEmail.ForeColor = Color.FromArgb(48, 48, 48);
            LblEmail.Location = new Point(401, 197);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(114, 37);
            LblEmail.TabIndex = 7;
            LblEmail.Text = "Email";
            // 
            // LblPassword
            // 
            LblPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPassword.ForeColor = Color.FromArgb(48, 48, 48);
            LblPassword.Location = new Point(401, 265);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(114, 37);
            LblPassword.TabIndex = 8;
            LblPassword.Text = "Password";
            LblPassword.Click += LblPassword_Click;
            // 
            // LblCfPassword
            // 
            LblCfPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCfPassword.ForeColor = Color.FromArgb(48, 48, 48);
            LblCfPassword.Location = new Point(401, 330);
            LblCfPassword.Name = "LblCfPassword";
            LblCfPassword.Size = new Size(297, 37);
            LblCfPassword.TabIndex = 9;
            LblCfPassword.Text = "Confirm Password";
            // 
            // LblPhoneNumber
            // 
            LblPhoneNumber.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblPhoneNumber.ForeColor = Color.FromArgb(48, 48, 48);
            LblPhoneNumber.Location = new Point(401, 404);
            LblPhoneNumber.Name = "LblPhoneNumber";
            LblPhoneNumber.Size = new Size(114, 37);
            LblPhoneNumber.TabIndex = 10;
            LblPhoneNumber.Text = "Phone Number";
            LblPhoneNumber.Click += LblPhoneNumber_Click;
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtName.Location = new Point(401, 156);
            TxtName.Margin = new Padding(4, 5, 4, 5);
            TxtName.MinimumSize = new Size(1, 16);
            TxtName.Name = "TxtName";
            TxtName.Padding = new Padding(5);
            TxtName.RectColor = Color.White;
            TxtName.ShowText = false;
            TxtName.Size = new Size(297, 36);
            TxtName.TabIndex = 12;
            TxtName.Text = "Enter your full name";
            TxtName.TextAlignment = ContentAlignment.MiddleLeft;
            TxtName.Watermark = "";
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEmail.Location = new Point(401, 224);
            TxtEmail.Margin = new Padding(4, 5, 4, 5);
            TxtEmail.MinimumSize = new Size(1, 16);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Padding = new Padding(5);
            TxtEmail.RectColor = Color.White;
            TxtEmail.ShowText = false;
            TxtEmail.Size = new Size(297, 36);
            TxtEmail.TabIndex = 13;
            TxtEmail.Text = "Enter your email";
            TxtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            TxtEmail.Watermark = "";
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPassword.Location = new Point(401, 289);
            TxtPassword.Margin = new Padding(4, 5, 4, 5);
            TxtPassword.MinimumSize = new Size(1, 16);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Padding = new Padding(5);
            TxtPassword.RectColor = Color.White;
            TxtPassword.ShowText = false;
            TxtPassword.Size = new Size(297, 36);
            TxtPassword.TabIndex = 14;
            TxtPassword.Text = "Create a password";
            TxtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            TxtPassword.Watermark = "";
            // 
            // TxtCfPassword
            // 
            TxtCfPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCfPassword.Location = new Point(401, 363);
            TxtCfPassword.Margin = new Padding(4, 5, 4, 5);
            TxtCfPassword.MinimumSize = new Size(1, 16);
            TxtCfPassword.Name = "TxtCfPassword";
            TxtCfPassword.Padding = new Padding(5);
            TxtCfPassword.RectColor = Color.White;
            TxtCfPassword.ShowText = false;
            TxtCfPassword.Size = new Size(297, 36);
            TxtCfPassword.TabIndex = 15;
            TxtCfPassword.Text = "Confirm your password";
            TxtCfPassword.TextAlignment = ContentAlignment.MiddleLeft;
            TxtCfPassword.Watermark = "";
            // 
            // TxtPhoneNumber
            // 
            TxtPhoneNumber.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPhoneNumber.Location = new Point(401, 428);
            TxtPhoneNumber.Margin = new Padding(4, 5, 4, 5);
            TxtPhoneNumber.MinimumSize = new Size(1, 16);
            TxtPhoneNumber.Name = "TxtPhoneNumber";
            TxtPhoneNumber.Padding = new Padding(5);
            TxtPhoneNumber.RectColor = Color.White;
            TxtPhoneNumber.ShowText = false;
            TxtPhoneNumber.Size = new Size(297, 36);
            TxtPhoneNumber.TabIndex = 16;
            TxtPhoneNumber.TextAlignment = ContentAlignment.MiddleLeft;
            TxtPhoneNumber.Watermark = "Enter your phone number";
            // 
            // CheckBox1
            // 
            CheckBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBox1.ForeColor = Color.FromArgb(48, 48, 48);
            CheckBox1.Location = new Point(401, 472);
            CheckBox1.MinimumSize = new Size(1, 1);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(297, 49);
            CheckBox1.TabIndex = 17;
            CheckBox1.Text = "I agree to the Terms & Conditions";
            // 
            // BtnRegister
            // 
            BtnRegister.FillColor = Color.Purple;
            BtnRegister.FillColor2 = Color.Purple;
            BtnRegister.Font = new Font("Microsoft Sans Serif", 12F);
            BtnRegister.Location = new Point(401, 527);
            BtnRegister.MinimumSize = new Size(1, 1);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.RectColor = Color.FromArgb(192, 0, 192);
            BtnRegister.RectHoverColor = Color.FromArgb(192, 0, 192);
            BtnRegister.RectPressColor = Color.FromArgb(192, 0, 192);
            BtnRegister.RectSelectedColor = Color.FromArgb(192, 0, 192);
            BtnRegister.Size = new Size(299, 50);
            BtnRegister.TabIndex = 18;
            BtnRegister.Text = "Register";
            BtnRegister.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiButton1
            // 
            uiButton1.FillColor = Color.DeepSkyBlue;
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton1.Location = new Point(401, 662);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(299, 50);
            uiButton1.TabIndex = 19;
            uiButton1.Text = "Already have an account? Login";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(499, 611);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(125, 29);
            uiLabel2.TabIndex = 20;
            uiLabel2.Text = "Or";
            // 
            // uiImageListBox1
            // 
            uiImageListBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiImageListBox1.HoverColor = Color.FromArgb(155, 200, 255);
            uiImageListBox1.ItemSelectForeColor = Color.White;
            uiImageListBox1.Location = new Point(68, 218);
            uiImageListBox1.Margin = new Padding(4, 5, 4, 5);
            uiImageListBox1.MinimumSize = new Size(1, 1);
            uiImageListBox1.Name = "uiImageListBox1";
            uiImageListBox1.Padding = new Padding(2);
            uiImageListBox1.ShowText = false;
            uiImageListBox1.Size = new Size(228, 188);
            uiImageListBox1.TabIndex = 22;
            uiImageListBox1.Text = "uiImageListBox1";
            uiImageListBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1080, 840);
            Controls.Add(uiImageListBox1);
            Controls.Add(uiLabel2);
            Controls.Add(uiButton1);
            Controls.Add(BtnRegister);
            Controls.Add(CheckBox1);
            Controls.Add(TxtPhoneNumber);
            Controls.Add(TxtCfPassword);
            Controls.Add(TxtPassword);
            Controls.Add(TxtEmail);
            Controls.Add(TxtName);
            Controls.Add(LblPhoneNumber);
            Controls.Add(LblCfPassword);
            Controls.Add(LblPassword);
            Controls.Add(LblEmail);
            Controls.Add(LblName);
            Controls.Add(uiLabel1);
            Controls.Add(LblAcc);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            Padding = new Padding(0, 50, 0, 0);
            Text = "REGISTER";
            TitleHeight = 50;
            ZoomScaleRect = new Rectangle(22, 22, 800, 450);
            Load += Register_Load;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel LblAcc;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel LblName;
        private Sunny.UI.UILabel LblEmail;
        private Sunny.UI.UILabel LblPassword;
        private Sunny.UI.UILabel LblCfPassword;
        private Sunny.UI.UILabel LblPhoneNumber;
        private Sunny.UI.UITextBox TxtName;
        private Sunny.UI.UITextBox TxtEmail;
        private Sunny.UI.UITextBox TxtPassword;
        private Sunny.UI.UITextBox TxtCfPassword;
        private Sunny.UI.UITextBox TxtPhoneNumber;
        private Sunny.UI.UICheckBox CheckBox1;
        private Sunny.UI.UIButton BtnRegister;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIImageListBox uiImageListBox1;
    }
}