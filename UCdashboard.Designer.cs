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
            panel1 = new Panel();
            BtnPay = new Button();
            LblWallet = new Label();
            LblMoney = new Label();
            pictureBox1 = new PictureBox();
            LblAvailableBalance = new Label();
            BtnAddMoney = new Button();
            BtnTransacton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(BtnTransacton);
            panel1.Controls.Add(BtnPay);
            panel1.Controls.Add(LblWallet);
            panel1.Controls.Add(BtnAddMoney);
            panel1.Controls.Add(LblMoney);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LblAvailableBalance);
            panel1.Location = new Point(50, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 614);
            panel1.TabIndex = 0;
            // 
            // BtnPay
            // 
            BtnPay.BackColor = Color.FromArgb(192, 192, 255);
            BtnPay.FlatStyle = FlatStyle.Popup;
            BtnPay.ForeColor = Color.White;
            BtnPay.Location = new Point(35, 434);
            BtnPay.Name = "BtnPay";
            BtnPay.Size = new Size(233, 137);
            BtnPay.TabIndex = 4;
            BtnPay.Text = "Pay";
            BtnPay.UseVisualStyleBackColor = false;
            // 
            // LblWallet
            // 
            LblWallet.AutoSize = true;
            LblWallet.BackColor = Color.FromArgb(128, 128, 255);
            LblWallet.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblWallet.ForeColor = SystemColors.ButtonHighlight;
            LblWallet.Location = new Point(338, 0);
            LblWallet.Name = "LblWallet";
            LblWallet.Size = new Size(312, 72);
            LblWallet.TabIndex = 1;
            LblWallet.Text = "Your wallet";
            LblWallet.Click += LblWallet_Click;
            // 
            // LblMoney
            // 
            LblMoney.AutoSize = true;
            LblMoney.BackColor = Color.FromArgb(128, 128, 255);
            LblMoney.Font = new Font("Nirmala Text", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMoney.ForeColor = SystemColors.ButtonHighlight;
            LblMoney.Location = new Point(13, 266);
            LblMoney.Name = "LblMoney";
            LblMoney.Size = new Size(308, 72);
            LblMoney.TabIndex = 3;
            LblMoney.Text = "$12,023.00";
            LblMoney.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wp14132219;
            pictureBox1.Location = new Point(13, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LblAvailableBalance
            // 
            LblAvailableBalance.AutoSize = true;
            LblAvailableBalance.BackColor = Color.FromArgb(128, 128, 255);
            LblAvailableBalance.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblAvailableBalance.ForeColor = SystemColors.ButtonHighlight;
            LblAvailableBalance.Location = new Point(13, 203);
            LblAvailableBalance.Name = "LblAvailableBalance";
            LblAvailableBalance.Size = new Size(313, 49);
            LblAvailableBalance.TabIndex = 2;
            LblAvailableBalance.Text = "Available Balance";
            LblAvailableBalance.Click += LblAvailableBalance_Click;
            // 
            // BtnAddMoney
            // 
            BtnAddMoney.BackColor = Color.FromArgb(192, 192, 255);
            BtnAddMoney.FlatStyle = FlatStyle.Popup;
            BtnAddMoney.ForeColor = Color.White;
            BtnAddMoney.Location = new Point(338, 434);
            BtnAddMoney.Name = "BtnAddMoney";
            BtnAddMoney.Size = new Size(233, 137);
            BtnAddMoney.TabIndex = 5;
            BtnAddMoney.Text = "Add Money";
            BtnAddMoney.UseVisualStyleBackColor = false;
            // 
            // BtnTransacton
            // 
            BtnTransacton.BackColor = Color.FromArgb(192, 192, 255);
            BtnTransacton.FlatStyle = FlatStyle.Popup;
            BtnTransacton.ForeColor = Color.White;
            BtnTransacton.Location = new Point(640, 434);
            BtnTransacton.Name = "BtnTransacton";
            BtnTransacton.Size = new Size(233, 137);
            BtnTransacton.TabIndex = 6;
            BtnTransacton.Text = "Transaction";
            BtnTransacton.UseVisualStyleBackColor = false;
            // 
            // UCdashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "UCdashboard";
            Size = new Size(1070, 1518);
            Load += UCdashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label LblWallet;
        private Label LblAvailableBalance;
        private Label LblMoney;
        private Button BtnPay;
        private Button BtnAddMoney;
        private Button BtnTransacton;
    }
}
