using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms; 

public partial class RegisterForm : Form {
    private IAuthService register = new AuthService();
    
    public RegisterForm() {
        InitializeComponent();
    }
    
    private async void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            var login = tbUsername.Text;
            var password = tbPassword.Text;
            var name = tbName.Text;
            var surname = tbSurname.Text;

            var res = await register.signUp(new User() {
                login = login,
                password = password,
                firstName = name,
                lastName = surname
            });
                
            if (!res)
            {
                MessageBox.Show("Такой пользователь уже существует");
            }
            else
            {
                MessageBox.Show("Вы успешно зарегистрировались");
                AuthForm authForm = new AuthForm();
                authForm.Show();
                Hide();
            }

        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
        }
    }

    private void RegisterForm_Load(object sender, EventArgs e)
    {
        AcceptButton = btnLogin;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        //вернуться на форму авторизации
        AuthForm authForm = new AuthForm();
        authForm.Show();
        Hide();
    }

    private void btnLogin_MouseEnter(object sender, EventArgs e)
    {
        btnLogin.ForeColor = Color.Black;
    }

    private void btnLogin_MouseLeave(object sender, EventArgs e)
    {
        btnLogin.ForeColor = Color.DarkTurquoise;
    }

    private void button1_MouseEnter(object sender, EventArgs e)
    {
        btnLogin.ForeColor = Color.Black;
    }

    private void button1_MouseLeave(object sender, EventArgs e)
    {
        btnLogin.ForeColor = Color.DarkTurquoise;
    }
}