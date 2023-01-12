using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsForms.Data.Service;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms {
    public partial class AuthForm : Form
    {
        private readonly IAuthService login = new AuthService();

        public AuthForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var signUpForm = new RegisterForm();
            signUpForm.Show();
            Hide();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DarkTurquoise;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var username = tbUsername.Text;
                var password = tbPassword.Text;

                var info = await login.signIn(username, password);


                if (info == null) return;

                var userForm = new UserForm();
                userForm.Show();
                if (info.role == "admin")
                {
                    // ClientForm userForm = new ClientForm(access: info);
                    // userForm.Show();
                    Hide();
                }
                else if (info.role == "user")
                {
                    // ClientForm userForm = new ClientForm(info.Email, info.Role, info.access_token);
                    // userForm.Show();
                    Hide();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.DarkTurquoise;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            //при нажатии на Enter нажимается кнопка входа
            this.AcceptButton = btnLogin;
            //при нажатии кнопка анимирует
            btnLogin.MouseEnter += (s, a) => { btnLogin.ForeColor = Color.Black; };
            btnLogin.MouseLeave += (s, a) => { btnLogin.ForeColor = Color.DarkTurquoise; };

            //пока данные загружаются кнопка блокируется
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}