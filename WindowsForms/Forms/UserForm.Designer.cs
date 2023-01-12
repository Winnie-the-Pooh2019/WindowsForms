using System.ComponentModel;

namespace WindowsForms.Forms; 

partial class UserForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

#region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.exit = new System.Windows.Forms.ToolStripMenuItem();
        this.добавлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.добавлениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.bookCreateMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.categoryCreateMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.customerCreateMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.deliveryCreateMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.priceCreateMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.publisherCreateMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.purchaseCreateMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.itemCreateMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.storeCreateMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.userCreateMenu = new System.Windows.Forms.ToolStripMenuItem();
        this.tabs = new System.Windows.Forms.TabControl();
        this.bookTab = new System.Windows.Forms.TabPage();
        this.booksGrid = new System.Windows.Forms.DataGridView();
        this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.publisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deleteBook = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editBook = new System.Windows.Forms.DataGridViewButtonColumn();
        this.categoryTab = new System.Windows.Forms.TabPage();
        this.categoriesGrid = new System.Windows.Forms.DataGridView();
        this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.nameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.delelteCategory = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editCategory = new System.Windows.Forms.DataGridViewButtonColumn();
        this.customerTab = new System.Windows.Forms.TabPage();
        this.customersGrid = new System.Windows.Forms.DataGridView();
        this.idCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.firstNameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.lastNameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deleteCustomer = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editCustomer = new System.Windows.Forms.DataGridViewButtonColumn();
        this.deliveryTab = new System.Windows.Forms.TabPage();
        this.deliveriesGrid = new System.Windows.Forms.DataGridView();
        this.idDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.bookIdDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dateDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.booksCountDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.priceDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deleteDelivery = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editDelivery = new System.Windows.Forms.DataGridViewButtonColumn();
        this.priceTab = new System.Windows.Forms.TabPage();
        this.pricesGrid = new System.Windows.Forms.DataGridView();
        this.idPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.datePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.pricePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deletePrice = new System.Windows.Forms.DataGridViewButtonColumn();
        this.eidtPrice = new System.Windows.Forms.DataGridViewButtonColumn();
        this.publisherTab = new System.Windows.Forms.TabPage();
        this.publishersGrid = new System.Windows.Forms.DataGridView();
        this.idPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.namePublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deletePublisher = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editPublisher = new System.Windows.Forms.DataGridViewButtonColumn();
        this.purchaseTab = new System.Windows.Forms.TabPage();
        this.purchasesGrid = new System.Windows.Forms.DataGridView();
        this.idPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.customerSurnamePurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.datePurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deletePuchase = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editPurchase = new System.Windows.Forms.DataGridViewButtonColumn();
        this.itemTab = new System.Windows.Forms.TabPage();
        this.itemsGrid = new System.Windows.Forms.DataGridView();
        this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.purchaseIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.bookIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.booksCountItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.priceIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deleteItem = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editItem = new System.Windows.Forms.DataGridViewButtonColumn();
        this.storeTab = new System.Windows.Forms.TabPage();
        this.storeGrid = new System.Windows.Forms.DataGridView();
        this.bookIdStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.booksCountStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.priceStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deleteStore = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editStore = new System.Windows.Forms.DataGridViewButtonColumn();
        this.userTab = new System.Windows.Forms.TabPage();
        this.usersGrid = new System.Windows.Forms.DataGridView();
        this.idUsers = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.loginUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.passwordUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.firstNameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.lastNameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.roleUser = new System.Windows.Forms.DataGridViewComboBoxColumn();
        this.deleteUser = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editUser = new System.Windows.Forms.DataGridViewButtonColumn();
        this.menuStrip1.SuspendLayout();
        this.tabs.SuspendLayout();
        this.bookTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
        this.categoryTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.categoriesGrid)).BeginInit();
        this.customerTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
        this.deliveryTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.deliveriesGrid)).BeginInit();
        this.priceTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pricesGrid)).BeginInit();
        this.publisherTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.publishersGrid)).BeginInit();
        this.purchaseTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.purchasesGrid)).BeginInit();
        this.itemTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
        this.storeTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.storeGrid)).BeginInit();
        this.userTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
        this.SuspendLayout();
        // 
        // menuStrip1
        // 
        this.menuStrip1.BackColor = System.Drawing.Color.White;
        this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.менюToolStripMenuItem, this.добавлениеToolStripMenuItem, this.добавлениеToolStripMenuItem1 });
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(800, 24);
        this.menuStrip1.TabIndex = 4;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // менюToolStripMenuItem
        // 
        this.менюToolStripMenuItem.BackColor = System.Drawing.Color.White;
        this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.exit });
        this.менюToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.менюToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
        this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
        this.менюToolStripMenuItem.Text = "Menu";
        // 
        // exit
        // 
        this.exit.BackColor = System.Drawing.Color.White;
        this.exit.ForeColor = System.Drawing.Color.Black;
        this.exit.Name = "exit";
        this.exit.Size = new System.Drawing.Size(97, 22);
        this.exit.Text = "Exit";
        // 
        // добавлениеToolStripMenuItem
        // 
        this.добавлениеToolStripMenuItem.Name = "добавлениеToolStripMenuItem";
        this.добавлениеToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
        // 
        // добавлениеToolStripMenuItem1
        // 
        this.добавлениеToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.bookCreateMenu, this.categoryCreateMenu, this.customerCreateMenu, this.deliveryCreateMenu, this.priceCreateMenu, this.publisherCreateMenu, this.purchaseCreateMenu, this.itemCreateMenu, this.storeCreateMenu, this.userCreateMenu });
        this.добавлениеToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.добавлениеToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
        this.добавлениеToolStripMenuItem1.Name = "добавлениеToolStripMenuItem1";
        this.добавлениеToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
        this.добавлениеToolStripMenuItem1.Text = "Add";
        // 
        // bookCreateMenu
        // 
        this.bookCreateMenu.Name = "bookCreateMenu";
        this.bookCreateMenu.Size = new System.Drawing.Size(161, 22);
        this.bookCreateMenu.Text = "Book";
        this.bookCreateMenu.Click += new System.EventHandler(this.bookCreateMenu_Click);
        // 
        // categoryCreateMenu
        // 
        this.categoryCreateMenu.Name = "categoryCreateMenu";
        this.categoryCreateMenu.Size = new System.Drawing.Size(161, 22);
        this.categoryCreateMenu.Text = "Category";
        this.categoryCreateMenu.Click += new System.EventHandler(this.categoryCreateMenu_Click);
        // 
        // customerCreateMenu
        // 
        this.customerCreateMenu.Name = "customerCreateMenu";
        this.customerCreateMenu.Size = new System.Drawing.Size(161, 22);
        this.customerCreateMenu.Text = "Customer";
        this.customerCreateMenu.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
        // 
        // deliveryCreateMenu
        // 
        this.deliveryCreateMenu.Name = "deliveryCreateMenu";
        this.deliveryCreateMenu.Size = new System.Drawing.Size(161, 22);
        this.deliveryCreateMenu.Text = "Delivery";
        this.deliveryCreateMenu.Click += new System.EventHandler(this.deliveryCreateMenu_Click);
        // 
        // priceCreateMenu
        // 
        this.priceCreateMenu.Name = "priceCreateMenu";
        this.priceCreateMenu.Size = new System.Drawing.Size(161, 22);
        this.priceCreateMenu.Text = "Price";
        // 
        // publisherCreateMenu
        // 
        this.publisherCreateMenu.Name = "publisherCreateMenu";
        this.publisherCreateMenu.Size = new System.Drawing.Size(161, 22);
        this.publisherCreateMenu.Text = "Publisher";
        this.publisherCreateMenu.Click += new System.EventHandler(this.publisherCreateMenu_Click);
        // 
        // purchaseCreateMenu
        // 
        this.purchaseCreateMenu.Name = "purchaseCreateMenu";
        this.purchaseCreateMenu.Size = new System.Drawing.Size(161, 22);
        this.purchaseCreateMenu.Text = "Purchase";
        // 
        // itemCreateMenu
        // 
        this.itemCreateMenu.Name = "itemCreateMenu";
        this.itemCreateMenu.Size = new System.Drawing.Size(161, 22);
        this.itemCreateMenu.Text = "Purchase item";
        // 
        // storeCreateMenu
        // 
        this.storeCreateMenu.Name = "storeCreateMenu";
        this.storeCreateMenu.Size = new System.Drawing.Size(161, 22);
        this.storeCreateMenu.Text = "Store";
        // 
        // userCreateMenu
        // 
        this.userCreateMenu.Name = "userCreateMenu";
        this.userCreateMenu.Size = new System.Drawing.Size(161, 22);
        this.userCreateMenu.Text = "User";
        // 
        // tabs
        // 
        this.tabs.Controls.Add(this.bookTab);
        this.tabs.Controls.Add(this.categoryTab);
        this.tabs.Controls.Add(this.customerTab);
        this.tabs.Controls.Add(this.deliveryTab);
        this.tabs.Controls.Add(this.priceTab);
        this.tabs.Controls.Add(this.publisherTab);
        this.tabs.Controls.Add(this.purchaseTab);
        this.tabs.Controls.Add(this.itemTab);
        this.tabs.Controls.Add(this.storeTab);
        this.tabs.Controls.Add(this.userTab);
        this.tabs.Location = new System.Drawing.Point(2, 147);
        this.tabs.Name = "tabs";
        this.tabs.SelectedIndex = 0;
        this.tabs.Size = new System.Drawing.Size(797, 304);
        this.tabs.TabIndex = 5;
        // 
        // bookTab
        // 
        this.bookTab.Controls.Add(this.booksGrid);
        this.bookTab.Location = new System.Drawing.Point(4, 22);
        this.bookTab.Name = "bookTab";
        this.bookTab.Padding = new System.Windows.Forms.Padding(3);
        this.bookTab.Size = new System.Drawing.Size(789, 278);
        this.bookTab.TabIndex = 0;
        this.bookTab.Text = "Books";
        this.bookTab.UseVisualStyleBackColor = true;
        // 
        // booksGrid
        // 
        this.booksGrid.AllowUserToAddRows = false;
        this.booksGrid.AllowUserToDeleteRows = false;
        this.booksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.booksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.id, this.name, this.publisherName, this.categoryName, this.deleteBook, this.editBook });
        this.booksGrid.Location = new System.Drawing.Point(1, 0);
        this.booksGrid.Name = "booksGrid";
        this.booksGrid.Size = new System.Drawing.Size(787, 277);
        this.booksGrid.TabIndex = 0;
        this.booksGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksGrid_CellContentClick);
        // 
        // id
        // 
        this.id.HeaderText = "Id";
        this.id.Name = "id";
        // 
        // name
        // 
        this.name.HeaderText = "Name";
        this.name.Name = "name";
        // 
        // publisherName
        // 
        this.publisherName.HeaderText = "Publisher name";
        this.publisherName.Name = "publisherName";
        // 
        // categoryName
        // 
        this.categoryName.HeaderText = "Category name";
        this.categoryName.Name = "categoryName";
        // 
        // deleteBook
        // 
        this.deleteBook.HeaderText = "Delete";
        this.deleteBook.Name = "deleteBook";
        // 
        // editBook
        // 
        this.editBook.HeaderText = "Edit";
        this.editBook.Name = "editBook";
        // 
        // categoryTab
        // 
        this.categoryTab.Controls.Add(this.categoriesGrid);
        this.categoryTab.Location = new System.Drawing.Point(4, 22);
        this.categoryTab.Name = "categoryTab";
        this.categoryTab.Padding = new System.Windows.Forms.Padding(3);
        this.categoryTab.Size = new System.Drawing.Size(789, 278);
        this.categoryTab.TabIndex = 1;
        this.categoryTab.Text = "Categories";
        this.categoryTab.UseVisualStyleBackColor = true;
        // 
        // categoriesGrid
        // 
        this.categoriesGrid.AllowUserToAddRows = false;
        this.categoriesGrid.AllowUserToDeleteRows = false;
        this.categoriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.categoriesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idCategory, this.nameCategory, this.delelteCategory, this.editCategory });
        this.categoriesGrid.Location = new System.Drawing.Point(1, 1);
        this.categoriesGrid.Name = "categoriesGrid";
        this.categoriesGrid.Size = new System.Drawing.Size(787, 280);
        this.categoriesGrid.TabIndex = 0;
        this.categoriesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriesGrid_CellContentClick);
        // 
        // idCategory
        // 
        this.idCategory.HeaderText = "Id";
        this.idCategory.Name = "idCategory";
        // 
        // nameCategory
        // 
        this.nameCategory.HeaderText = "Name";
        this.nameCategory.Name = "nameCategory";
        // 
        // delelteCategory
        // 
        this.delelteCategory.HeaderText = "Delete";
        this.delelteCategory.Name = "delelteCategory";
        this.delelteCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
        this.delelteCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
        // 
        // editCategory
        // 
        this.editCategory.HeaderText = "Edit";
        this.editCategory.Name = "editCategory";
        // 
        // customerTab
        // 
        this.customerTab.Controls.Add(this.customersGrid);
        this.customerTab.Location = new System.Drawing.Point(4, 22);
        this.customerTab.Name = "customerTab";
        this.customerTab.Size = new System.Drawing.Size(789, 278);
        this.customerTab.TabIndex = 2;
        this.customerTab.Text = "Customers";
        this.customerTab.UseVisualStyleBackColor = true;
        // 
        // customersGrid
        // 
        this.customersGrid.AllowUserToAddRows = false;
        this.customersGrid.AllowUserToDeleteRows = false;
        this.customersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.customersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idCustomer, this.firstNameCustomer, this.lastNameCustomer, this.deleteCustomer, this.editCustomer });
        this.customersGrid.Location = new System.Drawing.Point(1, 1);
        this.customersGrid.Name = "customersGrid";
        this.customersGrid.Size = new System.Drawing.Size(787, 276);
        this.customersGrid.TabIndex = 0;
        this.customersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersGrid_CellContentClick);
        // 
        // idCustomer
        // 
        this.idCustomer.HeaderText = "Id";
        this.idCustomer.Name = "idCustomer";
        // 
        // firstNameCustomer
        // 
        this.firstNameCustomer.HeaderText = "First name";
        this.firstNameCustomer.Name = "firstNameCustomer";
        // 
        // lastNameCustomer
        // 
        this.lastNameCustomer.HeaderText = "Last name";
        this.lastNameCustomer.Name = "lastNameCustomer";
        // 
        // deleteCustomer
        // 
        this.deleteCustomer.HeaderText = "Delete";
        this.deleteCustomer.Name = "deleteCustomer";
        // 
        // editCustomer
        // 
        this.editCustomer.HeaderText = "Edit";
        this.editCustomer.Name = "editCustomer";
        // 
        // deliveryTab
        // 
        this.deliveryTab.Controls.Add(this.deliveriesGrid);
        this.deliveryTab.Location = new System.Drawing.Point(4, 22);
        this.deliveryTab.Name = "deliveryTab";
        this.deliveryTab.Size = new System.Drawing.Size(789, 278);
        this.deliveryTab.TabIndex = 3;
        this.deliveryTab.Text = "Deliveries";
        this.deliveryTab.UseVisualStyleBackColor = true;
        // 
        // deliveriesGrid
        // 
        this.deliveriesGrid.AllowUserToAddRows = false;
        this.deliveriesGrid.AllowUserToDeleteRows = false;
        this.deliveriesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.deliveriesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idDelivery, this.bookIdDelivery, this.dateDelivery, this.booksCountDelivery, this.priceDelivery, this.deleteDelivery, this.editDelivery });
        this.deliveriesGrid.Location = new System.Drawing.Point(2, 1);
        this.deliveriesGrid.Name = "deliveriesGrid";
        this.deliveriesGrid.Size = new System.Drawing.Size(786, 276);
        this.deliveriesGrid.TabIndex = 0;
        this.deliveriesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deliveriesGrid_CellContentClick);
        // 
        // idDelivery
        // 
        this.idDelivery.HeaderText = "Id";
        this.idDelivery.Name = "idDelivery";
        // 
        // bookIdDelivery
        // 
        this.bookIdDelivery.HeaderText = "Book id";
        this.bookIdDelivery.Name = "bookIdDelivery";
        // 
        // dateDelivery
        // 
        this.dateDelivery.HeaderText = "Delivery date";
        this.dateDelivery.Name = "dateDelivery";
        // 
        // booksCountDelivery
        // 
        this.booksCountDelivery.HeaderText = "Books count";
        this.booksCountDelivery.Name = "booksCountDelivery";
        // 
        // priceDelivery
        // 
        this.priceDelivery.HeaderText = "Price";
        this.priceDelivery.Name = "priceDelivery";
        // 
        // deleteDelivery
        // 
        this.deleteDelivery.HeaderText = "Delete";
        this.deleteDelivery.Name = "deleteDelivery";
        // 
        // editDelivery
        // 
        this.editDelivery.HeaderText = "Edit";
        this.editDelivery.Name = "editDelivery";
        // 
        // priceTab
        // 
        this.priceTab.Controls.Add(this.pricesGrid);
        this.priceTab.Location = new System.Drawing.Point(4, 22);
        this.priceTab.Name = "priceTab";
        this.priceTab.Size = new System.Drawing.Size(789, 278);
        this.priceTab.TabIndex = 4;
        this.priceTab.Text = "Prices";
        this.priceTab.UseVisualStyleBackColor = true;
        // 
        // pricesGrid
        // 
        this.pricesGrid.AllowUserToAddRows = false;
        this.pricesGrid.AllowUserToDeleteRows = false;
        this.pricesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.pricesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idPrice, this.datePrice, this.pricePrice, this.deletePrice, this.eidtPrice });
        this.pricesGrid.Location = new System.Drawing.Point(4, 3);
        this.pricesGrid.Name = "pricesGrid";
        this.pricesGrid.Size = new System.Drawing.Size(784, 274);
        this.pricesGrid.TabIndex = 0;
        this.pricesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pricesGrid_CellContentClick);
        // 
        // idPrice
        // 
        this.idPrice.HeaderText = "Id";
        this.idPrice.Name = "idPrice";
        // 
        // datePrice
        // 
        this.datePrice.HeaderText = "Price Changed";
        this.datePrice.Name = "datePrice";
        // 
        // pricePrice
        // 
        this.pricePrice.HeaderText = "New Price";
        this.pricePrice.Name = "pricePrice";
        // 
        // deletePrice
        // 
        this.deletePrice.HeaderText = "Delete";
        this.deletePrice.Name = "deletePrice";
        // 
        // eidtPrice
        // 
        this.eidtPrice.HeaderText = "Edit";
        this.eidtPrice.Name = "eidtPrice";
        // 
        // publisherTab
        // 
        this.publisherTab.Controls.Add(this.publishersGrid);
        this.publisherTab.Location = new System.Drawing.Point(4, 22);
        this.publisherTab.Name = "publisherTab";
        this.publisherTab.Size = new System.Drawing.Size(789, 278);
        this.publisherTab.TabIndex = 5;
        this.publisherTab.Text = "Publishers";
        this.publisherTab.UseVisualStyleBackColor = true;
        // 
        // publishersGrid
        // 
        this.publishersGrid.AllowUserToAddRows = false;
        this.publishersGrid.AllowUserToDeleteRows = false;
        this.publishersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.publishersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idPublisher, this.namePublisher, this.deletePublisher, this.editPublisher });
        this.publishersGrid.Location = new System.Drawing.Point(3, 1);
        this.publishersGrid.Name = "publishersGrid";
        this.publishersGrid.Size = new System.Drawing.Size(785, 276);
        this.publishersGrid.TabIndex = 0;
        this.publishersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.publishersGrid_CellContentClick);
        // 
        // idPublisher
        // 
        this.idPublisher.HeaderText = "Id";
        this.idPublisher.Name = "idPublisher";
        // 
        // namePublisher
        // 
        this.namePublisher.HeaderText = "Name";
        this.namePublisher.Name = "namePublisher";
        // 
        // deletePublisher
        // 
        this.deletePublisher.HeaderText = "Delete";
        this.deletePublisher.Name = "deletePublisher";
        // 
        // editPublisher
        // 
        this.editPublisher.HeaderText = "Edit";
        this.editPublisher.Name = "editPublisher";
        // 
        // purchaseTab
        // 
        this.purchaseTab.Controls.Add(this.purchasesGrid);
        this.purchaseTab.Location = new System.Drawing.Point(4, 22);
        this.purchaseTab.Name = "purchaseTab";
        this.purchaseTab.Size = new System.Drawing.Size(789, 278);
        this.purchaseTab.TabIndex = 6;
        this.purchaseTab.Text = "Purchases";
        this.purchaseTab.UseVisualStyleBackColor = true;
        // 
        // purchasesGrid
        // 
        this.purchasesGrid.AllowUserToAddRows = false;
        this.purchasesGrid.AllowUserToDeleteRows = false;
        this.purchasesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.purchasesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idPurchase, this.customerSurnamePurchase, this.datePurchase, this.deletePuchase, this.editPurchase });
        this.purchasesGrid.Location = new System.Drawing.Point(2, 1);
        this.purchasesGrid.Name = "purchasesGrid";
        this.purchasesGrid.Size = new System.Drawing.Size(786, 276);
        this.purchasesGrid.TabIndex = 0;
        this.purchasesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchasesGrid_CellContentClick);
        // 
        // idPurchase
        // 
        this.idPurchase.HeaderText = "Id";
        this.idPurchase.Name = "idPurchase";
        // 
        // customerSurnamePurchase
        // 
        this.customerSurnamePurchase.HeaderText = "Customer surname";
        this.customerSurnamePurchase.Name = "customerSurnamePurchase";
        // 
        // datePurchase
        // 
        this.datePurchase.HeaderText = "Date";
        this.datePurchase.Name = "datePurchase";
        // 
        // deletePuchase
        // 
        this.deletePuchase.HeaderText = "Delete";
        this.deletePuchase.Name = "deletePuchase";
        // 
        // editPurchase
        // 
        this.editPurchase.HeaderText = "Edit";
        this.editPurchase.Name = "editPurchase";
        // 
        // itemTab
        // 
        this.itemTab.Controls.Add(this.itemsGrid);
        this.itemTab.Location = new System.Drawing.Point(4, 22);
        this.itemTab.Name = "itemTab";
        this.itemTab.Size = new System.Drawing.Size(789, 278);
        this.itemTab.TabIndex = 7;
        this.itemTab.Text = "Items";
        this.itemTab.UseVisualStyleBackColor = true;
        // 
        // itemsGrid
        // 
        this.itemsGrid.AllowUserToAddRows = false;
        this.itemsGrid.AllowUserToDeleteRows = false;
        this.itemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.itemsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idItem, this.purchaseIdItem, this.bookIdItem, this.booksCountItem, this.priceIdItem, this.deleteItem, this.editItem });
        this.itemsGrid.Location = new System.Drawing.Point(1, 0);
        this.itemsGrid.Name = "itemsGrid";
        this.itemsGrid.Size = new System.Drawing.Size(787, 277);
        this.itemsGrid.TabIndex = 0;
        this.itemsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsGrid_CellContentClick);
        // 
        // idItem
        // 
        this.idItem.HeaderText = "Id";
        this.idItem.Name = "idItem";
        // 
        // purchaseIdItem
        // 
        this.purchaseIdItem.HeaderText = "Purchase id";
        this.purchaseIdItem.Name = "purchaseIdItem";
        // 
        // bookIdItem
        // 
        this.bookIdItem.HeaderText = "Book id";
        this.bookIdItem.Name = "bookIdItem";
        // 
        // booksCountItem
        // 
        this.booksCountItem.HeaderText = "Books count";
        this.booksCountItem.Name = "booksCountItem";
        // 
        // priceIdItem
        // 
        this.priceIdItem.HeaderText = "Price id";
        this.priceIdItem.Name = "priceIdItem";
        // 
        // deleteItem
        // 
        this.deleteItem.HeaderText = "Delete";
        this.deleteItem.Name = "deleteItem";
        // 
        // editItem
        // 
        this.editItem.HeaderText = "Edit";
        this.editItem.Name = "editItem";
        // 
        // storeTab
        // 
        this.storeTab.Controls.Add(this.storeGrid);
        this.storeTab.Location = new System.Drawing.Point(4, 22);
        this.storeTab.Name = "storeTab";
        this.storeTab.Size = new System.Drawing.Size(789, 278);
        this.storeTab.TabIndex = 8;
        this.storeTab.Text = "Store";
        this.storeTab.UseVisualStyleBackColor = true;
        // 
        // storeGrid
        // 
        this.storeGrid.AllowUserToAddRows = false;
        this.storeGrid.AllowUserToDeleteRows = false;
        this.storeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.storeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.bookIdStore, this.booksCountStore, this.priceStore, this.deleteStore, this.editStore });
        this.storeGrid.Location = new System.Drawing.Point(1, 1);
        this.storeGrid.Name = "storeGrid";
        this.storeGrid.Size = new System.Drawing.Size(787, 276);
        this.storeGrid.TabIndex = 0;
        this.storeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.storeGrid_CellContentClick);
        // 
        // bookIdStore
        // 
        this.bookIdStore.HeaderText = "Book id";
        this.bookIdStore.Name = "bookIdStore";
        // 
        // booksCountStore
        // 
        this.booksCountStore.HeaderText = "Books count";
        this.booksCountStore.Name = "booksCountStore";
        // 
        // priceStore
        // 
        this.priceStore.HeaderText = "Price id";
        this.priceStore.Name = "priceStore";
        // 
        // deleteStore
        // 
        this.deleteStore.HeaderText = "Delete";
        this.deleteStore.Name = "deleteStore";
        // 
        // editStore
        // 
        this.editStore.HeaderText = "Edit";
        this.editStore.Name = "editStore";
        // 
        // userTab
        // 
        this.userTab.Controls.Add(this.usersGrid);
        this.userTab.Location = new System.Drawing.Point(4, 22);
        this.userTab.Name = "userTab";
        this.userTab.Size = new System.Drawing.Size(789, 278);
        this.userTab.TabIndex = 9;
        this.userTab.Text = "Users";
        this.userTab.UseVisualStyleBackColor = true;
        // 
        // usersGrid
        // 
        this.usersGrid.AllowUserToAddRows = false;
        this.usersGrid.AllowUserToDeleteRows = false;
        this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.usersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idUsers, this.loginUser, this.passwordUser, this.firstNameUser, this.lastNameUser, this.roleUser, this.deleteUser, this.editUser });
        this.usersGrid.Location = new System.Drawing.Point(0, 0);
        this.usersGrid.Name = "usersGrid";
        this.usersGrid.Size = new System.Drawing.Size(786, 275);
        this.usersGrid.TabIndex = 0;
        this.usersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGrid_CellContentClick);
        // 
        // idUsers
        // 
        this.idUsers.HeaderText = "Id";
        this.idUsers.Name = "idUsers";
        // 
        // loginUser
        // 
        this.loginUser.HeaderText = "Login";
        this.loginUser.Name = "loginUser";
        // 
        // passwordUser
        // 
        this.passwordUser.HeaderText = "Password";
        this.passwordUser.Name = "passwordUser";
        // 
        // firstNameUser
        // 
        this.firstNameUser.HeaderText = "First name";
        this.firstNameUser.Name = "firstNameUser";
        // 
        // lastNameUser
        // 
        this.lastNameUser.HeaderText = "Last name";
        this.lastNameUser.Name = "lastNameUser";
        // 
        // roleUser
        // 
        this.roleUser.HeaderText = "Role";
        this.roleUser.Name = "roleUser";
        this.roleUser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
        this.roleUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
        // 
        // deleteUser
        // 
        this.deleteUser.HeaderText = "Delete";
        this.deleteUser.Name = "deleteUser";
        // 
        // editUser
        // 
        this.editUser.HeaderText = "Edit";
        this.editUser.Name = "editUser";
        // 
        // UserForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.tabs);
        this.Controls.Add(this.menuStrip1);
        this.Name = "UserForm";
        this.Text = "UserForm";
        this.Load += new System.EventHandler(this.loadData);
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.tabs.ResumeLayout(false);
        this.bookTab.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
        this.categoryTab.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.categoriesGrid)).EndInit();
        this.customerTab.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
        this.deliveryTab.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.deliveriesGrid)).EndInit();
        this.priceTab.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.pricesGrid)).EndInit();
        this.publisherTab.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.publishersGrid)).EndInit();
        this.purchaseTab.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.purchasesGrid)).EndInit();
        this.itemTab.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
        this.storeTab.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.storeGrid)).EndInit();
        this.userTab.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem publisherCreateMenu;
    private System.Windows.Forms.ToolStripMenuItem purchaseCreateMenu;
    private System.Windows.Forms.ToolStripMenuItem itemCreateMenu;
    private System.Windows.Forms.ToolStripMenuItem storeCreateMenu;
    private System.Windows.Forms.ToolStripMenuItem userCreateMenu;

    private System.Windows.Forms.TabControl tabs;

    private System.Windows.Forms.DataGridViewTextBoxColumn idUsers;
    private System.Windows.Forms.DataGridViewTextBoxColumn loginUser;
    private System.Windows.Forms.DataGridViewTextBoxColumn passwordUser;
    private System.Windows.Forms.DataGridViewTextBoxColumn firstNameUser;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastNameUser;
    private System.Windows.Forms.DataGridViewComboBoxColumn roleUser;
    private System.Windows.Forms.DataGridViewButtonColumn deleteUser;
    private System.Windows.Forms.DataGridViewButtonColumn editUser;

    private System.Windows.Forms.DataGridViewTextBoxColumn bookIdStore;
    private System.Windows.Forms.DataGridViewTextBoxColumn booksCountStore;
    private System.Windows.Forms.DataGridViewTextBoxColumn priceStore;
    private System.Windows.Forms.DataGridViewButtonColumn deleteStore;
    private System.Windows.Forms.DataGridViewButtonColumn editStore;
    private System.Windows.Forms.DataGridView usersGrid;

    private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn purchaseIdItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn bookIdItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn booksCountItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn priceIdItem;
    private System.Windows.Forms.DataGridViewButtonColumn deleteItem;
    private System.Windows.Forms.DataGridViewButtonColumn editItem;
    private System.Windows.Forms.DataGridView storesGrid;

    private System.Windows.Forms.DataGridView itemsGrid;

    private System.Windows.Forms.DataGridViewTextBoxColumn idPurchase;
    private System.Windows.Forms.DataGridViewTextBoxColumn customerSurnamePurchase;
    private System.Windows.Forms.DataGridViewTextBoxColumn datePurchase;
    private System.Windows.Forms.DataGridViewButtonColumn deletePuchase;
    private System.Windows.Forms.DataGridViewButtonColumn editPurchase;

    private System.Windows.Forms.DataGridViewTextBoxColumn idPublisher;
    private System.Windows.Forms.DataGridViewTextBoxColumn namePublisher;
    private System.Windows.Forms.DataGridViewButtonColumn deletePublisher;
    private System.Windows.Forms.DataGridViewButtonColumn editPublisher;
    private System.Windows.Forms.DataGridView purchasesGrid;

    private System.Windows.Forms.DataGridView publishersGrid;

    private System.Windows.Forms.DataGridViewTextBoxColumn idPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn datePrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn pricePrice;
    private System.Windows.Forms.DataGridViewButtonColumn deletePrice;
    private System.Windows.Forms.DataGridViewButtonColumn eidtPrice;

    private System.Windows.Forms.DataGridViewTextBoxColumn idDelivery;
    private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDelivery;
    private System.Windows.Forms.DataGridViewTextBoxColumn dateDelivery;
    private System.Windows.Forms.DataGridViewTextBoxColumn booksCountDelivery;
    private System.Windows.Forms.DataGridViewTextBoxColumn priceDelivery;
    private System.Windows.Forms.DataGridViewButtonColumn deleteDelivery;
    private System.Windows.Forms.DataGridViewButtonColumn editDelivery;
    private System.Windows.Forms.DataGridView pricesGrid;

    private System.Windows.Forms.DataGridView deliveriesGrid;

    private System.Windows.Forms.DataGridViewTextBoxColumn idCustomer;
    private System.Windows.Forms.DataGridViewTextBoxColumn firstNameCustomer;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastNameCustomer;
    private System.Windows.Forms.DataGridViewButtonColumn deleteCustomer;
    private System.Windows.Forms.DataGridViewButtonColumn editCustomer;

    private System.Windows.Forms.DataGridView customersGrid;

    private System.Windows.Forms.DataGridViewButtonColumn delelteCategory;
    private System.Windows.Forms.DataGridViewButtonColumn editCategory;

    private System.Windows.Forms.DataGridViewButtonColumn deleteBook;
    private System.Windows.Forms.DataGridViewButtonColumn editBook;

    private System.Windows.Forms.DataGridViewTextBoxColumn idCategory;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameCategory;

    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn name;
    private System.Windows.Forms.DataGridViewTextBoxColumn publisherName;
    private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
    private System.Windows.Forms.DataGridView categoriesGrid;

    private System.Windows.Forms.TabPage bookTab;
    private System.Windows.Forms.TabPage customerTab;
    private System.Windows.Forms.TabPage deliveryTab;
    private System.Windows.Forms.TabPage priceTab;
    private System.Windows.Forms.TabPage publisherTab;
    private System.Windows.Forms.TabPage purchaseTab;
    private System.Windows.Forms.TabPage itemTab;
    private System.Windows.Forms.TabPage storeTab;
    private System.Windows.Forms.DataGridView booksGrid;

    private System.Windows.Forms.DataGridView storeGrid;
    private System.Windows.Forms.TabPage userTab;
    private System.Windows.Forms.TabPage categoryTab;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exit;
    private System.Windows.Forms.ToolStripMenuItem добавлениеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem добавлениеToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem bookCreateMenu;
    private System.Windows.Forms.ToolStripMenuItem categoryCreateMenu;
    private System.Windows.Forms.ToolStripMenuItem customerCreateMenu;
    private System.Windows.Forms.ToolStripMenuItem deliveryCreateMenu;
    private System.Windows.Forms.ToolStripMenuItem priceCreateMenu;

#endregion
}