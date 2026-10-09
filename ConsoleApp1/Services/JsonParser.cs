namespace ConsoleApp1.Services;
using System.Text.Json;

public class JsonParser
{
    public T? Parse<T>(string json)
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        return JsonSerializer.Deserialize<T>(json,options);
    }
}