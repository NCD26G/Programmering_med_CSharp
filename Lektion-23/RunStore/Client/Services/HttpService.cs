using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Interfaces;
using Client.Models;

namespace Client.Services;

public class HttpService<T> : IHttpService<T> where T : class
{
    private readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true
    };

    public async Task<List<T>> Get(string resource)
    {
        // steg 1. Skapa sökvägen till resursen
        var url = $"https://runstore-d66a.restdb.io/rest/{resource}";

        // steg 2. Skapa en instans av HttpClient(.NET) klassen.
        using HttpClient client = new();
        // steg 3. Konfigurera HttpClient objektet.
        client.BaseAddress = new Uri(url);
        client.DefaultRequestHeaders.Add("Cache-Control", "none");
        client.DefaultRequestHeaders.Add("x-apikey", "5c67443c49fe0b870ee9bc7ecf94af4f396fe");

        // steg 4. Skicka paketet
        var response = await client.GetAsync(url);

        if (!response.IsSuccessStatusCode) return [];

        var result = await response.Content.ReadAsStringAsync();

        var list = JsonSerializer.Deserialize<List<T>>(result, _options) ?? [];
        return list;
        // return JsonSerializer.Deserialize<List<T>>(result, _options) ?? [];
    }

    public Task Post(string resource, T data)
    {
        throw new NotImplementedException();
    }
}
