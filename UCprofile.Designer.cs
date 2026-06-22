namespace Mini_Digital_Wallet
{
    partial class UCprofile
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
            PanelProfile = new Sunny.UI.UIPanel();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiPanel2 = new Sunny.UI.UIPanel();
            pictureBox1 = new PictureBox();
            labeluploadpf = new Sunny.UI.UILinkLabel();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelProfile
            // 
            PanelProfile.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PanelProfile.Location = new Point(16, 5);
            PanelProfile.Margin = new Padding(4, 5, 4, 5);
            PanelProfile.MinimumSize = new Size(1, 1);
            PanelProfile.Name = "PanelProfile";
            PanelProfile.Size = new Size(667, 59);
            PanelProfile.TabIndex = 0;
            PanelProfile.Text = "Profile";
            PanelProfile.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(labeluploadpf);
            uiPanel1.Controls.Add(pictureBox1);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(16, 74);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(236, 364);
            uiPanel1.TabIndex = 1;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(269, 74);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(414, 553);
            uiPanel2.TabIndex = 2;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(48, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 108);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labeluploadpf
            // 
            labeluploadpf.ActiveLinkColor = Color.FromArgb(80, 160, 255);
            labeluploadpf.BackColor = Color.Transparent;
            labeluploadpf.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeluploadpf.ForeColor = Color.FromArgb(48, 48, 48);
            labeluploadpf.LinkBehavior = LinkBehavior.AlwaysUnderline;
            labeluploadpf.Location = new Point(48, 139);
            labeluploadpf.Name = "labeluploadpf";
            labeluploadpf.Size = new Size(90, 23);
            labeluploadpf.TabIndex = 1;
            labeluploadpf.TabStop = true;
            labeluploadpf.Text = "upload Profile";
            labeluploadpf.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            // 
            // UCprofile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(uiPanel2);
            Controls.Add(uiPanel1);
            Controls.Add(PanelProfile);
            Margin = new Padding(2);
            Name = "UCprofile";
            Size = new Size(703, 632);
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel PanelProfile;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILinkLabel labeluploadpf;
        private PictureBox pictureBox1;
        private Sunny.UI.UIPanel uiPanel2;
    }
}
