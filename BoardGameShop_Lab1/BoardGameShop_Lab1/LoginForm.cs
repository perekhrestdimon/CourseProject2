using System;
using System.Windows.Forms;

namespace BoardGameShop_Lab1
{
    public partial class LoginForm : Form
    {
        public bool IsAdmin { get; private set; } = false;

        public LoginForm()
        {
            InitializeComponent();
            this.Text = "Авторизація";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtPassword.Text == "admin")
            {
                IsAdmin = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Невірний логін або пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            IsAdmin = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}