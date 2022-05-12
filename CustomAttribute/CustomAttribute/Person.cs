using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{

    [DeveloperInfo(name: "Türkay", CreatedDate = "11.05.2022", Description = "Person modeli oluşturuldu")]
    [DeveloperInfo(name: "Elif", CreatedDate = "12.05.2022", Description = "Türkay yanlış yapmış. Ben düzelttim ;)")]
    public class Person
    {
        [DeveloperInfo(name: "Yaren", CreatedDate = "11.07.2024", Description = "Process metodu eklendi")]
        public void Process()
        {
            Console.WriteLine("Person classının işlemleri");
        }
    }
}
