using MemoryManagement;

Console.WriteLine(GC.GetTotalMemory(true));
doIt();
Console.WriteLine(GC.GetTotalMemory(true));
GC.Collect();
GC.Collect(1, GCCollectionMode.Forced);
Console.WriteLine(GC.GetTotalMemory(true));

static void doIt()
{
    var a = new int[100000000];
    
}


using (Helper helper = new Helper())
{
    helper.Save("test.txt", "Naptin mudur");
    GCMemoryInfo gCMemoryInfo = new GCMemoryInfo();
    Console.WriteLine($"Nesne oluştuğunda ve save çalıştığında: {gCMemoryInfo.HeapSizeBytes}");
    helper.Dispose();
    GC.Collect();
    Console.WriteLine($"Nesne dispose edildiğinde: {GC.GetTotalMemory(true)}");
}

//Console.WriteLine($"Using sonrası: {gCMemoryInfo.HeapSizeBytes}");