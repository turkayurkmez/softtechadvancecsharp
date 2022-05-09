using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInInterfaces
{
    public class ClassRoom : IEnumerable
    {
        private List<Student> students = new();
        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Sort()
        {
            students.Sort();
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in students)
            {
                yield return item;
            }
        }
    }
}
