using System;
using System.Linq;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms;

public partial class PurchaseCreate : Form {
    private readonly PurchaseService purchaseService;
    private readonly CustomerService customerService;

    public PurchaseCreate(Access access) {
        purchaseService = new PurchaseService("purchase", access.accessToken);
        customerService = new CustomerService("clients", access.accessToken);

        InitializeComponent();
    }

    private async void load(object sender, EventArgs ev) {
        try {
            var clients = (await customerService.getAll()).Select(p => p.id.ToString()).ToArray();

            this.clientsCombo.Items.AddRange(clients);
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            MessageBox.Show("Exception occured while loading purchases or categories");
        }
    }

    private void label1_Click(object sender, EventArgs e) { }


    private async void create_Click(object sender, EventArgs ev) {
        if (clientsCombo.Text == "") {
            MessageBox.Show("Fill all fields");
            return;
        }

        try {
            var purchase = new Purchase {
                customerId = Convert.ToInt32(clientsCombo.SelectedItem.ToString()),
                purchaseDate = datePiker.Value
            };

            await purchaseService.create(purchase);
            Hide();
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            MessageBox.Show(e.Message);
            Hide();
        }
    }
}