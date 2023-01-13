using System;
using System.Linq;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Exceptions;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms;

public partial class PurchaseCreate : Form {
    private readonly PurchaseService purchaseService;
    private readonly CustomerService customerService;

    private readonly UserForm userForm;

    public PurchaseCreate(Access access, UserForm userForm) {
        this.userForm = userForm;
        purchaseService = new PurchaseService("purchase", access.accessToken);
        customerService = new CustomerService("clients", access.accessToken);

        InitializeComponent();
    }

    private async void load(object sender, EventArgs ev) {
        try {
            var clients = (await customerService.getAll()).Select(p => p.id.ToString()).ToArray();

            this.clientsCombo.Items.AddRange(clients);
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
            userForm.Close();
        }
        catch (UnauthorizedException exception) {
            Console.WriteLine(exception.StackTrace);
            MessageBox.Show(exception.Message);
            
            var authForm = new AuthForm();
            authForm.Show();
            Close();
            userForm.Close();
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            MessageBox.Show(e.Message);
            Hide();
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
            userForm.Close();
        }
        catch (UnauthorizedException exception) {
            Console.WriteLine(exception.StackTrace);
            MessageBox.Show(exception.Message);
            
            var authForm = new AuthForm();
            authForm.Show();
            Close();
            userForm.Close();
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            MessageBox.Show(e.Message);
            Hide();
        }
    }
}