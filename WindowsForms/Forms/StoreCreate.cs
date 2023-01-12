using System;
using System.Linq;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms;

public partial class StoreCreate : Form {
    private readonly BookService bookService;
    private readonly PriceChangeService priceChangeService;
    private readonly StoreService storeService;

    public StoreCreate(Access access) {
        bookService = new BookService("books", access.accessToken);
        priceChangeService = new PriceChangeService("price", access.accessToken);
        storeService = new StoreService("store", access.accessToken);

        InitializeComponent();
    }
    
    private async void load(object sender, EventArgs ev) {
        try {
            var books = (await bookService.getAll()).Select(p => p.id.ToString()).ToArray();
            var prices = (await priceChangeService.getAll()).Select(c => c.id.ToString()).ToArray();
        
            bookCombo.Items.AddRange(books);
            priceCombo.Items.AddRange(prices);
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            MessageBox.Show("Exception occured while loading purchases or categories");
        }
    }

    private async void create_Click(object sender, EventArgs ev) {
        if (count.Text == "" || bookCombo.Text == "" || priceCombo.Text == "") {
            MessageBox.Show("Fill all fields");
            return;
        }

        try {
            var purchaseItem = new Store {
                bookId = Convert.ToInt32(bookCombo.SelectedItem.ToString()),
                booksCount = Convert.ToInt32(count.Text),
                priceChangeId = Convert.ToInt32(priceCombo.SelectedItem.ToString()),
            };

            await storeService.create(purchaseItem);
            Hide();
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            MessageBox.Show(e.Message);
            Hide();
        }
    }
}