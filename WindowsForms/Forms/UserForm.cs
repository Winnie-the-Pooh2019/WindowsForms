using System;
using System.Collections.Generic;
using System.Drawing;
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
    private readonly UserService userService;

    private DateTimePicker datePiker;

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
        userService = new UserService("user", access.accessToken);

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
            var users = await userService.getAll();

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

            usersGrid.Rows.Clear();
            // var roleGrid = new DataGridViewComboBoxColumn();
            // roleGrid.HeaderText = "Role";
            // roleGrid.Items.AddRange("admin", "user");
            // usersGrid.Columns.Add(roleGrid);
            users.ForEach(it => {
                var row = new DataGridViewRow();

                var cellCombo = new DataGridViewComboBoxCell();
                cellCombo.DataSource = new List<string> { "user", "admin" };
                cellCombo.Value = it.role;

                var idt = new DataGridViewTextBoxCell();
                idt.Value = it.id;
                var pt = new DataGridViewTextBoxCell();
                pt.Value = it.password;
                var lt = new DataGridViewTextBoxCell();
                lt.Value = it.login;
                var fnt = new DataGridViewTextBoxCell();
                fnt.Value = it.firstName;
                var lnt = new DataGridViewTextBoxCell();
                lnt.Value = it.lastName;

                row.Cells.AddRange(idt, lt, pt, fnt, lnt, cellCombo);
                usersGrid.Rows.Add(row);
            });

            if (access.role == "user") {
                addMenu.Visible = false;
                tabs.TabPages.Remove(userTab);

                storeGrid.Columns.RemoveAt(3);
                storeGrid.Columns.RemoveAt(3);

                itemsGrid.Columns.RemoveAt(5);
                itemsGrid.Columns.RemoveAt(5);

                purchasesGrid.Columns.RemoveAt(3);
                purchasesGrid.Columns.RemoveAt(3);

                publishersGrid.Columns.RemoveAt(2);
                publishersGrid.Columns.RemoveAt(2);

                pricesGrid.Columns.RemoveAt(3);
                pricesGrid.Columns.RemoveAt(3);

                deliveriesGrid.Columns.RemoveAt(5);
                deliveriesGrid.Columns.RemoveAt(5);

                customersGrid.Columns.RemoveAt(3);
                customersGrid.Columns.RemoveAt(3);

                categoriesGrid.Columns.RemoveAt(2);
                categoriesGrid.Columns.RemoveAt(2);

                booksGrid.Columns.RemoveAt(4);
                booksGrid.Columns.RemoveAt(4);
            }
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
        }
        catch (UnauthorizedException exception) {
            Console.WriteLine(exception.StackTrace);
            MessageBox.Show(exception.Message);
            
            var authForm = new AuthForm();
            authForm.Show();
            Close();
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
        try {
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
        catch (Exception exception) {
            Console.WriteLine(exception.StackTrace);
            MessageBox.Show(exception.Message);
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
        if (e.RowIndex > -1 && e.ColumnIndex == 2) {
            datePiker = new DateTimePicker();
            deliveriesGrid.Controls.Add(datePiker);
            datePiker.Format = DateTimePickerFormat.Short;
            var rec = deliveriesGrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            datePiker.Size = new Size(rec.Width, rec.Height);
            datePiker.Location = new Point(rec.X, rec.Y);
            datePiker.TextChanged += pikerDeliveryChanged;
            // datePiker.CloseUp += pickerClosed;
            datePiker.Visible = true;
        }

        if (e.RowIndex > -1 && e.ColumnIndex == 5) {
            var delivery = new Delivery {
                id = Convert.ToInt32(deliveriesGrid.Rows[e.RowIndex].Cells[0].Value),
                bookId = Convert.ToInt32(deliveriesGrid.Rows[e.RowIndex].Cells[1].Value),
                booksCount = Convert.ToInt32(deliveriesGrid.Rows[e.RowIndex].Cells[3].Value),
                deliveryDate = Convert.ToDateTime(deliveriesGrid.Rows[e.RowIndex].Cells[2].Value),
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
                booksCount = Convert.ToInt32(deliveriesGrid.Rows[e.RowIndex].Cells[3].Value),
                deliveryDate = Convert.ToDateTime(deliveriesGrid.Rows[e.RowIndex].Cells[2].Value),
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
        if (e.RowIndex > -1 && e.ColumnIndex == 2) {
            datePiker = new DateTimePicker();
            purchasesGrid.Controls.Add(datePiker);
            datePiker.Format = DateTimePickerFormat.Short;
            var rec = purchasesGrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            datePiker.Size = new Size(rec.Width, rec.Height);
            datePiker.Location = new Point(rec.X, rec.Y);
            datePiker.TextChanged += pickerPurchaseChanged;
            // datePiker.CloseUp += pickerClosed;
            datePiker.Visible = true;
        }

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

    private void pickerClosed(object sender, EventArgs e) {
        datePiker.Visible = false;
    }

    private void pickerPurchaseChanged(object sender, EventArgs e) {
        purchasesGrid.CurrentCell.Value = datePiker.Text;
    }

    private void pikerDeliveryChanged(object sender, EventArgs e) {
        deliveriesGrid.CurrentCell.Value = datePiker.Text;
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

    private async void usersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        if (e.RowIndex > -1 && e.ColumnIndex == 6) {
            var user = new User {
                id = Convert.ToInt32(usersGrid.Rows[e.RowIndex].Cells[0].Value),
                login = usersGrid.Rows[e.RowIndex].Cells[1].Value.ToString(),
                password = usersGrid.Rows[e.RowIndex].Cells[2].Value.ToString(),
                firstName = usersGrid.Rows[e.RowIndex].Cells[3].Value.ToString(),
                lastName = usersGrid.Rows[e.RowIndex].Cells[4].Value.ToString(),
                role = usersGrid.Rows[e.RowIndex].Cells[5].Value.ToString()
            };

            var result = MessageBox.Show($"Вы действительно хотите удалить данные пользователя {user.login}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                await userService.deleteById(user.id);
                load();
            }
        }

        if (e.RowIndex > -1 && e.ColumnIndex == 7) {
            var user = new User {
                id = Convert.ToInt32(usersGrid.Rows[e.RowIndex].Cells[0].Value),
                login = usersGrid.Rows[e.RowIndex].Cells[1].Value.ToString(),
                password = usersGrid.Rows[e.RowIndex].Cells[2].Value.ToString(),
                firstName = usersGrid.Rows[e.RowIndex].Cells[3].Value.ToString(),
                lastName = usersGrid.Rows[e.RowIndex].Cells[4].Value.ToString(),
                role = usersGrid.Rows[e.RowIndex].Cells[5].Value.ToString()
            };

            var result = MessageBox.Show($"Вы действительно хотите изменить данные пользователя {user.login}?",
                "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                await userService.update(user);
        }
    }

    private void bookCreateMenu_Click(object sender, EventArgs e) {
        var createBook = new BookCreate(access, this);
        createBook.ShowDialog();
        load();
    }

    private void categoryCreateMenu_Click(object sender, EventArgs e) {
        var createBook = new CategoryCreate(access, this);
        createBook.ShowDialog();
        load();
    }

    private void publisherCreateMenu_Click(object sender, EventArgs e) {
        var createBook = new PublisherCreate(access, this);
        createBook.ShowDialog();
        load();
    }

    private void customerToolStripMenuItem_Click(object sender, EventArgs e) {
        var createBook = new CutomerCreate(access, this);
        createBook.ShowDialog();
        load();
    }

    private void deliveryCreateMenu_Click(object sender, EventArgs e) {
        var createBook = new DeliveryCreate(access, this);
        createBook.ShowDialog();
        load();
    }

    private void priceCreateMenu_Click(object sender, EventArgs e) {
        var createBook = new PriceCreate(access, this);
        createBook.ShowDialog();
        load();
    }

    private void purchaseCreateMenu_Click(object sender, EventArgs e) {
        var createBook = new PurchaseCreate(access, this);
        createBook.ShowDialog();
        load();
    }

    private void itemCreateMenu_Click(object sender, EventArgs e) {
        var createBook = new PurchaseItemCreate(access, this);
        createBook.ShowDialog();
        load();
    }

    private void storeCreateMenu_Click(object sender, EventArgs e) {
        var createBook = new StoreCreate(access, this);
        createBook.ShowDialog();
        load();
    }

    private void userCreateMenu_Click(object sender, EventArgs e) {
        var createBook = new UserCreate(access, this);
        createBook.ShowDialog();
        load();
    }

    private void exit_Click(object sender, EventArgs e) {
        var authorizationForm = new AuthForm();
        if (MessageBox.Show("Are you sure you want to exit", "", MessageBoxButtons.YesNo) !=
            DialogResult.Yes) return;
        Close();
        authorizationForm.Show();
    }
}