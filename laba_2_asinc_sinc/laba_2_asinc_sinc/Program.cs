// Синхронная версия
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;

class sync
{
    static void Main()
    {
        var timerForAll = new Stopwatch();
        Console.WriteLine("     Синхронный запрос\n");
        string[] sites = { "https://printotana.wordpress.com/", "https://github.com", "https://www.microsoft.com" };
        timerForAll.Start();

        var client = new HttpClient();

        for (int i = 0; i < sites.Length; i++)
        {
            var startTime = DateTime.Now;
            var response = client.GetAsync(sites[i]).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            File.WriteAllText("testSync" + (i + 1) + ".json", content);
            var endTime = DateTime.Now;
            Console.WriteLine("Время на запрос " + (i + 1) + ": " + (endTime - startTime));
        }

        timerForAll.Stop();
        Console.WriteLine("\n     Общее время " + timerForAll.ElapsedMilliseconds + "ms");
    }
}
