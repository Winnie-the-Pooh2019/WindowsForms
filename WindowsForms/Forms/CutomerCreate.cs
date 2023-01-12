using System;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms;

public partial class CutomerCreate : Form {
    private readonly CustomerService customerService;

    public CutomerCreate(Access access) {
        customerService = new CustomerService("clients", access.accessToken);

        InitializeComponent();
    }

    private void CutomerCreate_Load(object sender, EventArgs e) { }

    private async void create_Click(object sender, EventArgs ev) {
        if (firstName.Text == "" || secondName.Text == "") {
            MessageBox.Show("Fill all fields");
            return;
        }

        try {
            var book = new Customer {
                firstName = firstName.Text,
                lastName = secondName.Text
            };

            await customerService.create(book);
            Hide();
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            MessageBox.Show(e.Message);
            Hide();
        }
    }
}