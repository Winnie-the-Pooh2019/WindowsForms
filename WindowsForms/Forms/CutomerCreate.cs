using System;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Exceptions;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms;

public partial class CutomerCreate : Form {
    private readonly CustomerService customerService;

    private readonly UserForm userForm;

    public CutomerCreate(Access access, UserForm userForm) {
        this.userForm = userForm;
        customerService = new CustomerService("clients", access.accessToken);

        InitializeComponent();
    }

    private void CutomerCreate_Load(object sender, EventArgs e) { }

    private async void create_Click(object sender, EventArgs ev) {
        if (firstName.Text == "" || secondName.Text == "") {
            MessageBox.Show("Fill all fields");
            return;
        }

        try {
            var book = new Customer {
                firstName = firstName.Text,
                lastName = secondName.Text
            };

            await customerService.create(book);
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