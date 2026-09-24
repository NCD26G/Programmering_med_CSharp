using System.Text.Encodings.Web;
using System.Text.Json;
using WestcoastBank.Models.Account;

namespace WestcoastBank.Models.Persistance;

public class Storage
{
    private static readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    public static void WriteToJson(List<Transaction> transactions, string path)
    {
        string json = JsonSerializer.Serialize(transactions, _options);
        File.WriteAllText(path, json);
    }

    public static List<Transaction> ReadFromJson(string path)
    {
        string storedTrx = File.ReadAllText(path);
        return JsonSerializer.Deserialize<List<Transaction>>(storedTrx, _options)!;
    }
}
