using System;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms;

public partial class PublisherCreate : Form {
    private readonly PublisherService publisherService;

    public PublisherCreate(Access access) {
        publisherService = new PublisherService("publisher", access.accessToken);

        InitializeComponent();
    }

    private async void create_Click(object sender, EventArgs ev) {
        if (name.Text == "") {
            MessageBox.Show("Fill all fields");
            return;
        }

        try {
            var book = new Publisher { name = name.Text };

            await publisherService.create(book);
            Hide();
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            MessageBox.Show(e.Message);
            Hide();
        }
    }
}