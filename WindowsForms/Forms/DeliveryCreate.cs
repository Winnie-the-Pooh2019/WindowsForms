using System;
using System.Linq;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms;

public partial class DeliveryCreate : Form {
    private readonly DeliveryService deliveryService;
    private readonly BookService bookService;

    public DeliveryCreate(Access access) {
        deliveryService = new DeliveryService("delivery", access.accessToken);
        bookService = new BookService("books", access.accessToken);

        InitializeComponent();
    }
    
    private async void load(object sender, EventArgs ev) {
        try {
            var books = (await bookService.getAll()).Select(p => p.id.ToString()).ToArray();

            bookCombo.Items.AddRange(books);
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            MessageBox.Show("Exception occured while loading purchases or categories");
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
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            MessageBox.Show(e.Message);
            Hide();
        }
    }
}