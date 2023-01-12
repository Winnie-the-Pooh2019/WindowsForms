using System;
using System.Security.AccessControl;
using System.Threading.Tasks;
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

    private async void load() {
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
            MessageBox.Show(exception.Message);
        }
        catch (Exception exception) {
            Console.WriteLine(exception.StackTrace);
            MessageBox.Show(exception.StackTrace);
        }
    }

    private async void loadData(object sender, EventArgs e) {
        load();
    }

    private async void booksGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex > -1 && e.ColumnIndex == 4) {
            var book = new Book() {
                id = Convert.ToInt32(booksGrid.Rows[e.RowIndex].Cells[0].Value),
                categoryId = Convert.ToInt32(booksGrid.Rows[e.RowIndex].Cells[3].Value),
                name = booksGrid.Rows[e.RowIndex].Cells[1].Value.ToString(),
                publisherId = Convert.ToInt32(booksGrid.Rows[e.RowIndex].Cells[2].Value),
            };

            var result = MessageBox.Show($"Вы действительно хотите книгу: {book.name}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                await bookService.deleteById(book.id);
                load();
            }
        }

        if (e.RowIndex > -1 && e.ColumnIndex == 5) {
            var book = new Book() {
                id = Convert.ToInt32(booksGrid.Rows[e.RowIndex].Cells[0].Value),
                categoryId = Convert.ToInt32(booksGrid.Rows[e.RowIndex].Cells[3].Value),
                name = booksGrid.Rows[e.RowIndex].Cells[1].Value.ToString(),
                publisherId = Convert.ToInt32(booksGrid.Rows[e.RowIndex].Cells[2].Value),
            };

            var result = MessageBox.Show($"Вы уверены, что хотите перезаписать книгу: {book.name}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                await bookService.update(book);
        }
    }

    private async void categoriesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex > -1 && e.ColumnIndex == 2) {
            var category = new Category() {
                id = Convert.ToInt32(categoriesGrid.Rows[e.RowIndex].Cells[0].Value),
                name = categoriesGrid.Rows[e.RowIndex].Cells[1].Value.ToString()
            };

            var result = MessageBox.Show($"Вы действительно хотите категорию: {category.name}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                await categoryService.deleteById(category.id);
                load();
            }
        }

        if (e.RowIndex > -1 && e.ColumnIndex == 3) {
            var category = new Category() {
                id = Convert.ToInt32(categoriesGrid.Rows[e.RowIndex].Cells[0].Value),
                name = categoriesGrid.Rows[e.RowIndex].Cells[1].Value.ToString()
            };

            var result = MessageBox.Show($"Вы уверены, что хотите перезаписать категорию: {category.name}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                await categoryService.update(category);
        }
    }

    private async void customersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex > -1 && e.ColumnIndex == 3) {
            var customer = new Customer {
                id = Convert.ToInt32(customersGrid.Rows[e.RowIndex].Cells[0].Value),
                firstName = customersGrid.Rows[e.RowIndex].Cells[1].Value.ToString(),
                lastName = customersGrid.Rows[e.RowIndex].Cells[2].Value.ToString()
            };

            var result = MessageBox.Show(
                $"Вы действительно хотите покупателя: {customer.firstName} {customer.lastName}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                await customerService.deleteById(customer.id);
                load();
            }
        }

        if (e.RowIndex > -1 && e.ColumnIndex == 4) {
            var customer = new Customer {
                id = Convert.ToInt32(customersGrid.Rows[e.RowIndex].Cells[0].Value),
                firstName = customersGrid.Rows[e.RowIndex].Cells[1].Value.ToString(),
                lastName = customersGrid.Rows[e.RowIndex].Cells[2].Value.ToString()
            };

            var result = MessageBox.Show(
                $"Вы действительно перезаписать покупателя: {customer.firstName} {customer.lastName}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                await customerService.update(customer);
        }
    }

    private async void deliveriesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex > -1 && e.ColumnIndex == 5) {
            var delivery = new Delivery {
                id = Convert.ToInt32(deliveriesGrid.Rows[e.RowIndex].Cells[0].Value),
                bookId = Convert.ToInt32(deliveriesGrid.Rows[e.RowIndex].Cells[1].Value),
                booksCount = Convert.ToInt32(deliveriesGrid.Rows[e.RowIndex].Cells[2].Value),
                deliveryDate = Convert.ToDateTime(deliveriesGrid.Rows[e.RowIndex].Cells[3].Value),
                price = Convert.ToDouble(deliveriesGrid.Rows[e.RowIndex].Cells[4].Value)
            };

            var result = MessageBox.Show($"Вы действительно хотите поставку №: {delivery.id}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                await deliveryService.deleteById(delivery.id);
                load();
            }
        }

        if (e.RowIndex > -1 && e.ColumnIndex == 6) {
            var delivery = new Delivery {
                id = Convert.ToInt32(deliveriesGrid.Rows[e.RowIndex].Cells[0].Value),
                bookId = Convert.ToInt32(deliveriesGrid.Rows[e.RowIndex].Cells[1].Value),
                booksCount = Convert.ToInt32(deliveriesGrid.Rows[e.RowIndex].Cells[2].Value),
                deliveryDate = Convert.ToDateTime(deliveriesGrid.Rows[e.RowIndex].Cells[3].Value),
                price = Convert.ToDouble(deliveriesGrid.Rows[e.RowIndex].Cells[4].Value)
            };

            var result = MessageBox.Show($"Вы действительно хотите перезаписать поставку №: {delivery.id}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                await deliveryService.update(delivery);
        }
    }

    private async void pricesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex > -1 && e.ColumnIndex == 3) {
            var price = new PriceChange {
                id = Convert.ToInt32(pricesGrid.Rows[e.RowIndex].Cells[0].Value),
                newPrice = Convert.ToDouble(pricesGrid.Rows[e.RowIndex].Cells[2].Value),
                priceChanged = Convert.ToDateTime(pricesGrid.Rows[e.RowIndex].Cells[1].Value)
            };

            var result = MessageBox.Show($"Вы действительно хотите удалить цену: {price.id}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                await priceChangeService.deleteById(price.id);
                load();
            }
        }

        if (e.RowIndex > -1 && e.ColumnIndex == 4) {
            var price = new PriceChange {
                id = Convert.ToInt32(pricesGrid.Rows[e.RowIndex].Cells[0].Value),
                newPrice = Convert.ToDouble(pricesGrid.Rows[e.RowIndex].Cells[2].Value),
                priceChanged = Convert.ToDateTime(pricesGrid.Rows[e.RowIndex].Cells[1].Value)
            };

            var result = MessageBox.Show($"Вы действительно хотите перезаписать цену: {price.id}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                await priceChangeService.update(price);
        }
    }

    private async void publishersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex > -1 && e.ColumnIndex == 2) {
            var publisher = new Publisher {
                id = Convert.ToInt32(publishersGrid.Rows[e.RowIndex].Cells[0].Value),
                name = publishersGrid.Rows[e.RowIndex].Cells[1].Value.ToString()
            };

            var result = MessageBox.Show($"Вы действительно хотите удалить издателя: {publisher.name}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                await publisherService.deleteById(publisher.id);
                load();
            }
        }

        if (e.RowIndex > -1 && e.ColumnIndex == 3) {
            var publisher = new Publisher {
                id = Convert.ToInt32(publishersGrid.Rows[e.RowIndex].Cells[0].Value),
                name = publishersGrid.Rows[e.RowIndex].Cells[1].Value.ToString()
            };

            var result = MessageBox.Show($"Вы уверены, что хотите перезаписать издателя: {publisher.name}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                await publisherService.update(publisher);
        }
    }

    private async void purchasesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex > -1 && e.ColumnIndex == 3) {
            var purchase = new Purchase {
                id = Convert.ToInt32(purchasesGrid.Rows[e.RowIndex].Cells[0].Value),
                customerId = Convert.ToInt32(purchasesGrid.Rows[e.RowIndex].Cells[1].Value),
                purchaseDate = Convert.ToDateTime(purchasesGrid.Rows[e.RowIndex].Cells[2].Value)
            };

            var result = MessageBox.Show($"Вы действительно хотите удалить покупку: {purchase.id}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                await purchaseService.deleteById(purchase.id);
                load();
            }
        }

        if (e.RowIndex > -1 && e.ColumnIndex == 4) {
            var purchase = new Purchase {
                id = Convert.ToInt32(purchasesGrid.Rows[e.RowIndex].Cells[0].Value),
                customerId = Convert.ToInt32(purchasesGrid.Rows[e.RowIndex].Cells[1].Value),
                purchaseDate = Convert.ToDateTime(purchasesGrid.Rows[e.RowIndex].Cells[2].Value)
            };

            var result = MessageBox.Show($"Вы действительно хотите перезаписать покупку: {purchase.id}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                await purchaseService.update(purchase);
        }
    }

    private async void itemsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex > -1 && e.ColumnIndex == 5) {
            var item = new PurchaseItem {
                id = Convert.ToInt32(itemsGrid.Rows[e.RowIndex].Cells[0].Value),
                bookId = Convert.ToInt32(itemsGrid.Rows[e.RowIndex].Cells[2].Value),
                booksCount = Convert.ToInt32(itemsGrid.Rows[e.RowIndex].Cells[3].Value),
                purchaseId = Convert.ToInt32(itemsGrid.Rows[e.RowIndex].Cells[1].Value),
                priceId = Convert.ToInt32(itemsGrid.Rows[e.RowIndex].Cells[4].Value)
            };

            var result = MessageBox.Show($"Вы действительно хотите удалить данные о покупке?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                await purchaseItemService.deleteById(item.id);
                load();
            }
        }

        if (e.RowIndex > -1 && e.ColumnIndex == 6) {
            var item = new PurchaseItem {
                id = Convert.ToInt32(itemsGrid.Rows[e.RowIndex].Cells[0].Value),
                bookId = Convert.ToInt32(itemsGrid.Rows[e.RowIndex].Cells[2].Value),
                booksCount = Convert.ToInt32(itemsGrid.Rows[e.RowIndex].Cells[3].Value),
                purchaseId = Convert.ToInt32(itemsGrid.Rows[e.RowIndex].Cells[1].Value),
                priceId = Convert.ToInt32(itemsGrid.Rows[e.RowIndex].Cells[4].Value)
            };

            var result = MessageBox.Show($"Вы действительно хотите удалить данные о покупке?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                await purchaseItemService.update(item);
        }
    }

    private async void storeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex > -1 && e.ColumnIndex == 3) {
            var store = new Store {
                bookId = Convert.ToInt32(storeGrid.Rows[e.RowIndex].Cells[0].Value),
                booksCount = Convert.ToInt32(storeGrid.Rows[e.RowIndex].Cells[1].Value),
                priceChangeId = Convert.ToInt32(storeGrid.Rows[e.RowIndex].Cells[2].Value),
            };

            var result = MessageBox.Show($"Вы действительно хотите удалить данные о книге?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                await storeService.deleteById(store.bookId);
                load();
            }
        }

        if (e.RowIndex > -1 && e.ColumnIndex == 4) {
            var store = new Store {
                bookId = Convert.ToInt32(storeGrid.Rows[e.RowIndex].Cells[0].Value),
                booksCount = Convert.ToInt32(storeGrid.Rows[e.RowIndex].Cells[1].Value),
                priceChangeId = Convert.ToInt32(storeGrid.Rows[e.RowIndex].Cells[2].Value),
            };

            var result = MessageBox.Show($"Вы действительно хотите изменить данные о книге?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                await storeService.update(store);
                load();
            }
        }
    }
}