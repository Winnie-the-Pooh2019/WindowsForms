using System;
using System.Linq;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Exceptions;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms; 

public partial class BookCreate : Form {
    private readonly PublisherService publisherService;
    private readonly CategoryService categoryService;
    private readonly BookService bookService;

    private readonly UserForm userForm;
    
    public BookCreate(Access access, UserForm userForm) {
        this.userForm = userForm;
        publisherService = new PublisherService("publisher", access.accessToken);
        categoryService = new CategoryService("categories", access.accessToken);
        bookService = new BookService("books", access.accessToken);
        
        InitializeComponent();
    }

    private async void load(object sender, EventArgs ev) {
        try {
            var publishers = (await publisherService.getAll()).Select(p => p.id.ToString()).ToArray();
            var categories = (await categoryService.getAll()).Select(c => c.id.ToString()).ToArray();

            publisher.Items.AddRange(publishers);
            category.Items.AddRange(categories);
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            MessageBox.Show("Exception occured while loading purchases or categories");
        }
    }

    private async void create_Click(object sender, EventArgs ev) {
        if (name.Text == "" || publisher.Text == "" || category.Text == "") {
            MessageBox.Show("Fill all fields");
            return;
        }

        try {
            var book = new Book {
                name = name.Text,
                publisherId = Convert.ToInt32(publisher.SelectedItem.ToString()),
                categoryId = Convert.ToInt32(category.SelectedItem.ToString())
            };

            await bookService.create(book);
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