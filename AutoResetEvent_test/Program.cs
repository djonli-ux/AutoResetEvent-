
int x = 0;

AutoResetEvent autoResetEvent = new AutoResetEvent(true);

for (int i = 0; i < 5; i++) 
{
    Thread t = new (Print);
    t.Name = $"Thread {i}";
    t.Start();
}


void Print()
{
    autoResetEvent.WaitOne();
    x = 1;

    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
        ++x;
        Thread.Sleep(500);
    }
    autoResetEvent.Set();
}
