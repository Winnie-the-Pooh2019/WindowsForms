using System;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Exceptions;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms;

public partial class PublisherCreate : Form {
    private readonly PublisherService publisherService;

    private readonly UserForm userForm;

    public PublisherCreate(Access access, UserForm userForm) {
        this.userForm = userForm;
        publisherService = new PublisherService("publisher", access.accessToken);

        InitializeComponent();
    }

    private async void create_Click(object sender, EventArgs ev) {
        if (name.Text == "") {
            MessageBox.Show("Fill all fields");
            return;
        }

        try {
            var book = new Publisher { name = name.Text };

            await publisherService.create(book);
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