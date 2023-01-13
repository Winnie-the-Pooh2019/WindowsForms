using System;
using System.Linq;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Exceptions;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms;

public partial class PurchaseItemCreate : Form {
    private readonly PurchaseItemService purchaseItemService;
    private readonly PurchaseService purchaseService;
    private readonly BookService bookService;
    private readonly PriceChangeService priceChangeService;

    private readonly UserForm userForm;

    public PurchaseItemCreate(Access access, UserForm userForm) {
        this.userForm = userForm;
        purchaseItemService = new PurchaseItemService("purchaseItem", access.accessToken);
        purchaseService = new PurchaseService("purchase", access.accessToken);
        bookService = new BookService("books", access.accessToken);
        priceChangeService = new PriceChangeService("price", access.accessToken);

        InitializeComponent();
    }

    private async void load(object sender, EventArgs ev) {
        try {
            var books = (await bookService.getAll()).Select(p => p.id.ToString()).ToArray();
            var prices = (await priceChangeService.getAll()).Select(c => c.id.ToString()).ToArray();
            var purchases = (await purchaseService.getAll()).Select(c => c.id.ToString()).ToArray();
        
            bookCombo.Items.AddRange(books);
            purchaseCombo.Items.AddRange(purchases);
            priceCombo.Items.AddRange(prices);
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
        if (count.Text == "" || bookCombo.Text == "" || purchaseCombo.Text == "" || priceCombo.Text == "") {
            MessageBox.Show("Fill all fields");
            return;
        }

        try {
            var purchaseItem = new PurchaseItem {
                bookId = Convert.ToInt32(bookCombo.SelectedItem.ToString()),
                booksCount = Convert.ToInt32(count.Text),
                priceId = Convert.ToInt32(priceCombo.SelectedItem.ToString()),
                purchaseId = Convert.ToInt32(purchaseCombo.Text)
            };

            await purchaseItemService.create(purchaseItem);
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