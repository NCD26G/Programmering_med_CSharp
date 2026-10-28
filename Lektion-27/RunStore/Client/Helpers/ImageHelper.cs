using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;

namespace Client.Helpers;

public static class ImageHelper
{
    public static async Task<Bitmap> ImageFromUrl(string url)
    {
        try
        {
            Uri uri = new(url);
            using HttpClient httpClient = new();
            var data = await httpClient.GetByteArrayAsync(uri);
            return new Bitmap(new MemoryStream(data));
        }
        catch (HttpRequestException ex)
        {
            throw new Exception(ex.Message);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
