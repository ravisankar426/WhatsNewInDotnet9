
/*
1. In .NET 9, a new synchronization mechanism has been introduced 
through the System.Threading.Lock class, offering an alternative 
to traditional monitor-based locking.
2. Explicitly designed for synchronization, reduced ambiguity 
and potentinal misuse.
3. The C# compiler recognizes instances of System.Threading.Lock 
within lock statements and translates them into a using statement 
that calls the _lock.EnterScope(), ensuring proper acquisition and release.
*/

public class Counter
{
    private readonly Lock _lock = new();
    private int _count;

    public void IncrementCount()
    {
        lock (_lock)
        {
            _count++;
            Console.WriteLine($"Count value incremented to {_count} by Thread {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}

public class LockClass
{
    public static async Task Run()
    {
        var counter = new Counter();

        //Run multiple tasks in parallel.
        var tasks = new Task[10];

        for (int i = 0; i < tasks.Length; i++)
        {
            tasks[i] = Task.Run(() => counter.IncrementCount());
        }

        await Task.WhenAll(tasks);

        Console.WriteLine("All tasks completed.");
    }
}