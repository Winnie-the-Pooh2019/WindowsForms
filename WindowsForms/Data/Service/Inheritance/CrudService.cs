using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;
using WindowsForms.Data.Service.Exceptions;

namespace WindowsForms.Data.Service.Inheritance; 

public class CrudService<T> {
    private readonly Uri baseUrl = new Uri("https://localhost:7019");
    private string url;
    private string token;

    protected CrudService(string url, string token) {
        this.url = url;
        this.token = token;
    }

    public async Task<List<T>> getAll() {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        var response = await client.GetAsync(baseUrl + url + "/all");

        if (!response.IsSuccessStatusCode)
            throw response.StatusCode switch {
                HttpStatusCode.NotFound => new NothingFoundException("No content found"),
                HttpStatusCode.Unauthorized => new TokenExpiredException("Token for such user is expired"),
                HttpStatusCode.Forbidden => new UnauthorizedException(
                    "You are not authorized or dont have rights to commit request"),
                _ => new Exception("unexpected exception")
            };
        
        var data = await response.Content.ReadAsStringAsync();
        return data == "" ? new List<T>() : JsonConvert.DeserializeObject<List<T>>(data);
    }
    
    public async Task<List<T>> getAllBy(object param, string finalRequest, string paramName) {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        var queries = HttpUtility.ParseQueryString($"{baseUrl}/{url}/all/{finalRequest}");
        queries[paramName] = param.ToString();
        
        var response = await client.GetAsync(queries.ToString());
        
        if (!response.IsSuccessStatusCode)
            throw response.StatusCode switch {
                HttpStatusCode.NotFound => new NothingFoundException("No content found"),
                HttpStatusCode.Unauthorized => new TokenExpiredException("Token for such user is expired"),
                HttpStatusCode.Forbidden => new UnauthorizedException(
                    "You are not authorized or dont have rights to commit request"),
                _ => new Exception("unexpected exception")
            };
        
        var data = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<T>>(data);
    }

    public async Task<T> getById(int id) {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        var query = HttpUtility.ParseQueryString(string.Empty);
        query["id"] = id.ToString();

        var response = await client.DeleteAsync($"{baseUrl}{url}/byId?{query}");
        
        if (!response.IsSuccessStatusCode)
            throw response.StatusCode switch {
                HttpStatusCode.NotFound => new NothingFoundException("No content found"),
                HttpStatusCode.Unauthorized => new TokenExpiredException("Token for such user is expired"),
                HttpStatusCode.InternalServerError => new ServerErrorException("Internal server error"),
                HttpStatusCode.Forbidden => new UnauthorizedException(
                    "You are not authorized or dont have rights to commit request"),
                _ => new Exception("unexpected exception")
            };
        
        var data = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(data);
    }

    public async Task<bool> deleteById(int id) {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        var query = HttpUtility.ParseQueryString(string.Empty);
        query["id"] = id.ToString();

        var response = await client.DeleteAsync($"{baseUrl}{url}/delete/byId?{query}");
        
        if (!response.IsSuccessStatusCode)
            throw response.StatusCode switch {
                HttpStatusCode.Unauthorized => new TokenExpiredException("Token for such user is expired"),
                HttpStatusCode.InternalServerError => new ServerErrorException("Internal server error"),
                HttpStatusCode.Forbidden => new UnauthorizedException(
                    "You are not authorized or dont have rights to commit request"),
                _ => new Exception("unexpected exception")
            };
        
        return true;
    }

    public async Task<bool> update(T obj) {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        var builder = new UriBuilder(baseUrl + $"{url}/update");
        var query = HttpUtility.ParseQueryString(string.Empty);
        builder.Query = query.ToString();

        MessageBox.Show(builder.ToString());
        
        var content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

        var response = await client.PutAsync(builder.ToString(), content);
        
        if (!response.IsSuccessStatusCode)
            throw response.StatusCode switch {
                HttpStatusCode.Unauthorized => new TokenExpiredException("Token for such user is expired"),
                HttpStatusCode.InternalServerError => new ServerErrorException("Internal server error"),
                HttpStatusCode.Forbidden => new UnauthorizedException(
                    "You are not authorized or dont have rights to commit request"),
                _ => new Exception("unexpected exception")
            };
        
        return true;
    }
}