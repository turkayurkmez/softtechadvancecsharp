public static class Program
{
    public static void Main()
    {
        SampleParallelFor(0, 1000, x => Console.WriteLine(x));
        //Parallel.For(0, 1000, x => Console.WriteLine(x));
    }

    public static void SampleParallelFor(int lowerBound, int upperBound, Action<int> process)
    {
        int processorNumber = Environment.ProcessorCount;
        int size = upperBound - lowerBound;
        int range = size / processorNumber;

        var threads = new List<Thread>();
        for (int i = 0; i < processorNumber; i++)
        {
            int start = i * range + lowerBound;
            int end = (i == processorNumber - 1) ? upperBound : start + range;
            threads.Add(new Thread(() =>
            {
                for (int x = start; x < end; x++)
                {
                    Console.WriteLine("------------------");
                    process(x);
                  
                    Thread.Sleep(50);
                }
              
            }));

        }

        foreach (var item in threads)
        {
            item.Start();
        }

        foreach (var item in threads)
        {
            item.Join();
        }


    }

}