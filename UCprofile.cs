using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mini_Digital_Wallet
{
    public partial class UCprofile : UserControl
    {
        public UCprofile()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            uiPanel1 = new Sunny.UI.UIPanel();
            labeluploadpf = new Sunny.UI.UILinkLabel();
            pictureBox1 = new PictureBox();
            PanelProfile = new Sunny.UI.UIPanel();
            uiPanel2 = new Sunny.UI.UIPanel();
            txtaddressPF = new Sunny.UI.UITextBox();
            txtdobPF = new Sunny.UI.UITextBox();
            txtphonePF = new Sunny.UI.UITextBox();
            txtemailPF = new Sunny.UI.UITextBox();
            txtfullnamePF = new Sunny.UI.UITextBox();
            labeladdressPF = new Sunny.UI.UILabel();
            lbeldobPF = new Sunny.UI.UILabel();
            LabelphonePF = new Sunny.UI.UILabel();
            labelemailPF = new Sunny.UI.UILabel();
            lblfullnamePF = new Sunny.UI.UILabel();
            uiPanel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            uiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(labeluploadpf);
            uiPanel1.Controls.Add(pictureBox1);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(18, 79);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(236, 364);
            uiPanel1.TabIndex = 4;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(48, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 108);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelProfile
            // 
            PanelProfile.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PanelProfile.Location = new Point(18, 10);
            PanelProfile.Margin = new Padding(4, 5, 4, 5);
            PanelProfile.MinimumSize = new Size(1, 1);
            PanelProfile.Name = "PanelProfile";
            PanelProfile.Size = new Size(667, 59);
            PanelProfile.TabIndex = 3;
            PanelProfile.Text = "Profile";
            PanelProfile.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(txtaddressPF);
            uiPanel2.Controls.Add(txtdobPF);
            uiPanel2.Controls.Add(txtphonePF);
            uiPanel2.Controls.Add(txtemailPF);
            uiPanel2.Controls.Add(txtfullnamePF);
            uiPanel2.Controls.Add(labeladdressPF);
            uiPanel2.Controls.Add(lbeldobPF);
            uiPanel2.Controls.Add(LabelphonePF);
            uiPanel2.Controls.Add(labelemailPF);
            uiPanel2.Controls.Add(lblfullnamePF);
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(271, 79);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(414, 543);
            uiPanel2.TabIndex = 5;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtaddressPF
            // 
            txtaddressPF.Font = new Font("Microsoft Sans Serif", 12F);
            txtaddressPF.Location = new Point(26, 422);
            txtaddressPF.Margin = new Padding(4, 5, 4, 5);
            txtaddressPF.MinimumSize = new Size(1, 16);
            txtaddressPF.Name = "txtaddressPF";
            txtaddressPF.Padding = new Padding(5);
            txtaddressPF.ShowText = false;
            txtaddressPF.Size = new Size(354, 91);
            txtaddressPF.TabIndex = 9;
            txtaddressPF.TextAlignment = ContentAlignment.MiddleLeft;
            txtaddressPF.Watermark = "";
            // 
            // txtdobPF
            // 
            txtdobPF.Font = new Font("Microsoft Sans Serif", 12F);
            txtdobPF.Location = new Point(26, 328);
            txtdobPF.Margin = new Padding(4, 5, 4, 5);
            txtdobPF.MinimumSize = new Size(1, 16);
            txtdobPF.Name = "txtdobPF";
            txtdobPF.Padding = new Padding(5);
            txtdobPF.ShowText = false;
            txtdobPF.Size = new Size(354, 36);
            txtdobPF.TabIndex = 8;
            txtdobPF.TextAlignment = ContentAlignment.MiddleLeft;
            txtdobPF.Watermark = "";
            // 
            // txtphonePF
            // 
            txtphonePF.Font = new Font("Microsoft Sans Serif", 12F);
            txtphonePF.Location = new Point(26, 234);
            txtphonePF.Margin = new Padding(4, 5, 4, 5);
            txtphonePF.MinimumSize = new Size(1, 16);
            txtphonePF.Name = "txtphonePF";
            txtphonePF.Padding = new Padding(5);
            txtphonePF.ShowText = false;
            txtphonePF.Size = new Size(354, 36);
            txtphonePF.TabIndex = 7;
            txtphonePF.TextAlignment = ContentAlignment.MiddleLeft;
            txtphonePF.Watermark = "";
            // 
            // txtemailPF
            // 
            txtemailPF.Font = new Font("Microsoft Sans Serif", 12F);
            txtemailPF.Location = new Point(26, 139);
            txtemailPF.Margin = new Padding(4, 5, 4, 5);
            txtemailPF.MinimumSize = new Size(1, 16);
            txtemailPF.Name = "txtemailPF";
            txtemailPF.Padding = new Padding(5);
            txtemailPF.ShowText = false;
            txtemailPF.Size = new Size(354, 36);
            txtemailPF.TabIndex = 6;
            txtemailPF.TextAlignment = ContentAlignment.MiddleLeft;
            txtemailPF.Watermark = "";
            // 
            // txtfullnamePF
            // 
            txtfullnamePF.Font = new Font("Microsoft Sans Serif", 12F);
            txtfullnamePF.Location = new Point(26, 53);
            txtfullnamePF.Margin = new Padding(4, 5, 4, 5);
            txtfullnamePF.MinimumSize = new Size(1, 16);
            txtfullnamePF.Name = "txtfullnamePF";
            txtfullnamePF.Padding = new Padding(5);
            txtfullnamePF.ShowText = false;
            txtfullnamePF.Size = new Size(354, 36);
            txtfullnamePF.TabIndex = 5;
            txtfullnamePF.TextAlignment = ContentAlignment.MiddleLeft;
            txtfullnamePF.Watermark = "";
            // 
            // labeladdressPF
            // 
            labeladdressPF.BackColor = Color.Transparent;
            labeladdressPF.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeladdressPF.ForeColor = Color.FromArgb(48, 48, 48);
            labeladdressPF.Location = new Point(26, 397);
            labeladdressPF.Name = "labeladdressPF";
            labeladdressPF.Size = new Size(125, 29);
            labeladdressPF.TabIndex = 4;
            labeladdressPF.Text = "Address";
            // 
            // lbeldobPF
            // 
            lbeldobPF.BackColor = Color.Transparent;
            lbeldobPF.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbeldobPF.ForeColor = Color.FromArgb(48, 48, 48);
            lbeldobPF.Location = new Point(26, 305);
            lbeldobPF.Name = "lbeldobPF";
            lbeldobPF.Size = new Size(125, 29);
            lbeldobPF.TabIndex = 3;
            lbeldobPF.Text = "Date of Birth";
            // 
            // LabelphonePF
            // 
            LabelphonePF.BackColor = Color.Transparent;
            LabelphonePF.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelphonePF.ForeColor = Color.FromArgb(48, 48, 48);
            LabelphonePF.Location = new Point(26, 210);
            LabelphonePF.Name = "LabelphonePF";
            LabelphonePF.Size = new Size(125, 29);
            LabelphonePF.TabIndex = 2;
            LabelphonePF.Text = "Phone Number";
            // 
            // labelemailPF
            // 
            labelemailPF.BackColor = Color.Transparent;
            labelemailPF.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelemailPF.ForeColor = Color.FromArgb(48, 48, 48);
            labelemailPF.Location = new Point(26, 115);
            labelemailPF.Name = "labelemailPF";
            labelemailPF.Size = new Size(125, 29);
            labelemailPF.TabIndex = 1;
            labelemailPF.Text = "Email";
            // 
            // lblfullnamePF
            // 
            lblfullnamePF.BackColor = Color.Transparent;
            lblfullnamePF.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfullnamePF.ForeColor = Color.FromArgb(48, 48, 48);
            lblfullnamePF.Location = new Point(26, 28);
            lblfullnamePF.Name = "lblfullnamePF";
            lblfullnamePF.Size = new Size(125, 29);
            lblfullnamePF.TabIndex = 0;
            lblfullnamePF.Text = "Full Name";
            // 
            // UCprofile
            // 
            Controls.Add(uiPanel1);
            Controls.Add(PanelProfile);
            Controls.Add(uiPanel2);
            Name = "UCprofile";
            Size = new Size(703, 632);
            uiPanel1.ResumeLayout(false);
            ((ISupportInitialize)pictureBox1).EndInit();
            uiPanel2.ResumeLayout(false);
            ResumeLayout(false);

        }
    }
}
