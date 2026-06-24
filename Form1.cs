using Sunny.UI;
namespace Mini_Digital_Wallet
{
    public partial class Form1 : UIForm
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            btnLogin.FillColor = Color.FromArgb(108, 92, 231);

            btnLogin.RectColor = Color.FromArgb(108, 92, 231);

            btnCreateAccount.FillColor = Color.White;

            btnCreateAccount.RectColor = Color.FromArgb(108, 92, 231);

            btnCreateAccount.ForeColor = Color.FromArgb(108, 92, 231);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")

            {

                UIMessageBox.ShowWarning("Please enter email!");

                txtEmail.Focus();

                return;

            }

            if (txtPassword.Text.Trim() == "")

            {

                UIMessageBox.ShowWarning("Please enter password!");

                txtPassword.Focus();

                return;

            }

            if (txtEmail.Text == "admin@gmail.com" &&

                txtPassword.Text == "123456")

            {

                UIMessageBox.ShowSuccess("Login Successful");

                UCdashboard frm = new UCdashboard();

                frm.Show();

                this.Hide();

            }

            else

            {

                UIMessageBox.ShowError("Invalid Email or Password!");

            }

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            UIMessageBox.Show("Forgot Password Function");
        }

        private void btnEye_Click(object sender, EventArgs e)
        {

        }

        private void uiPanel_Click(object sender, EventArgs e)
        {

        }

        private void SymLogin_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text.Trim() == "")

            {

                UIMessageBox.ShowWarning("Please enter email!");

                txtEmail.Focus();

                return;

            }

            if (txtPassword.Text.Trim() == "")

            {

                UIMessageBox.ShowWarning("Please enter password!");

                txtPassword.Focus();

                return;

            }

            if (txtEmail.Text == "admin@gmail.com" &&

                txtPassword.Text == "123456")

            {

                UIMessageBox.ShowSuccess("Login Successful");

                UCdashboard frm = new UCdashboard();

                frm.Show();

                this.Hide();

            }

            else

            {

                UIMessageBox.ShowError("Invalid Email or Password!");

            }
        }

        private void SymCNA_Click(object sender, EventArgs e)
        {
            Register frm = new Register();
            frm.Show();
            this.Hide();
        }
    }
}
