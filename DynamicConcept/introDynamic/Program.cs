// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
dynamic generator = new Random();
generator.Next(1, 10);
generator = "boş ver bu olsun";
Console.WriteLine(generator.ToUpper());

var x = getNumber();
//x = "naber";

int getNumber()
{
    return 5;
}



dynamic getData(dynamic value)
{
    dynamic result = value * 2;
    return result;
}

//var deneme(var aaa)
//{
//    return "deneme";
//}