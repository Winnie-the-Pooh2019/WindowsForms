using System;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms; 

public partial class PriceCreate : Form {
    private readonly PriceChangeService priceChangeService;
    
    public PriceCreate(Access access) {
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
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            MessageBox.Show(e.Message);
            Hide();
        }
    }
}