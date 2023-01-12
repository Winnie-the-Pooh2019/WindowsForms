namespace WindowsForms.Data.Models;

public record Access {
    public string accessToken { get; set; }
    public string username { get; set; }
    public string role { get; set; }
}