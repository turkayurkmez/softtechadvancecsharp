// See https://aka.ms/new-console-template for more information
using LockingResource;

Console.WriteLine("Hello, World!");

CustomResource customResource = new CustomResource();
Thread t1 = new Thread(new ThreadStart(customResource.writeNumbersToConsole));
Thread t2 = new Thread(new ThreadStart(customResource.writeNumbersToConsole));
Thread t3 = new Thread(new ThreadStart(customResource.writeNumbersToConsole));
Thread t4 = new Thread(new ThreadStart(customResource.writeNumbersToConsole));

Thread[] threads = new Thread[] { t1, t2, t3, t4 };
foreach (var item in threads)
{
     item.Start();
}


