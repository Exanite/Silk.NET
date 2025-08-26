using System.Diagnostics;

namespace Silk.NET.SilkTouch;

internal readonly struct ProfilingScope : IDisposable
{
    private readonly string name;
    private readonly long timestamp;

    public ProfilingScope(string name)
    {
        this.name = name;
        timestamp = Stopwatch.GetTimestamp();
    }

    public void Dispose()
    {
        var elapsed = Stopwatch.GetElapsedTime(timestamp);
        Console.WriteLine("Scope '{0}' took {1:F3} seconds", name, elapsed.TotalSeconds);
    }
}
