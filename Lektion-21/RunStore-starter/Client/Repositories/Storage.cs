using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.Java;
using System.Text.Encodings.Web;
using System.Text.Json;
using Avalonia.Media;
using Client.Interfaces;

namespace Client.Repositories;

public class Storage<T> : IStorage<T> where T : class
{
    readonly JsonSerializerOptions options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    public List<T> Read(string path)
    {
        try
        {
            var json = File.ReadAllText(path);
            var data = JsonSerializer.Deserialize<List<T>>(json, options);

            return data ?? [];
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }

    public void Write(string path, List<T> data)
    {
        try
        {
            var json = JsonSerializer.Serialize(data, options);
            File.WriteAllText(path, json);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
