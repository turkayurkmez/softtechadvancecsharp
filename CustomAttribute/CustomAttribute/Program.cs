// See https://aka.ms/new-console-template for more information
using CustomAttribute;
using System.Reflection;
public class Program
{
    public static void Main(string[] args)
    {
       

        Console.WriteLine("Hello, World!");
        var executeFiles = Directory.GetFiles(@"C:\Users\turka\source\repos\Kurumsal\Softtech\Ileri C#\CustomAttribute\Sample\bin\Debug\net6.0", "*.dll");
        foreach (var file in executeFiles)
        {
            var assembly = Assembly.LoadFile(file);
            foreach (var item in assembly.GetTypes())
            {
                developerInfoLog(item);
            }

        }

        static void developerInfoLog(Type type)
        {
            Console.WriteLine("Yazılımcı bilgileri alınıyor");
            Attribute[] attributes = Attribute.GetCustomAttributes(type);
            foreach (var item in attributes)
            {
                if (item is DeveloperInfoAttribute)
                {
                    DeveloperInfoAttribute developerInfoAttribute = (DeveloperInfoAttribute)item;
                    Console.WriteLine($"Yazılımcı:  { developerInfoAttribute.Name}\nAçıklama: {developerInfoAttribute.Description}\nDeğişiklik Tarihi:{developerInfoAttribute.CreatedDate}");

                }
            }
        }
    }
}


