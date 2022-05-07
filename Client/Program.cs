using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    private static async IAsyncEnumerable<int> Generate(int max)
    {
        for (int i = 0; i < max; i++)
        {
            await Task.Run(() => Thread.Sleep(200));
            yield return i;
        }
    }

    public static async Task Main(string[] args)
    {
        await foreach (var i in Generate(10))
        {
            Console.WriteLine($"{i,-5:N0}{Thread.CurrentThread.ManagedThreadId,5:N0}");
        }
    }
}