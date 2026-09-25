using System.Text.Encodings.Web;
using System.Text.Json;

namespace Core.Persistance;

public class Storage<T>
{
    // Skapa json inställningar...
    private static readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true
    };
    public static List<T>Read(string path)
    {
        try
        {
            string data = File.ReadAllText(path);
            // Kontrollera så att innehållet i filen är json format...
            if(!string.IsNullOrEmpty(data) || !string.IsNullOrWhiteSpace(data))
            {
                return JsonSerializer.Deserialize<List<T>>(data,_options) ?? [];
            }
            else
            {
                return [];
            }
        }
        catch (Exception ex)
        {
          throw new Exception(ex.Message);
        }
    }
    public static void Write(List<T> data, string path)
    {
        try
        {
            string json = JsonSerializer.Serialize(data,_options);
            File.WriteAllText(path,json);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

}
