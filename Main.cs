using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mini_Digital_Wallet
{
    public partial class Main : UIForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void LoadUserControl(TabPage tab, UserControl uc)
        {
            tab.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            tab.Controls.Add(uc);
        }   //Methona   Connect from User Control to Tabpage

        private void Main_Load(object sender, EventArgs e)
        {
            LoadUserControl(TbpDashboard, new UCdashboard());
            LoadUserControl(TbpSendMoney, new UCsendmoney());
            LoadUserControl(TbpAddMoney, new UCaddmoney());
            LoadUserControl(TbpTransactions, new UCtransactions());
            LoadUserControl(TbpContacs, new UCcontacs());
            LoadUserControl(TbpProfile, new UCprofile());
            LoadUserControl(TbpSetting, new UCsetting());
            LoadUserControl(TbpLogOut, new UClogOut());
        }   //Methona   Connect from User Control to Tabpage
    }
}
