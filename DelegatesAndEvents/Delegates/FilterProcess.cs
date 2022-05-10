using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public static class FilterProcess
    {
        //public delegate bool Criteria(int number);
       public static int[] Filter(int[] values, Func<int,bool> criteria)
        {
            List<int> evens = new List<int>();
            foreach (int number in values)
            {
                if (criteria(number))
                {
                    evens.Add(number);
                }
            }
            return evens.ToArray();

        }
    }
}
