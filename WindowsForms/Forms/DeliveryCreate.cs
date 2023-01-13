using System;
using System.Linq;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Exceptions;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms;

public partial class DeliveryCreate : Form {
    private readonly DeliveryService deliveryService;
    private readonly BookService bookService;

    private readonly UserForm userForm;

    public DeliveryCreate(Access access, UserForm userForm) {
        this.userForm = userForm;
        deliveryService = new DeliveryService("delivery", access.accessToken);
        bookService = new BookService("books", access.accessToken);

        InitializeComponent();
    }
    
    private async void load(object sender, EventArgs ev) {
        try {
            var books = (await bookService.getAll()).Select(p => p.id.ToString()).ToArray();

            bookCombo.Items.AddRange(books);
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

    private async void create_Click(object sender, EventArgs ev) {
        if (bookCombo.Text == "" || booksCount.Text == "" || price.Text == "") {
            MessageBox.Show("Fill all fields");
            return;
        }

        try {
            var delivery = new Delivery {
                bookId = Convert.ToInt32(bookCombo.SelectedItem.ToString()),
                booksCount = Convert.ToInt32(booksCount.Text),
                price = Convert.ToDouble(price.Text),
                deliveryDate = deliveryPiker.Value
            };

            await deliveryService.create(delivery);
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