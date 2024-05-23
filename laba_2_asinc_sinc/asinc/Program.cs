// Асинхронная версия
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

class Async
{
    static async Task Main()
    {
        var timerForAll = new Stopwatch();
        Console.WriteLine("     Асинхронный запрос      \n");
        string[] sites = { "https://printotana.wordpress.com/", "https://github.com", "https://www.microsoft.com" };
        timerForAll.Start();

        var client = new HttpClient();
        var tasks = new Task[sites.Length];

        for (int i = 0; i < sites.Length; i++)
        {
            tasks[i] = ProcessSiteAsync(client, sites[i], i + 1);
        }

        await Task.WhenAll(tasks);

        timerForAll.Stop();
        Console.WriteLine("\n     Общее время " + timerForAll.ElapsedMilliseconds + "ms");
    }

    static async Task ProcessSiteAsync(HttpClient client, string site, int index)
    {
        var startTime = DateTime.Now;
        var response = await client.GetAsync(site);
        var content = await response.Content.ReadAsStringAsync();
        File.WriteAllText("testAsync" + index + ".json", content);
        var endTime = DateTime.Now;
        Console.WriteLine("Время на запрос " + index + ": " + (endTime - startTime));
    }
}
