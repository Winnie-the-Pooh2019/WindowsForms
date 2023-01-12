using System;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms;

public partial class CategoryCreate : Form {
    private readonly CategoryService categoryService;

    public CategoryCreate(Access access) {
        categoryService = new CategoryService("categories", access.accessToken);

        InitializeComponent();
    }

    private void CategoryCreate_Load(object sender, EventArgs e) {
    }

    private async void create_Click(object sender, EventArgs ev) {
        if (name.Text == "") {
            MessageBox.Show("Fill all fields");
            return;
        }

        try {
            var book = new Category { name = name.Text };

            await categoryService.create(book);
            Hide();
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            MessageBox.Show(e.Message);
            Hide();
        }
    }
}