using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using archivos;

class Program
{
    static async Task Main(string[] args)
    {
        string fileName = args[0];

        string content = args[1];
        string path = args[2];      

        await WriteTextAsync(fileName, content, path);

        var text = await ReadTextAsync(fileName);

        Console.Write(text);
    }

    private static async Task<string> ReadTextAsync(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize:4096, useAsync:true))
        {
            using (StreamReader sr = new StreamReader(fs))
            {
                return await sr.ReadToEndAsync();
            }
        }
    }

    private static async Task WriteTextAsync(string fileName, string content, string path)
    {
        byte[] encodedText = Encoding.UTF8.GetBytes(content);

        using (FileStream fs = new(Path.Combine(path, fileName), FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 4096, useAsync: true))
        {
            await fs.WriteAsync(encodedText, 0, encodedText.Length);
        }
    }
}