using System;
using System.Windows.Forms;
using WindowsForms.Data.Models;
using WindowsForms.Data.Service.Inheritance;

namespace WindowsForms.Forms;

public partial class UserCreate : Form {
    private readonly UserService userService;

    public UserCreate(Access access) {
        userService = new UserService("user", access.accessToken);

        InitializeComponent();
    }

    private async void create_Click(object sender, EventArgs ev) {
        if (login.Text == "" || firstName.Text == "" || secondName.Text == "" || password.Text == "" ||
            role.Text == "") {
            MessageBox.Show("Fill all fields");
            return;
        }

        try {
            var user = new User {
                login = login.Text,
                firstName = firstName.Text,
                lastName = secondName.Text,
                password = password.Text,
                role = role.SelectedItem.ToString()
            };

            await userService.create(user);
            Hide();
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            MessageBox.Show(e.Message);
            Hide();
        }
    }
}