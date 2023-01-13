using System;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Exceptions;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms; 

public partial class PriceCreate : Form {
    private readonly PriceChangeService priceChangeService;

    private readonly UserForm userForm;
    
    public PriceCreate(Access access, UserForm userForm) {
        this.userForm = userForm;
        priceChangeService = new PriceChangeService("price", access.accessToken);
        
        InitializeComponent();
    }


    private async void create_Click(object sender, EventArgs ev) {
        if (price.Text == "") {
            MessageBox.Show("Fill all fields");
            return;
        }

        try {
            var priceChange = new PriceChange {
                priceChanged = datePiker.Value,
                newPrice = Convert.ToDouble(price.Text)
            };

            await priceChangeService.create(priceChange);
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