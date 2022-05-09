using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInInterfaces
{
    public class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Student other)
        {
            if (Age<other?.Age)
            {
                return -1;
            }
            else if (Age > other?.Age)
            {
                return 1;
            }


            return 0;
        }
    }
}
