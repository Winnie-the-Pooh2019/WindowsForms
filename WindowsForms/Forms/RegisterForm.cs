using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service;
using WindowsForms.Data.Service.Exceptions;
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
        catch (NothingFoundException exception) {
            Console.WriteLine(exception);
            MessageBox.Show(exception.Message);
        }
        catch (ServerErrorException exception) {
            Console.WriteLine(exception);
            MessageBox.Show(exception.Message);
        }
        catch (Exception exception) {
            Console.WriteLine(exception.StackTrace);
            MessageBox.Show(exception.Message);
            Hide();
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

    private void label5_Click(object sender, EventArgs e) {
    }

    private void label2_Click(object sender, EventArgs e) {
    }
}