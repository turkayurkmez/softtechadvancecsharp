// See https://aka.ms/new-console-template for more information
using ExtensionMethods;

Console.WriteLine("Hello, World!");

string companyName = "Softtech AŞ";
Console.WriteLine(companyName.RemoveSpaces());
Random random = new Random();
Console.WriteLine(random.NextChar());
Console.WriteLine(random.NextString(10));
Console.WriteLine(DateTime.Now.TotalWorkDaysInYear());

List<string> words = new List<string>();
words.Where(w => w.StartsWith("a")).ToList().ForEach(w => Console.WriteLine(w));
//foreach (var item in words)
//{
//    if (item.StartsWith("a"))
//    {
//        Console.WriteLine(item);
//    }
//}
