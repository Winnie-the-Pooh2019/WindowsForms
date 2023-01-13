using System;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Exceptions;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms;

public partial class UserCreate : Form {
    private readonly UserForm userForm;
    private readonly UserService userService;

    public UserCreate(Access access, UserForm userForm) {
        this.userForm = userForm;
        userService = new UserService("user", access.accessToken);

        InitializeComponent();
    }

    private async void create_Click(object sender, EventArgs ev) {
        if (login.Text == "" || firstName.Text == "" || secondName.Text == "" || password.Text == "" ||
            role.Text == "") {
            MessageBox.Show("Fill all fields");
            return;
        }

        try {
            var user = new User {
                login = login.Text,
                firstName = firstName.Text,
                lastName = secondName.Text,
                password = password.Text,
                role = role.SelectedItem.ToString()
            };

            await userService.create(user);
            Hide();
        }
        catch (NothingFoundException exception) {
            Console.WriteLine(exception);
            MessageBox.Show(exception.Message);
        }
        catch (ServerErrorException exception) {
            Console.WriteLine(exception);
            MessageBox.Show(exception.Message);
        }
        catch (TokenExpiredException exception) {
            Console.WriteLine(exception.StackTrace);
            MessageBox.Show(exception.Message);

            var authForm = new AuthForm();
            authForm.Show();
            Close();
            userForm.Close();
        }
        catch (UnauthorizedException exception) {
            Console.WriteLine(exception.StackTrace);
            MessageBox.Show(exception.Message);
            
            var authForm = new AuthForm();
            authForm.Show();
            Close();
            userForm.Close();
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            MessageBox.Show(e.Message);
            Hide();
        }
    }
}