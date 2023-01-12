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
        this.разлогинитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.добавлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.добавлениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.спортсменToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.клубToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.спортивноеСооружениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.видСпортаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.тренерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.спортсменToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.клубToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.спортивноеСооружениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.видТренераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.тненерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.editMeniStripItem = new System.Windows.Forms.ToolStripMenuItem();
        this.спортсменToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        this.клубToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        this.спортивноеСооружениеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        this.видСпортаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.тренерToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.bookTab = new System.Windows.Forms.TabPage();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.categoryTab = new System.Windows.Forms.TabPage();
        this.dataGridView2 = new System.Windows.Forms.DataGridView();
        this.customerTab = new System.Windows.Forms.TabPage();
        this.deliveryTab = new System.Windows.Forms.TabPage();
        this.priceTab = new System.Windows.Forms.TabPage();
        this.publisherTab = new System.Windows.Forms.TabPage();
        this.purchaseTab = new System.Windows.Forms.TabPage();
        this.itemTab = new System.Windows.Forms.TabPage();
        this.storeTab = new System.Windows.Forms.TabPage();
        this.userTab = new System.Windows.Forms.TabPage();
        this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.publisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deleteBook = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editBook = new System.Windows.Forms.DataGridViewButtonColumn();
        this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.nameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.delelteCategory = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editCategory = new System.Windows.Forms.DataGridViewButtonColumn();
        this.dataGridView3 = new System.Windows.Forms.DataGridView();
        this.idCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.firstNameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.lastNameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deleteCustomer = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editCustomer = new System.Windows.Forms.DataGridViewButtonColumn();
        this.dataGridView4 = new System.Windows.Forms.DataGridView();
        this.idDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.bookIdDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dateDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.booksCountDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.priceDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deleteDelivery = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editDelivery = new System.Windows.Forms.DataGridViewButtonColumn();
        this.dataGridView5 = new System.Windows.Forms.DataGridView();
        this.idPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.datePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.pricePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deletePrice = new System.Windows.Forms.DataGridViewButtonColumn();
        this.eidtPrice = new System.Windows.Forms.DataGridViewButtonColumn();
        this.dataGridView6 = new System.Windows.Forms.DataGridView();
        this.idPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.namePublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deletePublisher = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editPublisher = new System.Windows.Forms.DataGridViewButtonColumn();
        this.dataGridView7 = new System.Windows.Forms.DataGridView();
        this.idPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.customerSurnamePurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.datePurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deletePuchase = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editPurchase = new System.Windows.Forms.DataGridViewButtonColumn();
        this.dataGridView8 = new System.Windows.Forms.DataGridView();
        this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.purchaseIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.bookIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.booksCountItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.priceIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deleteItem = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editItem = new System.Windows.Forms.DataGridViewButtonColumn();
        this.dataGridView9 = new System.Windows.Forms.DataGridView();
        this.bookIdStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.booksCountStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.priceStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deleteStore = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editStore = new System.Windows.Forms.DataGridViewButtonColumn();
        this.dataGridView10 = new System.Windows.Forms.DataGridView();
        this.idUsers = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.loginUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.passwordUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.firstNameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.lastNameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.roleUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.saltUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.deleteUser = new System.Windows.Forms.DataGridViewButtonColumn();
        this.editUser = new System.Windows.Forms.DataGridViewButtonColumn();
        this.menuStrip1.SuspendLayout();
        this.tabControl1.SuspendLayout();
        this.bookTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.categoryTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
        this.customerTab.SuspendLayout();
        this.deliveryTab.SuspendLayout();
        this.priceTab.SuspendLayout();
        this.publisherTab.SuspendLayout();
        this.purchaseTab.SuspendLayout();
        this.itemTab.SuspendLayout();
        this.storeTab.SuspendLayout();
        this.userTab.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
        this.SuspendLayout();
        // 
        // menuStrip1
        // 
        this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
        this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.менюToolStripMenuItem, this.добавлениеToolStripMenuItem, this.добавлениеToolStripMenuItem1, this.deleteToolStripMenuItem, this.editMeniStripItem });
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(800, 26);
        this.menuStrip1.TabIndex = 4;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // менюToolStripMenuItem
        // 
        this.менюToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
        this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.разлогинитьсяToolStripMenuItem });
        this.менюToolStripMenuItem.ForeColor = System.Drawing.Color.White;
        this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
        this.менюToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
        this.менюToolStripMenuItem.Text = "Меню";
        // 
        // разлогинитьсяToolStripMenuItem
        // 
        this.разлогинитьсяToolStripMenuItem.BackColor = System.Drawing.Color.White;
        this.разлогинитьсяToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        this.разлогинитьсяToolStripMenuItem.Name = "разлогинитьсяToolStripMenuItem";
        this.разлогинитьсяToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
        this.разлогинитьсяToolStripMenuItem.Text = "Логаут";
        // 
        // добавлениеToolStripMenuItem
        // 
        this.добавлениеToolStripMenuItem.Name = "добавлениеToolStripMenuItem";
        this.добавлениеToolStripMenuItem.Size = new System.Drawing.Size(12, 22);
        // 
        // добавлениеToolStripMenuItem1
        // 
        this.добавлениеToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.спортсменToolStripMenuItem, this.клубToolStripMenuItem, this.спортивноеСооружениеToolStripMenuItem, this.видСпортаToolStripMenuItem, this.тренерToolStripMenuItem });
        this.добавлениеToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
        this.добавлениеToolStripMenuItem1.Name = "добавлениеToolStripMenuItem1";
        this.добавлениеToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
        this.добавлениеToolStripMenuItem1.Text = "Добавление";
        // 
        // спортсменToolStripMenuItem
        // 
        this.спортсменToolStripMenuItem.Name = "спортсменToolStripMenuItem";
        this.спортсменToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
        this.спортсменToolStripMenuItem.Text = "Спортсмен";
        // 
        // клубToolStripMenuItem
        // 
        this.клубToolStripMenuItem.Name = "клубToolStripMenuItem";
        this.клубToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
        this.клубToolStripMenuItem.Text = "Клуб";
        // 
        // спортивноеСооружениеToolStripMenuItem
        // 
        this.спортивноеСооружениеToolStripMenuItem.Name = "спортивноеСооружениеToolStripMenuItem";
        this.спортивноеСооружениеToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
        this.спортивноеСооружениеToolStripMenuItem.Text = "Спортивное сооружение";
        // 
        // видСпортаToolStripMenuItem
        // 
        this.видСпортаToolStripMenuItem.Name = "видСпортаToolStripMenuItem";
        this.видСпортаToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
        this.видСпортаToolStripMenuItem.Text = "Вид спорта";
        // 
        // тренерToolStripMenuItem
        // 
        this.тренерToolStripMenuItem.Name = "тренерToolStripMenuItem";
        this.тренерToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
        this.тренерToolStripMenuItem.Text = "Тренер";
        // 
        // deleteToolStripMenuItem
        // 
        this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.спортсменToolStripMenuItem1, this.клубToolStripMenuItem1, this.спортивноеСооружениеToolStripMenuItem1, this.видТренераToolStripMenuItem, this.тненерToolStripMenuItem });
        this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
        this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
        this.deleteToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
        this.deleteToolStripMenuItem.Text = "Удаление";
        this.deleteToolStripMenuItem.Visible = false;
        // 
        // спортсменToolStripMenuItem1
        // 
        this.спортсменToolStripMenuItem1.Name = "спортсменToolStripMenuItem1";
        this.спортсменToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
        this.спортсменToolStripMenuItem1.Text = "Спортсмен";
        // 
        // клубToolStripMenuItem1
        // 
        this.клубToolStripMenuItem1.Name = "клубToolStripMenuItem1";
        this.клубToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
        this.клубToolStripMenuItem1.Text = "Клуб";
        // 
        // спортивноеСооружениеToolStripMenuItem1
        // 
        this.спортивноеСооружениеToolStripMenuItem1.Name = "спортивноеСооружениеToolStripMenuItem1";
        this.спортивноеСооружениеToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
        this.спортивноеСооружениеToolStripMenuItem1.Text = "Спортивное сооружение";
        // 
        // видТренераToolStripMenuItem
        // 
        this.видТренераToolStripMenuItem.Name = "видТренераToolStripMenuItem";
        this.видТренераToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
        this.видТренераToolStripMenuItem.Text = "Вид тренера";
        // 
        // тненерToolStripMenuItem
        // 
        this.тненерToolStripMenuItem.Name = "тненерToolStripMenuItem";
        this.тненерToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
        this.тненерToolStripMenuItem.Text = "Тренер";
        // 
        // editMeniStripItem
        // 
        this.editMeniStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.спортсменToolStripMenuItem2, this.клубToolStripMenuItem2, this.спортивноеСооружениеToolStripMenuItem2, this.видСпортаToolStripMenuItem1, this.тренерToolStripMenuItem1 });
        this.editMeniStripItem.ForeColor = System.Drawing.Color.White;
        this.editMeniStripItem.Name = "editMeniStripItem";
        this.editMeniStripItem.Size = new System.Drawing.Size(149, 22);
        this.editMeniStripItem.Text = "Редактирование";
        this.editMeniStripItem.Visible = false;
        // 
        // спортсменToolStripMenuItem2
        // 
        this.спортсменToolStripMenuItem2.Name = "спортсменToolStripMenuItem2";
        this.спортсменToolStripMenuItem2.Size = new System.Drawing.Size(269, 22);
        this.спортсменToolStripMenuItem2.Text = "Спортсмен";
        // 
        // клубToolStripMenuItem2
        // 
        this.клубToolStripMenuItem2.Name = "клубToolStripMenuItem2";
        this.клубToolStripMenuItem2.Size = new System.Drawing.Size(269, 22);
        this.клубToolStripMenuItem2.Text = "Клуб";
        // 
        // спортивноеСооружениеToolStripMenuItem2
        // 
        this.спортивноеСооружениеToolStripMenuItem2.Name = "спортивноеСооружениеToolStripMenuItem2";
        this.спортивноеСооружениеToolStripMenuItem2.Size = new System.Drawing.Size(269, 22);
        this.спортивноеСооружениеToolStripMenuItem2.Text = "Спортивное сооружение";
        // 
        // видСпортаToolStripMenuItem1
        // 
        this.видСпортаToolStripMenuItem1.Name = "видСпортаToolStripMenuItem1";
        this.видСпортаToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
        this.видСпортаToolStripMenuItem1.Text = "Вид спорта";
        // 
        // тренерToolStripMenuItem1
        // 
        this.тренерToolStripMenuItem1.Name = "тренерToolStripMenuItem1";
        this.тренерToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
        this.тренерToolStripMenuItem1.Text = "Тренер";
        // 
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.bookTab);
        this.tabControl1.Controls.Add(this.categoryTab);
        this.tabControl1.Controls.Add(this.customerTab);
        this.tabControl1.Controls.Add(this.deliveryTab);
        this.tabControl1.Controls.Add(this.priceTab);
        this.tabControl1.Controls.Add(this.publisherTab);
        this.tabControl1.Controls.Add(this.purchaseTab);
        this.tabControl1.Controls.Add(this.itemTab);
        this.tabControl1.Controls.Add(this.storeTab);
        this.tabControl1.Controls.Add(this.userTab);
        this.tabControl1.Location = new System.Drawing.Point(2, 147);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(797, 304);
        this.tabControl1.TabIndex = 5;
        // 
        // bookTab
        // 
        this.bookTab.Controls.Add(this.dataGridView1);
        this.bookTab.Location = new System.Drawing.Point(4, 22);
        this.bookTab.Name = "bookTab";
        this.bookTab.Padding = new System.Windows.Forms.Padding(3);
        this.bookTab.Size = new System.Drawing.Size(789, 278);
        this.bookTab.TabIndex = 0;
        this.bookTab.Text = "Books";
        this.bookTab.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        this.dataGridView1.AllowUserToAddRows = false;
        this.dataGridView1.AllowUserToDeleteRows = false;
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.id, this.name, this.publisherName, this.categoryName, this.deleteBook, this.editBook });
        this.dataGridView1.Location = new System.Drawing.Point(1, 0);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.Size = new System.Drawing.Size(787, 277);
        this.dataGridView1.TabIndex = 0;
        // 
        // categoryTab
        // 
        this.categoryTab.Controls.Add(this.dataGridView2);
        this.categoryTab.Location = new System.Drawing.Point(4, 22);
        this.categoryTab.Name = "categoryTab";
        this.categoryTab.Padding = new System.Windows.Forms.Padding(3);
        this.categoryTab.Size = new System.Drawing.Size(789, 278);
        this.categoryTab.TabIndex = 1;
        this.categoryTab.Text = "Categories";
        this.categoryTab.UseVisualStyleBackColor = true;
        // 
        // dataGridView2
        // 
        this.dataGridView2.AllowUserToAddRows = false;
        this.dataGridView2.AllowUserToDeleteRows = false;
        this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idCategory, this.nameCategory, this.delelteCategory, this.editCategory });
        this.dataGridView2.Location = new System.Drawing.Point(1, 1);
        this.dataGridView2.Name = "dataGridView2";
        this.dataGridView2.Size = new System.Drawing.Size(787, 280);
        this.dataGridView2.TabIndex = 0;
        // 
        // customerTab
        // 
        this.customerTab.Controls.Add(this.dataGridView3);
        this.customerTab.Location = new System.Drawing.Point(4, 22);
        this.customerTab.Name = "customerTab";
        this.customerTab.Size = new System.Drawing.Size(789, 278);
        this.customerTab.TabIndex = 2;
        this.customerTab.Text = "Customers";
        this.customerTab.UseVisualStyleBackColor = true;
        // 
        // deliveryTab
        // 
        this.deliveryTab.Controls.Add(this.dataGridView4);
        this.deliveryTab.Location = new System.Drawing.Point(4, 22);
        this.deliveryTab.Name = "deliveryTab";
        this.deliveryTab.Size = new System.Drawing.Size(789, 278);
        this.deliveryTab.TabIndex = 3;
        this.deliveryTab.Text = "Deliveries";
        this.deliveryTab.UseVisualStyleBackColor = true;
        // 
        // priceTab
        // 
        this.priceTab.Controls.Add(this.dataGridView5);
        this.priceTab.Location = new System.Drawing.Point(4, 22);
        this.priceTab.Name = "priceTab";
        this.priceTab.Size = new System.Drawing.Size(789, 278);
        this.priceTab.TabIndex = 4;
        this.priceTab.Text = "Prices";
        this.priceTab.UseVisualStyleBackColor = true;
        // 
        // publisherTab
        // 
        this.publisherTab.Controls.Add(this.dataGridView6);
        this.publisherTab.Location = new System.Drawing.Point(4, 22);
        this.publisherTab.Name = "publisherTab";
        this.publisherTab.Size = new System.Drawing.Size(789, 278);
        this.publisherTab.TabIndex = 5;
        this.publisherTab.Text = "Publishers";
        this.publisherTab.UseVisualStyleBackColor = true;
        // 
        // purchaseTab
        // 
        this.purchaseTab.Controls.Add(this.dataGridView7);
        this.purchaseTab.Location = new System.Drawing.Point(4, 22);
        this.purchaseTab.Name = "purchaseTab";
        this.purchaseTab.Size = new System.Drawing.Size(789, 278);
        this.purchaseTab.TabIndex = 6;
        this.purchaseTab.Text = "Purchases";
        this.purchaseTab.UseVisualStyleBackColor = true;
        // 
        // itemTab
        // 
        this.itemTab.Controls.Add(this.dataGridView8);
        this.itemTab.Location = new System.Drawing.Point(4, 22);
        this.itemTab.Name = "itemTab";
        this.itemTab.Size = new System.Drawing.Size(789, 278);
        this.itemTab.TabIndex = 7;
        this.itemTab.Text = "Items";
        this.itemTab.UseVisualStyleBackColor = true;
        // 
        // storeTab
        // 
        this.storeTab.Controls.Add(this.dataGridView9);
        this.storeTab.Location = new System.Drawing.Point(4, 22);
        this.storeTab.Name = "storeTab";
        this.storeTab.Size = new System.Drawing.Size(789, 278);
        this.storeTab.TabIndex = 8;
        this.storeTab.Text = "Store";
        this.storeTab.UseVisualStyleBackColor = true;
        // 
        // userTab
        // 
        this.userTab.Controls.Add(this.dataGridView10);
        this.userTab.Location = new System.Drawing.Point(4, 22);
        this.userTab.Name = "userTab";
        this.userTab.Size = new System.Drawing.Size(789, 278);
        this.userTab.TabIndex = 9;
        this.userTab.Text = "Users";
        this.userTab.UseVisualStyleBackColor = true;
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
        // dataGridView3
        // 
        this.dataGridView3.AllowUserToAddRows = false;
        this.dataGridView3.AllowUserToDeleteRows = false;
        this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idCustomer, this.firstNameCustomer, this.lastNameCustomer, this.deleteCustomer, this.editCustomer });
        this.dataGridView3.Location = new System.Drawing.Point(1, 1);
        this.dataGridView3.Name = "dataGridView3";
        this.dataGridView3.Size = new System.Drawing.Size(787, 276);
        this.dataGridView3.TabIndex = 0;
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
        // dataGridView4
        // 
        this.dataGridView4.AllowUserToAddRows = false;
        this.dataGridView4.AllowUserToDeleteRows = false;
        this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idDelivery, this.bookIdDelivery, this.dateDelivery, this.booksCountDelivery, this.priceDelivery, this.deleteDelivery, this.editDelivery });
        this.dataGridView4.Location = new System.Drawing.Point(2, 1);
        this.dataGridView4.Name = "dataGridView4";
        this.dataGridView4.Size = new System.Drawing.Size(786, 276);
        this.dataGridView4.TabIndex = 0;
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
        // dataGridView5
        // 
        this.dataGridView5.AllowUserToAddRows = false;
        this.dataGridView5.AllowUserToDeleteRows = false;
        this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idPrice, this.datePrice, this.pricePrice, this.deletePrice, this.eidtPrice });
        this.dataGridView5.Location = new System.Drawing.Point(4, 3);
        this.dataGridView5.Name = "dataGridView5";
        this.dataGridView5.Size = new System.Drawing.Size(784, 274);
        this.dataGridView5.TabIndex = 0;
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
        // dataGridView6
        // 
        this.dataGridView6.AllowUserToAddRows = false;
        this.dataGridView6.AllowUserToDeleteRows = false;
        this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idPublisher, this.namePublisher, this.deletePublisher, this.editPublisher });
        this.dataGridView6.Location = new System.Drawing.Point(3, 1);
        this.dataGridView6.Name = "dataGridView6";
        this.dataGridView6.Size = new System.Drawing.Size(785, 276);
        this.dataGridView6.TabIndex = 0;
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
        // dataGridView7
        // 
        this.dataGridView7.AllowUserToAddRows = false;
        this.dataGridView7.AllowUserToDeleteRows = false;
        this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idPurchase, this.customerSurnamePurchase, this.datePurchase, this.deletePuchase, this.editPurchase });
        this.dataGridView7.Location = new System.Drawing.Point(2, 1);
        this.dataGridView7.Name = "dataGridView7";
        this.dataGridView7.Size = new System.Drawing.Size(786, 276);
        this.dataGridView7.TabIndex = 0;
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
        // dataGridView8
        // 
        this.dataGridView8.AllowUserToAddRows = false;
        this.dataGridView8.AllowUserToDeleteRows = false;
        this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idItem, this.purchaseIdItem, this.bookIdItem, this.booksCountItem, this.priceIdItem, this.deleteItem, this.editItem });
        this.dataGridView8.Location = new System.Drawing.Point(1, 0);
        this.dataGridView8.Name = "dataGridView8";
        this.dataGridView8.Size = new System.Drawing.Size(787, 277);
        this.dataGridView8.TabIndex = 0;
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
        // dataGridView9
        // 
        this.dataGridView9.AllowUserToAddRows = false;
        this.dataGridView9.AllowUserToDeleteRows = false;
        this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView9.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.bookIdStore, this.booksCountStore, this.priceStore, this.deleteStore, this.editStore });
        this.dataGridView9.Location = new System.Drawing.Point(1, 1);
        this.dataGridView9.Name = "dataGridView9";
        this.dataGridView9.Size = new System.Drawing.Size(787, 276);
        this.dataGridView9.TabIndex = 0;
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
        // dataGridView10
        // 
        this.dataGridView10.AllowUserToAddRows = false;
        this.dataGridView10.AllowUserToDeleteRows = false;
        this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idUsers, this.loginUser, this.passwordUser, this.firstNameUser, this.lastNameUser, this.roleUser, this.saltUser, this.deleteUser, this.editUser });
        this.dataGridView10.Location = new System.Drawing.Point(0, 0);
        this.dataGridView10.Name = "dataGridView10";
        this.dataGridView10.Size = new System.Drawing.Size(786, 275);
        this.dataGridView10.TabIndex = 0;
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
        // 
        // saltUser
        // 
        this.saltUser.HeaderText = "Salt";
        this.saltUser.Name = "saltUser";
        this.saltUser.ReadOnly = true;
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
        this.Controls.Add(this.tabControl1);
        this.Controls.Add(this.menuStrip1);
        this.Name = "UserForm";
        this.Text = "UserForm";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.tabControl1.ResumeLayout(false);
        this.bookTab.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.categoryTab.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
        this.customerTab.ResumeLayout(false);
        this.deliveryTab.ResumeLayout(false);
        this.priceTab.ResumeLayout(false);
        this.publisherTab.ResumeLayout(false);
        this.purchaseTab.ResumeLayout(false);
        this.itemTab.ResumeLayout(false);
        this.storeTab.ResumeLayout(false);
        this.userTab.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.DataGridViewTextBoxColumn idUsers;
    private System.Windows.Forms.DataGridViewTextBoxColumn loginUser;
    private System.Windows.Forms.DataGridViewTextBoxColumn passwordUser;
    private System.Windows.Forms.DataGridViewTextBoxColumn firstNameUser;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastNameUser;
    private System.Windows.Forms.DataGridViewTextBoxColumn roleUser;
    private System.Windows.Forms.DataGridViewTextBoxColumn saltUser;
    private System.Windows.Forms.DataGridViewButtonColumn deleteUser;
    private System.Windows.Forms.DataGridViewButtonColumn editUser;

    private System.Windows.Forms.DataGridViewTextBoxColumn bookIdStore;
    private System.Windows.Forms.DataGridViewTextBoxColumn booksCountStore;
    private System.Windows.Forms.DataGridViewTextBoxColumn priceStore;
    private System.Windows.Forms.DataGridViewButtonColumn deleteStore;
    private System.Windows.Forms.DataGridViewButtonColumn editStore;
    private System.Windows.Forms.DataGridView dataGridView10;

    private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn purchaseIdItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn bookIdItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn booksCountItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn priceIdItem;
    private System.Windows.Forms.DataGridViewButtonColumn deleteItem;
    private System.Windows.Forms.DataGridViewButtonColumn editItem;
    private System.Windows.Forms.DataGridView dataGridView9;

    private System.Windows.Forms.DataGridView dataGridView8;

    private System.Windows.Forms.DataGridViewTextBoxColumn idPurchase;
    private System.Windows.Forms.DataGridViewTextBoxColumn customerSurnamePurchase;
    private System.Windows.Forms.DataGridViewTextBoxColumn datePurchase;
    private System.Windows.Forms.DataGridViewButtonColumn deletePuchase;
    private System.Windows.Forms.DataGridViewButtonColumn editPurchase;

    private System.Windows.Forms.DataGridViewTextBoxColumn idPublisher;
    private System.Windows.Forms.DataGridViewTextBoxColumn namePublisher;
    private System.Windows.Forms.DataGridViewButtonColumn deletePublisher;
    private System.Windows.Forms.DataGridViewButtonColumn editPublisher;
    private System.Windows.Forms.DataGridView dataGridView7;

    private System.Windows.Forms.DataGridView dataGridView6;

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
    private System.Windows.Forms.DataGridView dataGridView5;

    private System.Windows.Forms.DataGridView dataGridView4;

    private System.Windows.Forms.DataGridViewTextBoxColumn idCustomer;
    private System.Windows.Forms.DataGridViewTextBoxColumn firstNameCustomer;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastNameCustomer;
    private System.Windows.Forms.DataGridViewButtonColumn deleteCustomer;
    private System.Windows.Forms.DataGridViewButtonColumn editCustomer;

    private System.Windows.Forms.DataGridView dataGridView3;

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
    private System.Windows.Forms.DataGridView dataGridView2;

    private System.Windows.Forms.TabPage bookTab;
    private System.Windows.Forms.TabPage customerTab;
    private System.Windows.Forms.TabPage deliveryTab;
    private System.Windows.Forms.TabPage priceTab;
    private System.Windows.Forms.TabPage publisherTab;
    private System.Windows.Forms.TabPage purchaseTab;
    private System.Windows.Forms.TabPage itemTab;
    private System.Windows.Forms.TabPage storeTab;
    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage userTab;
    private System.Windows.Forms.TabPage categoryTab;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem разлогинитьсяToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem добавлениеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem добавлениеToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem спортсменToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem клубToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem спортивноеСооружениеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem видСпортаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem тренерToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem спортсменToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem клубToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem спортивноеСооружениеToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem видТренераToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem тненерToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editMeniStripItem;
    private System.Windows.Forms.ToolStripMenuItem спортсменToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem клубToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem спортивноеСооружениеToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem видСпортаToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem тренерToolStripMenuItem1;

#endregion
}