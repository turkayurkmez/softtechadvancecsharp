using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockingResource
{
    public class CustomResource
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private object _lock = new object();
        public void writeNumbersToConsole()
        {

            //lock (_lock)
            //{
            Monitor.Enter(_lock);
            for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {numbers[i]}");
                }
            Monitor.Exit(_lock);
            //}
        }
    }
}
