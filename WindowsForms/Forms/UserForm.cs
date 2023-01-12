using System;
using System.Security.AccessControl;
using System.Web.ModelBinding;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Exceptions;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms;

public partial class UserForm : Form {
    private Access access;
    private readonly BookService bookService;
    private readonly CategoryService categoryService;
    private readonly CustomerService customerService;
    private readonly DeliveryService deliveryService;
    private readonly PriceChangeService priceChangeService;
    private readonly PublisherService publisherService;
    private readonly PurchaseService purchaseService;
    private readonly PurchaseItemService purchaseItemService;
    private readonly StoreService storeService;

    // public UserForm() {
    //     InitializeComponent();
    // }

    public UserForm(Access access) {
        this.access = access;
        bookService = new BookService("books", access.accessToken);
        categoryService = new CategoryService("categories", access.accessToken);
        customerService = new CustomerService("clients", access.accessToken);
        deliveryService = new DeliveryService("delivery", access.accessToken);
        priceChangeService = new PriceChangeService("price", access.accessToken);
        publisherService = new PublisherService("publisher", access.accessToken);
        purchaseService = new PurchaseService("purchase", access.accessToken);
        purchaseItemService = new PurchaseItemService("purchaseItem", access.accessToken);
        storeService = new StoreService("store", access.accessToken);

        InitializeComponent();
    }

    private async void loadData(object sender, EventArgs e) {
        try {
            var books = await bookService.getAll();
            var categories = await categoryService.getAll();
            var customers = await customerService.getAll();
            var deliveries = await deliveryService.getAll();
            var prices = await priceChangeService.getAll();
            var publishers = await publisherService.getAll();
            var purchases = await purchaseService.getAll();
            var items = await purchaseItemService.getAll();
            var stores = await storeService.getAll();

            booksGrid.Rows.Clear();
            books.ForEach(book => booksGrid.Rows.Add(book.id, book.name, book.publisherId, book.categoryId));

            categoriesGrid.Rows.Clear();
            categories.ForEach(category => categoriesGrid.Rows.Add(category.id, category.name));

            customersGrid.Rows.Clear();
            customers.ForEach(customer => customersGrid.Rows.Add(customer.id, 
                customer.firstName, 
                customer.lastName));

            deliveriesGrid.Rows.Clear();
            deliveries.ForEach(
                it => deliveriesGrid.Rows.Add(it.id, it.bookId, it.deliveryDate, it.booksCount, it.price));

            pricesGrid.Rows.Clear();
            prices.ForEach(it => pricesGrid.Rows.Add(it.id, it.priceChanged, it.newPrice));

            publishersGrid.Rows.Clear();
            publishers.ForEach(it => publishersGrid.Rows.Add(it.id, it.name));

            purchasesGrid.Rows.Clear();
            purchases.ForEach(it => purchasesGrid.Rows.Add(it.id, it.customerId, it.purchaseDate));

            itemsGrid.Rows.Clear();
            items.ForEach(it => itemsGrid.Rows.Add(it.id, it.purchaseId, it.bookId, it.booksCount, it.priceId));
            
            storeGrid.Rows.Clear();
            stores.ForEach(it => storeGrid.Rows.Add(it.bookId, it.booksCount, it.priceChangeId));
        }
        catch (NothingFoundException exception) {
            Console.WriteLine(exception);
            MessageBox.Show("Nothing found");
        }
        catch (Exception exception) {
            Console.WriteLine(exception.StackTrace);
            MessageBox.Show(exception.StackTrace);
        }
    }
}