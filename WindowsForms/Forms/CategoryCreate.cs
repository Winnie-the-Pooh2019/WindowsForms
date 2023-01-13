using System;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Exceptions;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms;

public partial class CategoryCreate : Form {
    private readonly CategoryService categoryService;

    private readonly UserForm userForm;

    public CategoryCreate(Access access, UserForm userForm) {
        this.userForm = userForm;
        categoryService = new CategoryService("categories", access.accessToken);

        InitializeComponent();
    }

    private void CategoryCreate_Load(object sender, EventArgs e) {
    }

    private async void create_Click(object sender, EventArgs ev) {
        if (name.Text == "") {
            MessageBox.Show("Fill all fields");
            return;
        }

        try {
            var book = new Category { name = name.Text };

            await categoryService.create(book);
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