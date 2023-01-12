using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WindowsForms.Data.Models;

namespace WindowsForms.Data.Service.Inheritance;

public class AuthService : IAuthService {
    public static Access access;
    private readonly Uri baseUrl = new Uri("https://localhost:7019");

    public async Task<Access> signIn(string login, string password) {
        const string urlEnd = "signin";

        var json = new {
            login,
            password
        };

        var content = new StringContent(JsonConvert.SerializeObject(json), Encoding.UTF8, "application/json");
        var client = new HttpClient();
        var response = await client.PostAsync(baseUrl + urlEnd, content);

        if (response.IsSuccessStatusCode) {
            var data = await response.Content.ReadAsStringAsync();
            access = JsonConvert.DeserializeObject<Access>(data);
            return access;
        }

        MessageBox.Show("Incorrect login or password");
        return null;
    }

    public async Task<bool> signUp(User user) {
        const string urlEnd = "signup";

        var content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
        var client = new HttpClient();

        try {
            var response = await client.PostAsync(baseUrl + urlEnd, content);

            switch (response.StatusCode) {
            case HttpStatusCode.InternalServerError:
                MessageBox.Show("Unexpected serverside error");
                return false;
            case HttpStatusCode.BadRequest:
                MessageBox.Show("Such user is already exists");
                return false;
            case HttpStatusCode.OK:
                return true;
            default:
                MessageBox.Show("Unexpected error");
                return false;
            }
        }
        catch (Exception e) {
            Console.WriteLine(e.StackTrace);
            return false;
        }
    }
}