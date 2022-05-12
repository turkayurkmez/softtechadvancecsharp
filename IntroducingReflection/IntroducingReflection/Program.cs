// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Type type1 = typeof(string);
Random random = new Random();
Type type2 = random.GetType();

showAllMethodsInType(type1);
showAllPropertyInType(type1);


void showAllMethodsInType(Type type)
{
    Console.WriteLine("---------------------");
    Console.WriteLine($"{type.Name} tipinin metotları");
    type.GetMethods().ToList().ForEach(x => Console.WriteLine($"{x.Name} {x.ReturnType.Name} ({string.Join(',', x.GetParameters().Select(y => y.Name))})"));



}


void showAllPropertyInType(Type type)
{
    Console.WriteLine("---------------------");
    Console.WriteLine($"{type.Name} tipinin propertyleri");
    type.GetProperties().ToList().ForEach(x => Console.WriteLine($"{x.Name} {x.PropertyType.Name}"));
}
